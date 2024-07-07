using Barcosproyecto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TallerFrankyUi
{
    public partial class FrmBarco : Form
    {
        public Barco frmBarquito;
        public FrmBarco()
        {
            InitializeComponent();
            cmbTipo.DataSource = Enum.GetValues(typeof(ETipoBarco));
            cmbOperacion.DataSource = Enum.GetValues(typeof(EOperacion));
            
        }

        private void FrmVehiculo_Load(object sender, EventArgs e)
        {

        }


        private void btnCargar_Click(object sender, EventArgs e)
        {
            if ((ETipoBarco)(cmbTipo.SelectedValue) == ETipoBarco.Pirata)
            {
                frmBarquito = new Pirata(txtNombre.Text,0);
                frmBarquito.Operacion = (EOperacion)cmbOperacion.SelectedValue;
            }
            else if ((ETipoBarco)(cmbTipo.SelectedValue) == ETipoBarco.Marina)
            {
                frmBarquito = new Marina(txtNombre.Text,0);
                frmBarquito.Operacion = (EOperacion)cmbOperacion.SelectedValue;
            }


            DialogResult = DialogResult.OK;
  
            //TODO:Validar si el barco es pirata o marina y lo instancio
            // retornar DialogResult OK y cerrar el formulario
            // 


        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbOperacion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
