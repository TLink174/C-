namespace WinForms
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
            txtPass = new TextBox();
            label2 = new Label();
            btnShow = new Button();
            btnNext = new Button();
            btnExit = new Button();
            lblShow = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(36, 13);
            label1.Name = "label1";
            label1.Size = new Size(132, 21);
            label1.TabIndex = 0;
            label1.Text = "Nhập Password:";
            // 
            // txtPass
            // 
            txtPass.Location = new Point(174, 12);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '#';
            txtPass.Size = new Size(242, 23);
            txtPass.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(90, 51);
            label2.Name = "label2";
            label2.Size = new Size(78, 21);
            label2.TabIndex = 0;
            label2.Text = "Hiển Thị:";
            // 
            // btnShow
            // 
            btnShow.Location = new Point(36, 105);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(89, 23);
            btnShow.TabIndex = 2;
            btnShow.Text = "Hiển Thị";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += BtnShow_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(174, 105);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(89, 23);
            btnNext.TabIndex = 2;
            btnNext.Text = "Tiếp";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(314, 105);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(89, 23);
            btnExit.TabIndex = 2;
            btnExit.Text = "Đóng";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblShow
            // 
            lblShow.Enabled = false;
            lblShow.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblShow.ForeColor = SystemColors.InfoText;
            lblShow.Location = new Point(174, 51);
            lblShow.Name = "lblShow";
            lblShow.Size = new Size(242, 23);
            lblShow.TabIndex = 1;
            lblShow.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(433, 149);
            Controls.Add(btnExit);
            Controls.Add(btnNext);
            Controls.Add(btnShow);
            Controls.Add(lblShow);
            Controls.Add(txtPass);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPass;
        private Label label2;
        private Button btnShow;
        private Button btnNext;
        private Button btnExit;
        private TextBox lblShow;
    }
}
