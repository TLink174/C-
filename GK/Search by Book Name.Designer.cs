namespace GK
{
    partial class Search_by_Book_Name
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
            txtBookName = new TextBox();
            datBook = new DataGridView();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)datBook).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 34);
            label1.Name = "label1";
            label1.Size = new Size(125, 20);
            label1.TabIndex = 0;
            label1.Text = "Enter Book Name";
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(226, 31);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(215, 27);
            txtBookName.TabIndex = 1;
            txtBookName.KeyDown += txtBookName_KeyDown;
            // 
            // datBook
            // 
            datBook.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datBook.Location = new Point(60, 106);
            datBook.Name = "datBook";
            datBook.RowHeadersWidth = 51;
            datBook.Size = new Size(541, 228);
            datBook.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 83);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 0;
            label2.Text = "Results:";
            // 
            // Search_by_Book_Name
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(660, 346);
            Controls.Add(datBook);
            Controls.Add(txtBookName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Search_by_Book_Name";
            Text = "Search_by_Book_Name";
            ((System.ComponentModel.ISupportInitialize)datBook).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtBookName;
        private DataGridView datBook;
        private Label label2;
    }
}