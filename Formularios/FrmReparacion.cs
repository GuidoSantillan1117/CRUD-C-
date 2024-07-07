using Barcosproyecto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TallerFrankyUi
{
    public partial class FrmReparacion : Form
    {
        Taller miTaller;
        public FrmReparacion(Taller t)
        {
            InitializeComponent();
            miTaller = t;
        }

        private void FrmReparacion_Load(object sender, EventArgs e)
        {
            miTaller.ListaBarcos = AccesoDatos.SeleccionarBarcos();
            miTaller.Reparar(miTaller);
            foreach (Barco barco in miTaller.ListaBarcos)
            {
                lstTaller.Items.Add(barco.ToString());

            }

            //TODO: Asocio el evento que va a imprimir el ticket
            //TODO: Instanciar y comenzar el hilo que se va a encargar de reparar los barcos del taller


        }

        private void FrmReparacion_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void lblBarcoTipo_Click(object sender, EventArgs e)
        {

        }

        private void lstTaller_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
