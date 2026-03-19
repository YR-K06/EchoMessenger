namespace EchoMessenger
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lstEchoWindow = new ListBox();
            txtMessenger = new TextBox();
            btnSend = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Script", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(85, 40);
            label1.Name = "label1";
            label1.Size = new Size(641, 120);
            label1.TabIndex = 0;
            label1.Text = "Echo Messenger";
            // 
            // lstEchoWindow
            // 
            lstEchoWindow.BackColor = SystemColors.ActiveCaption;
            lstEchoWindow.Font = new Font("맑은 고딕", 20F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lstEchoWindow.FormattingEnabled = true;
            lstEchoWindow.Location = new Point(109, 178);
            lstEchoWindow.Name = "lstEchoWindow";
            lstEchoWindow.Size = new Size(1217, 436);
            lstEchoWindow.TabIndex = 1;
            // 
            // txtMessenger
            // 
            txtMessenger.BackColor = SystemColors.InactiveCaption;
            txtMessenger.Font = new Font("맑은 고딕", 20F, FontStyle.Regular, GraphicsUnit.Point, 129);
            txtMessenger.Location = new Point(109, 677);
            txtMessenger.Name = "txtMessenger";
            txtMessenger.Size = new Size(1105, 61);
            txtMessenger.TabIndex = 2;
            txtMessenger.Text = "(여기에 입력하세요)\r\n\r\n";
            // 
            // btnSend
            // 
            btnSend.BackColor = SystemColors.Highlight;
            btnSend.Font = new Font("맑은 고딕", 20F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnSend.ForeColor = SystemColors.ControlLightLight;
            btnSend.Location = new Point(1214, 677);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(112, 61);
            btnSend.TabIndex = 3;
            btnSend.Text = "전송";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1435, 871);
            Controls.Add(btnSend);
            Controls.Add(txtMessenger);
            Controls.Add(lstEchoWindow);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstEchoWindow;
        private TextBox txtMessenger;
        private Button btnSend;
    }
}
