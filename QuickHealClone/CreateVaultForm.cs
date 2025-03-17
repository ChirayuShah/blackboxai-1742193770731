using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace QuickHealClone
{
    public partial class CreateVaultForm : Form
    {
        public CreateVaultForm()
        {
            InitializeComponent();
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;
            string email = txtEmail.Text;

            if (!ValidatePassword(password, confirmPassword))
            {
                MessageBox.Show("Passwords do not match or do not meet the criteria.");
                return;
            }

            if (!ValidateEmail(email))
            {
                MessageBox.Show("Invalid email address.");
                return;
            }

            // Proceed with creating the vault
            MessageBox.Show("Vault created successfully!");
        }

        private bool ValidatePassword(string password, string confirmPassword)
        {
            return password == confirmPassword && password.Length >= 6 && password.Length <= 18;
        }

        private bool ValidateEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }
    }
}
