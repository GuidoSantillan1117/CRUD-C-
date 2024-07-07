namespace TallerFrankyUi
{
    partial class FrmReparacion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReparacion));
            lstTaller = new ListBox();
            SuspendLayout();
            // 
            // lstTaller
            // 
            lstTaller.FormattingEnabled = true;
            lstTaller.ItemHeight = 15;
            lstTaller.Location = new Point(138, 142);
            lstTaller.Margin = new Padding(4, 3, 4, 3);
            lstTaller.Name = "lstTaller";
            lstTaller.Size = new Size(694, 274);
            lstTaller.TabIndex = 0;
            lstTaller.SelectedIndexChanged += lstTaller_SelectedIndexChanged;
            // 
            // FrmReparacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(910, 541);
            Controls.Add(lstTaller);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmReparacion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmReparacion";
            FormClosing += FrmReparacion_FormClosing;
            Load += FrmReparacion_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ListBox lstTaller;
    }
}

