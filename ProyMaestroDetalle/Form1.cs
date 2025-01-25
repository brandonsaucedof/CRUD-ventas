using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyMaestroDetalle
{
    public partial class Form1 : Form
    {
        private Conexion conexion;
        public static string id = "";
        public static string nproducto = "";
        public static string precio = "";
        public static string idventa = "";

        public Form1()
        {
            InitializeComponent();
            conexion = new Conexion();
            cargarlistaidmarca();
            cargarlistaidstock();
            MostrarDatoscredito();
            MostrarDatoscliente();
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MostrarDatoscredito();
            this.MostrarDatoscliente();
        }
        private void cargarlistaidstock()
        {
            try
            {
                string consulta = "SELECT stockId FROM producto";
                DataSet data = conexion.LlenarDatos(consulta);

                if (data.Tables[0].Rows.Count > 0)
                {
                    comboBoxstock.DataSource = data.Tables[0];
                    
                    comboBoxstock.ValueMember = "stockId";
                }
                else
                {
                    MessageBox.Show("No hay clientes registrados.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private void cargarlistaidmarca()
        {
            try
            {
                string consulta = "SELECT marcaId FROM producto";
                DataSet data = conexion.LlenarDatos(consulta);

                if (data.Tables[0].Rows.Count > 0)
                {
                    comboBoxmarca.DataSource = data.Tables[0];

                    comboBoxmarca.ValueMember = "marcaId";
                }
                else
                {
                    MessageBox.Show("No hay clientes registrados.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtproducto.Text;
                string descripcion = txtdescripcion.Text;                
                decimal precio = decimal.Parse(txtprecio.Text);
                

                if (comboBoxmarca.SelectedValue != null && int.TryParse(comboBoxmarca.SelectedValue.ToString(), out int idmarca) && comboBoxstock.SelectedValue != null && int.TryParse(comboBoxstock.SelectedValue.ToString(), out int idstock))
                {

                    if (int.TryParse(txtidproducto.Text, out int id))
                    {
                        string consulta = $"INSERT INTO producto (productoid, nombre, descripcion, precio, marcaid,stockid) VALUES ({id}, '{nombre}', '{descripcion}', {precio},{idmarca},{idstock})";

                        bool exito = conexion.EjecutarComando(consulta);

                        if (exito)
                        {
                            MessageBox.Show("credito agregada exitosamente.");
                            MostrarDatoscredito();
                            LimpiarControles();
                        }
                        else
                        {
                            MessageBox.Show("Error al agregar la compra.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Por favor, ingrese un valor válido para IdCompra.");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un proveedor válido.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }


        }
        private void LimpiarControles()
        {

            txtidproducto.Clear();            
            txtproducto.Clear();
            txtdescripcion.Clear();
            txtprecio.Clear();
            comboBoxmarca.SelectedIndex = -1;
            comboBoxstock.SelectedIndex = -1;
            txtidcliente.Clear();
            txtcliente.Clear();
            txtCI.Clear();
            txtdireccion.Clear();
            txttelefono.Clear();
        }
        private void MostrarDatoscredito()
        {
            try
            {
                string consulta = "SELECT Productoid,Nombre,Descripcion,Precio,MarcaId,StockId FROM Producto";
                DataSet data = conexion.LlenarDatos(consulta);

                if (data.Tables[0].Rows.Count > 0)
                {
                    dataGridView1.DataSource = data.Tables[0];
                }
                else
                {
                    MessageBox.Show("No hay pagos registrados.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

        }

        private void MostrarDatoscliente()
        {
            try
            {
                string consulta = "SELECT clienteid,Nombre,ci,direccion,telefono FROM cliente";
                DataSet data = conexion.LlenarDatos(consulta);

                if (data.Tables[0].Rows.Count > 0)
                {
                    dataGridView2.DataSource = data.Tables[0];
                }
                else
                {
                    MessageBox.Show("No hay pagos registrados.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dataGridView1.SelectedRows[0];

                txtidproducto.Text = filaSeleccionada.Cells["productoId"].Value.ToString();

                txtproducto.Text = filaSeleccionada.Cells["nombre"].Value.ToString();

                txtdescripcion.Text = filaSeleccionada.Cells["descripcion"].Value.ToString();
                txtprecio.Text = filaSeleccionada.Cells["precio"].Value.ToString();

                int idmarca = Convert.ToInt32(filaSeleccionada.Cells["marcaid"].Value);
                comboBoxmarca.SelectedValue = idmarca;
                int idstock = Convert.ToInt32(filaSeleccionada.Cells["stockid"].Value);
                comboBoxstock.SelectedValue = idstock;


            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {

                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["productoid"].Value);

                    string consulta = $"DELETE FROM Producto WHERE productoId = {id}";

                    bool exito = conexion.EjecutarComando(consulta);

                    if (exito)
                    {
                        MessageBox.Show("Compra eliminada exitosamente.");
                        MostrarDatoscredito();
                        LimpiarControles();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar la compra.");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione una compra para eliminar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["productoId"].Value);
                    string nuevonombre = txtproducto.Text;
                    string nuevodescripcion = txtdescripcion.Text;

                    decimal nuevoprecio = decimal.Parse(txtprecio.Text);


                    if (comboBoxmarca.SelectedValue != null && int.TryParse(comboBoxmarca.SelectedValue.ToString(), out int idmarca) && comboBoxstock.SelectedValue != null && int.TryParse(comboBoxstock.SelectedValue.ToString(), out int idstock))
                    {
                       
                        string consulta = $"UPDATE Producto SET  nombre = '{nuevonombre}',descripcion ='{nuevodescripcion}', precio = {nuevoprecio},marcaid = {idmarca} ,stockid = {idstock}WHERE productoId = {id}";

                        bool exito = conexion.EjecutarComando(consulta);

                        if (exito)
                        {
                            MessageBox.Show("Pago actualizado exitosamente.");
                            MostrarDatoscredito();
                            LimpiarControles();
                        }
                        else
                        {
                            MessageBox.Show("Error al actualizar el pago.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Por favor, seleccione un cliente válido (saldo).");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un pago para editar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            idventa = "";
            FBuscarVenta fbv = new FBuscarVenta();
            fbv.ShowDialog();
            if (idventa != "")
            {
                this.CargarVenta(idventa);
            }
        }
        private void CargarVenta(string idventa)
        {


        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {
            FImprimir fimpre = new FImprimir();
            fimpre.Imprimir(this.txtidproducto.Text);

        }

        private void btncredito_Click(object sender, EventArgs e)
        {
            try
            {
                CompraFR formularioCompra = new CompraFR();
                formularioCompra.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada2 = dataGridView2.SelectedRows[0];

                txtidcliente.Text = filaSeleccionada2.Cells["clienteId"].Value.ToString();
                txtcliente.Text = filaSeleccionada2.Cells["nombre"].Value.ToString();
                txtCI.Text = filaSeleccionada2.Cells["ci"].Value.ToString();
                txtdireccion.Text = filaSeleccionada2.Cells["direccion"].Value.ToString();
                txttelefono.Text = filaSeleccionada2.Cells["telefono"].Value.ToString();
            }
        }

        private void btnguardarc_Click(object sender, EventArgs e)
        {
            try
            {
                
                string nombre = txtcliente.Text;               
                int ci =int.Parse (txtCI.Text);
                string direccion = txtdireccion.Text;
                string telefono = txttelefono.Text;

                if (int.TryParse(txtidcliente.Text, out int id))
                    {
                        string consulta = $"INSERT INTO cliente (clienteid, nombre, ci, direccion, telefono) VALUES ({id}, '{nombre}', '{ci}', '{direccion}',{telefono})";

                        bool exito = conexion.EjecutarComando(consulta);

                        if (exito)
                        {
                            MessageBox.Show("credito agregada exitosamente.");
                            MostrarDatoscredito();
                            LimpiarControles();
                        }
                        else
                        {
                            MessageBox.Show("Error al agregar la compra.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Por favor, ingrese un valor válido para IdCompra.");
                    }
                
               
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

        }

        private void btndetallecredito_Click(object sender, EventArgs e)
        {
            try
            {
                provedorFR formularioproveedor = new provedorFR();
                formularioproveedor.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void bntventas_Click(object sender, EventArgs e)
        {
            try
            {
                venta formularioproveedor = new venta();
                formularioproveedor.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
