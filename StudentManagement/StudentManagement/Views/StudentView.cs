using StudentManagement.Models;
using StudentManagement.Views;
using System.Data;

namespace StudentManagement
{
    public partial class StudentView : Form, IStudentView
    {
        private string message;
        private bool isSuccessful;
        private bool isEdit;

        private Group _group;

        public StudentView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tabControl1.TabPages.Remove(tabPage_StudentDetail);
            studentView_close_btn.Click += delegate { Close(); };
        }

        private void AssociateAndRaiseViewEvents()
        {
            studentList_search_btn.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            studentList_search_textBox.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };

            studentList_create_btn.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPage_StudentList);
                tabControl1.TabPages.Add(tabPage_StudentDetail);
                tabPage_StudentDetail.Text = "Add new student";
            };

            studentList_update_btn.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPage_StudentList);
                tabControl1.TabPages.Add(tabPage_StudentDetail);
                tabPage_StudentDetail.Text = "Update student";
            };

            students_save_btn.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);

                if (isSuccessful)
                {
                    tabControl1.TabPages.Remove(tabPage_StudentDetail);
                    tabControl1.TabPages.Add(tabPage_StudentList);
                }

                MessageBox.Show(Message);
            };

            students_cancel_btn.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPage_StudentDetail);
                tabControl1.TabPages.Add(tabPage_StudentList);
            };

            studentList_delete_btn.Click += delegate
            {
                var result = MessageBox.Show("Are you sure you want to delete the selected student?",
                    "Warning",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };
        }

        public string StudentId { get => students_studentId_textBox.Text; set => students_studentId_textBox.Text = value; }
        public string StudentName { get => students_studentName_textBox.Text; set => students_studentName_textBox.Text = value; }
        public string StudentSurname { get => students_studentSurname_textBox.Text; set => students_studentSurname_textBox.Text = value; }
        public string StudentGroupId { get => students_groupName_textBox.Text; set => students_groupName_textBox.Text = value; }
        public Group? StudentGroup
        {
            get
            {
                _group.Id = (int)students_groupList_comboBox.SelectedValue!;
                _group.Name = students_groupList_comboBox.GetItemText(students_groupList_comboBox.SelectedItem)!;

                return _group;
            }
            set
            {
                _group = value!;
            }
        }
        public string SearchValue { get => studentList_search_textBox.Text; set => studentList_search_textBox.Text = value; }
        public bool IsEdit { get => isEdit; set => isEdit = value; }
        public bool IsSuccessful { get => isSuccessful; set => isSuccessful = value; }
        public string Message { get => message; set => message = value; }

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public void SetStudentListBindingSource(BindingSource studentList)
        {
            studentList_dataGridView.DataSource = studentList;
            
        }

        private static StudentView instance;
        public static StudentView GetInstace(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed || instance.tabControl1.SelectedTab == instance.tabPage_StudentDetail)
            {
                if (instance != null)
                {
                    instance.Close();
                }

                instance = new StudentView();
                instance.MdiParent = parentContainer;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                {
                    instance.WindowState = FormWindowState.Normal;
                }

                instance.BringToFront();
            }

            return instance;
        }

        public void SetComboBoxData(BindingSource groups)
        {
            students_groupList_comboBox.DataSource = groups;
            students_groupList_comboBox.ValueMember = "Id";
            students_groupList_comboBox.DisplayMember = "Name";
        }

        private void students_groupList_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (students_groupList_comboBox.SelectedValue?.ToString() != null)
            {
                StudentGroupId = (Convert.ToInt32(students_groupList_comboBox.SelectedValue!.ToString())).ToString();
            }            
        }
    }
}
