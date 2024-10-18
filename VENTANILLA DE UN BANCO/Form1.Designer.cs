namespace VentanillaBancoApp
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
            this.groupBoxDatosCliente = new System.Windows.Forms.GroupBox();
            this.txtTurno = new System.Windows.Forms.TextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.cmbMovimiento = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.btnAtender = new System.Windows.Forms.Button();
            this.lblFrente = new System.Windows.Forms.Label();
            this.lblFinal = new System.Windows.Forms.Label();
            this.lblTurno = new System.Windows.Forms.Label();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.lblMovimiento = new System.Windows.Forms.Label();
            this.Turno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Movimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraLlegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxDatosCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxDatosCliente
            // 
            this.groupBoxDatosCliente.Controls.Add(this.lblMovimiento);
            this.groupBoxDatosCliente.Controls.Add(this.lblNombreCliente);
            this.groupBoxDatosCliente.Controls.Add(this.lblTurno);
            this.groupBoxDatosCliente.Controls.Add(this.txtTurno);
            this.groupBoxDatosCliente.Controls.Add(this.txtNombreCliente);
            this.groupBoxDatosCliente.Controls.Add(this.cmbMovimiento);
            this.groupBoxDatosCliente.Location = new System.Drawing.Point(12, 12);
            this.groupBoxDatosCliente.Name = "groupBoxDatosCliente";
            this.groupBoxDatosCliente.Size = new System.Drawing.Size(320, 150);
            this.groupBoxDatosCliente.TabIndex = 0;
            this.groupBoxDatosCliente.TabStop = false;
            this.groupBoxDatosCliente.Text = "Datos del Cliente";
            // 
            // txtTurno
            // 
            this.txtTurno.Location = new System.Drawing.Point(110, 30);
            this.txtTurno.Name = "txtTurno";
            this.txtTurno.ReadOnly = true;
            this.txtTurno.Size = new System.Drawing.Size(180, 20);
            this.txtTurno.TabIndex = 0;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(150, 65);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(130, 20);
            this.txtNombreCliente.TabIndex = 1;
            // 
            // cmbMovimiento
            // 
            this.cmbMovimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMovimiento.FormattingEnabled = true;
            this.cmbMovimiento.Location = new System.Drawing.Point(110, 100);
            this.cmbMovimiento.Name = "cmbMovimiento";
            this.cmbMovimiento.Size = new System.Drawing.Size(180, 21);
            this.cmbMovimiento.TabIndex = 2;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(12, 180);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(150, 30);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar Cliente";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Turno,
            this.Nombre,
            this.Movimiento,
            this.HoraLlegada});
            this.dgvClientes.Location = new System.Drawing.Point(350, 12);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(440, 200);
            this.dgvClientes.TabIndex = 4;
            // 
            // btnAtender
            // 
            this.btnAtender.Location = new System.Drawing.Point(180, 180);
            this.btnAtender.Name = "btnAtender";
            this.btnAtender.Size = new System.Drawing.Size(150, 30);
            this.btnAtender.TabIndex = 5;
            this.btnAtender.Text = "Atender en Ventanilla";
            this.btnAtender.UseVisualStyleBackColor = true;
            this.btnAtender.Click += new System.EventHandler(this.btnAtender_Click);
            // 
            // lblFrente
            // 
            this.lblFrente.AutoSize = true;
            this.lblFrente.Location = new System.Drawing.Point(350, 220);
            this.lblFrente.Name = "lblFrente";
            this.lblFrente.Size = new System.Drawing.Size(53, 13);
            this.lblFrente.TabIndex = 6;
            this.lblFrente.Text = "Frente: ---";
            // 
            // lblFinal
            // 
            this.lblFinal.AutoSize = true;
            this.lblFinal.Location = new System.Drawing.Point(350, 240);
            this.lblFinal.Name = "lblFinal";
            this.lblFinal.Size = new System.Drawing.Size(43, 13);
            this.lblFinal.TabIndex = 7;
            this.lblFinal.Text = "Final: ---";
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Location = new System.Drawing.Point(20, 33);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(38, 13);
            this.lblTurno.TabIndex = 3;
            this.lblTurno.Text = "Turno:";
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Location = new System.Drawing.Point(20, 68);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(88, 13);
            this.lblNombreCliente.TabIndex = 4;
            this.lblNombreCliente.Text = "Nombre Cliente:";
            // 
            // lblMovimiento
            // 
            this.lblMovimiento.AutoSize = true;
            this.lblMovimiento.Location = new System.Drawing.Point(20, 103);
            this.lblMovimiento.Name = "lblMovimiento";
            this.lblMovimiento.Size = new System.Drawing.Size(62, 13);
            this.lblMovimiento.TabIndex = 5;
            this.lblMovimiento.Text = "Movimiento:";
            // 
            // Turno
            // 
            this.Turno.HeaderText = "Turno";
            this.Turno.Name = "Turno";
            this.Turno.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Movimiento
            // 
            this.Movimiento.HeaderText = "Movimiento";
            this.Movimiento.Name = "Movimiento";
            this.Movimiento.ReadOnly = true;
            // 
            // HoraLlegada
            // 
            this.HoraLlegada.HeaderText = "Hora de Llegada";
            this.HoraLlegada.Name = "HoraLlegada";
            this.HoraLlegada.ReadOnly = true;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(800, 300);
            this.Controls.Add(this.lblFinal);
            this.Controls.Add(this.lblFrente);
            this.Controls.Add(this.btnAtender);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.groupBoxDatosCliente);
            this.Name = "Form1";
            this.Text = "Ventanilla de un Banco";
            this.groupBoxDatosCliente.ResumeLayout(false);
            this.groupBoxDatosCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.GroupBox groupBoxDatosCliente;
        private System.Windows.Forms.TextBox txtTurno;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.ComboBox cmbMovimiento;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button btnAtender;
        private System.Windows.Forms.Label lblFrente;
        private System.Windows.Forms.Label lblFinal;
        private System.Windows.Forms.Label lblMovimiento;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Turno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Movimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraLlegada;
    }
}
