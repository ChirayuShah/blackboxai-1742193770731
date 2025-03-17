namespace QuickHealClone
{
    partial class CreateVaultForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblSetPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnFinish;

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
            this.lblSetPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnFinish = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSetPassword
            // 
            this.lblSetPassword.Text = "Set Password:";
            this.lblSetPassword.Location = new System.Drawing.Point(20, 20);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(150, 20);
            this.txtPassword.PasswordChar = '*';
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.Text = "Confirm Password:";
            this.lblConfirmPassword.Location = new System.Drawing.Point(20, 60);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(150, 60);
            this.txtConfirmPassword.PasswordChar = '*';
            // 
            // lblEmail
            // 
            this.lblEmail.Text = "Email Address:";
            this.lblEmail.Location = new System.Drawing.Point(20, 100);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(150, 100);
            // 
            // btnFinish
            // 
            this.btnFinish.Text = "Finish";
            this.btnFinish.Location = new System.Drawing.Point(150, 140);
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // CreateVaultForm
            // 
            this.ClientSize = new System.Drawing.Size(400, 200);
            this.Controls.Add(this.lblSetPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnFinish);
            this.Name = "CreateVaultForm";
            this.Text = "Create Vault";
            this.ResumeLayout(false);
        }
    }
}
