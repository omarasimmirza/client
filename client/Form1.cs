using System;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Text;
using System.Linq;

namespace client
{
    public partial class Form1 : Form
    {
        private TcpClient clientSocket;
        private string username;
        private bool subscribedToIF100, subscribedToSPS101;

        public Form1()
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
            InitializeComponent();
            DisableInput();
        }

        private void DisableInput()
        {
            IF_send.Enabled = false;
            IF_messageBox.Enabled = false;
            SPS_send.Enabled = false;
            SPS_messageBox.Enabled = false;
        }

        private void Button_Connect_Click(object sender, EventArgs e)
        {
            ConnectToServer(textBox_ip.Text, Int32.Parse(textBox_port.Text));
        }

        private void ConnectToServer(string ip, int port)
        {
            try
            {
                clientSocket = new TcpClient(ip, port);
                username = textBox_user.Text;
                SendUsername(username);
                EnableInput();
                DisplayLog("Connected to server.");
            }
            catch (Exception ex)
            {
                DisplayLog("Connection failed: " + ex.Message);
            }
        }

        private void SendUsername(string username)
        {
            NetworkStream stream = clientSocket.GetStream();
            byte[] data = Encoding.ASCII.GetBytes("CONNECT:" + username);
            stream.Write(data, 0, data.Length);
        }

        private void EnableInput()
        {
            IF_send.Enabled = true;
            IF_sub.Enabled = true;
            IF_messageBox.Enabled = true;
            SPS_sub.Enabled = true;
            SPS_messageBox.Enabled = true;
            SPS_send.Enabled = true;
        }

        private void DisplayLog(string message)
        {
            logs.AppendText(DateTime.Now.ToString("HH:mm:ss") + ": " + message + "\n");
        }

        private void ReadFromServer()
        {
            while (true)
            {
                try
                {
                    NetworkStream stream = clientSocket.GetStream();
                    byte[] buffer = new byte[1024];
                    int bytesRead = stream.Read(buffer, 0, buffer.Length);

                    if (bytesRead > 0)
                    {
                        string response = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                        ProcessServerResponse(response);
                    }
                    else
                    {
                        DisplayLog("Connection closed by server.");
                        break;
                    }
                }
                catch (Exception ex)
                {
                    DisplayLog("Error receiving data: " + ex.Message);
                    break;
                }
            }
        }

        private void HandleSubscriptionStatus(string channel, string status)
        {
            if (status == "success")
            {
                if (channel == "IF100")
                {
                    subscribedToIF100 = true;
                }
                else if (channel == "SPS101")
                {
                    subscribedToSPS101 = true;
                }
            }
            else if (status == "failure")
            {
                if (channel == "IF100")
                {
                    subscribedToIF100 = false;
                }
                else if (channel == "SPS101")
                {
                    subscribedToSPS101 = false;
                }
            }

            UpdateUIBasedOnSubscriptionState(channel);
        }

        private void UpdateUIBasedOnSubscriptionState(string channel)
        {
            if (channel == "IF100")
            {
                IF_messageBox.Enabled = subscribedToIF100;
            }
            else if (channel == "SPS101")
            {
                SPS_messageBox.Enabled = subscribedToSPS101;
            }
        }

        private void ProcessServerResponse(string response)
        {
            string[] parts = response.Split(' ');
            if (parts.Length >= 2)
            {
                switch (parts[0])
                {
                    case "MESSAGE":
                        string channel = parts[1];
                        string message = string.Join(" ", parts.Skip(2));
                        UpdateChannelLog(channel, message);
                        break;
                    case "SUBSCRIPTION":
                        HandleSubscriptionStatus(parts[1], parts[2]);
                        break;
                    default:
                        DisplayLog("Received unknown message: " + response);
                        break;
                }
            }
        }

        private void UpdateChannelLog(string channel, string message)
        {
            if (channel == "IF100")
            {
                IF_logs.Invoke((MethodInvoker)delegate ()
                {
                    IF_logs.AppendText(message + "\n");
                });
            }
            else if (channel == "SPS101")
            {
                SPS_logs.Invoke((MethodInvoker)delegate ()
                {
                    SPS_logs.AppendText(message + "\n");
                });
            }
            else
            {
                DisplayLog("Received message from unknown channel: " + channel);
            }
        }

        private void DisplayMessage(string channel, string message)
        {
            string timestamp = DateTime.Now.ToString("HH:mm:ss");
            string displayMessage = "[" + timestamp + "] " + channel + ": " + message;

            if (channel == "IF100")
            {
                IF_logs.Invoke((MethodInvoker)delegate ()
                {
                    IF_logs.AppendText(displayMessage + "\n");
                });
            }
            else if (channel == "SPS101")
            {
                SPS_logs.Invoke((MethodInvoker)delegate ()
                {
                    SPS_logs.AppendText(displayMessage + "\n");
                });
            }
            else
            {
                DisplayLog("Received message from unknown channel: " + displayMessage);
            }
        }

        private void IF_Send_Click(object sender, EventArgs e)
        {
            string message = IF_messageBox.Text;
            IF_messageBox.Clear();
            if (!string.IsNullOrEmpty(message))
            {
                try
                {
                    string formattedMessage = "MESSAGE:" + message + ":IF100";
                    SendToServer(formattedMessage);
                }
                catch (Exception ex)
                {
                    DisplayLog("Sending message failed: " + ex.Message);
                }
            }
            if (clientSocket == null || !clientSocket.Connected)
            {
                DisplayLog("Error: Not connected to server. Please connect first.");
                return;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            clientSocket?.Close();
        }

        private void IF_sub_Click(object sender, EventArgs e)
        {
            if (!subscribedToIF100)
            {
                SendToServer("SUBSCRIBE:IF100");
                subscribedToIF100 = true;
                IF_messageBox.Enabled = true;
                IF_send.Enabled = true;
            }
            else
            {
                SendToServer("UNSUBSCRIBE:IF100"); 
                subscribedToIF100 = false;
                IF_send.Enabled = false;
                IF_messageBox.Enabled = false;
            }
        }

        private void SPS_sub_Click(object sender, EventArgs e)
        {
            if (!subscribedToSPS101)
            {
                SendToServer("SUBSCRIBE:SPS101"); 
                subscribedToSPS101 = true;
                SPS_send.Enabled = true;
                SPS_messageBox.Enabled = true;
            }
            else
            {
                SendToServer("UNSUBSCRIBE:SPS101");
                subscribedToSPS101 = false;
                SPS_messageBox.Enabled = false;
                SPS_send.Enabled = false;
            }
        }

        private void SPS_send_Click(object sender, EventArgs e)
        {
            string message = SPS_messageBox.Text;
            SPS_messageBox.Clear();
            if (!string.IsNullOrEmpty(message))
            {
                try
                {
                    string formattedMessage = "MESSAGE:" + message + ":SPS101";
                    SendToServer(formattedMessage);
                }
                catch (Exception ex)
                {
                    DisplayLog("Sending message failed: " + ex.Message);
                }
            }
            if (clientSocket == null || !clientSocket.Connected)
            {
                DisplayLog("Error: Not connected to server. Please connect first.");
                return;
            }
        }

        private void SendToServer(string message)
        {
            NetworkStream stream = clientSocket.GetStream();
            byte[] data = Encoding.ASCII.GetBytes(message);
            stream.Write(data, 0, data.Length);
            DisplayLog("Sent: " + message);
        }

    }
}