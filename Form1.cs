namespace EchoMessenger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            String typed_msg = txtMessenger.Text;
            lstEchoWindow.Items.Add(typed_msg);
            txtMessenger.Clear();

        }
    }
}
