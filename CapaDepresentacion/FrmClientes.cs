using CapadeDatos;
using CapadeDatos.Modelos;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDepresentacion
{
    public partial class FrmClientes : Form
    {
        CN_Clientes cnCliente;
        public FrmClientes()
        {
            InitializeComponent();

            cnCliente = new CN_Clientes();
        }
        private void CargarDatos()
        {
            var clientes = cnCliente.obtenerCliente()
                                   .ToList()
                                   .Select(c => new { c.ClienteId, c.Codigo, c.DNI, c.Nombres, c.Apellidos, c.Estado }).ToList();
            dgvdatos.DataSource = clientes.ToList();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            ClientesModel cliente = new ClientesModel()
            {
                Codigo = txtCodigo.Text,
                DNI = txtDNI.Text,
                Nombres = txtNombres.Text,
                Apellidos = txtApellidos.Text,
                Estado = chkEstado.Checked,
                FechaCreacion = DateTime.Now
            };
            cnCliente.Guardar(cliente);
            CargarDatos();

        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
    }
}
