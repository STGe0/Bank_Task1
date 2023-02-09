using BankService;

namespace cur
{
    public partial class MainForm : Form
    {
        private Control oldParent;
        private Panel oldPanel;
        public MainForm()
        {
            InitializeComponent();
        }
        public void SetContent(Panel targetPanel)
        {
            if (oldParent != null)
            {
                oldPanel.Parent = oldParent;
            }
            oldPanel= targetPanel;
            oldParent = targetPanel.Parent;
            targetPanel.Parent = Mpanel;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            using var client = new BankService.DailyInfoSoapClient(DailyInfoSoapClient.EndpointConfiguration.DailyInfoSoap);
            DateTime dateV = client.GetLatestDateTime();

            toolStripLabel2.Text = toolStripLabel2.Text.Insert(3, dateV.ToString("d"));

            var formLogin = new LoginP();
            SetContent(formLogin.panelLogin);
        }

        private void AboutP_Click(object sender, EventArgs e)
        {
            var formAbout = new AboutP();
            SetContent(formAbout.panel1);
        }

        private void ExitTool_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuStrip1_MouseMove(object sender, MouseEventArgs e)
        {
            ValutaTool.Enabled = LoginP.butV;
            AboutP.Enabled = LoginP.butO;
        }

        private void ValutaTool_Click(object sender, EventArgs e)
        {
            var cur = new curP();
            SetContent(cur.panelC);
        }
    }
}