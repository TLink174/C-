namespace WinForms
{
    partial class Form4
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
            txtNhapTen = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            radBlack = new RadioButton();
            radGreen = new RadioButton();
            radBlue = new RadioButton();
            radRed = new RadioButton();
            groupBox2 = new GroupBox();
            chkGach = new CheckBox();
            chkItalic = new CheckBox();
            chkBold = new CheckBox();
            label2 = new Label();
            btnEXit = new Button();
            lblLapTrinh = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // txtNhapTen
            // 
            txtNhapTen.Location = new Point(96, 12);
            txtNhapTen.Name = "txtNhapTen";
            txtNhapTen.Size = new Size(219, 23);
            txtNhapTen.TabIndex = 0;
            txtNhapTen.TextChanged += txtNhapTen_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Lime;
            label1.Location = new Point(19, 17);
            label1.Name = "label1";
            label1.Size = new Size(71, 17);
            label1.TabIndex = 1;
            label1.Text = "Nhập Tên:";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.PowderBlue;
            groupBox1.Controls.Add(radBlack);
            groupBox1.Controls.Add(radGreen);
            groupBox1.Controls.Add(radBlue);
            groupBox1.Controls.Add(radRed);
            groupBox1.Location = new Point(19, 63);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(119, 129);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Color";
            // 
            // radBlack
            // 
            radBlack.AutoSize = true;
            radBlack.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radBlack.Location = new Point(20, 97);
            radBlack.Name = "radBlack";
            radBlack.Size = new Size(58, 21);
            radBlack.TabIndex = 1;
            radBlack.Text = "Black";
            radBlack.UseVisualStyleBackColor = true;
            radBlack.CheckedChanged += radBlack_CheckedChanged;
            // 
            // radGreen
            // 
            radGreen.AutoSize = true;
            radGreen.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radGreen.ForeColor = Color.Green;
            radGreen.Location = new Point(20, 47);
            radGreen.Name = "radGreen";
            radGreen.Size = new Size(62, 21);
            radGreen.TabIndex = 1;
            radGreen.Text = "Green";
            radGreen.UseVisualStyleBackColor = true;
            radGreen.CheckedChanged += radGreen_CheckedChanged;
            // 
            // radBlue
            // 
            radBlue.AutoSize = true;
            radBlue.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radBlue.ForeColor = Color.Blue;
            radBlue.Location = new Point(20, 72);
            radBlue.Name = "radBlue";
            radBlue.Size = new Size(53, 21);
            radBlue.TabIndex = 0;
            radBlue.Text = "Blue";
            radBlue.UseVisualStyleBackColor = true;
            radBlue.CheckedChanged += radBlue_CheckedChanged;
            // 
            // radRed
            // 
            radRed.AutoSize = true;
            radRed.Checked = true;
            radRed.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radRed.ForeColor = Color.Red;
            radRed.Location = new Point(20, 22);
            radRed.Name = "radRed";
            radRed.Size = new Size(49, 21);
            radRed.TabIndex = 0;
            radRed.TabStop = true;
            radRed.Text = "Red";
            radRed.UseVisualStyleBackColor = true;
            radRed.CheckedChanged += radRed_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.NavajoWhite;
            groupBox2.Controls.Add(chkGach);
            groupBox2.Controls.Add(chkItalic);
            groupBox2.Controls.Add(chkBold);
            groupBox2.Location = new Point(170, 63);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(145, 129);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Font";
            // 
            // chkGach
            // 
            chkGach.AutoSize = true;
            chkGach.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            chkGach.ForeColor = Color.Blue;
            chkGach.Location = new Point(18, 97);
            chkGach.Name = "chkGach";
            chkGach.Size = new Size(92, 21);
            chkGach.TabIndex = 0;
            chkGach.Text = "Gạch Chân";
            chkGach.UseVisualStyleBackColor = true;
            chkGach.CheckedChanged += chkGach_CheckedChanged;
            // 
            // chkItalic
            // 
            chkItalic.AutoSize = true;
            chkItalic.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            chkItalic.ForeColor = Color.Blue;
            chkItalic.Location = new Point(18, 63);
            chkItalic.Name = "chkItalic";
            chkItalic.Size = new Size(115, 21);
            chkItalic.TabIndex = 0;
            chkItalic.Text = "Nghiêng Italic";
            chkItalic.UseVisualStyleBackColor = true;
            chkItalic.CheckedChanged += chkItalic_CheckedChanged;
            // 
            // chkBold
            // 
            chkBold.AutoSize = true;
            chkBold.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkBold.ForeColor = Color.Blue;
            chkBold.Location = new Point(18, 29);
            chkBold.Name = "chkBold";
            chkBold.Size = new Size(88, 21);
            chkBold.TabIndex = 0;
            chkBold.Text = "Đậm Bold";
            chkBold.UseVisualStyleBackColor = true;
            chkBold.CheckedChanged += chkBold_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.IndianRed;
            label2.Location = new Point(19, 225);
            label2.Name = "label2";
            label2.Size = new Size(94, 17);
            label2.TabIndex = 4;
            label2.Text = "Lập Trình Bởi:";
            // 
            // btnEXit
            // 
            btnEXit.Location = new Point(250, 216);
            btnEXit.Name = "btnEXit";
            btnEXit.Size = new Size(65, 40);
            btnEXit.TabIndex = 6;
            btnEXit.Text = "Thoát";
            btnEXit.UseVisualStyleBackColor = true;
            btnEXit.Click += btnEXit_Click;
            // 
            // lblLapTrinh
            // 
            lblLapTrinh.AutoSize = true;
            lblLapTrinh.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLapTrinh.Location = new Point(119, 227);
            lblLapTrinh.Name = "lblLapTrinh";
            lblLapTrinh.Size = new Size(43, 17);
            lblLapTrinh.TabIndex = 7;
            lblLapTrinh.Text = "label3";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(338, 278);
            Controls.Add(lblLapTrinh);
            Controls.Add(btnEXit);
            Controls.Add(label2);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(txtNhapTen);
            Name = "Form4";
            Text = "Form4";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNhapTen;
        private Label label1;
        private GroupBox groupBox1;
        private RadioButton radBlack;
        private RadioButton radGreen;
        private RadioButton radBlue;
        private RadioButton radRed;
        private GroupBox groupBox2;
        private CheckBox chkItalic;
        private CheckBox chkBold;
        private CheckBox chkGach;
        private Label label2;
        private Button btnEXit;
        private Label lblLapTrinh;
    }
}