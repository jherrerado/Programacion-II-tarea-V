namespace Bank
{
	partial class Bank
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			lbl_cuenta = new Label();
			lbl_nom_cuenta = new Label();
			lbl_tipo = new Label();
			lbl_monto = new Label();
			txt_cuenta = new TextBox();
			txt_nom_cuenta = new TextBox();
			txt_monto = new TextBox();
			cmb_tipo = new ComboBox();
			btn_add = new Button();
			dvg_table = new DataGridView();
			Column1 = new DataGridViewTextBoxColumn();
			Column2 = new DataGridViewTextBoxColumn();
			Column3 = new DataGridViewTextBoxColumn();
			Column4 = new DataGridViewTextBoxColumn();
			lbl_tot_debito = new Label();
			lbl_tot_credito = new Label();
			txt_tot_debito = new TextBox();
			txt_tot_credito = new TextBox();
			((System.ComponentModel.ISupportInitialize)dvg_table).BeginInit();
			SuspendLayout();
			// 
			// lbl_cuenta
			// 
			lbl_cuenta.AutoSize = true;
			lbl_cuenta.Location = new Point(63, 55);
			lbl_cuenta.Name = "lbl_cuenta";
			lbl_cuenta.Size = new Size(45, 15);
			lbl_cuenta.TabIndex = 0;
			lbl_cuenta.Text = "Cuenta";
			// 
			// lbl_nom_cuenta
			// 
			lbl_nom_cuenta.AutoSize = true;
			lbl_nom_cuenta.Location = new Point(184, 55);
			lbl_nom_cuenta.Name = "lbl_nom_cuenta";
			lbl_nom_cuenta.Size = new Size(92, 15);
			lbl_nom_cuenta.TabIndex = 1;
			lbl_nom_cuenta.Text = "Nombre Cuenta\r\n";
			// 
			// lbl_tipo
			// 
			lbl_tipo.AutoSize = true;
			lbl_tipo.Location = new Point(568, 55);
			lbl_tipo.Name = "lbl_tipo";
			lbl_tipo.Size = new Size(30, 15);
			lbl_tipo.TabIndex = 2;
			lbl_tipo.Text = "Tipo\r\n";
			// 
			// lbl_monto
			// 
			lbl_monto.AutoSize = true;
			lbl_monto.Location = new Point(710, 55);
			lbl_monto.Name = "lbl_monto";
			lbl_monto.Size = new Size(43, 15);
			lbl_monto.TabIndex = 3;
			lbl_monto.Text = "Monto";
			// 
			// txt_cuenta
			// 
			txt_cuenta.Location = new Point(63, 73);
			txt_cuenta.Name = "txt_cuenta";
			txt_cuenta.Size = new Size(100, 23);
			txt_cuenta.TabIndex = 4;
			// 
			// txt_nom_cuenta
			// 
			txt_nom_cuenta.Location = new Point(184, 73);
			txt_nom_cuenta.Name = "txt_nom_cuenta";
			txt_nom_cuenta.Size = new Size(366, 23);
			txt_nom_cuenta.TabIndex = 5;
			// 
			// txt_monto
			// 
			txt_monto.Location = new Point(710, 73);
			txt_monto.Name = "txt_monto";
			txt_monto.Size = new Size(94, 23);
			txt_monto.TabIndex = 6;
			// 
			// cmb_tipo
			// 
			cmb_tipo.Cursor = Cursors.Hand;
			cmb_tipo.DropDownStyle = ComboBoxStyle.DropDownList;
			cmb_tipo.FormattingEnabled = true;
			cmb_tipo.Items.AddRange(new object[] { "--Selecciona--", "Debito", "Credito" });
			cmb_tipo.Location = new Point(568, 73);
			cmb_tipo.Name = "cmb_tipo";
			cmb_tipo.Size = new Size(121, 23);
			cmb_tipo.TabIndex = 7;
			// 
			// btn_add
			// 
			btn_add.BackColor = SystemColors.ControlLightLight;
			btn_add.Cursor = Cursors.Hand;
			btn_add.Location = new Point(822, 67);
			btn_add.Name = "btn_add";
			btn_add.Size = new Size(92, 29);
			btn_add.TabIndex = 8;
			btn_add.Text = "Agregar";
			btn_add.UseVisualStyleBackColor = false;
			btn_add.Click += btn_add_Click;
			// 
			// dvg_table
			// 
			dvg_table.AllowUserToAddRows = false;
			dvg_table.AllowUserToDeleteRows = false;
			dvg_table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dvg_table.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			dvg_table.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
			dvg_table.Location = new Point(63, 113);
			dvg_table.Name = "dvg_table";
			dvg_table.ReadOnly = true;
			dvg_table.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
			dvg_table.Size = new Size(851, 274);
			dvg_table.TabIndex = 9;
			// 
			// Column1
			// 
			Column1.DataPropertyName = "cue_ban";
			Column1.HeaderText = "Cuenta";
			Column1.Name = "Column1";
			Column1.ReadOnly = true;
			// 
			// Column2
			// 
			Column2.DataPropertyName = "nom_cue_ban";
			Column2.HeaderText = "Nombre de Cuenta";
			Column2.Name = "Column2";
			Column2.ReadOnly = true;
			// 
			// Column3
			// 
			Column3.DataPropertyName = "deb_ban";
			Column3.HeaderText = "Debito";
			Column3.Name = "Column3";
			Column3.ReadOnly = true;
			// 
			// Column4
			// 
			Column4.DataPropertyName = "cre_ban";
			Column4.HeaderText = "Credito";
			Column4.Name = "Column4";
			Column4.ReadOnly = true;
			// 
			// lbl_tot_debito
			// 
			lbl_tot_debito.AutoSize = true;
			lbl_tot_debito.Location = new Point(590, 412);
			lbl_tot_debito.Name = "lbl_tot_debito";
			lbl_tot_debito.Size = new Size(70, 15);
			lbl_tot_debito.TabIndex = 10;
			lbl_tot_debito.Text = "Total Debito\r\n";
			// 
			// lbl_tot_credito
			// 
			lbl_tot_credito.AutoSize = true;
			lbl_tot_credito.Location = new Point(750, 412);
			lbl_tot_credito.Name = "lbl_tot_credito";
			lbl_tot_credito.Size = new Size(74, 15);
			lbl_tot_credito.TabIndex = 11;
			lbl_tot_credito.Text = "Total Credito";
			// 
			// txt_tot_debito
			// 
			txt_tot_debito.Location = new Point(590, 430);
			txt_tot_debito.Name = "txt_tot_debito";
			txt_tot_debito.Size = new Size(142, 23);
			txt_tot_debito.TabIndex = 12;
			// 
			// txt_tot_credito
			// 
			txt_tot_credito.Location = new Point(750, 430);
			txt_tot_credito.Name = "txt_tot_credito";
			txt_tot_credito.Size = new Size(134, 23);
			txt_tot_credito.TabIndex = 13;
			// 
			// Bank
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(954, 509);
			Controls.Add(txt_tot_credito);
			Controls.Add(txt_tot_debito);
			Controls.Add(lbl_tot_credito);
			Controls.Add(lbl_tot_debito);
			Controls.Add(dvg_table);
			Controls.Add(btn_add);
			Controls.Add(cmb_tipo);
			Controls.Add(txt_monto);
			Controls.Add(txt_nom_cuenta);
			Controls.Add(txt_cuenta);
			Controls.Add(lbl_monto);
			Controls.Add(lbl_tipo);
			Controls.Add(lbl_nom_cuenta);
			Controls.Add(lbl_cuenta);
			Name = "Bank";
			Text = "Bank";
			Load += Form1_Load;
			((System.ComponentModel.ISupportInitialize)dvg_table).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lbl_cuenta;
		private Label lbl_nom_cuenta;
		private Label lbl_tipo;
		private Label lbl_monto;
		private TextBox txt_cuenta;
		private TextBox txt_nom_cuenta;
		private TextBox txt_monto;
		private ComboBox cmb_tipo;
		private Button btn_add;
		private DataGridView dvg_table;
		private Label lbl_tot_debito;
		private Label lbl_tot_credito;
		private TextBox txt_tot_debito;
		private TextBox txt_tot_credito;
		private DataGridViewTextBoxColumn Column1;
		private DataGridViewTextBoxColumn Column2;
		private DataGridViewTextBoxColumn Column3;
		private DataGridViewTextBoxColumn Column4;
	}
}
