namespace pjCajeroAutomatico
{
    public partial class frmCajero : Form
    {

        Cajero caja = new Cajero();

        public frmCajero()
        {
            InitializeComponent();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSaldo_Click(object sender, EventArgs e)
        {

            lblsaldo.Text = caja.Saldo.ToString();
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos() == false)
            {
                return;
            }

            caja.Deposito = double.Parse(txtDeposito.Text);
            caja.Depositar(caja.Deposito);
            lblsaldo.Text = caja.Saldo.ToString();
            txtDeposito.Clear();

            ListViewItem fila = new ListViewItem("Deposito");
            fila.SubItems.Add(caja.Saldo.ToString());
            lvMovimientos.Items.Add(fila);

            MessageBox.Show("Deposito Realizado");


        }

        private bool ValidarRetiro()
        {
            if (caja.Saldo > double.Parse(txtDeposito.Text))
            {
                erpError.SetError(txtDeposito, "Valor excede el que esta guardado en la cuenta");
                txtDeposito.Clear();
                txtDeposito.Focus();
                return false;
            }
            else
            {
                erpError.SetError(txtDeposito, "");
                return true;
            }


        }

        private bool ValidarDatos()
        {
            double deposito;
            if (!double.TryParse(txtDeposito.Text, out deposito) || txtDeposito.Text == "")
            {
                erpError.SetError(txtDeposito, "Debe ingresar un valor numerico");
                txtDeposito.Clear();
                txtDeposito.Focus();
                return false;
            }
            else
            {
                erpError.SetError(txtDeposito, "");
                return true;
            }


        }

        private void tnRetirar_Click(object sender, EventArgs e)
        {
            if (ValidarRetiro() == false)
            {
                return;
            }

            if (ValidarRetiro() == false)
            {
                return ;
                
                if (ValidarDatos() == false)
                {
                    return;
                }
                caja.Retiro = double.Parse(txtDeposito.Text);
                caja.Retirar(caja.Retiro);
                lblsaldo.Text = caja.Retiro.ToString();
                txtDeposito.Clear();

                ListViewItem fila = new ListViewItem("Retiro");
                fila.SubItems.Add(caja.Saldo.ToString());
                lvMovimientos.Items.Add(fila);

                MessageBox.Show("Retiro Realizado"); 
            }
        }
    }
}