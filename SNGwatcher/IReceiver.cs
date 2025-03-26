using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNGwatcher
{

    public interface IReceiver
    {
        string Type { get; }
        ReceiverData ReadStatus();
        event ReceiverStatusUpdateDelegate StatusUpdate;
    }

    public delegate void ReceiverStatusUpdateDelegate(IReceiver receiver, ReceiverData status);

}
