using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyMaestroDetalle
{
    public partial class FBuscarVenta : Form
    {
        public FBuscarVenta()
        {
            InitializeComponent();
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            if (this.radioButton2.Checked == true)
            {
                label3.Visible = true;
                label4.Visible = true;
                this.dateTimePicker1.Visible = true;
                this.dateTimePicker2.Visible =true;
                label1.Visible = false;
                label2.Visible = false;
                this.textBox1.Visible = false;
                this.textBox2.Visible = false;

                this.dataGridView1.DataSource = null;
                this.dataGridView1.Refresh();
            }
            else
            {
            }
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            if (this.radioButton1.Checked == true)
            {
                label3.Visible = false;
                label4.Visible = false;
                this.dateTimePicker1.Visible = false;
                this.dateTimePicker2.Visible = false;
                label1.Visible = true;
                label2.Visible = true;
                this.textBox1.Visible = true;
                this.textBox2.Visible = true;

                this.dataGridView1.DataSource = null;
                this.dataGridView1.Refresh();
            }
            else
            {
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet data = new DataSet();
            Conexion c = new Conexion();
            string cadena = "";
           
                if (this.radioButton1.Checked == true)
                {
                    cadena = "select id,fecha,cliente.nombre from venta inner join cliente on (venta.ci=cliente.ci) where id>=" + this.textBox1.Text+" and id<="+this.textBox2.Text;
                }
                else
                {
                    cadena = "select id,fecha,cliente.nombre from venta inner join cliente on (venta.ci=cliente.ci) where fecha between '" + this.dateTimePicker1.Value.ToShortDateString() + "' and '" + this.dateTimePicker2.Value.ToShortDateString()+"'";
                }
                data = c.LlenarDatos(cadena);
                if (data.Tables[0].Rows.Count > 0)
                    this.dataGridView1.DataSource = data.Tables[0];
                else
                    MessageBox.Show("No hay Datos");
           
            
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            string i;
            string n;
            string p;
            i = this.dataGridView1.Rows[this.dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
           


            Form1.idventa = i;
           


            this.Close();
        }
    }
}
