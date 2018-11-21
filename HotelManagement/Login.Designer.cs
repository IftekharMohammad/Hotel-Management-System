namespace HotelManagement
{
	partial class Login
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
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnLogin = new System.Windows.Forms.Button();
			this.btnEmployeeLogin = new System.Windows.Forms.Button();
			this.txtPass = new MetroFramework.Controls.MetroTextBox();
			this.txtUser = new MetroFramework.Controls.MetroTextBox();
			this.btnBack = new System.Windows.Forms.Button();
			this.btnCustomerLogin = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.flowLayoutPanel1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.panel1);
			this.flowLayoutPanel1.Location = new System.Drawing.Point(23, 27);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(854, 475);
			this.flowLayoutPanel1.TabIndex = 0;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnLogin);
			this.panel1.Controls.Add(this.btnEmployeeLogin);
			this.panel1.Controls.Add(this.txtPass);
			this.panel1.Controls.Add(this.txtUser);
			this.panel1.Controls.Add(this.btnBack);
			this.panel1.Controls.Add(this.btnCustomerLogin);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(851, 472);
			this.panel1.TabIndex = 0;
			// 
			// btnLogin
			// 
			this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLogin.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLogin.ForeColor = System.Drawing.Color.CornflowerBlue;
			this.btnLogin.Location = new System.Drawing.Point(659, 268);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(160, 34);
			this.btnLogin.TabIndex = 57;
			this.btnLogin.Text = "Login";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Visible = false;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click_1);
			// 
			// btnEmployeeLogin
			// 
			this.btnEmployeeLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEmployeeLogin.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEmployeeLogin.ForeColor = System.Drawing.Color.CornflowerBlue;
			this.btnEmployeeLogin.Location = new System.Drawing.Point(29, 268);
			this.btnEmployeeLogin.Name = "btnEmployeeLogin";
			this.btnEmployeeLogin.Size = new System.Drawing.Size(160, 129);
			this.btnEmployeeLogin.TabIndex = 56;
			this.btnEmployeeLogin.Text = "Employee Login";
			this.btnEmployeeLogin.UseVisualStyleBackColor = true;
			this.btnEmployeeLogin.Click += new System.EventHandler(this.btnEmployeeLogin_Click);
			// 
			// txtPass
			// 
			// 
			// 
			// 
			this.txtPass.CustomButton.Image = null;
			this.txtPass.CustomButton.Location = new System.Drawing.Point(235, 1);
			this.txtPass.CustomButton.Name = "";
			this.txtPass.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.txtPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtPass.CustomButton.TabIndex = 1;
			this.txtPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtPass.CustomButton.UseSelectable = true;
			this.txtPass.CustomButton.Visible = false;
			this.txtPass.Lines = new string[0];
			this.txtPass.Location = new System.Drawing.Point(562, 211);
			this.txtPass.MaxLength = 32767;
			this.txtPass.Name = "txtPass";
			this.txtPass.PasswordChar = '●';
			this.txtPass.PromptText = "Type Your Password";
			this.txtPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtPass.SelectedText = "";
			this.txtPass.SelectionLength = 0;
			this.txtPass.SelectionStart = 0;
			this.txtPass.ShortcutsEnabled = true;
			this.txtPass.Size = new System.Drawing.Size(257, 23);
			this.txtPass.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtPass.TabIndex = 55;
			this.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtPass.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.txtPass.UseSelectable = true;
			this.txtPass.UseSystemPasswordChar = true;
			this.txtPass.Visible = false;
			this.txtPass.WaterMark = "Type Your Password";
			this.txtPass.WaterMarkColor = System.Drawing.Color.CornflowerBlue;
			this.txtPass.WaterMarkFont = new System.Drawing.Font("Gill Sans Ultra Bold", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			// 
			// txtUser
			// 
			// 
			// 
			// 
			this.txtUser.CustomButton.Image = null;
			this.txtUser.CustomButton.Location = new System.Drawing.Point(235, 1);
			this.txtUser.CustomButton.Name = "";
			this.txtUser.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.txtUser.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtUser.CustomButton.TabIndex = 1;
			this.txtUser.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtUser.CustomButton.UseSelectable = true;
			this.txtUser.CustomButton.Visible = false;
			this.txtUser.Lines = new string[0];
			this.txtUser.Location = new System.Drawing.Point(562, 108);
			this.txtUser.MaxLength = 32767;
			this.txtUser.Name = "txtUser";
			this.txtUser.PasswordChar = '\0';
			this.txtUser.PromptText = "Type Your User Name";
			this.txtUser.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtUser.SelectedText = "";
			this.txtUser.SelectionLength = 0;
			this.txtUser.SelectionStart = 0;
			this.txtUser.ShortcutsEnabled = true;
			this.txtUser.Size = new System.Drawing.Size(257, 23);
			this.txtUser.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtUser.TabIndex = 54;
			this.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtUser.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.txtUser.UseSelectable = true;
			this.txtUser.Visible = false;
			this.txtUser.WaterMark = "Type Your User Name";
			this.txtUser.WaterMarkColor = System.Drawing.Color.CornflowerBlue;
			this.txtUser.WaterMarkFont = new System.Drawing.Font("Gill Sans Ultra Bold", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			// 
			// btnBack
			// 
			this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBack.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBack.ForeColor = System.Drawing.Color.CornflowerBlue;
			this.btnBack.Location = new System.Drawing.Point(659, 418);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(160, 51);
			this.btnBack.TabIndex = 53;
			this.btnBack.Text = "<- Back";
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// btnCustomerLogin
			// 
			this.btnCustomerLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCustomerLogin.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCustomerLogin.ForeColor = System.Drawing.Color.CornflowerBlue;
			this.btnCustomerLogin.Location = new System.Drawing.Point(29, 108);
			this.btnCustomerLogin.Name = "btnCustomerLogin";
			this.btnCustomerLogin.Size = new System.Drawing.Size(160, 129);
			this.btnCustomerLogin.TabIndex = 52;
			this.btnCustomerLogin.Text = "Customer Login";
			this.btnCustomerLogin.UseVisualStyleBackColor = true;
			this.btnCustomerLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.CornflowerBlue;
			this.label3.Location = new System.Drawing.Point(291, 211);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(144, 26);
			this.label3.TabIndex = 2;
			this.label3.Text = "Password : ";
			this.label3.Visible = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
			this.label2.Location = new System.Drawing.Point(291, 108);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(157, 26);
			this.label2.TabIndex = 1;
			this.label2.Text = "User Name : ";
			this.label2.Visible = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
			this.label1.Location = new System.Drawing.Point(15, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(128, 44);
			this.label1.TabIndex = 0;
			this.label1.Text = "Login";
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(900, 525);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Name = "Login";
			this.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnBack;
		private System.Windows.Forms.Button btnCustomerLogin;
		private MetroFramework.Controls.MetroTextBox txtUser;
		private MetroFramework.Controls.MetroTextBox txtPass;
		private System.Windows.Forms.Button btnEmployeeLogin;
		private System.Windows.Forms.Button btnLogin;
	}
}