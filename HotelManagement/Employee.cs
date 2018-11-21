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
using MigraDoc.DocumentObjectModel;
using MigraDoc.Rendering;

using HM.Data;
namespace HotelManagement
{
	public partial class Employee : MetroForm
	{
		static int customer_id1;
		public Employee(string name)
		{
			InitializeComponent();
			labWelcome.Text = "Welcome " + name;
			
			cbType.DataSource = DataAccess.GetDataTable("SELECT ROOM_TYPE FROM ROOM_COST");
			cbType.DisplayMember = "ROOM_TYPE";
			if(int.TryParse(DataAccess.GetDataTable("SELECT MAX(CUSTOMER_ID) AS A FROM CUSTOMER").Rows[0]["A"].ToString(),out int a)){
				customer_id1 = Convert.ToInt32(DataAccess.GetDataTable("SELECT MAX(CUSTOMER_ID) AS A FROM CUSTOMER").Rows[0]["A"].ToString()) + 1;
			}
			else
			{
				customer_id1 = 1;
			}
		}
		public static string password()
		{
			Random rand = new Random();
			return rand.Next(1000, 9999) + "";
		}
		/*----------------------------------------------------BUTTONS-----------------------------------------------------------------------------*/
		private void btnLogOut_Click(object sender, EventArgs e)
		{
			this.Visible = false;
			new Login().Visible = true;
		}

		private void btnOrder_Click(object sender, EventArgs e)
		{
			DataSet ds = new DataSet();
			ds = DataAccess.GetDataSet("SELECT CUSTOMER.ROOM_ID,ORDERS.CUSTOMER_ID, ORDERS.ORDER_ID,ORDERS.ITEM_NAME,ORDERS.ITEM_QUANTITY FROM CUSTOMER, ORDERS WHERE ORDERS.CUSTOMER_ID = CUSTOMER.CUSTOMER_ID");
			dgOrder.AutoGenerateColumns = false;
			dgOrder.DataSource = ds.Tables[0];

			panelOrder.Visible = true;
			panelApprove.Visible = false;
			panelCheckOut.Visible = false;
			panelOrder.BringToFront();
			panelApprove.SendToBack();
			panelCheckOut.SendToBack();
		}

		private void btnApprove_Click(object sender, EventArgs e)
		{
			DataSet ds2 = new DataSet();
			ds2 = DataAccess.GetDataSet("SELECT * FROM CUSTOMER_REQUEST ");
			dgApprove.AutoGenerateColumns = false;
			dgApprove.DataSource = ds2.Tables[0];

			panelOrder.Visible = false;
			panelApprove.Visible = true;
			panelCheckOut.Visible = false;
			panelOrder.SendToBack();
			panelApprove.BringToFront();
			panelCheckOut.SendToBack();
		}

