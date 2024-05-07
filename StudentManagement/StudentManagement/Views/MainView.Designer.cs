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
            mainview_groups_btn = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(mainview_groups_btn);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 617);
            panel1.TabIndex = 0;
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
            // MainView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1106, 617);
            Controls.Add(panel1);
            IsMdiContainer = true;
            Name = "MainView";
            Text = "MainView";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button mainview_groups_btn;
    }
}