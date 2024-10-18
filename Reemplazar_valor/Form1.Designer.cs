namespace ReemplazarValorEnPilaApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnReemplazar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtViejo;
        private System.Windows.Forms.TextBox txtNuevo;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblViejo;
        private System.Windows.Forms.Label lblNuevo;
        private System.Windows.Forms.Label lblNumero;

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
            this.btnReemplazar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtViejo = new System.Windows.Forms.TextBox();
            this.txtNuevo = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblViejo = new System.Windows.Forms.Label();
            this.lblNuevo = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();

            // 
            // btnReemplazar
            // 
            this.btnReemplazar.Location = new System.Drawing.Point(150, 180);
            this.btnReemplazar.Name = "btnReemplazar";
            this.btnReemplazar.Size = new System.Drawing.Size(100, 30);
            this.btnReemplazar.Text = "Reemplazar";
            this.btnReemplazar.Click += new System.EventHandler(this.btnReemplazar_Click);

            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(150, 110);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 30);
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);

            // 
            // lblResultado
            // 
            this.lblResultado.Location = new System.Drawing.Point(30, 220);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(300, 60);

            // 
            // txtViejo
            // 
            this.txtViejo.Location = new System.Drawing.Point(150, 30);
            this.txtViejo.Name = "txtViejo";
            this.txtViejo.Size = new System.Drawing.Size(100, 20);

            // 
            // txtNuevo
            // 
            this.txtNuevo.Location = new System.Drawing.Point(150, 70);
            this.txtNuevo.Name = "txtNuevo";
            this.txtNuevo.Size = new System.Drawing.Size(100, 20);

            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(150, 150);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);

            // 
            // lblViejo
            // 
            this.lblViejo.Location = new System.Drawing.Point(30, 30);
            this.lblViejo.Name = "lblViejo";
            this.lblViejo.Size = new System.Drawing.Size(100, 20);
            this.lblViejo.Text = "Valor Viejo";

            // 
            // lblNuevo
            // 
            this.lblNuevo.Location = new System.Drawing.Point(30, 70);
            this.lblNuevo.Name = "lblNuevo";
            this.lblNuevo.Size = new System.Drawing.Size(100, 20);
            this.lblNuevo.Text = "Valor Nuevo";

            // 
            // lblNumero
            // 
            this.lblNumero.Location = new System.Drawing.Point(30, 150);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(100, 20);
            this.lblNumero.Text = "Agregar Número";

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.btnReemplazar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtViejo);
            this.Controls.Add(this.txtNuevo);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblViejo);
            this.Controls.Add(this.lblNuevo);
            this.Controls.Add(this.lblNumero);
            this.Text = "Reemplazar Valor en Pila";
        }
    }
}
