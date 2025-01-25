using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyMaestroDetalle
{
    public partial class venta : Form
    {
        private Conexion conexion;

        public venta()
        {
            InitializeComponent();
            conexion = new Conexion();
            CargarListaClientes();
            MostrarDatosVentas();
            dataGridViewVentas.SelectionChanged += DataGridViewVentas_SelectionChanged;
        }


        private void CargarListaClientes()
        {
            try
            {
                string consulta = "SELECT ClienteID, Nombre FROM Cliente";
                DataSet data = conexion.LlenarDatos(consulta);

                if (data.Tables[0].Rows.Count > 0)
                {
                    ComboxCliente.DataSource = data.Tables[0];
                    ComboxCliente.ValueMember = "ClienteID";
                    ComboxCliente.DisplayMember = "Nombre";
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

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fecha = dateTimePickerFecha.Value;

                if (ComboxCliente.SelectedValue != null && int.TryParse(ComboxCliente.SelectedValue.ToString(), out int idCliente))
                {
                    if (int.TryParse(txtVentaID.Text, out int idVenta))
                    {
                        if (int.TryParse(txtProductoID.Text, out int idProducto) &&
                            int.TryParse(txtCantidad.Text, out int cantidad) &&
                            decimal.TryParse(txtPrecioUnitario.Text, out decimal precioUnitario) &&
                            decimal.TryParse(txtPrecioTotal.Text, out decimal precioTotal))
                        {
                            string fechaFormateada = fecha.ToString("yyyy-MM-dd"); // Formatea la fecha como 'YYYY-MM-DD'

                            string consulta = $"INSERT INTO Venta (VentaID, fecha, ClienteID, ProductoID, Cantidad, PrecioUnitario, PrecioTotal) " +
                                             $"VALUES ({idVenta}, '{fechaFormateada}', {idCliente}, {idProducto}, {cantidad}, {precioUnitario}, {precioTotal})";

                            bool exito = conexion.EjecutarComando(consulta);

                            if (exito)
                            {
                                MessageBox.Show("Venta agregada exitosamente.");
                                MostrarDatosVentas();
                                LimpiarControles();
                            }
                            else
                            {
                                MessageBox.Show("Error al agregar la venta.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Por favor, ingrese valores válidos para los campos de Producto, Cantidad, Precio Unitario y Precio Total.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Por favor, ingrese un valor válido para el ID de Venta.");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un cliente válido.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }


        private void LimpiarControles()
        {
            txtVentaID.Clear();
            dateTimePickerFecha.Value = DateTime.Now;
            ComboxCliente.SelectedIndex = -1;
        }

        private void MostrarDatosVentas()
        {
            try
            {
                string consulta = "SELECT VentaID, fecha, ClienteID, ProductoID, Cantidad, PrecioUnitario, PrecioTotal FROM Venta";
                DataSet data = conexion.LlenarDatos(consulta);

                if (data.Tables[0].Rows.Count > 0)
                {
                    dataGridViewVentas.DataSource = data.Tables[0];

                    // Configura las columnas del DataGridView para ajustarse automáticamente
                    dataGridViewVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    dataGridViewVentas.AutoResizeColumns();
                }
                else
                {
                    MessageBox.Show("No hay ventas registradas.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }


        private void BtnEliminar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewVentas.SelectedRows.Count > 0)
                {
                    int idVenta = Convert.ToInt32(dataGridViewVentas.SelectedRows[0].Cells["VentaID"].Value);
                    string consulta = $"DELETE FROM Venta WHERE VentaID = {idVenta}";

                    bool exito = conexion.EjecutarComando(consulta);

                    if (exito)
                    {
                        MessageBox.Show("Venta eliminada exitosamente.");
                        MostrarDatosVentas();
                        LimpiarControles();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar la venta.");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione una venta para eliminar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }


        private void BtnActualizar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewVentas.SelectedRows.Count > 0)
                {
                    int idVenta = Convert.ToInt32(dataGridViewVentas.SelectedRows[0].Cells["VentaID"].Value);
                    DateTime nuevaFecha = dateTimePickerFecha.Value;

                    if (ComboxCliente.SelectedValue != null && int.TryParse(ComboxCliente.SelectedValue.ToString(), out int idCliente))
                    {
                        string fechaFormateada = nuevaFecha.ToString("yyyy-MM-dd"); // Formatea la fecha como 'YYYY-MM-DD'

                        string consulta = $"UPDATE Venta SET fecha = '{fechaFormateada}', ClienteID = {idCliente} WHERE VentaID = {idVenta}";

                        bool exito = conexion.EjecutarComando(consulta);

                        if (exito)
                        {
                            MessageBox.Show("Venta actualizada exitosamente.");
                            MostrarDatosVentas();
                            LimpiarControles();
                        }
                        else
                        {
                            MessageBox.Show("Error al actualizar la venta.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Por favor, seleccione un cliente válido.");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione una venta para editar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }


        private void DataGridViewVentas_SelectionChanged(object sender, EventArgs e)
        {
           
        }



        private void CalcularPrecioTotal()
        {
            if (int.TryParse(txtCantidad.Text, out int cantidad) && decimal.TryParse(txtPrecioUnitario.Text, out decimal precioUnitario))
            {
                decimal precioTotal = cantidad * precioUnitario;
                txtPrecioTotal.Text = precioTotal.ToString("0"); // Ajusta el formato según tus necesidades
            }
            else
            {
                txtPrecioTotal.Text = ""; // Borra el valor si la cantidad o el precio no son válidos
            }
        }

        private void txtCantidad_TextChanged_1(object sender, EventArgs e)
        {
            CalcularPrecioTotal();
        }

        private void txtPrecioUnitario_TextChanged_1(object sender, EventArgs e)
        {
            CalcularPrecioTotal();
        }

        private decimal ObtenerPrecioUnitario(string consulta)
        {
            decimal precioUnitario = 0;

            try
            {
                using (SqlConnection conexion = new SqlConnection("Server=DESKTOP-00GNGBR;Database=Roho;Integrated Security=True"))
                {
                    conexion.Open();

                    using (SqlCommand cmd = new SqlCommand(consulta, conexion))
                    {
                        object result = cmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            precioUnitario = Convert.ToDecimal(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener el precio unitario: {ex.Message}");
            }

            return precioUnitario;
        }

        private void txtProductoID_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtProductoID.Text, out int ProductoId))
            {
                // Realiza una consulta a la base de datos para obtener el precio del producto
                string consulta = $"SELECT Precio FROM Producto WHERE ProductoID = {ProductoId}";
                decimal precioUnitario = ObtenerPrecioUnitario(consulta);

                // Muestra el precio unitario en el cuadro de texto
                txtPrecioUnitario.Text = precioUnitario.ToString("0"); // Ajusta el formato según tus necesidades
            }
            else
            {
                txtPrecioUnitario.Text = ""; // Borra el valor si el ID del producto no es válido
            }
        }

    }


}
