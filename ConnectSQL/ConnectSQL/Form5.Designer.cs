namespace ConnectSQL
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
            groupBox1 = new GroupBox();
            txtClassID = new TextBox();
            txtName = new TextBox();
            txtStudentID = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnDel = new Button();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtClassID);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(txtStudentID);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(370, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(271, 126);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Student Infomation";
            // 
            // txtClassID
            // 
            txtClassID.Location = new Point(96, 86);
            txtClassID.Name = "txtClassID";
            txtClassID.Size = new Size(152, 23);
            txtClassID.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new Point(96, 57);
            txtName.Name = "txtName";
            txtName.Size = new Size(152, 23);
            txtName.TabIndex = 1;
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(96, 30);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(152, 23);
            txtStudentID.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 89);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 0;
            label3.Text = "Class ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 60);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 0;
            label2.Text = "Full Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 33);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "Student ID";
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(376, 190);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(75, 23);
            btnInsert.TabIndex = 2;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(472, 190);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDel
            // 
            btnDel.Location = new Point(566, 190);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(75, 23);
            btnDel.TabIndex = 2;
            btnDel.Text = "Delete";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(338, 301);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(653, 325);
            Controls.Add(dataGridView1);
            Controls.Add(btnDel);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(groupBox1);
            Name = "Form5";
            Text = "Form5";
            Load += Form5_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private Label label1;
        private TextBox txtClassID;
        private TextBox txtName;
        private TextBox txtStudentID;
        private Label label3;
        private Label label2;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDel;
        private DataGridView dataGridView1;
    }
}