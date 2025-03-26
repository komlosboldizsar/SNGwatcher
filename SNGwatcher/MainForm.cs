namespace SNGwatcher
{
    public partial class MainForm : Form
    {

        public MainForm() => InitializeComponent();

        public MainForm(Config config, IReceiver receiver)
            : this()
        {
            _config = config;
            _receiver = receiver;
        }

        private readonly Config _config;
        private readonly IReceiver _receiver;

        private void MainForm_Load(object sender, EventArgs e)
        {

            valueCnMargin.Text = "--.-- dB";
            valueIdealRange.Text = _config.Receiver.IdealMin.ToString("F2").PadLeft(5, '0') + " - " + _config.Receiver.IdealMax.ToString("F2").PadLeft(5, '0') + " dB";
            valueReceiverType.Text = _config.Receiver.Type;
            valueReceiverAddress.Text = _config.Receiver.Address;
            if (_receiver != null)
            {
                valueReceiverStatus.Text = _receiver.Type;
            }
            else
            {
                valueReceiverStatus.Text = $"{_config.Receiver.Type} (unknown)";
                valueReceiverStatus.ForeColor = Color.DarkRed;
            }
            valueRemoteBaseUrl.Text = _config.Remote.BaseURL;
            valueRemoteId.Text = _config.Remote.ID;
            valueRemoteLastUpdate.Text = "-";
            valueRemoteLastUpdateStatus.Text = "-";
            valueRemoteLastSuccessfulUpdate.Text = "-";

            if (_receiver != null)
                _receiver.StatusUpdate += _receiver_StatusUpdate;

        }

        private void _receiver_StatusUpdate(IReceiver receiver, ReceiverData status)
        {
            valueCnMargin.Text = status.CnMargin.ToString("F2").PadLeft(5, '0');
            valueReceiverStatus.Text = status.ReadSuccess ? "OK" : "unavailable";
        }

    }
}