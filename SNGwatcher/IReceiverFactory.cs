using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNGwatcher
{
    public interface IReceiverFactory
    {
        string Code { get; }
        IReceiver CreateInstance(ConfigReceiver configReceiver);
    }
}
