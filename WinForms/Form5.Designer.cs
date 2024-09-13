namespace WinForms
{
    partial class Form5
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            groupBox1 = new GroupBox();
            radBlack = new RadioButton();
            radGreen = new RadioButton();
            radBlue = new RadioButton();
            radRed = new RadioButton();
            label1 = new Label();
            txtNhapTen = new TextBox();
            groupBox3 = new GroupBox();
            label3 = new Label();
            txtMess = new TextBox();
            chkVisible = new CheckBox();
            picBig = new PictureBox();
            picSmall = new PictureBox();
            groupBox4 = new GroupBox();
            btnExit = new Button();
            btnClear = new Button();
            btnDisplay = new Button();
            lblMess = new Label();
            panel1 = new Panel();
            toolTip = new ToolTip(components);
            toolTip1 = new ToolTip(components);
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBig).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picSmall).BeginInit();
            groupBox4.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(radBlack);
            groupBox1.Controls.Add(radGreen);
            groupBox1.Controls.Add(radBlue);
            groupBox1.Controls.Add(radRed);
            groupBox1.Location = new Point(12, 155);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(119, 129);
            groupBox1.TabIndex = 10;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(6, 29);
            label1.Name = "label1";
            label1.Size = new Size(71, 17);
            label1.TabIndex = 9;
            label1.Text = "Nhập Tên:";
            // 
            // txtNhapTen
            // 
            txtNhapTen.BackColor = Color.PeachPuff;
            txtNhapTen.Location = new Point(83, 24);
            txtNhapTen.Name = "txtNhapTen";
            txtNhapTen.Size = new Size(264, 23);
            txtNhapTen.TabIndex = 8;
            txtNhapTen.TextChanged += txtNhapTen_TextChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(txtMess);
            groupBox3.Controls.Add(txtNhapTen);
            groupBox3.Location = new Point(12, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(365, 110);
            groupBox3.TabIndex = 15;
            groupBox3.TabStop = false;
            groupBox3.Text = "Input Name & Message";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(11, 70);
            label3.Name = "label3";
            label3.Size = new Size(66, 17);
            label3.TabIndex = 9;
            label3.Text = "Lời nhắn:";
            // 
            // txtMess
            // 
            txtMess.BackColor = Color.PeachPuff;
            txtMess.Location = new Point(83, 64);
            txtMess.Name = "txtMess";
            txtMess.Size = new Size(264, 23);
            txtMess.TabIndex = 8;
            txtMess.KeyDown += txtMess_KeyDown;
            // 
            // chkVisible
            // 
            chkVisible.AutoSize = true;
            chkVisible.Checked = true;
            chkVisible.CheckState = CheckState.Checked;
            chkVisible.Location = new Point(145, 128);
            chkVisible.Name = "chkVisible";
            chkVisible.Size = new Size(109, 19);
            chkVisible.TabIndex = 16;
            chkVisible.Text = "Message Visible";
            chkVisible.UseVisualStyleBackColor = true;
            chkVisible.CheckedChanged += chkVisible_CheckedChanged;
            // 
            // picBig
            // 
            picBig.Image = (Image)resources.GetObject("picBig.Image");
            picBig.Location = new Point(145, 167);
            picBig.Name = "picBig";
            picBig.Size = new Size(109, 93);
            picBig.TabIndex = 17;
            picBig.TabStop = false;
            toolTip.SetToolTip(picBig, "Click Me");
            picBig.Click += picBig_Click;
            // 
            // picSmall
            // 
            picSmall.ErrorImage = null;
            picSmall.Image = (Image)resources.GetObject("picSmall.Image");
            picSmall.Location = new Point(170, 185);
            picSmall.Name = "picSmall";
            picSmall.Size = new Size(63, 63);
            picSmall.TabIndex = 17;
            picSmall.TabStop = false;
            toolTip1.SetToolTip(picSmall, "Click Me");
            picSmall.Visible = false;
            picSmall.Click += picSmall_Click;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = SystemColors.ActiveCaption;
            groupBox4.Controls.Add(btnExit);
            groupBox4.Controls.Add(btnClear);
            groupBox4.Controls.Add(btnDisplay);
            groupBox4.Location = new Point(270, 150);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(107, 134);
            groupBox4.TabIndex = 18;
            groupBox4.TabStop = false;
            groupBox4.Text = "Action";
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(14, 96);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 0;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(14, 61);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 0;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDisplay
            // 
            btnDisplay.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDisplay.Location = new Point(14, 27);
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Size = new Size(75, 23);
            btnDisplay.TabIndex = 0;
            btnDisplay.Text = "Display";
            btnDisplay.UseVisualStyleBackColor = true;
            btnDisplay.Click += btnDisplay_Click;
            // 
            // lblMess
            // 
            lblMess.AutoSize = true;
            lblMess.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMess.Location = new Point(6, 12);
            lblMess.Name = "lblMess";
            lblMess.Size = new Size(54, 21);
            lblMess.TabIndex = 19;
            lblMess.Text = "label2";
            // 
            // panel1
            // 
            panel1.BackColor = Color.PeachPuff;
            panel1.Controls.Add(lblMess);
            panel1.Location = new Point(12, 290);
            panel1.Name = "panel1";
            panel1.Size = new Size(365, 47);
            panel1.TabIndex = 20;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(393, 350);
            Controls.Add(panel1);
            Controls.Add(groupBox4);
            Controls.Add(picBig);
            Controls.Add(chkVisible);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(picSmall);
            Name = "Form5";
            Text = "Form5";
            KeyDown += Form5_KeyDown;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBig).EndInit();
            ((System.ComponentModel.ISupportInitialize)picSmall).EndInit();
            groupBox4.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox1;
        private RadioButton radBlack;
        private RadioButton radGreen;
        private RadioButton radBlue;
        private RadioButton radRed;
        private Label label1;
        private TextBox txtNhapTen;
        private GroupBox groupBox3;
        private Label label3;
        private TextBox txtMess;
        private CheckBox chkVisible;
        private PictureBox picBig;
        private PictureBox picSmall;
        private GroupBox groupBox4;
        private Button btnDisplay;
        private Button btnExit;
        private Button btnClear;
        private Label lblMess;
        private Panel panel1;
        private ToolTip toolTip;
        private ToolTip toolTip1;
    }
}