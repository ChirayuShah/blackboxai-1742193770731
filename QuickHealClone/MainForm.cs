using System;
using System.Windows.Forms;

namespace QuickHealClone
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            btnStatus.Click += BtnStatus_Click;
            btnProtection.Click += BtnProtection_Click;
            btnPrivacy.Click += BtnPrivacy_Click;
            btnPerformance.Click += BtnPerformance_Click;
            btnMore.Click += BtnMore_Click();
            btnCreateVault.Click += BtnCreateVault_Click; // New button for Create Vault
        }

        private void BtnCreateVault_Click(object sender, EventArgs e)
        {
            CreateVaultForm createVaultForm = new CreateVaultForm();
            createVaultForm.ShowDialog();
        }

        private void BtnStatus_Click(object sender, EventArgs e)
        {
            // Load Status content
            mainContentPanel.Controls.Clear();
            Label statusLabel = new Label { Text = "Status Content", Dock = DockStyle.Fill };
            mainContentPanel.Controls.Add(statusLabel);
        }

        private void BtnProtection_Click(object sender, EventArgs e)
        {
            // Load Protection content
            mainContentPanel.Controls.Clear();
            Label protectionLabel = new Label { Text = "Protection Content", Dock = DockStyle.Fill };
            mainContentPanel.Controls.Add(protectionLabel);
        }

        private void BtnPrivacy_Click(object sender, EventArgs e)
        {
            // Load Privacy content
            mainContentPanel.Controls.Clear();
            Label privacyLabel = new Label { Text = "Privacy Content", Dock = DockStyle.Fill };
            mainContentPanel.Controls.Add(privacyLabel);
        }

        private void BtnPerformance_Click(object sender, EventArgs e)
        {
            // Load Performance content
            mainContentPanel.Controls.Clear();
            Label performanceLabel = new Label { Text = "Performance Content", Dock = DockStyle.Fill };
            mainContentPanel.Controls.Add(performanceLabel);
        }

        private void BtnMore_Click(object sender, EventArgs e)
        {
            // Load More content
            mainContentPanel.Controls.Clear();
            Label moreLabel = new Label { Text = "More Content", Dock = DockStyle.Fill };
            mainContentPanel.Controls.Add(moreLabel);
        }
    }
}