		private void btnCheckOut_Click(object sender, EventArgs e)
		{
			DataSet ds1 = new DataSet();
			ds1 = DataAccess.GetDataSet("SELECT * FROM CUSTOMER ");
			dgCheck.AutoGenerateColumns = false;
			dgCheck.DataSource = ds1.Tables[0];

			panelOrder.Visible = false;
			panelApprove.Visible = false;
			panelCheckOut.Visible = true;
			panelOrder.SendToBack();
			panelApprove.SendToBack();
			panelCheckOut.BringToFront();
		}
		/*----------------------------------------------------BUTTONS END-------------------------------------------------------------------------*/
		/*-------------------------------------------------------------Order------------------------------------------------------------*/
		private void dgOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow row = this.dgOrder.Rows[e.RowIndex];
				txtCID.Text = row.Cells["CUSTOMER_ID"].Value.ToString();
				txtOID.Text = row.Cells["ORDER_ID"].Value.ToString();
				txtRoomNo.Text = row.Cells["room_no"].Value.ToString();
			}
		}

		private void btnDone_Click(object sender, EventArgs e)
		{
			int price = 0;
			int totalCount = Convert.ToInt32(DataAccess.GetDataTable("SELECT COUNT(*) AS A FROM ORDERS WHERE CUSTOMER_ID='" + txtCID.Text + "' AND ORDER_ID=" + txtOID.Text + "").Rows[0]["A"].ToString());
			DataTable dt = DataAccess.GetDataTable("SELECT ITEM_NAME,ITEM_QUANTITY FROM ORDERS WHERE ORDER_ID=" + txtOID.Text + "AND CUSTOMER_ID=" + txtCID.Text + "");
			for(int i = 0; i < totalCount; i++)
			{
				string ina = dt.Rows[i]["ITEM_NAME"].ToString().Trim();
				int dataQuat = Convert.ToInt32(dt.Rows[i]["ITEM_QUANTITY"].ToString());
				int itemPrice =Convert.ToInt32(DataAccess.GetDataTable("SELECT ITEM_PRICE FROM ITEMS WHERE ITEM_NAME='" + ina + "'").Rows[0]["ITEM_PRICE"].ToString());
				int stock = Convert.ToInt32(DataAccess.GetDataTable("SELECT ITEM_STOCK FROM ITEMS WHERE ITEM_NAME='" + ina + "'").Rows[0]["ITEM_STOCK"]) - dataQuat;
				DataAccess.ExecuteQuery("UPDATE ITEMS SET ITEM_STOCK=" + stock + " WHERE ITEM_NAME='" + ina + "'");
			}
			int bill = Convert.ToInt32(DataAccess.GetDataTable("SELECT BILL FROM CUSTOMER WHERE CUSTOMER_ID='" + txtCID.Text + "'").Rows[0]["BILL"]) + price;
			DataAccess.ExecuteQuery("UPDATE CUSTOMER SET BILL=" + bill + " WHERE CUSTOMER_ID=" + txtCID.Text + "");
			DataAccess.ExecuteQuery("DELETE FROM ORDERS WHERE ORDER_ID=" + txtOID.Text + " AND CUSTOMER_ID=" + txtCID.Text + "");
			MessageBox.Show("Done");
			txtCID.Text = "";
			txtOID.Text = "";
			txtRoomNo.Text = "";
			DataTable dta = DataAccess.GetDataTable("SELECT CUSTOMER.ROOM_ID,ORDERS.CUSTOMER_ID, ORDERS.ORDER_ID,ORDERS.ITEM_NAME,ORDERS.ITEM_QUANTITY FROM CUSTOMER, ORDERS WHERE ORDERS.CUSTOMER_ID = CUSTOMER.CUSTOMER_ID");
			dgOrder.DataSource = dta;
		}
		/*-------------------------------------------------------------Order END------------------------------------------------------------*/
		/*-------------------------------------------------------------CheckOut------------------------------------------------------------*/
		private void dgCheck_CellContentClick(object sender, DataGridViewCellEventArgs e1)
		{
			if (e1.RowIndex >= 0)
			{
				DataGridViewRow row1 = this.dgCheck.Rows[e1.RowIndex];
				txtID.Text = row1.Cells["cid"].Value.ToString();
				txtFName.Text = row1.Cells["cFName"].Value.ToString();
				txtLName.Text = row1.Cells["cLName"].Value.ToString();
				txtPNo.Text = row1.Cells["phone"].Value.ToString();
			}
		}

		private void btnReciept_Click(object sender, EventArgs e)
		{
			if (txtID.Text == "")
			{
				MessageBox.Show("Select Entry");
				return;
			}
			DataTable co = DataAccess.GetDataTable("SELECT * FROM CUSTOMER WHERE CUSTOMER_ID="+ txtID.Text +"");
			Document document = new Document();
			Section section = document.AddSection();
			Paragraph paragraph = section.AddParagraph();

			paragraph.Format.Font.Color = MigraDoc.DocumentObjectModel.Color.FromCmyk(100, 30, 20, 50);
			paragraph.AddFormattedText("Reciept!", TextFormat.Underline);

			string fname = "First Name: "+Convert.ToString(co.Rows[0]["FIRST_NAME"]); section.AddParagraph(fname);
			section.AddParagraph();
			string lname = "Last Name: " + Convert.ToString(co.Rows[0]["LAST_NAME"]); section.AddParagraph(lname);
			section.AddParagraph();
			string pno = "Phone No: " + Convert.ToString(co.Rows[0]["PHONE"]); section.AddParagraph(pno);
			section.AddParagraph();
			string bill = "Bill: " + Convert.ToString(co.Rows[0]["BILL"]); section.AddParagraph(bill);
			section.AddParagraph();

			PdfDocumentRenderer pdfRenderer = new PdfDocumentRenderer(false);
			pdfRenderer.Document = document;
			pdfRenderer.RenderDocument();
			string filename = txtID.Text +"-" +txtFName.Text +".pdf";
			pdfRenderer.PdfDocument.Save(filename);
			System.Diagnostics.ProcessStartInfo processInfo = new System.Diagnostics.ProcessStartInfo();
			processInfo.FileName = filename;
			System.Diagnostics.Process.Start(filename);

		}

		private void btnCheck_Click(object sender, EventArgs e)
		{
			if (txtID.Text == "")
			{
				MessageBox.Show("Select Entry");
				return;
			}
			DataAccess.ExecuteQuery("DELETE FROM CUSTOMER WHERE CUSTOMER_ID=" + txtID.Text + "");
			DataSet ds1 = new DataSet();
			ds1 = DataAccess.GetDataSet("SELECT * FROM CUSTOMER ");
			dgCheck.DataSource = ds1.Tables[0];

		}
		/*-------------------------------------------------------------CheckOut END------------------------------------------------------------*/
		/*-------------------------------------------------------------Room Assing------------------------------------------------------------*/
		private void dgApprove_CellContentClick(object sender, DataGridViewCellEventArgs e1)
		{
			var senderGrid = (DataGridView)sender;

			if (senderGrid.Columns[e1.ColumnIndex] is DataGridViewButtonColumn &&e1.RowIndex >= 0)
			{
				DataGridViewRow row1 = this.dgApprove.Rows[e1.RowIndex];
				DataAccess.ExecuteQuery("DELETE FROM CUSTOMER_REQUEST WHERE PHONE='" + row1.Cells["PHONE1"].Value.ToString() + "'");
				DataSet ds2 = new DataSet();
				ds2 = DataAccess.GetDataSet("SELECT * FROM CUSTOMER_REQUEST ");
				dgApprove.DataSource = ds2.Tables[0];
			}
			else if (e1.RowIndex >= 0)
			{
				DataGridViewRow row1 = this.dgApprove.Rows[e1.RowIndex];
				txtRqID.Text = row1.Cells["REQUEST_ID1"].Value.ToString();
				txtF.Text = row1.Cells["FIRST_NAME"].Value.ToString();
				txtL.Text = row1.Cells["LAST_NAME"].Value.ToString();
				txtP.Text = row1.Cells["PHONE1"].Value.ToString();
				dtStart.Value =Convert.ToDateTime(row1.Cells["START_DATE"].Value.ToString());
				dtEnd.Value = Convert.ToDateTime(row1.Cells["END_DATE"].Value.ToString());
				cbType.SelectedIndex = cbType.FindString(row1.Cells["ROOM_TYPE"].Value.ToString());
				cbRNo.DataSource = DataAccess.GetDataTable("SELECT ROOM_ID FROM ROOMS WHERE ROOM_TYPE='"+ row1.Cells["ROOM_TYPE"].Value.ToString() +"'");
				cbRNo.DisplayMember = "ROOM_ID";
				txtFea.Text = row1.Cells["FEATURES"].Value.ToString();
			}
		}

		private void btnAssign_Click(object sender, EventArgs e)
		{
			DataTable asd = DataAccess.GetDataTable("SELECT * FROM CUSTOMER_REQUEST WHERE REQUEST_ID='" + txtRqID.Text + "'");
			string address = asd.Rows[0]["ADDRESS"].ToString();
			string email = asd.Rows[0]["EMAIL"].ToString();
			string username = txtF.Text.ToLower();
			string pass = password();
			int bill = Convert.ToInt32(DataAccess.GetDataTable("SELECT COST FROM ROOM_COST WHERE ROOM_TYPE='" + cbType.Text + "'").Rows[0]["COST"].ToString());
			DataAccess.ExecuteQuery("INSERT INTO CUSTOMER (CUSTOMER_ID, FIRST_NAME, LAST_NAME, PHONE, ADDRESS, EMAIL, ROOM_ID, BILL, USER_NAME, PASSWORD) VALUES (" +customer_id1+", '"+ txtF.Text + "', '" + txtL.Text + "', '" + txtP.Text + "', '" + address + "', '" + email + "', '" + cbRNo.Text + "', '" + bill + "', '" + username + "', '" + pass + "')");

			DataAccess.ExecuteQuery("DELETE FROM CUSTOMER_REQUEST WHERE REQUEST_ID='" + txtRqID.Text + "'");
			DataSet ds2 = new DataSet();
			ds2 = DataAccess.GetDataSet("SELECT * FROM CUSTOMER_REQUEST ");
			dgApprove.DataSource = ds2.Tables[0];
			customer_id1++;

			Document document = new Document();
			Section section = document.AddSection();
			Paragraph paragraph = section.AddParagraph();

			paragraph.Format.Font.Color = MigraDoc.DocumentObjectModel.Color.FromCmyk(100, 30, 20, 50);
			paragraph.AddFormattedText("Room Card!", TextFormat.Underline);

			string fname = "Room No: " + cbRNo.Text; section.AddParagraph(fname);
			section.AddParagraph();
			string lname = "User Name: " + username; section.AddParagraph(lname);
			section.AddParagraph();
			string pno = "Password: " + pass; section.AddParagraph(pno);
			section.AddParagraph();

			PdfDocumentRenderer pdfRenderer = new PdfDocumentRenderer(false);
			pdfRenderer.Document = document;
			pdfRenderer.RenderDocument();
			string filename = "Card.pdf";
			pdfRenderer.PdfDocument.Save(filename);
			System.Diagnostics.ProcessStartInfo processInfo = new System.Diagnostics.ProcessStartInfo();
			processInfo.FileName = filename;
			System.Diagnostics.Process.Start(filename);
			txtRqID.Text = "";
			txtF.Text = "";
			txtL.Text = "";
			txtP.Text = "";
			dtStart.Value = DateTime.Today;
			dtEnd.Value = DateTime.Today;
			txtFea.Text = "";
			cbType.Text = "";
			cbRNo.Text = "";
		}

		private void cbType_SelectedIndexChanged(object sender, EventArgs e)
		{
			cbRNo.DataSource = DataAccess.GetDataTable("SELECT ROOM_ID FROM ROOMS WHERE ROOM_TYPE='" + cbType.Text + "'");
			cbRNo.DisplayMember = "ROOM_ID";
		}
		/*-------------------------------------------------------------Room Assing END------------------------------------------------------------*/
		/*---------------------------------------------------Extras---------------------------------------------------------------------*/
		private void Employee_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}

		private void txtFName_Click(object sender, EventArgs e)
		{

		}
		/*---------------------------------------------------Extras END---------------------------------------------------------------------*/
	}
}
