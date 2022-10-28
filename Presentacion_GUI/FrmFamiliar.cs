using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
using Entidades;
namespace Presentacion_GUI
{
    public partial class FrmFamiliar : Form
    {
        ServicioContactosFamiliar ServicioCF = new ServicioContactosFamiliar();
        public FrmFamiliar()
        {
            InitializeComponent();
        }



        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
            CargarGrilla();
            CargarLista();
        }

        void Guardar() 
        {
            Entidades.Familiar familiar = new Entidades.Familiar();
            familiar.Id = new Random().Next(999999, 10000000);
            familiar.Nombre = txtNombre.Text;
            familiar.Telefono = txtTelefono.Text;
            familiar.FechaNacimiento = dtFecha.Value;
            var mensaje = ServicioCF.Save(familiar);
            MessageBox.Show(mensaje);
        }

        private void FrmFamiliar_Load(object sender, EventArgs e)
        {
            CargarLista();
            CargarGrilla();
            //this.Text = Lista.SelectedIndex.ToString();
        }
        void CargarLista()
        {
         //   Lista.Items.Clear();
            /*    foreach (var item in ServicioCF.GetAll())
                   {
                       Lista.Items.Add(item.Nombre);
                   }*/
            Lista.DataSource = ServicioCF.GetAll();
            Lista.DisplayMember = "Nombre";
        }
        void CargarGrilla()
        {
           // GrillaFamiliar.Rows.Clear();
                 //foreach (var item in ServicioCF.GetAll())
                 //  {
                 //      GrillaFamiliar.Rows.Add(item.Id,item.Nombre, item.Telefono,item.FechaNacimiento);
                 //  }
           GrillaFamiliar.DataSource = ServicioCF.GetAll();

            
        }
        private void Lista_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Text = Lista.SelectedIndex.ToString();
            ver(ServicioCF.GetAll()[Lista.SelectedIndex]);
        }
        void ver(Familiar contacto)
        {
           txtNombre.Text = contacto.Nombre;
            txtTelefono.Text = contacto.Telefono;
            dtFecha.Value = contacto.FechaNacimiento;

        }

      

        private void GrillaFamiliar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ver(ServicioCF.GetAll()[e.RowIndex]);
            tabPersonales.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        
    }
}
