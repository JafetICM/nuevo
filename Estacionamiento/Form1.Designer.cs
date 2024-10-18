namespace EstacionamientoApp
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
            this.txtPlacas = new System.Windows.Forms.TextBox();
            this.txtPropietario = new System.Windows.Forms.TextBox();
            this.btnEntrada = new System.Windows.Forms.Button();
            this.btnSalida = new System.Windows.Forms.Button();
            this.lstCola = new System.Windows.Forms.ListBox();
            this.lblPlacas = new System.Windows.Forms.Label();
            this.lblPropietario = new System.Windows.Forms.Label();
            this.lblCola = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPlacas
            // 
            this.txtPlacas.Location = new System.Drawing.Point(100, 30);
            this.txtPlacas.Name = "txtPlacas";
            this.txtPlacas.Size = new System.Drawing.Size(200, 20);
            this.txtPlacas.TabIndex = 0;
            // 
            // txtPropietario
            // 
            this.txtPropietario.Location = new System.Drawing.Point(100, 70);
            this.txtPropietario.Name = "txtPropietario";
            this.txtPropietario.Size = new System.Drawing.Size(200, 20);
            this.txtPropietario.TabIndex = 1;
            // 
            // btnEntrada
            // 
            this.btnEntrada.Location = new System.Drawing.Point(320, 30);
            this.btnEntrada.Name = "btnEntrada";
            this.btnEntrada.Size = new System.Drawing.Size(100, 30);
            this.btnEntrada.TabIndex = 2;
            this.btnEntrada.Text = "Entrada de Auto";
            this.btnEntrada.UseVisualStyleBackColor = true;
            this.btnEntrada.Click += new System.EventHandler(this.btnEntrada_Click);
            // 
            // btnSalida
            // 
            this.btnSalida.Location = new System.Drawing.Point(320, 70);
            this.btnSalida.Name = "btnSalida";
            this.btnSalida.Size = new System.Drawing.Size(100, 30);
            this.btnSalida.TabIndex = 3;
            this.btnSalida.Text = "Salida de Auto";
            this.btnSalida.UseVisualStyleBackColor = true;
            this.btnSalida.Click += new System.EventHandler(this.btnSalida_Click);
            // 
            // lstCola
            // 
            this.lstCola.FormattingEnabled = true;
            this.lstCola.Location = new System.Drawing.Point(20, 130);
            this.lstCola.Name = "lstCola";
            this.lstCola.Size = new System.Drawing.Size(400, 160);
            this.lstCola.TabIndex = 4;
            // 
            // lblPlacas
            // 
            this.lblPlacas.AutoSize = true;
            this.lblPlacas.Location = new System.Drawing.Point(20, 33);
            this.lblPlacas.Name = "lblPlacas";
            this.lblPlacas.Size = new System.Drawing.Size(78, 13);
            this.lblPlacas.TabIndex = 5;
            this.lblPlacas.Text = "Placas del Auto:";
            // 
            // lblPropietario
            // 
            this.lblPropietario.AutoSize = true;
            this.lblPropietario.Location = new System.Drawing.Point(20, 73);
            this.lblPropietario.Name = "lblPropietario";
            this.lblPropietario.Size = new System.Drawing.Size(63, 13);
            this.lblPropietario.TabIndex = 6;
            this.lblPropietario.Text = "Propietario:";
            // 
            // lblCola
            // 
            this.lblCola.AutoSize = true;
            this.lblCola.Location = new System.Drawing.Point(20, 110);
            this.lblCola.Name = "lblCola";
            this.lblCola.Size = new System.Drawing.Size(108, 13);
            this.lblCola.TabIndex = 7;
            this.lblCola.Text = "Autos en Estacionado:";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(450, 320);
            this.Controls.Add(this.lblCola);
            this.Controls.Add(this.lblPropietario);
            this.Controls.Add(this.lblPlacas);
            this.Controls.Add(this.lstCola);
            this.Controls.Add(this.btnSalida);
            this.Controls.Add(this.btnEntrada);
            this.Controls.Add(this.txtPropietario);
            this.Controls.Add(this.txtPlacas);
            this.Name = "Form1";
            this.Text = "Estacionamiento para Autos";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtPlacas;
        private System.Windows.Forms.TextBox txtPropietario;
        private System.Windows.Forms.Button btnEntrada;
        private System.Windows.Forms.Button btnSalida;
        private System.Windows.Forms.ListBox lstCola;
        private System.Windows.Forms.Label lblPlacas;
        private System.Windows.Forms.Label lblPropietario;
        private System.Windows.Forms.Label lblCola;
    }
}
