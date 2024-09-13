namespace WinForms
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtHo = new TextBox();
            txtTen = new TextBox();
            btnHo = new Button();
            btnTen = new Button();
            btnHoTen = new Button();
            btnExit = new Button();
            lblName = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 69);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 1;
            label1.Text = "Họ lót:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 107);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 1;
            label2.Text = "Tên:";
            // 
            // txtHo
            // 
            txtHo.Location = new Point(106, 66);
            txtHo.Name = "txtHo";
            txtHo.Size = new Size(312, 23);
            txtHo.TabIndex = 2;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(106, 104);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(312, 23);
            txtTen.TabIndex = 2;
            // 
            // btnHo
            // 
            btnHo.Location = new Point(57, 158);
            btnHo.Name = "btnHo";
            btnHo.Size = new Size(92, 37);
            btnHo.TabIndex = 3;
            btnHo.Text = "Họ Lót";
            btnHo.UseVisualStyleBackColor = true;
            btnHo.Click += btnHo_Click;
            // 
            // btnTen
            // 
            btnTen.Location = new Point(185, 158);
            btnTen.Name = "btnTen";
            btnTen.Size = new Size(92, 37);
            btnTen.TabIndex = 3;
            btnTen.Text = "Tên";
            btnTen.UseVisualStyleBackColor = true;
            btnTen.Click += btnTen_Click;
            // 
            // btnHoTen
            // 
            btnHoTen.Location = new Point(326, 158);
            btnHoTen.Name = "btnHoTen";
            btnHoTen.Size = new Size(92, 37);
            btnHoTen.TabIndex = 3;
            btnHoTen.Text = "Họ và Tên";
            btnHoTen.UseVisualStyleBackColor = true;
            btnHoTen.Click += btnHoTen_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(157, 208);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(143, 37);
            btnExit.TabIndex = 3;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblName
            // 
            lblName.AutoEllipsis = true;
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(49, 4);
            lblName.Name = "lblName";
            lblName.Size = new Size(83, 32);
            lblName.TabIndex = 0;
            lblName.Text = "label1";
            lblName.DoubleClick += lblName_DoubleClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblName);
            panel1.Location = new Point(8, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(441, 42);
            panel1.TabIndex = 0;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(461, 257);
            Controls.Add(btnHoTen);
            Controls.Add(btnExit);
            Controls.Add(btnTen);
            Controls.Add(btnHo);
            Controls.Add(txtTen);
            Controls.Add(txtHo);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Form3";
            Text = "Form3";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private TextBox txtHo;
        private TextBox txtTen;
        private Button btnHo;
        private Button btnTen;
        private Button btnHoTen;
        private Button btnExit;
        private Label lblName;
        private Panel panel1;
    }
}