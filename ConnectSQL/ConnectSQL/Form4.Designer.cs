namespace ConnectSQL
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
            label1 = new Label();
            label2 = new Label();
            datGVStudents = new DataGridView();
            lsbClasses = new ListBox();
            ((System.ComponentModel.ISupportInitialize)datGVStudents).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(125, 29);
            label1.Name = "label1";
            label1.Size = new Size(172, 32);
            label1.TabIndex = 0;
            label1.Text = "List of Classes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(509, 29);
            label2.Name = "label2";
            label2.Size = new Size(190, 32);
            label2.TabIndex = 1;
            label2.Text = "List of Students";
            // 
            // datGVStudents
            // 
            datGVStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datGVStudents.Location = new Point(434, 81);
            datGVStudents.Name = "datGVStudents";
            datGVStudents.Size = new Size(331, 214);
            datGVStudents.TabIndex = 2;
            // 
            // lsbClasses
            // 
            lsbClasses.FormattingEnabled = true;
            lsbClasses.ItemHeight = 15;
            lsbClasses.Location = new Point(38, 81);
            lsbClasses.Name = "lsbClasses";
            lsbClasses.Size = new Size(326, 214);
            lsbClasses.TabIndex = 3;
            lsbClasses.SelectedIndexChanged += lsbClasses_SelectedIndexChanged;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 324);
            Controls.Add(lsbClasses);
            Controls.Add(datGVStudents);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)datGVStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DataGridView datGVStudents;
        private ListBox lsbClasses;
    }
}