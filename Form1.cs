using Bank.contoller;
using Bank.lib;
using System.Windows.Forms;

namespace Bank
{
	public partial class Bank : Form
	{
		public Bank()
		{
			InitializeComponent();
		}
		AccountController accountController = new AccountController();
		private void Form1_Load(object sender, EventArgs e)
		{
			cmb_tipo.SelectedItem = "--Selecciona--";
			dvg_table.DataSource = accountController.GetAccounts();
			txt_tot_debito.Text = SumAmounts.Operation(accountController.GetAccounts(), "deb_ban").ToString();
			txt_tot_credito.Text = SumAmounts.Operation(accountController.GetAccounts(), "cre_ban").ToString();
		}

		private void btn_add_Click(object sender, EventArgs e)
		{
			if (txt_cuenta.Text != "" &&
					txt_nom_cuenta.Text != "" &&
					txt_monto.Text != "" &&
					cmb_tipo.SelectedItem.ToString() != "--Selecciona--")
			{

				accountController.SetNewAccounts(
					Convert.ToInt32(txt_cuenta.Text),
					txt_nom_cuenta.Text,
					cmb_tipo.SelectedItem.ToString(),
					Convert.ToDouble(txt_monto.Text)
					);

				txt_cuenta.Clear();
				txt_nom_cuenta.Clear();
				txt_monto.Clear();
				txt_tot_credito.Clear();
				txt_tot_debito.Clear();
				cmb_tipo.SelectedItem = "-- Selecciona --";
				dvg_table.DataSource = accountController.GetAccounts();
				txt_tot_debito.Text = SumAmounts.Operation(accountController.GetAccounts(), "deb_ban").ToString();
				txt_tot_credito.Text = SumAmounts.Operation(accountController.GetAccounts(), "cre_ban").ToString();


			}
			else
			{
				MessageBox.Show("No puede dejar campos vacio");
			}

		}


	}
}
