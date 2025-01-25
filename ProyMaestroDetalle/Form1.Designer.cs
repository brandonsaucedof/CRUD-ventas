namespace ProyMaestroDetalle
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataSet1 = new ProyMaestroDetalle.DataSet1();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtidproducto = new System.Windows.Forms.TextBox();
            this.txtproducto = new System.Windows.Forms.TextBox();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btnimprimir = new System.Windows.Forms.Button();
            this.bntventas = new System.Windows.Forms.Button();
            this.btncredito = new System.Windows.Forms.Button();
            this.btndetallecredito = new System.Windows.Forms.Button();
            this.btnpagos = new System.Windows.Forms.Button();
            this.comboBoxmarca = new System.Windows.Forms.ComboBox();
            this.comboBoxstock = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnguardarc = new System.Windows.Forms.Button();
            this.btneliminarc = new System.Windows.Forms.Button();
            this.btnmodificarc = new System.Windows.Forms.Button();
            this.txtidcliente = new System.Windows.Forms.TextBox();
            this.txtcliente = new System.Windows.Forms.TextBox();
            this.txtCI = new System.Windows.Forms.TextBox();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(84, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "IDproducto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(201, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Nombre";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(715, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "stock";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(481, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Precio";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(307, 145);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "descripcion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 69.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(308, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 105);
            this.label1.TabIndex = 36;
            this.label1.Text = "ROHO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(595, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "marca";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(75, 210);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(673, 204);
            this.dataGridView1.TabIndex = 40;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // txtidproducto
            // 
            this.txtidproducto.Location = new System.Drawing.Point(87, 176);
            this.txtidproducto.Name = "txtidproducto";
            this.txtidproducto.Size = new System.Drawing.Size(83, 20);
            this.txtidproducto.TabIndex = 41;
            // 
            // txtproducto
            // 
            this.txtproducto.Location = new System.Drawing.Point(204, 176);
            this.txtproducto.Name = "txtproducto";
            this.txtproducto.Size = new System.Drawing.Size(83, 20);
            this.txtproducto.TabIndex = 42;
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(310, 176);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(83, 20);
            this.txtdescripcion.TabIndex = 43;
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(475, 176);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(83, 20);
            this.txtprecio.TabIndex = 44;
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(87, 432);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(75, 23);
            this.btnguardar.TabIndex = 48;
            this.btnguardar.Text = "GUARDAR";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(231, 432);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(75, 23);
            this.btneliminar.TabIndex = 49;
            this.btneliminar.Text = "ELIMINAR";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(376, 432);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(75, 23);
            this.btnmodificar.TabIndex = 50;
            this.btnmodificar.Text = "MODIFICAR";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(530, 432);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 23);
            this.btnbuscar.TabIndex = 51;
            this.btnbuscar.Text = "BUSCAR";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // btnimprimir
            // 
            this.btnimprimir.Location = new System.Drawing.Point(673, 432);
            this.btnimprimir.Name = "btnimprimir";
            this.btnimprimir.Size = new System.Drawing.Size(75, 23);
            this.btnimprimir.TabIndex = 52;
            this.btnimprimir.Text = "IMPRIMIR";
            this.btnimprimir.UseVisualStyleBackColor = true;
            this.btnimprimir.Click += new System.EventHandler(this.btnimprimir_Click);
            // 
            // bntventas
            // 
            this.bntventas.Location = new System.Drawing.Point(754, 210);
            this.bntventas.Name = "bntventas";
            this.bntventas.Size = new System.Drawing.Size(127, 30);
            this.bntventas.TabIndex = 53;
            this.bntventas.Text = "VENTA";
            this.bntventas.UseVisualStyleBackColor = true;
            this.bntventas.Click += new System.EventHandler(this.bntventas_Click);
            // 
            // btncredito
            // 
            this.btncredito.Location = new System.Drawing.Point(754, 246);
            this.btncredito.Name = "btncredito";
            this.btncredito.Size = new System.Drawing.Size(127, 29);
            this.btncredito.TabIndex = 55;
            this.btncredito.Text = "CREDITO";
            this.btncredito.UseVisualStyleBackColor = true;
            this.btncredito.Click += new System.EventHandler(this.btncredito_Click);
            // 
            // btndetallecredito
            // 
            this.btndetallecredito.Location = new System.Drawing.Point(754, 345);
            this.btndetallecredito.Name = "btndetallecredito";
            this.btndetallecredito.Size = new System.Drawing.Size(127, 33);
            this.btndetallecredito.TabIndex = 56;
            this.btndetallecredito.Text = "DETALLECREDITO";
            this.btndetallecredito.UseVisualStyleBackColor = true;
            this.btndetallecredito.Click += new System.EventHandler(this.btndetallecredito_Click);
            // 
            // btnpagos
            // 
            this.btnpagos.Location = new System.Drawing.Point(754, 384);
            this.btnpagos.Name = "btnpagos";
            this.btnpagos.Size = new System.Drawing.Size(127, 30);
            this.btnpagos.TabIndex = 57;
            this.btnpagos.Text = "PAGOS";
            this.btnpagos.UseVisualStyleBackColor = true;
            // 
            // comboBoxmarca
            // 
            this.comboBoxmarca.FormattingEnabled = true;
            this.comboBoxmarca.Location = new System.Drawing.Point(598, 176);
            this.comboBoxmarca.Name = "comboBoxmarca";
            this.comboBoxmarca.Size = new System.Drawing.Size(74, 21);
            this.comboBoxmarca.TabIndex = 58;
            // 
            // comboBoxstock
            // 
            this.comboBoxstock.FormattingEnabled = true;
            this.comboBoxstock.Location = new System.Drawing.Point(718, 176);
            this.comboBoxstock.Name = "comboBoxstock";
            this.comboBoxstock.Size = new System.Drawing.Size(66, 21);
            this.comboBoxstock.TabIndex = 59;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(897, 210);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(416, 204);
            this.dataGridView2.TabIndex = 60;
            this.dataGridView2.SelectionChanged += new System.EventHandler(this.dataGridView2_SelectionChanged);
            // 
            // btnguardarc
            // 
            this.btnguardarc.Location = new System.Drawing.Point(897, 176);
            this.btnguardarc.Name = "btnguardarc";
            this.btnguardarc.Size = new System.Drawing.Size(75, 23);
            this.btnguardarc.TabIndex = 61;
            this.btnguardarc.Text = "GUARDAR";
            this.btnguardarc.UseVisualStyleBackColor = true;
            this.btnguardarc.Click += new System.EventHandler(this.btnguardarc_Click);
            // 
            // btneliminarc
            // 
            this.btneliminarc.Location = new System.Drawing.Point(1056, 176);
            this.btneliminarc.Name = "btneliminarc";
            this.btneliminarc.Size = new System.Drawing.Size(75, 23);
            this.btneliminarc.TabIndex = 62;
            this.btneliminarc.Text = "ELIMINAR";
            this.btneliminarc.UseVisualStyleBackColor = true;
            // 
            // btnmodificarc
            // 
            this.btnmodificarc.Location = new System.Drawing.Point(1201, 176);
            this.btnmodificarc.Name = "btnmodificarc";
            this.btnmodificarc.Size = new System.Drawing.Size(75, 23);
            this.btnmodificarc.TabIndex = 63;
            this.btnmodificarc.Text = "MODIFICAR";
            this.btnmodificarc.UseVisualStyleBackColor = true;
            // 
            // txtidcliente
            // 
            this.txtidcliente.Location = new System.Drawing.Point(897, 61);
            this.txtidcliente.Name = "txtidcliente";
            this.txtidcliente.Size = new System.Drawing.Size(100, 20);
            this.txtidcliente.TabIndex = 64;
            // 
            // txtcliente
            // 
            this.txtcliente.Location = new System.Drawing.Point(897, 101);
            this.txtcliente.Name = "txtcliente";
            this.txtcliente.Size = new System.Drawing.Size(100, 20);
            this.txtcliente.TabIndex = 65;
            // 
            // txtCI
            // 
            this.txtCI.Location = new System.Drawing.Point(897, 138);
            this.txtCI.Name = "txtCI";
            this.txtCI.Size = new System.Drawing.Size(100, 20);
            this.txtCI.TabIndex = 66;
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(1160, 61);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(100, 20);
            this.txtdireccion.TabIndex = 67;
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(1160, 108);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(100, 20);
            this.txttelefono.TabIndex = 68;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(848, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 69;
            this.label4.Text = "ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(839, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 70;
            this.label5.Text = "nombre";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(865, 141);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 13);
            this.label11.TabIndex = 71;
            this.label11.Text = "Ci";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1081, 61);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 13);
            this.label12.TabIndex = 72;
            this.label12.Text = "direccion";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1086, 111);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 13);
            this.label13.TabIndex = 73;
            this.label13.Text = "telefono";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(72, 115);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 74;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(880, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(313, 33);
            this.label14.TabIndex = 75;
            this.label14.Text = "REGISTRO CLIENTE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 496);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.txtCI);
            this.Controls.Add(this.txtcliente);
            this.Controls.Add(this.txtidcliente);
            this.Controls.Add(this.btnmodificarc);
            this.Controls.Add(this.btneliminarc);
            this.Controls.Add(this.btnguardarc);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.comboBoxstock);
            this.Controls.Add(this.comboBoxmarca);
            this.Controls.Add(this.btnpagos);
            this.Controls.Add(this.btndetallecredito);
            this.Controls.Add(this.btncredito);
            this.Controls.Add(this.bntventas);
            this.Controls.Add(this.btnimprimir);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.txtproducto);
            this.Controls.Add(this.txtidproducto);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private System.Windows.Forms.TextBox txtidproducto;
        private System.Windows.Forms.TextBox txtproducto;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button btnimprimir;
        private System.Windows.Forms.Button bntventas;
        private System.Windows.Forms.Button btncredito;
        private System.Windows.Forms.Button btndetallecredito;
        private System.Windows.Forms.Button btnpagos;
        private System.Windows.Forms.ComboBox comboBoxmarca;
        private System.Windows.Forms.ComboBox comboBoxstock;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnguardarc;
        private System.Windows.Forms.Button btneliminarc;
        private System.Windows.Forms.Button btnmodificarc;
        private System.Windows.Forms.TextBox txtidcliente;
        private System.Windows.Forms.TextBox txtcliente;
        private System.Windows.Forms.TextBox txtCI;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label14;
    }
}

