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
    public partial class FBuscarProducto : Form
    {
        public FBuscarProducto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet data = new DataSet();
            Conexion c = new Conexion();
            string cadena = "";
            if (this.textBox1.Text != "")
            {
                if (this.radioButton1.Checked == true)
                {
                    cadena = "select id,nombre,pventa,stock from producto where id=" + this.textBox1.Text;
                }
                else
                {
                    cadena = "select id,nombre,pventa,stock from producto where nombre like '%" + this.textBox1.Text + "%'";
                }
                data = c.LlenarDatos(cadena);
                if (data.Tables[0].Rows.Count > 0)
                    this.dataGridView1.DataSource = data.Tables[0];
                else
                    MessageBox.Show("No hay Datos");
            }

            else
                MessageBox.Show("Debe escribir el texto a buscar");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.dataGridView1.DataSource = null;
            this.dataGridView1.Refresh();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            string i;
            string n;
            string p;
            i = this.dataGridView1.Rows[this.dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
            n = this.dataGridView1.Rows[this.dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
            p = this.dataGridView1.Rows[this.dataGridView1.CurrentRow.Index].Cells["pventa"].Value.ToString();


            Form1.id = i;
            Form1.nproducto = n;
            Form1.precio = p;

         
            this.Close();
        }
    }
}
