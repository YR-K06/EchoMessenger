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
            //버튼을 누르면 lstEchoWindow에 메시지 입력
            txtMessenger.Clear();
            //txtMessenger에 남아있는 메시지 삭제

        }
    }
}
