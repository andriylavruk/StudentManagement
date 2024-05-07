namespace StudentManagement
{
    partial class Form1
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
            tabControl1 = new TabControl();
            tabPage_GroupList = new TabPage();
            tabPage_GroupDetail = new TabPage();
            groups_group_label = new Label();
            groups_save_btn = new Button();
            groups_cancel_btn = new Button();
            groups_grounName_textBox = new TextBox();
            groupList_dataGridView = new DataGridView();
            groupList_searchGroup_label = new Label();
            textBox1 = new TextBox();
            groupList_create_btn = new Button();
            groupList_update_btn = new Button();
            groupList_delete_btn = new Button();
            groupList_search_btn = new Button();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage_GroupList.SuspendLayout();
            tabPage_GroupDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)groupList_dataGridView).BeginInit();
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
            panel1.Controls.Add(label_Groups);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 77);
            panel1.TabIndex = 1;
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
            tabPage_GroupList.Controls.Add(textBox1);
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
            // tabPage_GroupDetail
            // 
            tabPage_GroupDetail.Controls.Add(groups_grounName_textBox);
            tabPage_GroupDetail.Controls.Add(groups_cancel_btn);
            tabPage_GroupDetail.Controls.Add(groups_save_btn);
            tabPage_GroupDetail.Controls.Add(groups_group_label);
            tabPage_GroupDetail.Location = new Point(4, 24);
            tabPage_GroupDetail.Name = "tabPage_GroupDetail";
            tabPage_GroupDetail.Padding = new Padding(3);
            tabPage_GroupDetail.Size = new Size(792, 345);
            tabPage_GroupDetail.TabIndex = 1;
            tabPage_GroupDetail.Text = "Group detail";
            tabPage_GroupDetail.UseVisualStyleBackColor = true;
            // 
            // groups_group_label
            // 
            groups_group_label.AutoSize = true;
            groups_group_label.Location = new Point(35, 36);
            groups_group_label.Name = "groups_group_label";
            groups_group_label.Size = new Size(73, 15);
            groups_group_label.TabIndex = 0;
            groups_group_label.Text = "Group name";
            // 
            // groups_save_btn
            // 
            groups_save_btn.Location = new Point(33, 83);
            groups_save_btn.Name = "groups_save_btn";
            groups_save_btn.Size = new Size(75, 23);
            groups_save_btn.TabIndex = 1;
            groups_save_btn.Text = "Save";
            groups_save_btn.UseVisualStyleBackColor = true;
            groups_save_btn.Click += groups_save_btn_Click;
            // 
            // groups_cancel_btn
            // 
            groups_cancel_btn.Location = new Point(130, 83);
            groups_cancel_btn.Name = "groups_cancel_btn";
            groups_cancel_btn.Size = new Size(75, 23);
            groups_cancel_btn.TabIndex = 2;
            groups_cancel_btn.Text = "Cancel";
            groups_cancel_btn.UseVisualStyleBackColor = true;
            groups_cancel_btn.Click += this.groups_cancel_btn_Click;
            // 
            // groups_grounName_textBox
            // 
            groups_grounName_textBox.Location = new Point(35, 54);
            groups_grounName_textBox.Name = "groups_grounName_textBox";
            groups_grounName_textBox.Size = new Size(170, 23);
            groups_grounName_textBox.TabIndex = 3;
            // 
            // groupList_dataGridView
            // 
            groupList_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            groupList_dataGridView.Location = new Point(36, 80);
            groupList_dataGridView.Name = "groupList_dataGridView";
            groupList_dataGridView.Size = new Size(648, 257);
            groupList_dataGridView.TabIndex = 0;
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
            // textBox1
            // 
            textBox1.Location = new Point(36, 51);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(567, 23);
            textBox1.TabIndex = 2;
            // 
            // groupList_create_btn
            // 
            groupList_create_btn.Location = new Point(690, 80);
            groupList_create_btn.Name = "groupList_create_btn";
            groupList_create_btn.Size = new Size(75, 23);
            groupList_create_btn.TabIndex = 3;
            groupList_create_btn.Text = "Create";
            groupList_create_btn.UseVisualStyleBackColor = true;
            // 
            // groupList_update_btn
            // 
            groupList_update_btn.Location = new Point(690, 109);
            groupList_update_btn.Name = "groupList_update_btn";
            groupList_update_btn.Size = new Size(75, 23);
            groupList_update_btn.TabIndex = 4;
            groupList_update_btn.Text = "Update";
            groupList_update_btn.UseVisualStyleBackColor = true;
            // 
            // groupList_delete_btn
            // 
            groupList_delete_btn.Location = new Point(690, 138);
            groupList_delete_btn.Name = "groupList_delete_btn";
            groupList_delete_btn.Size = new Size(75, 23);
            groupList_delete_btn.TabIndex = 5;
            groupList_delete_btn.Text = "Delete";
            groupList_delete_btn.UseVisualStyleBackColor = true;
            // 
            // groupList_search_btn
            // 
            groupList_search_btn.Location = new Point(609, 51);
            groupList_search_btn.Name = "groupList_search_btn";
            groupList_search_btn.Size = new Size(75, 23);
            groupList_search_btn.TabIndex = 6;
            groupList_search_btn.Text = "Search";
            groupList_search_btn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage_GroupList.ResumeLayout(false);
            tabPage_GroupList.PerformLayout();
            tabPage_GroupDetail.ResumeLayout(false);
            tabPage_GroupDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)groupList_dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label_Groups;
        private Panel panel1;
        private TabControl tabControl1;
        private TabPage tabPage_GroupList;
        private TabPage tabPage_GroupDetail;
        private Label groups_group_label;
        private TextBox groups_grounName_textBox;
        private Button groups_cancel_btn;
        private Button groups_save_btn;
        private Button groupList_search_btn;
        private Button groupList_delete_btn;
        private Button groupList_update_btn;
        private Button groupList_create_btn;
        private TextBox textBox1;
        private Label groupList_searchGroup_label;
        private DataGridView groupList_dataGridView;
    }
}
