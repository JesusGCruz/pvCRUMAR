using LoginCRUMAR.modales;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginCRUMAR
{
    public partial class FormVentas : Form
    {
        public FormVentas()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            txtfecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtidProducto.Text = "0";

            txttotalpagar.Text = "0";
            txtcambio.Text = "";

           
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            using (var modal = new mdProducto())
            {
                var result = modal.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txtidProducto.Text= modal._Producto.idProducto.ToString();
                    txtCodProducto.Text = modal._Producto.codigoBarras();
                    txtPrecio.Text = modal._Producto.PrecioVenta.ToString("0.00");
                    txtexistencia.Text = modal._Producto.existencia.ToString();
                    txtcantidad.Select();
                }
                else
                {
                    txtCodProducto.Select();
                }
            }
        }

        private void txtCodProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Producto oProducto = new CN_Producto().Listar().Where(p => txtCodProducto.Text && p.Estado == true).FirstOrDefault();

                if (oProducto != null)
                {
                    txtCodProducto.BackColor = Color.Honeydew;
                    txtidProducto.Text= oProducto.idProducVenta.ToString();
                    txtProducto.Text = oProducto.Nombre;
                    txtPrecio.Text = oProducto.precioVenta.ToString("0.00");
                    txtexistencia.Text = oProducto.existencia.ToString();
                    txtcantidad.Select();
                }
                else
                {
                    txtCodProducto.BackColor = Color.MistyRose;
                    txtidProducto.Text = "0";
                    txtProducto.Text = "";
                    txtPrecio.Text = "";
                    txtexistencia.Text = "";
                    txtcantidad.Value=1;
                }
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            decimal precio = 0;
            bool producto_existe = false;
            

            if (int.Parse(txtidProducto.Text) > 0)
            {
                MessageBox.Show("Debe seleccionar un producto","Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!decimal.TryParse(txtPrecio.Text, out precio))
            {
                MessageBox.Show("Precio - Formato moneda incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPrecio.Select();
                return;
            }

            if (Convert.ToInt32(txtexistencia.Text) < Convert.ToInt32(txtcantidad.Value.ToString()))
            {
                MessageBox.Show("La cantidad no puede ser mayor al Stock", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            foreach (DataGridViewRow fila in dgvdata.Rows)
            {
                if (fila.Cells["idProducVenta"].Value.ToString() == txtidProducto.Text)
                {
                    producto_existe = true;
                    break;
                }
            }

            if (!producto_existe)
            {
                dgvdata.Rows.Add(new object[]
                {
                    txtidProducto.Text,
                    txtProducto.Text,
                    precio.ToString("0.00"),
                    txtcantidad.Value .ToString(),
                    (txtcantidad.Value * precio).ToString("0.00")
                });

                calcularTotal();
                limpiarProducto();
                txtCodProducto.Select();
            }
        }

        private void calcularTotal()
        {
            decimal total = 0; 
            if(dgvdata.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvdata.Rows)
                    total += Convert.ToDecimal(row.Cells["Subtotal"].Value.ToString());
            }
            txttotalpagar.Text = total.ToString("0.00");
        }


         private void limpiarProducto ()
        {
            txtCodProducto.Text = "";
            txtidProducto.Text = "0";
            txtProducto.Text = "";
            txtPrecio.Text = "";
            txtexistencia.Text = "";
            txtcantidad.Value = 1;
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            //if (e.ColumnIndex == 5)
            //{
            //    e.Paint(e.CellBounds, DataGridViewPaintParts.All);

            //    var w = Properties.Resources.delete25.Width;
            //    var h = Properties.Resources.delete25.Height;
            //    var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
            //    var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

            //    e.Graphics.DrawImage(Properties.Resources.delete25, new Rectangle(x, y, w, h));
            //    e.Handled = true;

            //}
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvdata.Columns[e.ColumnIndex].Name == "btneliminar")
            {
                int index = e.RowIndex;
                if (index >= 0)
                {
                    dgvdata.Rows.RemoveAt(index);
                    calcularTotal();
                }  
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if(txtPrecio.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
                {
                    e.Handled = true;
                }
                else
                {
                    if (Char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ".")
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled= true;
                    }
                }
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (txtpagacon.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
                {
                    e.Handled = true;
                }
                else
                {
                    if (Char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ".")
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }


        private void calcularcambio()
        {
            if (txttotalpagar.Text.Trim() == ""){
                MessageBox.Show("No existen productos a la venta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            decimal pagacon;
            decimal total = Convert.ToDecimal(txttotalpagar.Text);

            if (txtpagacon.Text.Trim() == "")
            {
                txtpagacon.Text= "0";
            }

            if(decimal.TryParse(txtpagacon.Text.Trim(), out pagacon))
            {
                if (pagacon < total)
                {
                    txtcambio.Text= "0.00";
                }
                else
                {
                    decimal cambio = pagacon - total;
                    txtcambio.Text = cambio.ToString("0.00");
                }
            }
        }

        private void txtpagacon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                calcularcambio();
            }
        }
    }
}
