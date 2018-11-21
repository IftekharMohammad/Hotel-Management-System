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
namespace HotelManagement
{
	public partial class Home : MetroForm
	{
		public Home()
		{
			InitializeComponent();
		}

		private void btnRequest_Click(object sender, EventArgs e)
		{
			this.Visible = false;
			new Request().Visible=true;
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			this.Visible = false;
			new Login().Visible = true;
		}

		private void Home_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}
	}
}
