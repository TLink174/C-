namespace ConnectSQL
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
            btnCaculate = new Button();
            label1 = new Label();
            label2 = new Label();
            txtClassID = new TextBox();
            txtNumber = new TextBox();
            SuspendLayout();
            // 
            // btnCaculate
            // 
            btnCaculate.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCaculate.Location = new Point(63, 125);
            btnCaculate.Name = "btnCaculate";
            btnCaculate.Size = new Size(360, 76);
            btnCaculate.TabIndex = 0;
            btnCaculate.Text = "Caculate Number of Student";
            btnCaculate.UseVisualStyleBackColor = true;
            btnCaculate.Click += btnCaculate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 30);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 1;
            label1.Text = "Enter ClassID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 61);
            label2.Name = "label2";
            label2.Size = new Size(109, 15);
            label2.TabIndex = 2;
            label2.Text = "Number of Student";
            // 
            // txtClassID
            // 
            txtClassID.Location = new Point(242, 27);
            txtClassID.Name = "txtClassID";
            txtClassID.Size = new Size(181, 23);
            txtClassID.TabIndex = 3;
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(242, 58);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(181, 23);
            txtNumber.TabIndex = 3;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(486, 233);
            Controls.Add(txtNumber);
            Controls.Add(txtClassID);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCaculate);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCaculate;
        private Label label1;
        private Label label2;
        private TextBox txtClassID;
        private TextBox txtNumber;
    }
}