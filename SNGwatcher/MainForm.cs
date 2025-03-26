namespace SNGwatcher
{
    public partial class MainForm : Form
    {

        public MainForm() => InitializeComponent();

        public MainForm(Config config)
            : this()
        {
            _config = config;
        }

        private readonly Config _config;

        private void MainForm_Load(object sender, EventArgs e)
        {
            valueCnMargin.Text = "--.-- dB";
            valueIdealRange.Text = "--.-- - --.-- dB";
            valueReceiverType.Text = _config.Receiver.Type;
            valueReceiverAddress.Text = _config.Receiver.Address;
            valueReceiverStatus.Text = "-";
            valueRemoteBaseUrl.Text = _config.Remote.BaseURL;
            valueRemoteId.Text = _config.Remote.ID;
            valueRemoteLastUpdate.Text = "-";
            valueRemoteLastUpdateStatus.Text = "-";
            valueRemoteLastSuccessfulUpdate.Text = "-";
        }

    }
}