namespace TallerFrankyUi
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            btnReparar = new Button();
            btnCargarBarco = new Button();
            btnGuardar = new Button();
            btnCrud = new Button();
            SuspendLayout();
            // 
            // btnReparar
            // 
            btnReparar.Font = new Font("Calibri", 20F);
            btnReparar.Location = new Point(62, 137);
            btnReparar.Margin = new Padding(4, 3, 4, 3);
            btnReparar.Name = "btnReparar";
            btnReparar.Size = new Size(288, 46);
            btnReparar.TabIndex = 0;
            btnReparar.Text = "Reparar";
            btnReparar.UseVisualStyleBackColor = true;
            btnReparar.Click += btnReparar_Click;
            // 
            // btnCargarBarco
            // 
            btnCargarBarco.Font = new Font("Calibri", 20F);
            btnCargarBarco.Location = new Point(62, 30);
            btnCargarBarco.Margin = new Padding(4, 3, 4, 3);
            btnCargarBarco.Name = "btnCargarBarco";
            btnCargarBarco.Size = new Size(288, 46);
            btnCargarBarco.TabIndex = 1;
            btnCargarBarco.Text = "Cargar Barco";
            btnCargarBarco.UseVisualStyleBackColor = true;
            btnCargarBarco.Click += btnCargarBarco_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Calibri", 20F);
            btnGuardar.Location = new Point(62, 240);
            btnGuardar.Margin = new Padding(4, 3, 4, 3);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(288, 46);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar Registro";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCrud
            // 
            btnCrud.Font = new Font("Calibri", 20F);
            btnCrud.Location = new Point(62, 321);
            btnCrud.Margin = new Padding(4, 3, 4, 3);
            btnCrud.Name = "btnCrud";
            btnCrud.Size = new Size(288, 46);
            btnCrud.TabIndex = 3;
            btnCrud.Text = "CRUD";
            btnCrud.UseVisualStyleBackColor = true;
            btnCrud.Click += btnCrud_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(377, 401);
            Controls.Add(btnCrud);
            Controls.Add(btnGuardar);
            Controls.Add(btnCargarBarco);
            Controls.Add(btnReparar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmPrincipal";
            FormClosing += FrmPrincipal_FormClosing;
            Load += FrmPrincipal_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnReparar;
        private System.Windows.Forms.Button btnCargarBarco;
        private System.Windows.Forms.Button btnGuardar;
        private Button btnCrud;
    }
}