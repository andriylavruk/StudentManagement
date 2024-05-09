namespace StudentManagement
{
    partial class GroupView
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
            label_Groups = new Label();
            panel1 = new Panel();
            groupView_close_btn = new Button();
            tabControl1 = new TabControl();
            tabPage_GroupList = new TabPage();
            groupList_search_btn = new Button();
            groupList_delete_btn = new Button();
            groupList_update_btn = new Button();
            groupList_create_btn = new Button();
            groupList_search_textBox = new TextBox();
            groupList_searchGroup_label = new Label();
            groupList_dataGridView = new DataGridView();
            tabPage_GroupDetail = new TabPage();
            groups_groupId_label = new Label();
            groups_groupId_textBox = new TextBox();
            groups_cancel_btn = new Button();
            groups_groupName_textBox = new TextBox();
            groups_save_btn = new Button();
            groups_groupName_label = new Label();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage_GroupList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)groupList_dataGridView).BeginInit();
            tabPage_GroupDetail.SuspendLayout();
            SuspendLayout();
            // 
            // label_Groups
            // 
            label_Groups.AutoSize = true;
            label_Groups.Font = new Font("Segoe UI", 12F);
            label_Groups.Location = new Point(12, 29);
            label_Groups.Name = "label_Groups";
            label_Groups.Size = new Size(61, 21);
            label_Groups.TabIndex = 0;
            label_Groups.Text = "Groups";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(groupView_close_btn);
            panel1.Controls.Add(label_Groups);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 77);
            panel1.TabIndex = 1;
            // 
            // groupView_close_btn
            // 
            groupView_close_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupView_close_btn.Font = new Font("Segoe UI", 12F);
            groupView_close_btn.Location = new Point(757, 24);
            groupView_close_btn.Name = "groupView_close_btn";
            groupView_close_btn.Size = new Size(31, 30);
            groupView_close_btn.TabIndex = 7;
            groupView_close_btn.Text = "X";
            groupView_close_btn.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage_GroupList);
            tabControl1.Controls.Add(tabPage_GroupDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 77);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 373);
            tabControl1.TabIndex = 2;
            // 
            // tabPage_GroupList
            // 
            tabPage_GroupList.Controls.Add(groupList_search_btn);
            tabPage_GroupList.Controls.Add(groupList_delete_btn);
            tabPage_GroupList.Controls.Add(groupList_update_btn);
            tabPage_GroupList.Controls.Add(groupList_create_btn);
            tabPage_GroupList.Controls.Add(groupList_search_textBox);
            tabPage_GroupList.Controls.Add(groupList_searchGroup_label);
            tabPage_GroupList.Controls.Add(groupList_dataGridView);
            tabPage_GroupList.Location = new Point(4, 24);
            tabPage_GroupList.Name = "tabPage_GroupList";
            tabPage_GroupList.Padding = new Padding(3);
            tabPage_GroupList.Size = new Size(792, 345);
            tabPage_GroupList.TabIndex = 0;
            tabPage_GroupList.Text = "Group list";
            tabPage_GroupList.UseVisualStyleBackColor = true;
            // 
            // groupList_search_btn
            // 
            groupList_search_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupList_search_btn.Location = new Point(609, 51);
            groupList_search_btn.Name = "groupList_search_btn";
            groupList_search_btn.Size = new Size(75, 23);
            groupList_search_btn.TabIndex = 6;
            groupList_search_btn.Text = "Search";
            groupList_search_btn.UseVisualStyleBackColor = true;
            // 
            // groupList_delete_btn
            // 
            groupList_delete_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupList_delete_btn.Location = new Point(690, 138);
            groupList_delete_btn.Name = "groupList_delete_btn";
            groupList_delete_btn.Size = new Size(75, 23);
            groupList_delete_btn.TabIndex = 5;
            groupList_delete_btn.Text = "Delete";
            groupList_delete_btn.UseVisualStyleBackColor = true;
            // 
            // groupList_update_btn
            // 
            groupList_update_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupList_update_btn.Location = new Point(690, 109);
            groupList_update_btn.Name = "groupList_update_btn";
            groupList_update_btn.Size = new Size(75, 23);
            groupList_update_btn.TabIndex = 4;
            groupList_update_btn.Text = "Update";
            groupList_update_btn.UseVisualStyleBackColor = true;
            // 
            // groupList_create_btn
            // 
            groupList_create_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupList_create_btn.Location = new Point(690, 80);
            groupList_create_btn.Name = "groupList_create_btn";
            groupList_create_btn.Size = new Size(75, 23);
            groupList_create_btn.TabIndex = 3;
            groupList_create_btn.Text = "Create";
            groupList_create_btn.UseVisualStyleBackColor = true;
            // 
            // groupList_search_textBox
            // 
            groupList_search_textBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupList_search_textBox.Location = new Point(36, 51);
            groupList_search_textBox.Name = "groupList_search_textBox";
            groupList_search_textBox.Size = new Size(567, 23);
            groupList_search_textBox.TabIndex = 2;
            // 
            // groupList_searchGroup_label
            // 
            groupList_searchGroup_label.AutoSize = true;
            groupList_searchGroup_label.Location = new Point(36, 33);
            groupList_searchGroup_label.Name = "groupList_searchGroup_label";
            groupList_searchGroup_label.Size = new Size(80, 15);
            groupList_searchGroup_label.TabIndex = 1;
            groupList_searchGroup_label.Text = "Search group:";
            // 
            // groupList_dataGridView
            // 
            groupList_dataGridView.AllowUserToAddRows = false;
            groupList_dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupList_dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            groupList_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            groupList_dataGridView.Location = new Point(36, 80);
            groupList_dataGridView.Name = "groupList_dataGridView";
            groupList_dataGridView.ReadOnly = true;
            groupList_dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            groupList_dataGridView.Size = new Size(648, 257);
            groupList_dataGridView.TabIndex = 0;
            // 
            // tabPage_GroupDetail
            // 
            tabPage_GroupDetail.Controls.Add(groups_groupId_label);
            tabPage_GroupDetail.Controls.Add(groups_groupId_textBox);
            tabPage_GroupDetail.Controls.Add(groups_cancel_btn);
            tabPage_GroupDetail.Controls.Add(groups_groupName_textBox);
            tabPage_GroupDetail.Controls.Add(groups_save_btn);
            tabPage_GroupDetail.Controls.Add(groups_groupName_label);
            tabPage_GroupDetail.Location = new Point(4, 24);
            tabPage_GroupDetail.Name = "tabPage_GroupDetail";
            tabPage_GroupDetail.Padding = new Padding(3);
            tabPage_GroupDetail.Size = new Size(792, 345);
            tabPage_GroupDetail.TabIndex = 1;
            tabPage_GroupDetail.Text = "Group detail";
            tabPage_GroupDetail.UseVisualStyleBackColor = true;
            // 
            // groups_groupId_label
            // 
            groups_groupId_label.AutoSize = true;
            groups_groupId_label.Location = new Point(29, 36);
            groups_groupId_label.Name = "groups_groupId_label";
            groups_groupId_label.Size = new Size(53, 15);
            groups_groupId_label.TabIndex = 6;
            groups_groupId_label.Text = "Group Id";
            // 
            // groups_groupId_textBox
            // 
            groups_groupId_textBox.Enabled = false;
            groups_groupId_textBox.Location = new Point(29, 54);
            groups_groupId_textBox.Name = "groups_groupId_textBox";
            groups_groupId_textBox.Size = new Size(170, 23);
            groups_groupId_textBox.TabIndex = 5;
            groups_groupId_textBox.Text = "0";
            // 
            // groups_cancel_btn
            // 
            groups_cancel_btn.Location = new Point(124, 127);
            groups_cancel_btn.Name = "groups_cancel_btn";
            groups_cancel_btn.Size = new Size(75, 23);
            groups_cancel_btn.TabIndex = 4;
            groups_cancel_btn.Text = "Cancel";
            groups_cancel_btn.UseVisualStyleBackColor = true;
            // 
            // groups_groupName_textBox
            // 
            groups_groupName_textBox.Location = new Point(29, 98);
            groups_groupName_textBox.Name = "groups_groupName_textBox";
            groups_groupName_textBox.Size = new Size(170, 23);
            groups_groupName_textBox.TabIndex = 3;
            // 
            // groups_save_btn
            // 
            groups_save_btn.Location = new Point(27, 127);
            groups_save_btn.Name = "groups_save_btn";
            groups_save_btn.Size = new Size(75, 23);
            groups_save_btn.TabIndex = 1;
            groups_save_btn.Text = "Save";
            groups_save_btn.UseVisualStyleBackColor = true;
            groups_save_btn.Click += groups_save_btn_Click;
            // 
            // groups_groupName_label
            // 
            groups_groupName_label.AutoSize = true;
            groups_groupName_label.Location = new Point(29, 80);
            groups_groupName_label.Name = "groups_groupName_label";
            groups_groupName_label.Size = new Size(73, 15);
            groups_groupName_label.TabIndex = 0;
            groups_groupName_label.Text = "Group name";
            // 
            // GroupView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "GroupView";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage_GroupList.ResumeLayout(false);
            tabPage_GroupList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)groupList_dataGridView).EndInit();
            tabPage_GroupDetail.ResumeLayout(false);
            tabPage_GroupDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label_Groups;
        private Panel panel1;
        private TabControl tabControl1;
        private TabPage tabPage_GroupList;
        private TabPage tabPage_GroupDetail;
        private Label groups_groupName_label;
        private TextBox groups_groupName_textBox;
        private Button groups_save_btn;
        private Button groupList_search_btn;
        private Button groupList_delete_btn;
        private Button groupList_update_btn;
        private Button groupList_create_btn;
        private TextBox groupList_search_textBox;
        private Label groupList_searchGroup_label;
        private DataGridView groupList_dataGridView;
        private Button groups_cancel_btn;
        private Label groups_groupId_label;
        private TextBox groups_groupId_textBox;
        private Button groupView_close_btn;
    }
}
