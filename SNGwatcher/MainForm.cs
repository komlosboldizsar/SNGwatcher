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
            if (_receiver != null)
            {
                valueReceiverType.Text = _receiver.Type;
            }
            else
            {
                valueReceiverType.Text = $"{_config.Receiver.Type} (unknown)";
                valueReceiverType.ForeColor = Color.DarkRed;
            }
            valueReceiverAddress.Text = _config.Receiver.Address;
            valueReceiverStatus.Text = "-";            
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