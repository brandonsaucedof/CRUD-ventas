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
    public partial class Form2 : Form
    {
        private Conexion conexion;

        public Form2()
        {
            InitializeComponent();
            conexion = new Conexion();
            CargarListaIdCliente();
            MostrarDatosPago();
            dataGridViewPagos.SelectionChanged += DataGridViewPagos_SelectionChanged;
        }

        private void CargarListaIdCliente()
        {
            try
            {
                string consulta = "SELECT Id FROM credito";
                DataSet data = conexion.LlenarDatos(consulta);

                if (data.Tables[0].Rows.Count > 0)
                {
                    comboBoxidcredito.DataSource = data.Tables[0]; // Comentado para deshabilitar esta línea
                                                                   // Comentado para deshabilitar esta línea
                    comboBoxidcredito.ValueMember = "Id"; // Comentado para deshabilitar esta línea
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



        private void LimpiarControles()
        {
            txtPago.Clear();
            dateTimePickerFecha.Value = DateTime.Now;
            txtPago.Clear();
            txtsaldo.Clear(); // Cambiar el nombre del campo a "txtsaldo"
            txtMonto.Clear();
        }

        private void MostrarDatosPago()
        {
            try
            {
                string consulta = "SELECT Id, Fecha, Idcredito, NroPago, Monto, Saldo FROM Pagos";
                DataSet data = conexion.LlenarDatos(consulta);

                if (data.Tables[0].Rows.Count > 0)
                {
                    dataGridViewPagos.DataSource = data.Tables[0];
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

        private void DataGridViewPagos_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewPagos.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dataGridViewPagos.SelectedRows[0];

                txtid.Text = filaSeleccionada.Cells["Id"].Value.ToString();
                dateTimePickerFecha.Value = Convert.ToDateTime(filaSeleccionada.Cells["Fecha"].Value);

                int idcredito = Convert.ToInt32(filaSeleccionada.Cells["Idcredito"].Value);
                comboBoxidcredito.SelectedValue = idcredito;
                txtsaldo.Text = filaSeleccionada.Cells["saldo"].Value.ToString();
                txtPago.Text = filaSeleccionada.Cells["nropago"].Value.ToString();
                txtMonto.Text = filaSeleccionada.Cells["monto"].Value.ToString();
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewPagos.SelectedRows.Count > 0)
                {
                    int idPago = Convert.ToInt32(dataGridViewPagos.SelectedRows[0].Cells["Id"].Value);

                    string consulta = $"DELETE FROM Pagos WHERE Id = {idPago}";

                    bool exito = conexion.EjecutarComando(consulta);

                    if (exito)
                    {
                        MessageBox.Show("Pago eliminado exitosamente.");
                        MostrarDatosPago();
                        LimpiarControles();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el pago.");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un pago para eliminar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
          
        }

        private void Comboxidcliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Código relacionado al ComboBox si es necesario.
        }

        private void CompraFR_Load(object sender, EventArgs e)
        {
            // Código de inicialización del formulario.
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Manejo de eventos del label si es necesario.
        }

        private void BtnAgregar_Click_1(object sender, EventArgs e)
        {
            
        }

        private void BtnEliminar_Click_1(object sender, EventArgs e)
        {
        
        }

        private void BtnActualizar_Click_1(object sender, EventArgs e)
        {
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fechaPago = dateTimePickerFecha.Value;
                int Pago = int.Parse(txtPago.Text);
                decimal monto = decimal.Parse(txtMonto.Text);
                decimal saldo = decimal.Parse(txtsaldo.Text);
                if (comboBoxidcredito.SelectedValue != null && int.TryParse(comboBoxidcredito.SelectedValue.ToString(), out int idcredito))
                {
                    if (int.TryParse(txtid.Text, out int idpago)) // Cambiar el nombre del campo a "txtsaldo"
                    {
                        string consulta = $"INSERT INTO Pagos (Id, Fecha, IdCredito,nropago,monto,saldo) VALUES ({idpago}, '{fechaPago.ToString("yyyy-MM-dd")}', {idcredito},{Pago}, {monto},{saldo})";

                        bool exito = conexion.EjecutarComando(consulta);

                        if (exito)
                        {
                            MessageBox.Show("Pago agregado exitosamente.");
                            MostrarDatosPago();
                            LimpiarControles();
                        }
                        else
                        {
                            MessageBox.Show("Error al agregar el pago.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Por favor, ingrese un valor válido para el saldo (IdCredito).");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un valor válido para IdPago.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void BtnEliminar_Click_2(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewPagos.SelectedRows.Count > 0)
                {
                    int idPago = Convert.ToInt32(dataGridViewPagos.SelectedRows[0].Cells["Id"].Value);

                    string consulta = $"DELETE FROM Pagos WHERE Id = {idPago}";

                    bool exito = conexion.EjecutarComando(consulta);

                    if (exito)
                    {
                        MessageBox.Show("Pago eliminado exitosamente.");
                        MostrarDatosPago();
                        LimpiarControles();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el pago.");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un pago para eliminar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void BtnActualizar_Click_2(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewPagos.SelectedRows.Count > 0)
                {
                    int idPago = Convert.ToInt32(dataGridViewPagos.SelectedRows[0].Cells["Id"].Value);

                    DateTime nuevaFechaPago = dateTimePickerFecha.Value;
                    if (comboBoxidcredito.SelectedValue != null && int.TryParse(comboBoxidcredito.SelectedValue.ToString(), out int idcredito))
                    {
                        decimal nuevoMonto = decimal.Parse(txtMonto.Text);
                        decimal nuevopago = decimal.Parse(txtPago.Text);
                        decimal nuevosaldo = decimal.Parse(txtsaldo.Text);
                        string consulta = $"UPDATE Pagos SET Fecha = '{nuevaFechaPago.ToString("yyyy-MM-dd")}', IdCredito = {idcredito},nropago ={nuevopago}, Monto = {nuevoMonto},saldo = {nuevosaldo} WHERE Id = {idPago}";

                        bool exito = conexion.EjecutarComando(consulta);

                        if (exito)
                        {
                            MessageBox.Show("Pago actualizado exitosamente.");
                            MostrarDatosPago();
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
    }
}