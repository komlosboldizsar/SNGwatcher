namespace SNGwatcher
{
    public partial class MainForm : Form
    {
        public MainForm() => InitializeComponent();

        public MainForm(Config config)
            : this()
        {
            config = _config;
        }

        private readonly Config _config;

    }
}