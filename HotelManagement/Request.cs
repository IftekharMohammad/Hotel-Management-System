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
	public partial class Request : MetroForm
	{
		static int request_id;
		public Request()
		{
			InitializeComponent();
			if(int.TryParse(DataAccess.GetDataTable("SELECT MAX(REQUEST_ID) AS A FROM CUSTOMER_REQUEST").Rows[0]["A"].ToString(),out int a))
			{
				request_id = Convert.ToInt32(DataAccess.GetDataTable("SELECT MAX(REQUEST_ID) AS A FROM CUSTOMER_REQUEST").Rows[0]["A"].ToString()) + 1;
			}
			else
			{
				request_id = 1;
			}
			
			dgType.AutoGenerateColumns = false;
			dgType.Columns["room_type"].DefaultCellStyle.ForeColor = Color.CornflowerBlue;
			dgType.Columns["room_cost"].DefaultCellStyle.ForeColor = Color.CornflowerBlue;
			dgType.DataSource = DataAccess.GetDataTable("SELECT * FROM ROOM_COST"); 
			comboRoomType.DataSource = DataAccess.GetDataTable("SELECT ROOM_TYPE FROM ROOM_COST");
			comboRoomType.DisplayMember = "ROOM_TYPE";
		}
		public static bool IsStringValid(string value)
		{
			if (string.IsNullOrWhiteSpace(value) || string.IsNullOrEmpty(value))
				return false;

			return true;
		}
		private void btnBack_Click(object sender, EventArgs e)
		{
			this.Visible = false;
			new Home().Visible = true;
		}
		public void clear()
		{
			txtFName.Text = "";
			txtLName.Text = "";
			txtPhone.Text = "";
			txtAddress.Text = "";
			txtEmail.Text = "";
			txtFeatures.Text = "";
			comboRoomType.SelectedText = String.Empty;
			dtStart.Value = DateTime.Now;
			dtEnd.Value = DateTime.Now;
			radioBook.Checked = false;
			radioReserve.Checked = false;
		}
		private void btnRequestSent_Click(object sender, EventArgs e)
		{
			int checkNumber;
			string number = txtPhone.Text;
			string fname,lname,email,feature,address,roomType,requestType;
			if (txtFName.Text =="" || txtLName.Text == "" || txtPhone.Text == "" || txtAddress.Text == "" ||  (radioBook.Checked == false && radioReserve.Checked == false))
			{
				MessageBox.Show("Invalid Information");
				clear();
			}
			else
				{

				if (IsStringValid(txtFName.Text))
				{
					fname = txtFName.Text;
				}
				else
				{
					MessageBox.Show("Invalid First Name");
					clear();
					return;
				}
				if (IsStringValid(txtLName.Text))
				{
					lname = txtLName.Text;
				}
				else
				{
					MessageBox.Show("Invalid Last Name");
					clear();
					return;
				}

				if (IsStringValid(txtAddress.Text))
				{
					address = txtAddress.Text;
				}
				else
				{
					MessageBox.Show("Invalid Address");
					clear();
					return;
				}

				roomType = comboRoomType.Text;

				if (radioBook.Checked == false && radioReserve.Checked == false)
				{
					MessageBox.Show("Invalid Request Type");
					clear();
					return;
				}
				else if(radioBook.Checked == true)
				{
					requestType = radioBook.Text;
				}
				else
				{
					requestType = radioReserve.Text;
				}


				if (txtFeatures.Text == "")
					{
					feature = null;
					}
					else
					{
						if (IsStringValid(txtFeatures.Text))
						{
							feature = txtFeatures.Text;
						}
						else
						{
							MessageBox.Show("Invalid Features");
							clear();
							return;
						}
				}


					 if (txtEmail.Text == "")
					{
						email = null;
					}
					else if (txtEmail.Text.Contains('@'))
					{
						if (txtEmail.Text.Contains('.'))
						{
						if (txtEmail.Text.Length > 4)
						{
							email = txtEmail.Text;
						}
						else
						{
							MessageBox.Show("Invalid Mail Address");
							clear();
							return;
						}
						}
						else
						{
							MessageBox.Show("Invalid Mail Address");
							clear();
							return;
						}
					}
					else
					{
						MessageBox.Show("Invalid Mail Address");
						clear();
						return;
					}
				/*if (DataAccess.GetDataTable("SELECT * FROM CUSTOMER_REQUSET WHERE EMAIL='" + email + "'").Rows.Count > 0)
				{
					MessageBox.Show("Mail Address Exists");
					clear();
					return;
				}*/
				number = txtPhone.Text;

				 if (!int.TryParse(number, out checkNumber))
					{
						if (number[0] == '+')
						{
							number = number.Replace('+', '0');
							if (number.Contains('-'))
							{
								number = number.Replace("-", string.Empty);
							}
							if (!int.TryParse(number, out checkNumber))
							{
								MessageBox.Show("Invalid Number");
								clear();
								return;
							}
						}
						else
						{
							MessageBox.Show("Invalid Number");
							clear();
							return;
						}
					}
					else
					{
						number = txtPhone.Text;
					}
				/*if (DataAccess.GetDataTable("SELECT * FROM CUSTOMER_REQUSET WHERE PHONE='" + number + "'").Rows.Count > 0 || DataAccess.GetDataTable("SELECT * FROM CUSTOMER WHERE PHONE+'" + txtPhone.Text + "'").Rows.Count > 0)
				{
					MessageBox.Show("Phone Number Exists");
					clear();
					return;
				}*/

				if (dtStart.Value > dtEnd.Value)
				{
					MessageBox.Show("Start Date Can't Be Bigger Than End Date");
					clear();
					return;
				}
				try
				{
					DataAccess.ExecuteQuery("INSERT INTO CUSTOMER_REQUEST (REQUEST_ID,FIRST_NAME, LAST_NAME, PHONE, ADDRESS, EMAIL, ROOM_TYPE, REQUEST_TYPE, START_DATE, END_DATE, FEATURES) VALUES (" +request_id+",'"+ fname + "', '" + lname + "', '" + number + "', '" + address + "', '" + email + "', '" + roomType + "', '" + requestType + "', '" + dtStart.Value + "', '" + dtEnd.Value + "', '" + feature + "')");
					MessageBox.Show("Request Recorded");
					request_id++;
					clear();
				}catch(Exception e1)
				{
					MessageBox.Show(e1.Message);
					clear();
				}
			}
		}

		private void Request_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}
	}
}
