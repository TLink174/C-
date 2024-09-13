namespace ConnectSQL
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
            txtClassID = new TextBox();
            btnDetail = new Button();
            label2 = new Label();
            txtID = new TextBox();
            label3 = new Label();
            txtName = new TextBox();
            label4 = new Label();
            txtYear = new TextBox();
            btnList = new Button();
            lsStudents = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)lsStudents).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 31);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 0;
            label1.Text = "Enter Class ID";
            // 
            // txtClassID
            // 
            txtClassID.Location = new Point(150, 28);
            txtClassID.Name = "txtClassID";
            txtClassID.Size = new Size(152, 23);
            txtClassID.TabIndex = 1;
            // 
            // btnDetail
            // 
            btnDetail.Location = new Point(38, 95);
            btnDetail.Name = "btnDetail";
            btnDetail.Size = new Size(264, 44);
            btnDetail.TabIndex = 2;
            btnDetail.Text = "View in Detail";
            btnDetail.UseVisualStyleBackColor = true;
            btnDetail.Click += btnDetail_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 166);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 0;
            label2.Text = "Class ID";
            // 
            // txtID
            // 
            txtID.Location = new Point(150, 163);
            txtID.Name = "txtID";
            txtID.Size = new Size(152, 23);
            txtID.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 209);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 0;
            label3.Text = "Class Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(150, 206);
            txtName.Name = "txtName";
            txtName.Size = new Size(152, 23);
            txtName.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 254);
            label4.Name = "label4";
            label4.Size = new Size(29, 15);
            label4.TabIndex = 0;
            label4.Text = "Year";
            // 
            // txtYear
            // 
            txtYear.Location = new Point(150, 251);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(152, 23);
            txtYear.TabIndex = 1;
            // 
            // btnList
            // 
            btnList.Location = new Point(373, 95);
            btnList.Name = "btnList";
            btnList.Size = new Size(285, 44);
            btnList.TabIndex = 2;
            btnList.Text = "View List of Students";
            btnList.UseVisualStyleBackColor = true;
            btnList.Click += btnList_Click;
            // 
            // lsStudents
            // 
            lsStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            lsStudents.Location = new Point(373, 163);
            lsStudents.Name = "lsStudents";
            lsStudents.Size = new Size(343, 232);
            lsStudents.TabIndex = 3;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(746, 418);
            Controls.Add(lsStudents);
            Controls.Add(btnList);
            Controls.Add(btnDetail);
            Controls.Add(txtYear);
            Controls.Add(label4);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(txtID);
            Controls.Add(label2);
            Controls.Add(txtClassID);
            Controls.Add(label1);
            Name = "Form3";
            ((System.ComponentModel.ISupportInitialize)lsStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtClassID;
        private Button btnDetail;
        private Label label2;
        private TextBox txtID;
        private Label label3;
        private TextBox txtName;
        private Label label4;
        private TextBox txtYear;
        private Button btnList;
        private DataGridView lsStudents;
    }
}