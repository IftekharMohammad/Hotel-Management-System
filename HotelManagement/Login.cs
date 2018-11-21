using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using HM.Data;
namespace HotelManagement
{
	public partial class Login : MetroForm
	{
		string login;
		public Login()
		{
			InitializeComponent();
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			this.Visible = false;
			new Home().Visible = true;
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			login = "customer";
			label2.Text = "Customer User Name :";
			label2.Visible = true;
			label3.Visible = true;
			txtUser.Visible = true;
			txtPass.Visible = true;
			btnLogin.Visible = true;
		}

		private void btnEmployeeLogin_Click(object sender, EventArgs e)
		{

			login = "employee";
			label2.Text = "Employee User Name :";
			label2.Visible = true;
			label3.Visible = true;
			txtUser.Visible = true;
			txtPass.Visible = true;
			btnLogin.Visible = true;
		}
		private void btnLogin_Click_1(object sender, EventArgs e)
		{
			if (txtUser.Text == "" && txtPass.Text == "")
			{
				MessageBox.Show("Both User Name and Password are Empty");

			}
			else if (txtPass.Text == "")
			{
				MessageBox.Show("Password is Empty");
				txtUser.Text = "";
			}
			else if (txtUser.Text == "")
			{
				MessageBox.Show("User Name is Empty");
				txtPass.Text = "";
			}
			else
			{
				DataTable acc = new DataTable();
				if (login == "customer")
				{
					acc = DataAccess.GetDataTable("SELECT USER_NAME, PASSWORD FROM CUSTOMER WHERE USER_NAME='" + txtUser.Text + "'");
					if (acc.Rows.Count == 0)
					{
						MessageBox.Show("Wrong User Name");
						txtUser.Text = "";
						txtPass.Text = "";
					}
					else
					{
						acc = DataAccess.GetDataTable("SELECT USER_NAME, PASSWORD FROM CUSTOMER WHERE USER_NAME='" + txtUser.Text + "' AND PASSWORD ='" + txtPass.Text + "'");
						if (acc.Rows.Count == 0)
						{
							MessageBox.Show("Wrong Password");
							txtUser.Text = "";
							txtPass.Text = "";
						}
						else
						{
							acc = DataAccess.GetDataTable("SELECT CUSTOMER_ID, FIRST_NAME FROM CUSTOMER WHERE USER_NAME='" + txtUser.Text + "' AND PASSWORD ='" + txtPass.Text + "'");
							string name = acc.Rows[0]["FIRST_NAME"].ToString();
							int id = Convert.ToInt32(acc.Rows[0]["CUSTOMER_ID"].ToString());
							this.Visible = false;
							new User(name, id).Visible = true;
						}
					}
				}
				else
				{
					acc = DataAccess.GetDataTable("SELECT USERNAME, PASSWORD,EMPLOYEE_TYPE FROM EMPLOYEE WHERE USERNAME='" + txtUser.Text + "'");
					if (acc.Rows.Count == 0)
					{
						MessageBox.Show("Wrong User Name");
						txtUser.Text = "";
						txtPass.Text = "";
					}
					else
					{
						acc = DataAccess.GetDataTable("SELECT USERNAME, PASSWORD FROM EMPLOYEE WHERE USERNAME='" + txtUser.Text + "' AND PASSWORD ='" + txtPass.Text + "'");
						if (acc.Rows.Count == 0)
						{
							MessageBox.Show("Wrong Password");
							txtUser.Text = "";
							txtPass.Text = "";
						}
						else
						{
							acc = DataAccess.GetDataTable("SELECT FIRST_NAME,EMPLOYEE_TYPE FROM EMPLOYEE WHERE USERNAME='" + txtUser.Text + "' AND PASSWORD ='" + txtPass.Text + "'");
							string name = acc.Rows[0]["FIRST_NAME"].ToString();
							this.Visible = false;
							string type = acc.Rows[0]["EMPLOYEE_TYPE"].ToString();
							if (type == "Admin")
							{
								new Admin(name).Visible = true;
							}
							else
							{
								new Employee(name).Visible = true;
							}
						}
					}
				}
			}
		}
		private void Login_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}
	}
}
