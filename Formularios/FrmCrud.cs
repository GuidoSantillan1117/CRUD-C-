using System;
using Barcosproyecto;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class FrmCrud : Form
    {
        Taller miTaller;
        public FrmCrud(Taller t)
        {
            InitializeComponent();
            this.miTaller = t;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void RefrescarLista()
        {
            this.miTaller.ListaBarcos = AccesoDatos.SeleccionarBarcos();
            dataGridView1.DataSource = miTaller.ListaBarcos;
        }
        private void FrmCrud_Load(object sender, EventArgs e)
        {
            RefrescarLista();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.SelectedRows[0].Index;
            int tripulacion = int.Parse(txtTripulacion.Text);
 
            int id = (int)dataGridView1.SelectedRows[0].Cells["Id"].Value;
            if (miTaller.ListaBarcos[index] is Pirata)
            {
                Pirata barcoPirata = new Pirata(txtNombre.Text, tripulacion);
                barcoPirata.Id = id;
                AccesoDatos.ModificarBarcos(barcoPirata);

            }
            else if (miTaller.ListaBarcos[index] is Marina)
            {
                Marina barcoMarina = new Marina(txtNombre.Text, tripulacion);
                barcoMarina.Id = id;
                AccesoDatos.ModificarBarcos(barcoMarina);

            }
            RefrescarLista();
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            bool pudo = false;
            string txt = txtId.Text;
            int idEliminar = int.Parse(txt);
            foreach (Barco b in miTaller.ListaBarcos)
            {
                if (b .Id == idEliminar)
                {
                    pudo = true;
                }

            }
            if (pudo)
            {
                AccesoDatos.EliminarBarco(idEliminar);
                RefrescarLista();
            }
            else
            {
                MessageBox.Show("ERROR. ID no encontrado.");
            }



        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}


