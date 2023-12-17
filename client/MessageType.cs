using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace client
{
    public enum MessageType
    {
        CONNECT,
        MESSAGE,
        SUBSCRIBE,
        UNSUBSCRIBE,
        CHANNEL,
        SERVER_INFO,
    }
}
