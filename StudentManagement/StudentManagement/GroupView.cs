using StudentManagement.Views;

namespace StudentManagement
{
    public partial class GroupView : Form, IGroupView
    {
        private string message;
        private bool isSuccessful;
        private bool isEdit;

        public GroupView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
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
        }

        public string GroupId { get => groups_grounId_textBox.Text; set => groups_grounId_textBox.Text = value; }
        public string GroupName { get => groups_grounName_textBox.Text; set => groups_grounName_textBox.Text = value; }
        public string SearchValue { get => groupList_search_textBox.Text; set => groupList_search_textBox.Text = value; }
        public bool IsEdit { get => isEdit; set => isEdit = value; }
        public bool IsSuccessful { get => isSuccessful; set => isSuccessful = value; }
        public string Message { get => message; set => message = value; }

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
            if (instance == null || instance.IsDisposed)
            {
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
    }
}
