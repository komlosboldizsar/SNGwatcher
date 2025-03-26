namespace SNGwatcher
{
    internal static class Program
    {

        private const string DEFAULT_CONFIG = "config.json";

        [STAThread]
        static void Main(string[] args)
        {
            string configPath = (args.Length > 1) ? args[1] : DEFAULT_CONFIG;
            ConfigReader configReader = new(configPath);
            Config config = configReader.Read();
            IReceiver receiver = ReceiverRegister.CreateInstance(config.Receiver);
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm(config, receiver));
        }
    }
}