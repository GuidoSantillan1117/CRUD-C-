using Barcosproyecto;
using Formularios;
using Serializacion;
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
    public partial class FrmPrincipal : Form
    {
        Taller miTaller;
        XmlManager xml;
        public FrmPrincipal()
        {
            InitializeComponent();
            this.miTaller = new Taller();

            //TODO: Instanciar el taller
        }

        private void btnCargarBarco_Click(object sender, EventArgs e)
        {
            FrmBarco formularioBarco = new FrmBarco();
            if (formularioBarco.ShowDialog() == DialogResult.OK)
            {
                this.miTaller = this.miTaller.IngresarBarco(formularioBarco.frmBarquito);
                AccesoDatos.GuardarBarco(formularioBarco.frmBarquito);
                formularioBarco.Close();
            }

        }

        private void btnReparar_Click(object sender, EventArgs e)
        {
            FrmReparacion formularioReparacion = new FrmReparacion(this.miTaller);
            formularioReparacion.Show();

        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult msb = MessageBox.Show("¿Desea salir?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (msb == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.xml = new XmlManager(miTaller.ListaBarcos);
            xml.Guardar("C://Users//guido//OneDrive//Documentos//xmlTaller.xml");

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                miTaller.ListaBarcos = AccesoDatos.SeleccionarBarcos();
            
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR: {ex.Message} No se pudo acceder a la tabla CRUD_BARCOS de la Base de datos");
            }



        }

        private void btnCrud_Click(object sender, EventArgs e)
        {
            FrmCrud formularioCrud = new FrmCrud(this.miTaller);
            formularioCrud.Show();
        }
    }
}
