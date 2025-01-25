
namespace ProyMaestroDetalle
{
    partial class CompraFR
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.dataGridViewCompra = new System.Windows.Forms.DataGridView();
            this.txtcredito = new System.Windows.Forms.TextBox();
            this.dateTimePickerFecha = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Comboxidcliente = new System.Windows.Forms.ComboBox();
            this.txttotaldeuda = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Id Compra:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(230, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 42);
            this.label1.TabIndex = 15;
            this.label1.Text = "Agregar credito";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(104, 212);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(132, 40);
            this.BtnAgregar.TabIndex = 12;
            this.BtnAgregar.Text = "BtnAgregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Location = new System.Drawing.Point(487, 212);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(132, 40);
            this.BtnActualizar.TabIndex = 11;
            this.BtnActualizar.Text = "BtnActualizar";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(303, 212);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(132, 40);
            this.BtnEliminar.TabIndex = 10;
            this.BtnEliminar.Text = "BtnEliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // dataGridViewCompra
            // 
            this.dataGridViewCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCompra.Location = new System.Drawing.Point(104, 279);
            this.dataGridViewCompra.Name = "dataGridViewCompra";
            this.dataGridViewCompra.Size = new System.Drawing.Size(573, 227);
            this.dataGridViewCompra.TabIndex = 9;
            this.dataGridViewCompra.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCompra_CellContentClick);
            // 
            // txtcredito
            // 
            this.txtcredito.Location = new System.Drawing.Point(209, 73);
            this.txtcredito.Multiline = true;
            this.txtcredito.Name = "txtcredito";
            this.txtcredito.Size = new System.Drawing.Size(226, 28);
            this.txtcredito.TabIndex = 19;
            // 
            // dateTimePickerFecha
            // 
            this.dateTimePickerFecha.Location = new System.Drawing.Point(209, 107);
            this.dateTimePickerFecha.Name = "dateTimePickerFecha";
            this.dateTimePickerFecha.Size = new System.Drawing.Size(226, 20);
            this.dateTimePickerFecha.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(163, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Fecha:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(134, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "id cliente:";
            // 
            // Comboxidcliente
            // 
            this.Comboxidcliente.FormattingEnabled = true;
            this.Comboxidcliente.Location = new System.Drawing.Point(209, 133);
            this.Comboxidcliente.Name = "Comboxidcliente";
            this.Comboxidcliente.Size = new System.Drawing.Size(226, 21);
            this.Comboxidcliente.TabIndex = 23;
            this.Comboxidcliente.SelectedIndexChanged += new System.EventHandler(this.Comboxidcliente_SelectedIndexChanged);
            // 
            // txttotaldeuda
            // 
            this.txttotaldeuda.Location = new System.Drawing.Point(209, 160);
            this.txttotaldeuda.Multiline = true;
            this.txttotaldeuda.Name = "txttotaldeuda";
            this.txttotaldeuda.Size = new System.Drawing.Size(226, 28);
            this.txttotaldeuda.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(126, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "total deuda";
            // 
            // CompraFR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 518);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txttotaldeuda);
            this.Controls.Add(this.Comboxidcliente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePickerFecha);
            this.Controls.Add(this.txtcredito);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.dataGridViewCompra);
            this.Name = "CompraFR";
            this.Text = "CompraFR";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.DataGridView dataGridViewCompra;
        private System.Windows.Forms.TextBox txtcredito;
        private System.Windows.Forms.DateTimePicker dateTimePickerFecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Comboxidcliente;
        private System.Windows.Forms.TextBox txttotaldeuda;
        private System.Windows.Forms.Label label6;
    }
}