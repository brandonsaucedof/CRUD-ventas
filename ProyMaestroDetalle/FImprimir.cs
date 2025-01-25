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
    public partial class FImprimir : Form
    {
        public FImprimir()
        {
            InitializeComponent();
        }

        private void FImprimir_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DVenta.DetalleVenta' Puede moverla o quitarla según sea necesario.
            //this.DetalleVentaTableAdapter.DatosVenta(this.DVenta.DetalleVenta);
            
            //this.reportViewer1.RefreshReport();
            
            
        }

        public void Imprimir(string id)
        {
            this.DetalleVentaTableAdapter.DatosVenta(this.DVenta.DetalleVenta, int.Parse(id));
            this.reportViewer1.RefreshReport();
            this.Show();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
