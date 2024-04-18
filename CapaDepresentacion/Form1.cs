namespace CapaDepresentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClientes frmClientes = new FrmClientes();
            frmClientes.MdiParent = this;
            frmClientes.Show();
        }

        private void funcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFunciones FrmFunciones = new FrmFunciones();
            FrmFunciones.MdiParent = this;
            FrmFunciones.Show();
        }

        private void reservacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReservaciones FrmReservaciones = new FrmReservaciones();
            FrmReservaciones.MdiParent = this;
            FrmReservaciones.Show();
        }
    }
}