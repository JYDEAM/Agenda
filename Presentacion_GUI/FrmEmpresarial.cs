using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Logica;

namespace Presentacion_GUI
{
    public partial class FrmEmpresarial : Form
    {
        ServicioContactoEmpresarial ServicioCE = new ServicioContactoEmpresarial();
        public FrmEmpresarial()
        {
            InitializeComponent();
        }

        void ver(Empresarial contacto)
        {
            txtNombre.Text = contacto.Nombre;
            txtTelefono.Text = contacto.Telefono;
            txtNit.Text= contacto.Nit;  
            txtRazonSocial.Text = contacto.RazonSocial;
            txtCorreo.Text = contacto.Correo;
        }

        void Guardar()
        {
            Entidades.Empresarial empresarial = new Entidades.Empresarial();
            empresarial.Id = new Random().Next(999999, 10000000);
            empresarial.Nombre = txtNombre.Text;
            empresarial.Telefono = txtTelefono.Text;
            empresarial.Nit = txtNit.Text;
            empresarial.RazonSocial = txtRazonSocial.Text;
            empresarial.Correo = txtCorreo.Text;
            var mensaje = ServicioCE.Save(empresarial);
            MessageBox.Show(mensaje);
        }
        void CargarLista()
        {
          
            Lista.DataSource = ServicioCE.GetAll();
            Lista.DisplayMember = "Nombre";
        }


        void CargarGrilla()
        {
           
            GrillaEmpresarial.DataSource = ServicioCE.GetAll();

        }

         private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void GrillaEmpresarial_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ver(ServicioCE.GetAll()[e.RowIndex]);
            tabPersonal.Show();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
            CargarGrilla();
            CargarLista();
        }

        

        private void FrmEmpresarial_Load(object sender, EventArgs e)
        {
            CargarLista();
            CargarGrilla();
        }

        private void Lista_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Text = Lista.SelectedIndex.ToString();
            ver(ServicioCE.GetAll()[Lista.SelectedIndex]);
        }
    }
}
