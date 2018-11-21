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
using MigraDoc.DocumentObjectModel;
using MigraDoc.Rendering;
namespace HotelManagement
{
	public partial class Admin : MetroForm
	{
		int employee_count,itemId;
		public Admin(string name)
		{
			InitializeComponent();

			labWelcome.Text = "Welcome " + name;
			if (int.TryParse(DataAccess.GetDataTable("SELECT MAX(EMPLOYEE_ID) AS A FROM EMPLOYEE").Rows[0]["A"].ToString(), out int a))
			{
				employee_count = Convert.ToInt32(DataAccess.GetDataTable("SELECT MAX(EMPLOYEE_ID) AS A FROM EMPLOYEE").Rows[0]["A"].ToString()) + 1;
			}
			else
			{
				employee_count = 1;
			}

			if (int.TryParse(DataAccess.GetDataTable("SELECT MAX(ITEM_ID) AS A FROM ITEMS").Rows[0]["A"].ToString(), out int a1))
			{
				itemId = Convert.ToInt32(DataAccess.GetDataTable("SELECT MAX(ITEM_ID) AS A FROM ITEMS").Rows[0]["A"].ToString()) + 1;
			}
			else
			{
				itemId = 1;
			}

			dgItem.AutoGenerateColumns = false;
			dgItem.DataSource = DataAccess.GetDataTable("SELECT * FROM ITEMS");

			dgDept.AutoGenerateColumns = false;
			dgDept.DataSource = DataAccess.GetDataTable("SELECT * FROM DEPARTMENT");

			cbDeptID.DataSource = DataAccess.GetDataTable("SELECT DEPT_ID FROM DEPARTMENT");
			cbDeptID.DisplayMember = "DEPT_ID";

		}

		public void clear()
		{
			txtFNameE.Text = "";
			txtLNameE.Text = "";
			dtDOB.Value = DateTime.Today;
			txtAddressE.Text = "";
			txtPhoneE.Text = "";
			txtEmailE.Text = "";
			rbNormal.Checked = false;
			rbAdmin.Checked = false;
			txtSalaryE.Text = "";
		}

		public static bool IsStringValid(string value)
		{
			if (string.IsNullOrWhiteSpace(value) || string.IsNullOrEmpty(value))
				return false;

			return true;
		}

		private void btnApp_Click(object sender, EventArgs e)
		{
			panelInventory.Visible = false;
			panelRoom.Visible = false;
			panelAppoint.Visible = true;
			panelAppoint.BringToFront();
			panelInventory.SendToBack();
			panelRoom.SendToBack();
		}

		private void btnInventory_Click(object sender, EventArgs e)
		{
			panelAppoint.Visible = false;
			panelRoom.Visible = false;
			panelInventory.Visible = true;
			panelInventory.BringToFront();
			panelAppoint.SendToBack();
			panelRoom.SendToBack();
		}

		private void btnRooms_Click(object sender, EventArgs e)
		{
			panelAppoint.Visible = false;
			panelInventory.Visible = false;
			panelRoom.Visible = true;
			panelRoom.BringToFront();
			panelInventory.SendToBack();
			panelAppoint.SendToBack();
		}

		private void btnLogOut_Click(object sender, EventArgs e)
		{
			this.Visible = false;
			new Login().Visible = true;
		}

		private void Admin_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}

		private void dgItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void btnProviderMail_Click(object sender, EventArgs e)
		{

		}

		private void Admin_FormClosing_1(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}

