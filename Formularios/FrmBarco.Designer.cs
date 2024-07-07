namespace TallerFrankyUi
{
    partial class FrmBarco
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBarco));
            cmbTipo = new ComboBox();
            txtNombre = new TextBox();
            lblMarca = new Label();
            lblTipo = new Label();
            cmbOperacion = new ComboBox();
            lblOperacion = new Label();
            btnCargar = new Button();
            SuspendLayout();
            // 
            // cmbTipo
            // 
            cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipo.Font = new Font("Calibri", 10F);
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(34, 171);
            cmbTipo.Margin = new Padding(4, 3, 4, 3);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(171, 23);
            cmbTipo.TabIndex = 0;
            cmbTipo.SelectedIndexChanged += cmbTipo_SelectedIndexChanged;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Calibri", 10F);
            txtNombre.Location = new Point(34, 70);
            txtNombre.Margin = new Padding(4, 3, 4, 3);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(171, 24);
            txtNombre.TabIndex = 2;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.BackColor = Color.Transparent;
            lblMarca.Font = new Font("Calibri", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMarca.ForeColor = SystemColors.Control;
            lblMarca.Location = new Point(30, 37);
            lblMarca.Margin = new Padding(4, 0, 4, 0);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(78, 24);
            lblMarca.TabIndex = 3;
            lblMarca.Text = "Nombre";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.BackColor = Color.Transparent;
            lblTipo.Font = new Font("Calibri", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTipo.ForeColor = SystemColors.Control;
            lblTipo.Location = new Point(30, 133);
            lblTipo.Margin = new Padding(4, 0, 4, 0);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(47, 24);
            lblTipo.TabIndex = 4;
            lblTipo.Text = "Tipo";
            // 
            // cmbOperacion
            // 
            cmbOperacion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOperacion.Font = new Font("Calibri", 10F);
            cmbOperacion.FormattingEnabled = true;
            cmbOperacion.Location = new Point(34, 264);
            cmbOperacion.Margin = new Padding(4, 3, 4, 3);
            cmbOperacion.Name = "cmbOperacion";
            cmbOperacion.Size = new Size(171, 23);
            cmbOperacion.TabIndex = 5;
            cmbOperacion.SelectedIndexChanged += cmbOperacion_SelectedIndexChanged;
            // 
            // lblOperacion
            // 
            lblOperacion.AutoSize = true;
            lblOperacion.BackColor = Color.Transparent;
            lblOperacion.Font = new Font("Calibri", 15F, FontStyle.Bold);
            lblOperacion.ForeColor = SystemColors.Control;
            lblOperacion.Location = new Point(30, 230);
            lblOperacion.Margin = new Padding(4, 0, 4, 0);
            lblOperacion.Name = "lblOperacion";
            lblOperacion.Size = new Size(97, 24);
            lblOperacion.TabIndex = 7;
            lblOperacion.Text = "Operacion";
            // 
            // btnCargar
            // 
            btnCargar.Font = new Font("Calibri", 12F);
            btnCargar.Location = new Point(34, 320);
            btnCargar.Margin = new Padding(4, 3, 4, 3);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(172, 31);
            btnCargar.TabIndex = 8;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // FrmBarco
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(251, 365);
            Controls.Add(btnCargar);
            Controls.Add(lblOperacion);
            Controls.Add(cmbOperacion);
            Controls.Add(lblTipo);
            Controls.Add(lblMarca);
            Controls.Add(txtNombre);
            Controls.Add(cmbTipo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmBarco";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmBarco";
            Load += FrmVehiculo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cmbOperacion;
        private System.Windows.Forms.Label lblOperacion;
        private System.Windows.Forms.Button btnCargar;
    }
}