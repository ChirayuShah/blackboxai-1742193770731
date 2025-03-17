namespace QuickHealClone
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel sidebarPanel;
        private System.Windows.Forms.Button btnStatus;
        private System.Windows.Forms.Button btnProtection;
        private System.Windows.Forms.Button btnPrivacy;
        private System.Windows.Forms.Button btnPerformance;
        private System.Windows.Forms.Button btnMore;
        private System.Windows.Forms.Panel mainContentPanel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.sidebarPanel = new System.Windows.Forms.Panel();
            this.btnStatus = new System.Windows.Forms.Button();
            this.btnProtection = new System.Windows.Forms.Button();
            this.btnPrivacy = new System.Windows.Forms.Button();
            this.btnPerformance = new System.Windows.Forms.Button();
            this.btnMore = new System.Windows.Forms.Button();
            this.mainContentPanel = new System.Windows.Forms.Panel();
            this.sidebarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebarPanel
            // 
            this.sidebarPanel.Controls.Add(this.btnStatus);
            this.sidebarPanel.Controls.Add(this.btnProtection);
            this.sidebarPanel.Controls.Add(this.btnPrivacy);
            this.sidebarPanel.Controls.Add(this.btnPerformance);
            this.sidebarPanel.Controls.Add(this.btnMore);
            this.sidebarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarPanel.Width = 200;
            this.sidebarPanel.BackColor = System.Drawing.Color.LightGreen;
            // 
            // btnStatus
            // 
            this.btnStatus.Text = "Status";
            this.btnStatus.Dock = System.Windows.Forms.DockStyle.Top;
            // 
            // btnProtection
            // 
            this.btnProtection.Text = "Protection";
            this.btnProtection.Dock = System.Windows.Forms.DockStyle.Top;
            // 
            // btnPrivacy
            // 
            this.btnPrivacy.Text = "Privacy";
            this.btnPrivacy.Dock = System.Windows.Forms.DockStyle.Top;
            // 
            // btnPerformance
            // 
            this.btnPerformance.Text = "Performance";
            this.btnPerformance.Dock = System.Windows.Forms.DockStyle.Top;
            // 
            // btnMore
            // 
            this.btnMore.Text = "More";
            this.btnMore.Dock = System.Windows.Forms.DockStyle.Top;
            // 
            // mainContentPanel
            // 
            this.mainContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContentPanel.BackColor = System.Drawing.Color.White;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainContentPanel);
            this.Controls.Add(this.sidebarPanel);
            this.Name = "MainForm";
            this.Text = "Quick Heal Total Security";
            this.sidebarPanel.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}
