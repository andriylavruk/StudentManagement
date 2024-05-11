namespace StudentManagement.Views
{
    partial class MainView
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
            panel1 = new Panel();
            mainview_logout_btn = new Button();
            mainview_students_btn = new Button();
            mainview_groups_btn = new Button();
            statusStrip1 = new StatusStrip();
            mainview_toolStripStatusLabel = new ToolStripStatusLabel();
            panel1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(mainview_logout_btn);
            panel1.Controls.Add(mainview_students_btn);
            panel1.Controls.Add(mainview_groups_btn);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 595);
            panel1.TabIndex = 0;
            // 
            // mainview_logout_btn
            // 
            mainview_logout_btn.BackColor = Color.Gray;
            mainview_logout_btn.Font = new Font("Segoe UI", 12F);
            mainview_logout_btn.Location = new Point(3, 522);
            mainview_logout_btn.Name = "mainview_logout_btn";
            mainview_logout_btn.Size = new Size(194, 45);
            mainview_logout_btn.TabIndex = 3;
            mainview_logout_btn.Text = "Log out";
            mainview_logout_btn.UseVisualStyleBackColor = false;
            mainview_logout_btn.Click += mainview_logout_btn_Click;
            // 
            // mainview_students_btn
            // 
            mainview_students_btn.Font = new Font("Segoe UI", 12F);
            mainview_students_btn.Location = new Point(3, 136);
            mainview_students_btn.Name = "mainview_students_btn";
            mainview_students_btn.Size = new Size(194, 45);
            mainview_students_btn.TabIndex = 2;
            mainview_students_btn.Text = "Students";
            mainview_students_btn.UseVisualStyleBackColor = true;
            // 
            // mainview_groups_btn
            // 
            mainview_groups_btn.Font = new Font("Segoe UI", 12F);
            mainview_groups_btn.Location = new Point(3, 85);
            mainview_groups_btn.Name = "mainview_groups_btn";
            mainview_groups_btn.Size = new Size(194, 45);
            mainview_groups_btn.TabIndex = 1;
            mainview_groups_btn.Text = "Groups";
            mainview_groups_btn.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { mainview_toolStripStatusLabel });
            statusStrip1.Location = new Point(0, 595);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1106, 22);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // mainview_toolStripStatusLabel
            // 
            mainview_toolStripStatusLabel.Name = "mainview_toolStripStatusLabel";
            mainview_toolStripStatusLabel.Size = new Size(48, 17);
            mainview_toolStripStatusLabel.Text = "Login: ?";
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1106, 617);
            Controls.Add(panel1);
            Controls.Add(statusStrip1);
            IsMdiContainer = true;
            Name = "MainView";
            FormClosing += MainView_FormClosing;
            Load += MainView_Load;
            panel1.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button mainview_groups_btn;
        private Button mainview_students_btn;
        private Button mainview_logout_btn;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel mainview_toolStripStatusLabel;
    }
}