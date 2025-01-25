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
    public partial class provedorFR : Form
    {
        private Conexion conexion;

        public provedorFR()
        {
            InitializeComponent();
            conexion = new Conexion();
            CargarListaidcliente();
            CargarListaidcliente1();
            CargarListaidcliente2();
            MostrarDatoscredito();
            dataGridViewprovedor.SelectionChanged += DataGridViewCompra_SelectionChanged;
        }
        private void CargarListaidcliente()
        {
            try
            {
                string consulta = "SELECT detallecreditoId FROM detallecredito";
                DataSet data = conexion.LlenarDatos(consulta);

                if (data.Tables[0].Rows.Count > 0)
                {
                    Comboxidcredito.DataSource = data.Tables[0];
                    
                    Comboxidcredito.ValueMember = "detallecreditoId";
                }
                else
                {
                    MessageBox.Show("No hay detalles de creditos registrados.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void CargarListaidcliente1()
        {
            try
            {
                string consulta = "SELECT productoId  FROM producto";
                DataSet data = conexion.LlenarDatos(consulta);

                if (data.Tables[0].Rows.Count > 0)
                {
                    comBoxidproducto.DataSource = data.Tables[0];
                    comBoxidproducto.ValueMember = "productoId";


                }
                else
                {
                    MessageBox.Show("No hay productos registrados.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private void CargarListaidcliente2()
        {
            try
            {
                string consulta = "SELECT creditoId  FROM credito";
                DataSet data = conexion.LlenarDatos(consulta);

                if (data.Tables[0].Rows.Count > 0)
                {
                    comboBoxidventa.DataSource = data.Tables[0];
                    comboBoxidventa.ValueMember = "creditoId";


                }
                else
                {
                    MessageBox.Show("No hay creditos registrados.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private void BtnAgregar_Click_1(object sender, EventArgs e)
        {
            try
            {
                int cantidad = int.Parse(txtcantidad.Text);
                decimal precio = decimal.Parse(txtprecio.Text);
                

                if (Comboxidcredito.SelectedValue != null && int.TryParse(Comboxidcredito.SelectedValue.ToString(), out int iddetallecredito) && (comBoxidproducto.SelectedValue != null && int.TryParse(comBoxidproducto.SelectedValue.ToString(), out int Idproducto)) && (comboBoxidventa.SelectedValue != null && int.TryParse(comboBoxidventa.SelectedValue.ToString(), out int Idcredito)))
                {


                    
                    string consulta = $"INSERT INTO detallecredito (detallecreditoid,creditoId, productoId, cantidad , precio ) VALUES ({iddetallecredito},{Idcredito}, '{Idproducto}', {cantidad},{precio})";
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



            txtprecio.Clear();
            txtcantidad.Clear();
            
            Comboxidcredito.SelectedIndex = -1;
            comBoxidproducto.SelectedIndex = -1;
            comboBoxidventa.SelectedIndex = -1;

        }
        private void MostrarDatoscredito()
        {
            try
            {
                string consulta = "SELECT detallecreditoid,creditoId,productoId,cantidad,preciounitario FROM detallecredito";
                DataSet data = conexion.LlenarDatos(consulta);
                if (data.Tables[0].Rows.Count > 0)
                {
                    dataGridViewprovedor.DataSource = data.Tables[0];
                }
                else
                {
                    MessageBox.Show("No hay que mostrar registradas.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void DataGridViewCompra_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewprovedor.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dataGridViewprovedor.SelectedRows[0];



                txtprecio.Text = filaSeleccionada.Cells["preciounitario"].Value.ToString();
                txtcantidad.Text = filaSeleccionada.Cells["cantidad"].Value.ToString();


                int iddetallecredito = Convert.ToInt32(filaSeleccionada.Cells["detallecreditoid"].Value);
                Comboxidcredito.SelectedValue = iddetallecredito;
                int idproducto = Convert.ToInt32(filaSeleccionada.Cells["productoId"].Value);
                Comboxidcredito.SelectedValue = idproducto;
                int idcredito = Convert.ToInt32(filaSeleccionada.Cells["creditoid"].Value);
                comboBoxidventa.SelectedValue = idcredito;
            }
        }

        private void BtnEliminar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewprovedor.SelectedRows.Count > 0)
                {
                    int iddetallecredito = Convert.ToInt32(dataGridViewprovedor.SelectedRows[0].Cells["detallecreditoId"].Value);
                    string consulta = $"DELETE FROM detallecredito WHERE detallecreditoId = {iddetallecredito}";
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

        private void BtnActualizar_Click_1(object sender, EventArgs e)
        {
            
                try
                {
                    if (dataGridViewprovedor.SelectedRows.Count > 0)
                    {
                        int iddetallecredito = Convert.ToInt32(dataGridViewprovedor.SelectedRows[0].Cells["detallecreditoId"].Value);

                        if (decimal.TryParse(txtprecio.Text, out decimal precio) && int.TryParse(txtcantidad.Text, out int cantidad))
                        {
                            if (Comboxidcredito.SelectedValue != null && int.TryParse(Comboxidcredito.SelectedValue.ToString(), out int Iddetallecredito) && (comBoxidproducto.SelectedValue != null && int.TryParse(comBoxidproducto.SelectedValue.ToString(), out int Idproducto)) && (comboBoxidventa.SelectedValue != null && int.TryParse(comboBoxidventa.SelectedValue.ToString(), out int idcredito)))
                        {
                                string consulta = $"UPDATE detallecredito SET cantidad ={cantidad},preciounitario = {precio} WHERE detallecreditoId = {iddetallecredito}, creditoid = {idcredito},productoid = {Idproducto}";
                                bool exito = conexion.EjecutarComando(consulta);

                                if (exito)
                                {
                                    MessageBox.Show("Crédito actualizado exitosamente.");
                                    MostrarDatoscredito();
                                    LimpiarControles();
                                }
                                else
                                {
                                    MessageBox.Show("Error al actualizar el crédito.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Por favor, seleccione un crédito válido.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Por favor, ingrese precios y montos válidos.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Por favor, seleccione un crédito para editar.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }

       


    }
}
