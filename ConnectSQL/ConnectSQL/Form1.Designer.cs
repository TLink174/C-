namespace ConnectSQL
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
            btnConn = new Button();
            btnDisconn = new Button();
            SuspendLayout();
            // 
            // btnConn
            // 
            btnConn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConn.Location = new Point(107, 25);
            btnConn.Name = "btnConn";
            btnConn.Size = new Size(287, 74);
            btnConn.TabIndex = 0;
            btnConn.Text = "CONNECT DATABASE";
            btnConn.UseVisualStyleBackColor = true;
            btnConn.Click += btnConn_Click;
            // 
            // btnDisconn
            // 
            btnDisconn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDisconn.Location = new Point(157, 125);
            btnDisconn.Name = "btnDisconn";
            btnDisconn.Size = new Size(185, 72);
            btnDisconn.TabIndex = 1;
            btnDisconn.Text = "DISCONNECT";
            btnDisconn.UseVisualStyleBackColor = true;
            btnDisconn.Click += btnDisconn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(501, 250);
            Controls.Add(btnDisconn);
            Controls.Add(btnConn);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnConn;
        private Button btnDisconn;
    }
}
