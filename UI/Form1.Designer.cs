namespace UI
{
    partial class Form1
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtCuenta = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtgListarClientes = new System.Windows.Forms.DataGridView();
            this.dtgListarCuentas = new System.Windows.Forms.DataGridView();
            this.btnListarClientes = new System.Windows.Forms.Button();
            this.btnListarCuentas = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListarClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListarCuentas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(123, 207);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCuenta);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 252);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Clientes";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(179, 37);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(179, 80);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 2;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(179, 124);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 20);
            this.txtDireccion.TabIndex = 3;
            // 
            // txtCuenta
            // 
            this.txtCuenta.Location = new System.Drawing.Point(179, 164);
            this.txtCuenta.Name = "txtCuenta";
            this.txtCuenta.Size = new System.Drawing.Size(100, 20);
            this.txtCuenta.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtCliente);
            this.groupBox2.Controls.Add(this.txtSaldo);
            this.groupBox2.Controls.Add(this.txtID);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(25, 270);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(282, 212);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cuentas";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(133, 124);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(100, 20);
            this.txtCliente.TabIndex = 3;
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(133, 80);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(100, 20);
            this.txtSaldo.TabIndex = 2;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(133, 37);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 1;
            this.txtID.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(101, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cuenta Asignada";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Direccion";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Numero de Cienta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Saldo Inicial";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Cliente Asignado";
            // 
            // dtgListarClientes
            // 
            this.dtgListarClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListarClientes.Location = new System.Drawing.Point(339, 12);
            this.dtgListarClientes.Name = "dtgListarClientes";
            this.dtgListarClientes.Size = new System.Drawing.Size(589, 252);
            this.dtgListarClientes.TabIndex = 6;
            // 
            // dtgListarCuentas
            // 
            this.dtgListarCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListarCuentas.Location = new System.Drawing.Point(339, 285);
            this.dtgListarCuentas.Name = "dtgListarCuentas";
            this.dtgListarCuentas.Size = new System.Drawing.Size(589, 252);
            this.dtgListarCuentas.TabIndex = 7;
            // 
            // btnListarClientes
            // 
            this.btnListarClientes.Location = new System.Drawing.Point(952, 114);
            this.btnListarClientes.Name = "btnListarClientes";
            this.btnListarClientes.Size = new System.Drawing.Size(75, 42);
            this.btnListarClientes.TabIndex = 9;
            this.btnListarClientes.Text = "Listar";
            this.btnListarClientes.UseVisualStyleBackColor = true;
            this.btnListarClientes.Click += new System.EventHandler(this.btnListarClientes_Click);
            // 
            // btnListarCuentas
            // 
            this.btnListarCuentas.Location = new System.Drawing.Point(952, 391);
            this.btnListarCuentas.Name = "btnListarCuentas";
            this.btnListarCuentas.Size = new System.Drawing.Size(75, 39);
            this.btnListarCuentas.TabIndex = 10;
            this.btnListarCuentas.Text = "Listar";
            this.btnListarCuentas.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 549);
            this.Controls.Add(this.btnListarCuentas);
            this.Controls.Add(this.btnListarClientes);
            this.Controls.Add(this.dtgListarCuentas);
            this.Controls.Add(this.dtgListarClientes);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListarClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListarCuentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCuenta;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dtgListarClientes;
        private System.Windows.Forms.DataGridView dtgListarCuentas;
        private System.Windows.Forms.Button btnListarClientes;
        private System.Windows.Forms.Button btnListarCuentas;
    }
}

