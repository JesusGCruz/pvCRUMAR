using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Repositorio
{
    internal class ImpresionTicket
    {
        private DataGridView dgvProductos;
        private PrintDocument printDocument;
        private Font fontTitulo;
        private Font fontNormal;

        public ImpresionTicket(DataGridView dgv)
        {
            dgvProductos = dgv;
            printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocument_PrintPage;

            // Definir fuentes
            fontTitulo = new Font("Arial", 12, FontStyle.Bold);
            fontNormal = new Font("Arial", 10, FontStyle.Regular);
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Configuración inicial
            float yPos = 10;
            int padding = 10;
            float leftMargin = e.MarginBounds.Left;
            float topMargin = e.MarginBounds.Top;

            // Imprimir título
            e.Graphics.DrawString("Lista de Precios", fontTitulo, Brushes.Black, leftMargin, yPos);
            yPos += 30;

            // Imprimir fecha
            e.Graphics.DrawString($"Fecha: {DateTime.Now.ToString("dd/MM/yyyy")}", fontNormal, Brushes.Black, leftMargin, yPos);
            yPos += 20;

            // Línea separadora
            e.Graphics.DrawLine(Pens.Black, leftMargin, yPos, e.MarginBounds.Right, yPos);
            yPos += 10;

            // Encabezados
            e.Graphics.DrawString("Producto", fontNormal, Brushes.Black, leftMargin, yPos);
            e.Graphics.DrawString("Precio", fontNormal, Brushes.Black, e.MarginBounds.Right - 80, yPos);
            yPos += 20;

            // Imprimir productos
            foreach (DataGridViewRow row in dgvProductos.Rows)
            {
                if (row.Cells["nombre"].Value != null && row.Cells["precioVenta"].Value != null)
                {
                    string nombre = row.Cells["nombre"].Value.ToString();
                    decimal precio = Convert.ToDecimal(row.Cells["precioVenta"].Value);

                    // Truncar nombre si es muy largo
                    if (nombre.Length > 30)
                        nombre = nombre.Substring(0, 27) + "...";

                    e.Graphics.DrawString(nombre, fontNormal, Brushes.Black, leftMargin, yPos);
                    e.Graphics.DrawString(precio.ToString("C"), fontNormal, Brushes.Black, e.MarginBounds.Right - 80, yPos);

                    yPos += 15;

                    // Verificar si necesitamos una nueva página
                    if (yPos > e.MarginBounds.Bottom - 40)
                    {
                        e.HasMorePages = true;
                        return;
                    }
                }
            }

            // Línea final
            yPos += 10;
            e.Graphics.DrawLine(Pens.Black, leftMargin, yPos, e.MarginBounds.Right, yPos);
        }

        public void ImprimirTicket()
        {
            try
            {
                // Mostrar el diálogo de vista previa de impresión
                PrintPreviewDialog preview = new PrintPreviewDialog();
                preview.Document = printDocument;
                preview.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al imprimir: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
