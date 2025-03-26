using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNGwatcher
{
    public class ReceiverRegister
    {

        private static readonly Dictionary<string, IReceiverFactory> _registeredReceiverFactories = new();

        public static void AddFactory(IReceiverFactory factory)
            => _registeredReceiverFactories.Add(factory.Code, factory);

        public static IReceiver CreateInstance(ConfigReceiver configReceiver)
        {
            if (!_registeredReceiverFactories.TryGetValue(configReceiver.Type, out IReceiverFactory factory))
                return null;
            return factory.CreateInstance(configReceiver);
        }

    }
}
