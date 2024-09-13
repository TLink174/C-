namespace WinForms
{
    partial class Form2
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
            btnClick = new Button();
            SuspendLayout();
            // 
            // btnClick
            // 
            btnClick.Dock = DockStyle.Fill;
            btnClick.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClick.ForeColor = Color.Coral;
            btnClick.Location = new Point(0, 0);
            btnClick.Name = "btnClick";
            btnClick.Size = new Size(360, 187);
            btnClick.TabIndex = 0;
            btnClick.Text = "CLICK ME";
            btnClick.UseVisualStyleBackColor = true;
            btnClick.Click += btnClick_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 187);
            Controls.Add(btnClick);
            Name = "Form2";
            Text = "Simple Event Example";
            Load += Form2_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnClick;
    }
}