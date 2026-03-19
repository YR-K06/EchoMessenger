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
            string typed_msg = txtMessenger.Text?.Trim();
            if (string.IsNullOrEmpty(typed_msg))
                return; // 빈 문자열 또는 공백만 있을 때 전송하지 않음

            lstEchoWindow.Items.Add(typed_msg);
            // 버튼을 누르면 lstEchoWindow에 메시지 입력

            txtMessenger.Clear();
            // txtMessenger에 남아있는 메시지 삭제

            txtMessenger.Focus(); // 전송 후에도 입력창에 포커스 유지

        }

        private void txtMessenger_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // 'ding' 소리 방지 및 줄바꿈 방지
                btnSend_Click(btnSend, EventArgs.Empty);
            }
        }
    }
}
