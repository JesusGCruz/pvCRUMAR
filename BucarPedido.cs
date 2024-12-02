using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.UniversalAccessibility.Drawing;













namespace LoginCRUMAR
{
    public partial class BucarPedido : Form
    {
        ConexionProductos coBD = new ConexionProductos();

        private int numPedido;
        private int codigoBarras;
        private string nombreProducto;
        private int numProveedor;
        private DateTime fechaPedido;
        private int cantProducto;
        private string nombreProveedor;
        public BucarPedido()
        {
            InitializeComponent();
        }
        private void CargarPedidos()
        {
            try
            {

                DataSet ds = coBD.ConsultarPedidos();

                dgvPedidos.Rows.Clear();


                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {

                    foreach (DataRow fila in ds.Tables[0].Rows)
                    {
                        int indice = dgvPedidos.Rows.Add();
                        DataGridViewRow row = dgvPedidos.Rows[indice];


                        row.Cells["idProveedor"].Value = fila["idProveedor"].ToString();
                        row.Cells["codigpBarras"].Value = fila["codigpBarras"].ToString();
                        row.Cells["fecha"].Value = fila["fecha"].ToString();
                        row.Cells["idProductoProve"].Value = fila["idProductoProve"].ToString();
                        row.Cells["cantidadProducto"].Value = fila["cantidadProducto"].ToString();
                        row.Cells["nombre"].Value = fila["nombre"].ToString();
                        row.Cells["nombrePro"].Value = fila["nombrePro"].ToString();


                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron datos para mostrar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buscarPed(object sender, EventArgs e)
        {
            try
            {
                string columnaFiltro = ((OpcionCombo)cboBusqueda.SelectedItem).Valor.ToString();
                string textoBuscar = txtBuscar.Text.Trim().ToUpper();

                foreach (DataGridViewRow row in dgvPedidos.Rows)
                {
                    if (row.Cells[columnaFiltro].Value != null)
                    {
                        string valor = row.Cells[columnaFiltro].Value.ToString().ToUpper();
                        row.Visible = valor.Contains(textoBuscar);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al filtrar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void BucarPedido_Load(object sender, EventArgs e)
        {
            CargarPedidos();
            foreach (DataGridViewColumn column in dgvPedidos.Columns)
            {
                if (column.Visible == true)
                {
                    cboBusqueda.Items.Add(new OpcionCombo() { Valor = column.Name, Texto = column.HeaderText });

                }

            }
            cboBusqueda.DisplayMember = "Texto";
            cboBusqueda.ValueMember = "Valor";
            cboBusqueda.SelectedIndex = 0;
        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "Busca Aqui")
            {

                txtBuscar.Text = "";
                txtBuscar.ForeColor = Color.LightGray;


            }
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                txtBuscar.Text = "Busca Aqui";
                txtBuscar.ForeColor = Color.DimGray;
                CargarPedidos();

            }
        }

        private void btLimpiar2_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = "Busca Aqui";
            txtBuscar.ForeColor = Color.DimGray;
            CargarPedidos();
        }



        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            buscarPed(sender, e);
        }

        [Obsolete]
        private void btnComprobante_Click(object sender, EventArgs e)
        {

            // Check if a row is selected
            if (dgvPedidos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona una fila antes de continuar.");
                return;
            }

            try
            {
                numPedido = Convert.ToInt32(dgvPedidos.SelectedRows[0].Cells[0].Value);
                codigoBarras = Convert.ToInt32(dgvPedidos.SelectedRows[0].Cells[1].Value);
                nombreProducto = dgvPedidos.SelectedRows[0].Cells[2].Value.ToString() ?? string.Empty;
                numProveedor = Convert.ToInt32(dgvPedidos.SelectedRows[0].Cells[3].Value);
                fechaPedido = Convert.ToDateTime(dgvPedidos.SelectedRows[0].Cells[4].Value);
                cantProducto = Convert.ToInt32(dgvPedidos.SelectedRows[0].Cells[5].Value);
                nombreProveedor = dgvPedidos.SelectedRows[0].Cells[6].Value.ToString() ?? string.Empty;

                DateTime fechaActual = DateTime.Now;
                // Create PDF document
                PdfDocument document = new PdfDocument();
                PdfPage page = document.AddPage();
                XGraphics gfx = XGraphics.FromPdfPage(page);

                // Define fonts
                XFont titleFont = new XFont("Times New Roman", 16, XFontStyleEx.Bold);
                XFont headerFont = new XFont("Times New Roman", 12, XFontStyleEx.Bold);
                XFont infoFont = new XFont("Times New Roman", 12);

                // Draw title and logo
                gfx.DrawString("Comprobante de Pedido", titleFont, XBrushes.Black, new XRect(0, 50, page.Width, 30), XStringFormats.Center);
                gfx.DrawString("Crumar ©", infoFont, XBrushes.Black, new XPoint(50, 50));
                gfx.DrawString($"Fecha: {fechaActual.ToShortDateString()} ", infoFont, XBrushes.Black, new XPoint(450, 120));

                // Draw logo
                string imagePath = @"C:\Users\onefr\Source\Repos\pvCRUMAR\Resources\LogoCRUMAR.png";
                XImage image = XImage.FromFile(imagePath);
                gfx.DrawImage(image, page.Width - 100, 10, 75, 75);

                // Draw horizontal line
                XPen pen = new XPen(XColors.Black, 2);
                gfx.DrawLine(pen, 50, 90, page.Width - 50, 90);


                // Create table-like structure
                double startY = 120;
                double leftMargin = 50;
                double columnWidth = 200;

                // Table header
                gfx.DrawString("Detalles", headerFont, XBrushes.Black, new XPoint(leftMargin, startY));
                gfx.DrawString("Información", headerFont, XBrushes.Black, new XPoint(leftMargin + columnWidth, startY));
                startY += 20;

                // Draw table rows
                DrawTableRow(gfx, infoFont, leftMargin, startY, "Número de Pedido", numPedido.ToString()); startY += 20;
                DrawTableRow(gfx, infoFont, leftMargin, startY, "Código de Barras", codigoBarras.ToString()); startY += 20;
                DrawTableRow(gfx, infoFont, leftMargin, startY, "Nombre del Producto", nombreProducto); startY += 20;
                DrawTableRow(gfx, infoFont, leftMargin, startY, "Número de Proveedor", numProveedor.ToString()); startY += 20;
                DrawTableRow(gfx, infoFont, leftMargin, startY, "Fecha de Pedido", fechaPedido.ToString("dd/MM/yyyy")); startY += 20;
                DrawTableRow(gfx, infoFont, leftMargin, startY, "Cantidad de Producto", cantProducto.ToString()); startY += 20;
                DrawTableRow(gfx, infoFont, leftMargin, startY, "Proveedor", nombreProveedor); startY += 20;

                // Save PDF
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "PDF Files|*.pdf";
                    saveFileDialog.Title = "Guardar Comprobante de Pedido";
                    saveFileDialog.FileName = $"Comprobante de Pedido {numPedido}.pdf";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        document.Save(saveFileDialog.FileName);
                        System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(saveFileDialog.FileName) { UseShellExecute = true });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el comprobante: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DrawTableRow(XGraphics gfx, XFont font, double x, double y, string label, string value)
        {
            gfx.DrawString(label, font, XBrushes.Black, new XPoint(x, y));
            gfx.DrawString(value, font, XBrushes.Black, new XPoint(x + 200, y));

        }

    }
}
