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
    public partial class FrmFunciones : Form
    {
        CN_Funciones cnFunciones;
        public FrmFunciones()
        {
            InitializeComponent();
            cnFunciones = new CN_Funciones();
        }
        private void CargarDatos()
        {
            var funcion = cnFunciones.obtenerFuncion()
                                   .ToList()
                                   .Select(c => new { c.FuncionId, c.Nombre, c.FechaFuncion, c.HoraInicio, c.HoraFin, c.Estado }).ToList();
            dgvdatos.DataSource = funcion.ToList();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            FuncionesModel funcion = new FuncionesModel()
            {
                FuncionId = int.Parse(txtFuncionId.Text),
                Nombre = txtNombre.Text,
                FechaFuncion = DateOnly.Parse(dtpFecha.Text),
                HoraInicio = TimeOnly.Parse(dtpHoraI.Text),
                HoraFin = TimeOnly.Parse(dtpHoraFin.Text),
                Estado = chkEstado.Checked,
                FechaCreacion = DateTime.Now
            };
            cnFunciones.Guardar(funcion);
            CargarDatos();
        }
        private void FrmFunciones_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
    }
}
