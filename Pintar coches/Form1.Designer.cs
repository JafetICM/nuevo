namespace JuegoPintarCochesApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lstCola = new System.Windows.Forms.ListBox();
            this.lstPintados = new System.Windows.Forms.ListBox();
            this.cmbColores = new System.Windows.Forms.ComboBox();
            this.btnAgregarCoche = new System.Windows.Forms.Button();
            this.btnPintar = new System.Windows.Forms.Button();
            this.lblCola = new System.Windows.Forms.Label();
            this.lblPintados = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblSeleccionarColor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstCola
            // 
            this.lstCola.FormattingEnabled = true;
            this.lstCola.Location = new System.Drawing.Point(20, 50);
            this.lstCola.Name = "lstCola";
            this.lstCola.Size = new System.Drawing.Size(200, 160);
            this.lstCola.TabIndex = 0;
            // 
            // lstPintados
            // 
            this.lstPintados.FormattingEnabled = true;
            this.lstPintados.Location = new System.Drawing.Point(240, 50);
            this.lstPintados.Name = "lstPintados";
            this.lstPintados.Size = new System.Drawing.Size(200, 160);
            this.lstPintados.TabIndex = 1;
            // 
            // cmbColores
            // 
            this.cmbColores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColores.FormattingEnabled = true;
            this.cmbColores.Location = new System.Drawing.Point(460, 50);
            this.cmbColores.Name = "cmbColores";
            this.cmbColores.Size = new System.Drawing.Size(150, 21);
            this.cmbColores.TabIndex = 2;
            // 
            // btnAgregarCoche
            // 
            this.btnAgregarCoche.Location = new System.Drawing.Point(460, 90);
            this.btnAgregarCoche.Name = "btnAgregarCoche";
            this.btnAgregarCoche.Size = new System.Drawing.Size(150, 30);
            this.btnAgregarCoche.TabIndex = 3;
            this.btnAgregarCoche.Text = "Agregar Coche";
            this.btnAgregarCoche.UseVisualStyleBackColor = true;
            this.btnAgregarCoche.Click += new System.EventHandler(this.btnAgregarCoche_Click);
            // 
            // btnPintar
            // 
            this.btnPintar.Location = new System.Drawing.Point(460, 130);
            this.btnPintar.Name = "btnPintar";
            this.btnPintar.Size = new System.Drawing.Size(150, 30);
            this.btnPintar.TabIndex = 4;
            this.btnPintar.Text = "Pintar Coche";
            this.btnPintar.UseVisualStyleBackColor = true;
            this.btnPintar.Click += new System.EventHandler(this.btnPintar_Click);
            // 
            // lblCola
            // 
            this.lblCola.AutoSize = true;
            this.lblCola.Location = new System.Drawing.Point(20, 30);
            this.lblCola.Name = "lblCola";
            this.lblCola.Size = new System.Drawing.Size(78, 13);
            this.lblCola.TabIndex = 5;
            this.lblCola.Text = "Coches en Cola";
            // 
            // lblPintados
            // 
            this.lblPintados.AutoSize = true;
            this.lblPintados.Location = new System.Drawing.Point(240, 30);
            this.lblPintados.Name = "lblPintados";
            this.lblPintados.Size = new System.Drawing.Size(84, 13);
            this.lblPintados.TabIndex = 6;
            this.lblPintados.Text = "Coches Pintados";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(460, 30);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(84, 13);
            this.lblColor.TabIndex = 7;
            this.lblColor.Text = "Seleccionar color";
            // 
            // lblSeleccionarColor
            // 
            this.lblSeleccionarColor.AutoSize = true;
            this.lblSeleccionarColor.Location = new System.Drawing.Point(460, 180);
            this.lblSeleccionarColor.Name = "lblSeleccionarColor";
            this.lblSeleccionarColor.Size = new System.Drawing.Size(164, 13);
            this.lblSeleccionarColor.TabIndex = 8;
            this.lblSeleccionarColor.Text = "Seleccione un color para cada coche";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(650, 250);
            this.Controls.Add(this.lblSeleccionarColor);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblPintados);
            this.Controls.Add(this.lblCola);
            this.Controls.Add(this.btnPintar);
            this.Controls.Add(this.btnAgregarCoche);
            this.Controls.Add(this.cmbColores);
            this.Controls.Add(this.lstPintados);
            this.Controls.Add(this.lstCola);
            this.Name = "Form1";
            this.Text = "Juego Pintar Coches";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ListBox lstCola;
        private System.Windows.Forms.ListBox lstPintados;
        private System.Windows.Forms.ComboBox cmbColores;
        private System.Windows.Forms.Button btnAgregarCoche;
        private System.Windows.Forms.Button btnPintar;
        private System.Windows.Forms.Label lblCola;
        private System.Windows.Forms.Label lblPintados;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblSeleccionarColor;
    }
}
