namespace HotelManagement
{
	partial class User
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnLogOut = new System.Windows.Forms.Button();
			this.btnOrder = new System.Windows.Forms.Button();
			this.txtOrder = new MetroFramework.Controls.MetroTextBox();
			this.dataItems = new MetroFramework.Controls.MetroGrid();
			this.item_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.item_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnAdd = new System.Windows.Forms.Button();
			this.txtQuantity = new MetroFramework.Controls.MetroTextBox();
			this.txtOrderItem = new MetroFramework.Controls.MetroTextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.labWelcome = new System.Windows.Forms.Label();
			this.btnClear = new System.Windows.Forms.Button();
			this.flowLayoutPanel1.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataItems)).BeginInit();
			this.SuspendLayout();
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.panel1);
			this.flowLayoutPanel1.Location = new System.Drawing.Point(24, 30);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(853, 472);
			this.flowLayoutPanel1.TabIndex = 0;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnClear);
			this.panel1.Controls.Add(this.btnLogOut);
			this.panel1.Controls.Add(this.btnOrder);
			this.panel1.Controls.Add(this.txtOrder);
			this.panel1.Controls.Add(this.dataItems);
			this.panel1.Controls.Add(this.btnAdd);
			this.panel1.Controls.Add(this.txtQuantity);
			this.panel1.Controls.Add(this.txtOrderItem);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.labWelcome);
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(850, 469);
			this.panel1.TabIndex = 0;
			// 
			// btnLogOut
			// 
			this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLogOut.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLogOut.ForeColor = System.Drawing.Color.CornflowerBlue;
			this.btnLogOut.Location = new System.Drawing.Point(648, 10);
			this.btnLogOut.Name = "btnLogOut";
			this.btnLogOut.Size = new System.Drawing.Size(199, 39);
			this.btnLogOut.TabIndex = 63;
			this.btnLogOut.Text = "Log Out ";
			this.btnLogOut.UseVisualStyleBackColor = true;
			this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
			// 
			// btnOrder
			// 
			this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOrder.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOrder.ForeColor = System.Drawing.Color.CornflowerBlue;
			this.btnOrder.Location = new System.Drawing.Point(744, 416);
			this.btnOrder.Name = "btnOrder";
			this.btnOrder.Size = new System.Drawing.Size(88, 39);
			this.btnOrder.TabIndex = 59;
			this.btnOrder.Text = "Order";
			this.btnOrder.UseVisualStyleBackColor = true;
			this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
			// 
			// txtOrder
			// 
			// 
			// 
			// 
			this.txtOrder.CustomButton.Image = null;
			this.txtOrder.CustomButton.Location = new System.Drawing.Point(-60, 1);
			this.txtOrder.CustomButton.Name = "";
			this.txtOrder.CustomButton.Size = new System.Drawing.Size(245, 245);
			this.txtOrder.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtOrder.CustomButton.TabIndex = 1;
			this.txtOrder.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtOrder.CustomButton.UseSelectable = true;
			this.txtOrder.CustomButton.Visible = false;
			this.txtOrder.Enabled = false;
			this.txtOrder.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.txtOrder.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
			this.txtOrder.ForeColor = System.Drawing.Color.CornflowerBlue;
			this.txtOrder.Lines = new string[0];
			this.txtOrder.Location = new System.Drawing.Point(646, 157);
			this.txtOrder.MaxLength = 32767;
			this.txtOrder.Multiline = true;
			this.txtOrder.Name = "txtOrder";
			this.txtOrder.PasswordChar = '\0';
			this.txtOrder.ReadOnly = true;
			this.txtOrder.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtOrder.SelectedText = "";
			this.txtOrder.SelectionLength = 0;
			this.txtOrder.SelectionStart = 0;
			this.txtOrder.ShortcutsEnabled = true;
			this.txtOrder.Size = new System.Drawing.Size(186, 247);
			this.txtOrder.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtOrder.TabIndex = 58;
			this.txtOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtOrder.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.txtOrder.UseSelectable = true;
			this.txtOrder.WaterMarkColor = System.Drawing.Color.CornflowerBlue;
			this.txtOrder.WaterMarkFont = new System.Drawing.Font("Gill Sans Ultra Bold", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			// 
			// dataItems
			// 
			this.dataItems.AllowUserToAddRows = false;
			this.dataItems.AllowUserToDeleteRows = false;
			this.dataItems.AllowUserToResizeRows = false;
			this.dataItems.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			this.dataItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dataItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dataItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.item_name,
            this.item_price});
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataItems.DefaultCellStyle = dataGridViewCellStyle5;
			this.dataItems.EnableHeadersVisualStyles = false;
			this.dataItems.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.dataItems.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			this.dataItems.Location = new System.Drawing.Point(12, 157);
			this.dataItems.Name = "dataItems";
			this.dataItems.ReadOnly = true;
			this.dataItems.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataItems.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
			this.dataItems.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dataItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataItems.Size = new System.Drawing.Size(265, 298);
			this.dataItems.TabIndex = 57;
			this.dataItems.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.dataItems.UseCustomForeColor = true;
			this.dataItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataItems_CellContentClick);
			// 
			// item_name
			// 
			this.item_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.item_name.DataPropertyName = "ITEM_NAME";
			this.item_name.HeaderText = "Item Name";
			this.item_name.Name = "item_name";
			this.item_name.ReadOnly = true;
			// 
			// item_price
			// 
			this.item_price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.item_price.DataPropertyName = "ITEM_PRICE";
			this.item_price.HeaderText = "Item Price";
			this.item_price.Name = "item_price";
			this.item_price.ReadOnly = true;
			// 
			// btnAdd
			// 
			this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAdd.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdd.ForeColor = System.Drawing.Color.CornflowerBlue;
			this.btnAdd.Location = new System.Drawing.Point(502, 306);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(86, 39);
			this.btnAdd.TabIndex = 55;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// txtQuantity
			// 
			// 
			// 
			// 
			this.txtQuantity.CustomButton.Image = null;
			this.txtQuantity.CustomButton.Location = new System.Drawing.Point(164, 1);
			this.txtQuantity.CustomButton.Name = "";
			this.txtQuantity.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.txtQuantity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtQuantity.CustomButton.TabIndex = 1;
			this.txtQuantity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtQuantity.CustomButton.UseSelectable = true;
			this.txtQuantity.CustomButton.Visible = false;
			this.txtQuantity.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.txtQuantity.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
			this.txtQuantity.ForeColor = System.Drawing.Color.CornflowerBlue;
			this.txtQuantity.Lines = new string[0];
			this.txtQuantity.Location = new System.Drawing.Point(402, 250);
			this.txtQuantity.MaxLength = 32767;
			this.txtQuantity.Name = "txtQuantity";
			this.txtQuantity.PasswordChar = '\0';
			this.txtQuantity.PromptText = "Enter Quantity";
			this.txtQuantity.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtQuantity.SelectedText = "";
			this.txtQuantity.SelectionLength = 0;
			this.txtQuantity.SelectionStart = 0;
			this.txtQuantity.ShortcutsEnabled = true;
			this.txtQuantity.Size = new System.Drawing.Size(186, 23);
			this.txtQuantity.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtQuantity.TabIndex = 41;
			this.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtQuantity.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.txtQuantity.UseSelectable = true;
			this.txtQuantity.WaterMark = "Enter Quantity";
			this.txtQuantity.WaterMarkColor = System.Drawing.Color.CornflowerBlue;
			this.txtQuantity.WaterMarkFont = new System.Drawing.Font("Gill Sans Ultra Bold", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			// 
			// txtOrderItem
			// 
			// 
			// 
			// 
			this.txtOrderItem.CustomButton.Image = null;
			this.txtOrderItem.CustomButton.Location = new System.Drawing.Point(164, 1);
			this.txtOrderItem.CustomButton.Name = "";
			this.txtOrderItem.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.txtOrderItem.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtOrderItem.CustomButton.TabIndex = 1;
			this.txtOrderItem.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtOrderItem.CustomButton.UseSelectable = true;
			this.txtOrderItem.CustomButton.Visible = false;
			this.txtOrderItem.Enabled = false;
			this.txtOrderItem.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.txtOrderItem.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
			this.txtOrderItem.ForeColor = System.Drawing.Color.CornflowerBlue;
			this.txtOrderItem.Lines = new string[0];
			this.txtOrderItem.Location = new System.Drawing.Point(402, 193);
			this.txtOrderItem.MaxLength = 32767;
			this.txtOrderItem.Name = "txtOrderItem";
			this.txtOrderItem.PasswordChar = '\0';
			this.txtOrderItem.ReadOnly = true;
			this.txtOrderItem.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtOrderItem.SelectedText = "";
			this.txtOrderItem.SelectionLength = 0;
			this.txtOrderItem.SelectionStart = 0;
			this.txtOrderItem.ShortcutsEnabled = true;
			this.txtOrderItem.Size = new System.Drawing.Size(186, 23);
			this.txtOrderItem.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtOrderItem.TabIndex = 40;
			this.txtOrderItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtOrderItem.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.txtOrderItem.UseSelectable = true;
			this.txtOrderItem.WaterMarkColor = System.Drawing.Color.CornflowerBlue;
			this.txtOrderItem.WaterMarkFont = new System.Drawing.Font("Gill Sans Ultra Bold", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.CornflowerBlue;
			this.label4.Location = new System.Drawing.Point(299, 250);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(97, 23);
			this.label4.TabIndex = 32;
			this.label4.Text = "Quantity";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.CornflowerBlue;
			this.label3.Location = new System.Drawing.Point(299, 193);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(57, 23);
			this.label3.TabIndex = 31;
			this.label3.Text = "Item";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
			this.label2.Location = new System.Drawing.Point(5, 109);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(307, 39);
			this.label2.TabIndex = 29;
			this.label2.Text = "Place Your Order";
			// 
			// labWelcome
			// 
			this.labWelcome.AutoSize = true;
			this.labWelcome.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labWelcome.ForeColor = System.Drawing.Color.CornflowerBlue;
			this.labWelcome.Location = new System.Drawing.Point(3, 10);
			this.labWelcome.Name = "labWelcome";
			this.labWelcome.Size = new System.Drawing.Size(218, 49);
			this.labWelcome.TabIndex = 28;
			this.labWelcome.Text = "Welcome";
			// 
			// btnClear
			// 
			this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClear.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClear.ForeColor = System.Drawing.Color.CornflowerBlue;
			this.btnClear.Location = new System.Drawing.Point(646, 416);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(88, 39);
			this.btnClear.TabIndex = 64;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// User
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(900, 525);
			this.Controls.Add(this.flowLayoutPanel1);
			this.ForeColor = System.Drawing.Color.CornflowerBlue;
			this.Name = "User";
			this.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.User_FormClosing);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataItems)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label labWelcome;
		private MetroFramework.Controls.MetroTextBox txtQuantity;
		private MetroFramework.Controls.MetroTextBox txtOrderItem;
		private System.Windows.Forms.Button btnOrder;
		private MetroFramework.Controls.MetroTextBox txtOrder;
		private MetroFramework.Controls.MetroGrid dataItems;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnLogOut;
		private System.Windows.Forms.DataGridViewTextBoxColumn item_name;
		private System.Windows.Forms.DataGridViewTextBoxColumn item_price;
		private System.Windows.Forms.Button btnClear;
	}
}