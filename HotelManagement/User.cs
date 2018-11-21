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
	public partial class User : MetroForm
	{
		int id;
		private static int OrderID;
		public User(string name,int id)
		{
			InitializeComponent();

			labWelcome.Text = "Welcome " + name;

			DataTable items = DataAccess.GetDataTable("SELECT ITEM_NAME, ITEM_PRICE FROM ITEMS");
			dataItems.AutoGenerateColumns = false;
			dataItems.Columns["item_name"].DefaultCellStyle.ForeColor = Color.CornflowerBlue;
			dataItems.Columns["item_price"].DefaultCellStyle.ForeColor = Color.CornflowerBlue;
			dataItems.DataSource = items;
			this.id = id;

			if(DataAccess.GetDataTable("SELECT MAX(ORDER_ID) AS C FROM ORDERS").Rows[0]["C"].ToString()=="" || Convert.ToInt32(DataAccess.GetDataTable("SELECT MAX(ORDER_ID) AS C FROM ORDERS").Rows[0]["C"].ToString())<0)
			{
				OrderID = 1;
			}
			else
			{
				OrderID  = Convert.ToInt32(DataAccess.GetDataTable("SELECT MAX(ORDER_ID) AS C FROM ORDERS").Rows[0]["C"].ToString()) + 1;
			}
		}

		private void btnLogOut_Click(object sender, EventArgs e)
		{
			this.Visible = false;
			new Login().Visible = true;
		}

		private void dataItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow row = this.dataItems.Rows[e.RowIndex];
				txtOrderItem.Text = row.Cells["ITEM_NAME"].Value.ToString();
			}
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			int a;
			if (txtOrderItem.Text == "")
			{
				MessageBox.Show("Select Item From Item Menu");
				txtOrderItem.Text = "";
				txtQuantity.Text = "";
			}else if (txtQuantity.Text == "")
			{
				MessageBox.Show("Enter Quantity");
				txtOrderItem.Text = "";
				txtQuantity.Text = "";
			}
			else if (!int.TryParse(txtQuantity.Text, out a))
			{
				MessageBox.Show("Entered Quantity Is Not A Number");
				txtOrderItem.Text = "";
				txtQuantity.Text = "";
			}
			else
			{
				string order = txtOrderItem.Text + " X " + txtQuantity.Text + ",\n";
				txtOrder.AppendText(order);
				txtOrderItem.Text = "";
				txtQuantity.Text = "";
			}
		}

		private void btnOrder_Click(object sender, EventArgs e)
		{
			if (txtOrder.Text!="") {
				string[] orderItem = txtOrder.Text.Split(',');
				for (int i = 0; i < orderItem.Length - 1; i++)
				{
					string[] item = orderItem[i].Split('X');
					DataAccess.ExecuteQuery("INSERT INTO ORDERS (ORDER_ID, ITEM_NAME, ITEM_QUANTITY, CUSTOMER_ID) VALUES (" + OrderID + ", '" + item[0] + "', " + item[1] + ", " + id + ")");
				}
				OrderID++;
				MessageBox.Show("Order Added");
				txtOrderItem.Text = "";
				txtQuantity.Text = "";
				txtOrder.Text = "";
			}
			else
			{
				MessageBox.Show("Add Order Items");
				txtOrderItem.Text = "";
				txtQuantity.Text = "";
				txtOrder.Text = "";
			}
		}
		private void User_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			txtOrder.Text = "";
		}
	}
}
