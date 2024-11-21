using CapaNegocio;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoginCRUMAR.utilidades;

namespace LoginCRUMAR.modales
{
    public partial class mdProducto : Form
    {
        public Producto _Producto { get; set; }
        public mdProducto()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void mdProducto_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in dgvdata.Columns)
            {
                if (columna.Visible == true)
                {
                    cbobusqueda.Items.Add(new OpcionCombo() { valor = columna.Name, Texto = columna.HeaderText });
                }
            }

        cbobusqueda.DisplayMember = "Texto";
        cbobusqueda.ValueMember = "valor";
        cbobusqueda.SelectedIndex = 0;

        List<Producto> lista = new CN_Producto().Listar();

        foreach (Producto item in lista)
            {
                dgvdata.Rows.Add(new object[]{
                    item.idProducVenta,
                    item.codigoBarras,
                    item.Nombre,
                    item.existencia,
                    item.PrecioCompra,
                    item.PrecioVenta

                   });
            }
                                 
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            int iRow = e.RowIndex;                        
            int iColum = e.ColumnIndex;
            if (iRow >= 0 && iColum > 0)
            {
                _Producto = new Producto()
                {

            idProducVenta = Convert.ToInt32(dgvdata.Rows[iRow].Cells["Id"].Value.ToString(),
            codigoBarras = dgvdata.Rows[iRow].Cells["codigoBarras"].Value.ToString(),
            Nombre = dgvdata.Rows[iRow].Cells["nombre"].Value.ToString(),
            existencia = Convert.ToInt32(dgvdata.Rows[iRow].Cells["existencia"].Value.ToString()),
            precioCompra = Convert.ToDecimal(dgvdata.Rows[iRow].Cells["precioCompra"].Value.ToString()),
            precioVenta = Convert.ToDecimal(dgvdata.Rows[iRow].Cells["precioVenta"].Value.ToString()),
                };
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
           
            



        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            String columnaFiltro = ((OpcionCombo)cbobusqueda.SelectedItem).valor.ToString();
            if (dgvdata.Rows.Count > 0)
            {
                foreach(DataGridViewRow row in dgvdata.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtbusqueda.Text.Trim().ToUpper())) 
                        row.Visible = true;
                    else
                        row.Visible = false ;
                }
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            txtbusqueda.Text = "";
            foreach(DataGridViewRow row in dgvdata.Rows)
            {
                row.Visible = true;
            }
        }
    }
}
