namespace GK
{
    partial class Update_Book
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
            txtBookID = new TextBox();
            label3 = new Label();
            txtBookName = new TextBox();
            label4 = new Label();
            txtAuthor = new TextBox();
            label5 = new Label();
            txtYear = new TextBox();
            btnInsert = new Button();
            btnDel = new Button();
            btnUpdate = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(208, 25);
            label1.Name = "label1";
            label1.Size = new Size(225, 41);
            label1.TabIndex = 0;
            label1.Text = "UPDATE BOOK";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 90);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 1;
            label2.Text = "BOOK ID";
            // 
            // txtBookID
            // 
            txtBookID.Location = new Point(234, 87);
            txtBookID.Name = "txtBookID";
            txtBookID.Size = new Size(331, 27);
            txtBookID.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 137);
            label3.Name = "label3";
            label3.Size = new Size(95, 20);
            label3.TabIndex = 1;
            label3.Text = "BOOK NAME";
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(234, 134);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(331, 27);
            txtBookName.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 187);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 1;
            label4.Text = "AUTHOR";
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(234, 184);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(331, 27);
            txtAuthor.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(52, 241);
            label5.Name = "label5";
            label5.Size = new Size(138, 20);
            label5.TabIndex = 1;
            label5.Text = "PUBLICATION YEAR";
            // 
            // txtYear
            // 
            txtYear.Location = new Point(234, 238);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(331, 27);
            txtYear.TabIndex = 2;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(52, 311);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(94, 29);
            btnInsert.TabIndex = 3;
            btnInsert.Text = "INSERT";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnDel
            // 
            btnDel.Location = new Point(182, 311);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(94, 29);
            btnDel.TabIndex = 3;
            btnDel.Text = "DELETE";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(320, 311);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(471, 311);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 3;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Update_Book
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(623, 357);
            Controls.Add(btnExit);
            Controls.Add(btnUpdate);
            Controls.Add(btnDel);
            Controls.Add(btnInsert);
            Controls.Add(txtYear);
            Controls.Add(txtAuthor);
            Controls.Add(txtBookName);
            Controls.Add(txtBookID);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Update_Book";
            Text = "Update_Book";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtBookID;
        private Label label3;
        private TextBox txtBookName;
        private Label label4;
        private TextBox txtAuthor;
        private Label label5;
        private TextBox txtYear;
        private Button btnInsert;
        private Button btnDel;
        private Button btnUpdate;
        private Button btnExit;
    }
}