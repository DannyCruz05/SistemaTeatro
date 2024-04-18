using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CN_Clientes : Form
    {
        CN_Cliente nCliente;

        public CN_Clientes()
        {
            InitializeComponent();

            nCliente = new CN_Cliente();
        }

        private void vClientes_Load(object sender, EventArgs e)
        {
            cargarDatos();
            cargaCombos();
        }
        private void cargarDatos()
        {
            var clientes = nCliente.obtenerCliente()
                                   .ToList()
                                   .Select(c => new { c.ClienteId, c.Codigo, c.DNI, c.Nombres, c.Apellidos, c.FechaCreacion, c.Estado }).ToList();
            dgClientes.DataSource = clientes.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClientesModel cliente = new ClientesModel()
            {
                Codigo = txtCodigo.Text,
                DNI = txtDNI.Text,
                Nombres = txtNombres.Text,
                Apellidos = txtApellidos.Text,
                Estado = cbEstado.Checked,
                ClasificacionClienteId = int.Parse(cbClasificacion.SelectedValue.ToString()),
                GrupoClienteId = int.Parse(cbGrupo.SelectedValue.ToString()),
                FechaIngreso = DateTime.Now
            };
            nCliente.Guardar(cliente);
            cargarDatos();
        }
    }
}
