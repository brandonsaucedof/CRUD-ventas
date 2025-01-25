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
    public partial class CompraFR : Form
    {
        private Conexion conexion;

        public CompraFR()
        {
            InitializeComponent();
            conexion = new Conexion();
            CargarListaidcliente();
            MostrarDatoscredito();
            dataGridViewCompra.SelectionChanged += DataGridViewCompra_SelectionChanged;
        }
        private void CargarListaidcliente()
        {
            try
            {
                string consulta = "SELECT ventaId FROM venta";
                DataSet data = conexion.LlenarDatos(consulta);

                if (data.Tables[0].Rows.Count > 0)
                {
                    Comboxidcliente.DataSource = data.Tables[0];
                    
                    Comboxidcliente.ValueMember = "ventaId";
                }
                else
                {
                    MessageBox.Show("No hay VENTAS registrados.");
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
                DateTime fechacredito = dateTimePickerFecha.Value;
                
                decimal totaldeuda = decimal.Parse(txttotaldeuda.Text);

                if (Comboxidcliente.SelectedValue != null && int.TryParse(Comboxidcliente.SelectedValue.ToString(), out int idcliente))
                {

                    if (int.TryParse(txtcredito.Text, out int idcredito))
                    {
                        string consulta = $"INSERT INTO credito (creditoId, Fechavencimiento,  ventaid , montototal) VALUES ({idcredito}, '{fechacredito.ToShortDateString()}', {idcliente},{totaldeuda})";
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

            txtcredito.Clear();
            dateTimePickerFecha.Value = DateTime.Now;
            
            Comboxidcliente.SelectedIndex = -1; 
        }
        private void MostrarDatoscredito()
        {
            try
            {
                string consulta = "SELECT creditoId, Fechavencimiento,  ventaid, montototal FROM credito";
                DataSet data = conexion.LlenarDatos(consulta);
                if (data.Tables[0].Rows.Count > 0)
                {
                    dataGridViewCompra.DataSource = data.Tables[0];
                }
                else
                {
                    MessageBox.Show("No hay CREDITOS registradas.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private void DataGridViewCompra_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewCompra.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dataGridViewCompra.SelectedRows[0];

                txtcredito.Text = filaSeleccionada.Cells["creditoid"].Value.ToString();
                dateTimePickerFecha.Value = Convert.ToDateTime(filaSeleccionada.Cells["Fechavencimiento"].Value);
                



                int idcliente = Convert.ToInt32(filaSeleccionada.Cells["ventaid"].Value);
                Comboxidcliente.SelectedValue = idcliente;
                txttotaldeuda.Text = filaSeleccionada.Cells["montototal"].Value.ToString(); 
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {

                if (dataGridViewCompra.SelectedRows.Count > 0)
                {
                    int idcredito = Convert.ToInt32(dataGridViewCompra.SelectedRows[0].Cells["Id"].Value);
                    string consulta = $"DELETE FROM credito WHERE creditoId = {idcredito}";

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

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewCompra.SelectedRows.Count > 0)
                {
                    int idCredito = Convert.ToInt32(dataGridViewCompra.SelectedRows[0].Cells["creditoId"].Value);
                    decimal montototal = decimal.Parse(txttotaldeuda.Text);
                    DateTime nuevaFechaCompra = dateTimePickerFecha.Value;
                    
                    if (Comboxidcliente.SelectedValue != null && int.TryParse(Comboxidcliente.SelectedValue.ToString(), out int idventa))
                    {
                        string consulta = $"UPDATE credito SET Fechavencimiento = '{nuevaFechaCompra.ToShortDateString()}', ventaid = {idventa} WHERE Id = {idCredito},montotal={montototal}";
                        bool exito = conexion.EjecutarComando(consulta);

                        if (exito)
                        {
                            MessageBox.Show("Compra actualizada exitosamente.");
                            MostrarDatoscredito(); 
                            LimpiarControles(); 
                        }
                        else
                        {
                            MessageBox.Show("Error al actualizar la compra.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Por favor, seleccione un proveedor válido.");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione una compra para editar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void Comboxidcliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewCompra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
