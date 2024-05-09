namespace StudentManagement
{
    partial class StudentView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label_Students = new Label();
            panel1 = new Panel();
            studentView_close_btn = new Button();
            tabControl1 = new TabControl();
            tabPage_StudentList = new TabPage();
            studentList_search_btn = new Button();
            studentList_delete_btn = new Button();
            studentList_update_btn = new Button();
            studentList_create_btn = new Button();
            studentList_search_textBox = new TextBox();
            studentList_searchStudent_label = new Label();
            studentList_dataGridView = new DataGridView();
            tabPage_StudentDetail = new TabPage();
            students_groupList_comboBox = new ComboBox();
            students_studentSurname_label = new Label();
            students_studentSurname_textBox = new TextBox();
            students_studentName_label = new Label();
            students_studentName_textBox = new TextBox();
            students_studentId_label = new Label();
            students_studentId_textBox = new TextBox();
            students_cancel_btn = new Button();
            students_groupName_textBox = new TextBox();
            students_save_btn = new Button();
            students_groupName_label = new Label();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage_StudentList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)studentList_dataGridView).BeginInit();
            tabPage_StudentDetail.SuspendLayout();
            SuspendLayout();
            // 
            // label_Students
            // 
            label_Students.AutoSize = true;
            label_Students.Font = new Font("Segoe UI", 12F);
            label_Students.Location = new Point(12, 29);
            label_Students.Name = "label_Students";
            label_Students.Size = new Size(70, 21);
            label_Students.TabIndex = 0;
            label_Students.Text = "Students";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(studentView_close_btn);
            panel1.Controls.Add(label_Students);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 77);
            panel1.TabIndex = 1;
            // 
            // studentView_close_btn
            // 
            studentView_close_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            studentView_close_btn.Font = new Font("Segoe UI", 12F);
            studentView_close_btn.Location = new Point(757, 24);
            studentView_close_btn.Name = "studentView_close_btn";
            studentView_close_btn.Size = new Size(31, 30);
            studentView_close_btn.TabIndex = 7;
            studentView_close_btn.Text = "X";
            studentView_close_btn.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage_StudentList);
            tabControl1.Controls.Add(tabPage_StudentDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 77);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 373);
            tabControl1.TabIndex = 2;
            // 
            // tabPage_StudentList
            // 
            tabPage_StudentList.Controls.Add(studentList_search_btn);
            tabPage_StudentList.Controls.Add(studentList_delete_btn);
            tabPage_StudentList.Controls.Add(studentList_update_btn);
            tabPage_StudentList.Controls.Add(studentList_create_btn);
            tabPage_StudentList.Controls.Add(studentList_search_textBox);
            tabPage_StudentList.Controls.Add(studentList_searchStudent_label);
            tabPage_StudentList.Controls.Add(studentList_dataGridView);
            tabPage_StudentList.Location = new Point(4, 24);
            tabPage_StudentList.Name = "tabPage_StudentList";
            tabPage_StudentList.Padding = new Padding(3);
            tabPage_StudentList.Size = new Size(792, 345);
            tabPage_StudentList.TabIndex = 0;
            tabPage_StudentList.Text = "Student list";
            tabPage_StudentList.UseVisualStyleBackColor = true;
            // 
            // studentList_search_btn
            // 
            studentList_search_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            studentList_search_btn.Location = new Point(609, 51);
            studentList_search_btn.Name = "studentList_search_btn";
            studentList_search_btn.Size = new Size(75, 23);
            studentList_search_btn.TabIndex = 6;
            studentList_search_btn.Text = "Search";
            studentList_search_btn.UseVisualStyleBackColor = true;
            // 
            // studentList_delete_btn
            // 
            studentList_delete_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            studentList_delete_btn.Location = new Point(690, 138);
            studentList_delete_btn.Name = "studentList_delete_btn";
            studentList_delete_btn.Size = new Size(75, 23);
            studentList_delete_btn.TabIndex = 5;
            studentList_delete_btn.Text = "Delete";
            studentList_delete_btn.UseVisualStyleBackColor = true;
            // 
            // studentList_update_btn
            // 
            studentList_update_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            studentList_update_btn.Location = new Point(690, 109);
            studentList_update_btn.Name = "studentList_update_btn";
            studentList_update_btn.Size = new Size(75, 23);
            studentList_update_btn.TabIndex = 4;
            studentList_update_btn.Text = "Update";
            studentList_update_btn.UseVisualStyleBackColor = true;
            // 
            // studentList_create_btn
            // 
            studentList_create_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            studentList_create_btn.Location = new Point(690, 80);
            studentList_create_btn.Name = "studentList_create_btn";
            studentList_create_btn.Size = new Size(75, 23);
            studentList_create_btn.TabIndex = 3;
            studentList_create_btn.Text = "Create";
            studentList_create_btn.UseVisualStyleBackColor = true;
            // 
            // studentList_search_textBox
            // 
            studentList_search_textBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            studentList_search_textBox.Location = new Point(36, 51);
            studentList_search_textBox.Name = "studentList_search_textBox";
            studentList_search_textBox.Size = new Size(567, 23);
            studentList_search_textBox.TabIndex = 2;
            // 
            // studentList_searchStudent_label
            // 
            studentList_searchStudent_label.AutoSize = true;
            studentList_searchStudent_label.Location = new Point(36, 33);
            studentList_searchStudent_label.Name = "studentList_searchStudent_label";
            studentList_searchStudent_label.Size = new Size(88, 15);
            studentList_searchStudent_label.TabIndex = 1;
            studentList_searchStudent_label.Text = "Search student:";
            // 
            // studentList_dataGridView
            // 
            studentList_dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            studentList_dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            studentList_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            studentList_dataGridView.Location = new Point(36, 80);
            studentList_dataGridView.Name = "studentList_dataGridView";
            studentList_dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            studentList_dataGridView.Size = new Size(648, 257);
            studentList_dataGridView.TabIndex = 0;
            // 
            // tabPage_StudentDetail
            // 
            tabPage_StudentDetail.Controls.Add(students_groupList_comboBox);
            tabPage_StudentDetail.Controls.Add(students_studentSurname_label);
            tabPage_StudentDetail.Controls.Add(students_studentSurname_textBox);
            tabPage_StudentDetail.Controls.Add(students_studentName_label);
            tabPage_StudentDetail.Controls.Add(students_studentName_textBox);
            tabPage_StudentDetail.Controls.Add(students_studentId_label);
            tabPage_StudentDetail.Controls.Add(students_studentId_textBox);
            tabPage_StudentDetail.Controls.Add(students_cancel_btn);
            tabPage_StudentDetail.Controls.Add(students_groupName_textBox);
            tabPage_StudentDetail.Controls.Add(students_save_btn);
            tabPage_StudentDetail.Controls.Add(students_groupName_label);
            tabPage_StudentDetail.Location = new Point(4, 24);
            tabPage_StudentDetail.Name = "tabPage_StudentDetail";
            tabPage_StudentDetail.Padding = new Padding(3);
            tabPage_StudentDetail.Size = new Size(792, 345);
            tabPage_StudentDetail.TabIndex = 1;
            tabPage_StudentDetail.Text = "Student detail";
            tabPage_StudentDetail.UseVisualStyleBackColor = true;
            // 
            // students_groupList_comboBox
            // 
            students_groupList_comboBox.FormattingEnabled = true;
            students_groupList_comboBox.Location = new Point(413, 62);
            students_groupList_comboBox.Name = "students_groupList_comboBox";
            students_groupList_comboBox.Size = new Size(121, 23);
            students_groupList_comboBox.TabIndex = 11;
            students_groupList_comboBox.SelectedIndexChanged += students_groupList_comboBox_SelectedIndexChanged;
            // 
            // students_studentSurname_label
            // 
            students_studentSurname_label.AutoSize = true;
            students_studentSurname_label.Location = new Point(29, 128);
            students_studentSurname_label.Name = "students_studentSurname_label";
            students_studentSurname_label.Size = new Size(97, 15);
            students_studentSurname_label.TabIndex = 10;
            students_studentSurname_label.Text = "Student surname";
            // 
            // students_studentSurname_textBox
            // 
            students_studentSurname_textBox.Location = new Point(29, 146);
            students_studentSurname_textBox.Name = "students_studentSurname_textBox";
            students_studentSurname_textBox.Size = new Size(170, 23);
            students_studentSurname_textBox.TabIndex = 9;
            // 
            // students_studentName_label
            // 
            students_studentName_label.AutoSize = true;
            students_studentName_label.Location = new Point(29, 84);
            students_studentName_label.Name = "students_studentName_label";
            students_studentName_label.Size = new Size(81, 15);
            students_studentName_label.TabIndex = 8;
            students_studentName_label.Text = "Student name";
            // 
            // students_studentName_textBox
            // 
            students_studentName_textBox.Location = new Point(29, 102);
            students_studentName_textBox.Name = "students_studentName_textBox";
            students_studentName_textBox.Size = new Size(170, 23);
            students_studentName_textBox.TabIndex = 7;
            // 
            // students_studentId_label
            // 
            students_studentId_label.AutoSize = true;
            students_studentId_label.Location = new Point(29, 36);
            students_studentId_label.Name = "students_studentId_label";
            students_studentId_label.Size = new Size(61, 15);
            students_studentId_label.TabIndex = 6;
            students_studentId_label.Text = "Student Id";
            // 
            // students_studentId_textBox
            // 
            students_studentId_textBox.Enabled = false;
            students_studentId_textBox.Location = new Point(29, 54);
            students_studentId_textBox.Name = "students_studentId_textBox";
            students_studentId_textBox.Size = new Size(170, 23);
            students_studentId_textBox.TabIndex = 5;
            // 
            // students_cancel_btn
            // 
            students_cancel_btn.Location = new Point(124, 219);
            students_cancel_btn.Name = "students_cancel_btn";
            students_cancel_btn.Size = new Size(75, 23);
            students_cancel_btn.TabIndex = 4;
            students_cancel_btn.Text = "Cancel";
            students_cancel_btn.UseVisualStyleBackColor = true;
            // 
            // students_groupName_textBox
            // 
            students_groupName_textBox.Location = new Point(29, 190);
            students_groupName_textBox.Name = "students_groupName_textBox";
            students_groupName_textBox.Size = new Size(170, 23);
            students_groupName_textBox.TabIndex = 3;
            // 
            // students_save_btn
            // 
            students_save_btn.Location = new Point(27, 219);
            students_save_btn.Name = "students_save_btn";
            students_save_btn.Size = new Size(75, 23);
            students_save_btn.TabIndex = 1;
            students_save_btn.Text = "Save";
            students_save_btn.UseVisualStyleBackColor = true;
            // 
            // students_groupName_label
            // 
            students_groupName_label.AutoSize = true;
            students_groupName_label.Location = new Point(29, 172);
            students_groupName_label.Name = "students_groupName_label";
            students_groupName_label.Size = new Size(73, 15);
            students_groupName_label.TabIndex = 0;
            students_groupName_label.Text = "Group name";
            // 
            // StudentView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "StudentView";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage_StudentList.ResumeLayout(false);
            tabPage_StudentList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)studentList_dataGridView).EndInit();
            tabPage_StudentDetail.ResumeLayout(false);
            tabPage_StudentDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label_Students;
        private Panel panel1;
        private TabControl tabControl1;
        private TabPage tabPage_StudentList;
        private TabPage tabPage_StudentDetail;
        private Label students_groupName_label;
        private TextBox students_groupName_textBox;
        private Button students_save_btn;
        private Button studentList_search_btn;
        private Button studentList_delete_btn;
        private Button studentList_update_btn;
        private Button studentList_create_btn;
        private TextBox studentList_search_textBox;
        private Label studentList_searchStudent_label;
        private DataGridView studentList_dataGridView;
        private Button students_cancel_btn;
        private Label students_studentId_label;
        private TextBox students_studentId_textBox;
        private Button studentView_close_btn;
        private Label students_studentSurname_label;
        private TextBox students_studentSurname_textBox;
        private Label students_studentName_label;
        private TextBox students_studentName_textBox;
        private ComboBox students_groupList_comboBox;
    }
}
