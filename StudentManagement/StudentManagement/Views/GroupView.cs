using StudentManagement.Models;
using StudentManagement.Views;

namespace StudentManagement
{
    public partial class GroupView : Form, IGroupView
    {
        private string message;
        private bool isSuccessful;
        private bool isEdit;

        private User _userInfo;

        public GroupView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tabControl1.TabPages.Remove(tabPage_GroupDetail);
            groupView_close_btn.Click += delegate { Close(); };
        }

        private void AssociateAndRaiseViewEvents()
        {
            groupList_search_btn.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            groupList_search_textBox.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };

            groupList_create_btn.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPage_GroupList);
                tabControl1.TabPages.Add(tabPage_GroupDetail);
                tabPage_GroupDetail.Text = "Add new group";
            };

            groupList_update_btn.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPage_GroupList);
                tabControl1.TabPages.Add(tabPage_GroupDetail);
                tabPage_GroupDetail.Text = "Update group";
            };

            groups_save_btn.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);

                if (isSuccessful)
                {
                    tabControl1.TabPages.Remove(tabPage_GroupDetail);
                    tabControl1.TabPages.Add(tabPage_GroupList);
                }

                MessageBox.Show(Message);
            };

            groups_cancel_btn.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPage_GroupDetail);
                tabControl1.TabPages.Add(tabPage_GroupList);
            };

            groupList_delete_btn.Click += delegate
            {
                var result = MessageBox.Show("Are you sure you want to delete the selected group? All students who are members of the group will also be removed.",
                    "Warning",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };
        }

        public string GroupId { get => groups_groupId_textBox.Text; set => groups_groupId_textBox.Text = value; }
        public string GroupName { get => groups_groupName_textBox.Text; set => groups_groupName_textBox.Text = value; }
        public string SearchValue { get => groupList_search_textBox.Text; set => groupList_search_textBox.Text = value; }
        public bool IsEdit { get => isEdit; set => isEdit = value; }
        public bool IsSuccessful { get => isSuccessful; set => isSuccessful = value; }
        public string Message { get => message; set => message = value; }
        public User UserInfo { get => _userInfo; init => _userInfo = value; }

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public void SetGroupListBindingSource(BindingSource groupList)
        {
            groupList_dataGridView.DataSource = groupList;
        }

        private static GroupView instance;
        public static GroupView GetInstace(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed || instance.tabControl1.SelectedTab == instance.tabPage_GroupDetail)
            {
                if (instance != null)
                {
                    instance.Close();
                }

                instance = new GroupView();
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

        private void groups_save_btn_Click(object sender, EventArgs e)
        {

        }

        private void GroupView_Load(object sender, EventArgs e)
        {
            if(_userInfo.Role!.Name != "admin")
            {
                groupList_create_btn.Visible = false;
                groupList_update_btn.Visible = false;
                groupList_delete_btn.Visible = false;
            }
        }

        public void SetUserInfo(User user)
        {
            _userInfo = user;
        }
    }
}