		private void dgItem_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow row1 = this.dgItem.Rows[e.RowIndex];
				txtID.Text = row1.Cells["ITEM_ID"].Value.ToString();
				txtIName.Text = row1.Cells["ITEM_NAME"].Value.ToString();
				txtProvider.Text = row1.Cells["ITEM_STOCK"].Value.ToString();
				txtProviderEmail.Text = row1.Cells["ITEM_PRICE"].Value.ToString();
			}
		}

		private void btnProviderMail_Click_1(object sender, EventArgs e)
		{
			if (txtID.Text == "")
			{
				if (DataAccess.GetDataTable("SELECT * FROM ITEMS WHERE	 ITEM_NAME='"+ txtIName.Text+"'").Rows.Count>0)
				{
					MessageBox.Show("Item Already Exists. Try Updating");
					txtID.Text = "";
					txtIName.Text = "";
					txtProvider.Text = "";
					txtProviderEmail.Text = "";
				}
				else
				{
					DataAccess.ExecuteQuery("INSERT INTO ITEMS (ITEM_ID,ITEM_NAME,ITEM_STOCK,ITEM_PRICE) VALUES (" + itemId + ", '" + txtIName.Text.Trim() + "', " + txtProvider.Text + ", " + txtProviderEmail.Text + ")");
					dgItem.DataSource = DataAccess.GetDataTable("SELECT * FROM ITEMS");
					txtID.Text = "";
					txtIName.Text = "";
					txtProvider.Text = "";
					txtProviderEmail.Text = "";
				}
			}
			else
			{
				DataAccess.ExecuteQuery("UPDATE ITEMS SET ITEM_NAME='" + txtIName.Text + "',ITEM_STOCK='" + txtProvider.Text + "',ITEM_PRICE='" + txtProviderEmail.Text + "' WHERE ITEM_ID='" + txtID.Text + "'");
				dgItem.DataSource = DataAccess.GetDataTable("SELECT * FROM ITEMS");
				txtID.Text = "";
				txtIName.Text = "";
				txtProvider.Text = "";
				txtProviderEmail.Text = "";
			}
		}

		private void btnIDelete_Click(object sender, EventArgs e)
		{
			if (txtID.Text!= "")
			{
				DataAccess.ExecuteQuery("DELETE FROM ITEMS WHERE ITEM_ID='" + txtID.Text + "'");
				dgItem.DataSource = DataAccess.GetDataTable("SELECT * FROM ITEMS");
				txtID.Text = "";
				txtIName.Text = "";
				txtProvider.Text = "";
				txtProviderEmail.Text = "";
			}
			else
			{
				MessageBox.Show("Select item to delete");
				txtID.Text = "";
				txtIName.Text = "";
				txtProvider.Text = "";
				txtProviderEmail.Text = "";
			}
		}

		private void btnAppoint_Click(object sender, EventArgs e)
		{
			int checkNumber;
			string number = txtPhoneE.Text;
			string fname, lname, email, address, positionType,dept_id, salary;
			if (txtFNameE.Text == "" || txtLNameE.Text == "" || txtPhoneE.Text == "" || txtAddressE.Text == "" || (rbAdmin.Checked == false && rbNormal.Checked == false) || txtEmailE.Text=="" || txtSalaryE.Text=="" || cbDeptID.Text=="")
			{
				MessageBox.Show("Invalid Information");
				clear();
			}
			else
			{

				if (IsStringValid(txtFNameE.Text))
				{
					fname = txtFNameE.Text;
				}
				else
				{
					MessageBox.Show("Invalid First Name");
					clear();
					return;
				}
				if (IsStringValid(txtLNameE.Text))
				{
					lname = txtLNameE.Text;
				}
				else
				{
					MessageBox.Show("Invalid Last Name");
					clear();
					return;
				}

				if (IsStringValid(txtAddressE.Text))
				{
					address = txtAddressE.Text;
				}
				else
				{
					MessageBox.Show("Invalid Address");
					clear();
					return;
				}

				if (rbNormal.Checked == false && rbAdmin.Checked == false)
				{
					MessageBox.Show("Invalid Employee Type");
					clear();
					return;
				}
				else if (rbAdmin.Checked == true)
				{
					positionType = rbAdmin.Text;
				}
				else
				{
					positionType = rbNormal.Text;
				}



				if (txtEmailE.Text == "")
				{
					MessageBox.Show("Invalid Mail Address");
					clear();
					return;
				}
				else if (txtEmailE.Text.Contains('@'))
				{
					if (txtEmailE.Text.Contains('.'))
					{
						if (txtEmailE.Text.Length > 4)
						{
							email = txtEmailE.Text;
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
				number = txtPhoneE.Text;

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
					number = txtPhoneE.Text;
				}

				if (!int.TryParse(txtSalaryE.Text, out checkNumber))
				{
					MessageBox.Show("Invalid Salary");
					clear();
					return;
				}
				else
				{
					salary = txtSalaryE.Text;
				}

				if (dtDOB.Value >= DateTime.Today || (DateTime.Today.Year- dtDOB.Value.Year) <18)
				{
					MessageBox.Show("Too Small To Work");
					clear();
					return;
				}
				dept_id = cbDeptID.Text;
				string userName = txtFNameE.Text.ToLower();
				string password = Employee.password();
				try
				{
					DataAccess.ExecuteQuery("INSERT INTO EMPLOYEE (EMPLOYEE_ID,FIRST_NAME, LAST_NAME, DATE_OF_BIRTH, PHONE, ADDRESS, EMAIL, DEPT_ID, EMPLOYEE_TYPE, SALARY, PASSWORD, USERNAME) VALUES (" + employee_count + ",'" + fname + "', '" + lname + "', '" + dtDOB.Value + "', '" + number + "', '" + address + "', '" + email + "', '" + dept_id + "', '" + positionType + "', '" + salary + "', '" + password + "', '" + userName + "')");
					MessageBox.Show("Request Recorded");
					employee_count++;
					clear();
				}
				catch (Exception e1)
				{
					MessageBox.Show(e1.Message);
					clear();
				}

				Document document = new Document();
				Section section = document.AddSection();
				Paragraph paragraph = section.AddParagraph();

				paragraph.Format.Font.Color = MigraDoc.DocumentObjectModel.Color.FromCmyk(100, 30, 20, 50);
				paragraph.AddFormattedText("Appointment Letter", TextFormat.Underline);

				 section.AddParagraph("You Are Hereby Appointed As an Employee Of This Hotel");
				section.AddParagraph();
				string uname = "User Name: " + userName; section.AddParagraph(uname);
				section.AddParagraph();
				string pno = "Password: " + password; section.AddParagraph(pno);
				section.AddParagraph();

				PdfDocumentRenderer pdfRenderer = new PdfDocumentRenderer(false);
				pdfRenderer.Document = document;
				pdfRenderer.RenderDocument();
				string filename = "Card.pdf";
				pdfRenderer.PdfDocument.Save(filename);
				System.Diagnostics.ProcessStartInfo processInfo = new System.Diagnostics.ProcessStartInfo();
				processInfo.FileName = filename;
				System.Diagnostics.Process.Start(filename);
			}
		}
	}
}
