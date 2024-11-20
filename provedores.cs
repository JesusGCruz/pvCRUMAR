using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using iTextSharp.text.pdf;
using iTextSharp.text;
using LoginCRUMAR.utilidades;
using iTextSharp.text.pdf.draw;




namespace LoginCRUMAR
{
    public partial class provedores : Form
    {
        Conexion coBD = new Conexion();
        public provedores()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void provedores_Load(object sender, EventArgs e)
        {




            // TODO: esta línea de código carga datos en la tabla 'db_CRUMARDataSet.sp_ObtenerProveedoresContactos2' Puede moverla o quitarla según sea necesario.

            this.sp_ObtenerProveedoresContactos2TableAdapter.Fill(this.db_CRUMARDataSet.sp_ObtenerProveedoresContactos2);
            // TODO: esta línea de código carga datos en la tabla 'db_CRUMARDataSet.tbProveedores' Puede moverla o quitarla según sea necesario.
            this.tbProveedoresTableAdapter.Fill(this.db_CRUMARDataSet.tbProveedores);




            foreach (DataGridViewColumn columna in dgvdata.Columns)
            {
                if (columna.Visible == true && columna.Name != "selec")
                {
                    cboBusqueda.Items.Add(new OpcionCombo() { valor = columna.Name, Text = columna.HeaderText });

                }

            }
            cboBusqueda.DisplayMember = "Text";
            cboBusqueda.ValueMember = "Valor";
            cboBusqueda.SelectedIndex = 0;


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtidpro.Text))
            {
                if (MessageBox.Show("¿Está seguro de eliminar este proveedor?", "Confirmar eliminación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int idProveedor = Convert.ToInt32(txtidpro.Text);
                    bool resultado = coBD.eliminarProveedor(idProveedor, dgvdata);

                    if (resultado)
                    {
                        MessageBox.Show("Proveedor eliminado exitosamente.", "Éxito",
                                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiar();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el proveedor.", "Error",
                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un proveedor para eliminar.", "Advertencia",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                int idProveedor = Convert.ToInt32(txtidpro.Text);
                string nombre = txtnombrepro.Text;
                string numTelefono = txtnnumpro.Text;
                string ladaPais = txtladapro.Text;
                string correo = txtcorreopro.Text;
                bool activo = rbactivo.Checked;

                bool resultado = coBD.actualizarProveedor(idProveedor, nombre, numTelefono,
                                                                     ladaPais, correo, activo, dgvdata);

                if (resultado)
                {
                    MessageBox.Show("Proveedor actualizado exitosamente.", "Éxito",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
                }
                else
                {
                    MessageBox.Show("Error al actualizar el proveedor.", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvdata.Columns[e.ColumnIndex].Name == "selec")
            {
                int indi = e.RowIndex;
                if (indi >= 0)
                {
                    txtidpro.Text = dgvdata.Rows[indi].Cells["idPro"].Value.ToString();
                    txtidpro.ReadOnly = true; // Deshabilitar la edición
                    txtnombrepro.Text = dgvdata.Rows[indi].Cells["nomb"].Value.ToString();
                    txtnnumpro.Text = dgvdata.Rows[indi].Cells["numTel"].Value.ToString();
                    txtladapro.Text = dgvdata.Rows[indi].Cells["ladaP"].Value.ToString();
                    txtcorreopro.Text = dgvdata.Rows[indi].Cells["correoElec"].Value.ToString();
                    // Obtener el valor de "activ" como bool
                    bool isActive = Convert.ToBoolean(dgvdata.Rows[indi].Cells["activ"].Value);

                    // Configurar los RadioButton
                    rbactivo.Checked = isActive;      // Si está activo, marcar rbactivo
                    rbnoact.Checked = !isActive;      // Si no está activo, marcar rbnoac


                }
            }



        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                // Obtener los datos del formulario
                int idProveedor = Convert.ToInt32(txtidpro.Text);
                string nombre = txtnombrepro.Text;
                string numTelefono = txtnnumpro.Text;
                string ladaPais = txtladapro.Text;
                string correo = txtcorreopro.Text;
                bool activo = rbactivo.Checked; // Un CheckBox para marcar si está activo
                bool noactivo = rbnoact.Checked;
                // Llamar al método para insertar el proveedor
                bool resultado = coBD.agregarproveedor(idProveedor, nombre, numTelefono, ladaPais, correo, activo, dgvdata);

                // Mostrar el resultado al usuario
                if (resultado)
                {
                    MessageBox.Show("Proveedor guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
                }
                else
                {
                    MessageBox.Show("Error al guardar el proveedor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void limpiar()
        {

            txtidpro.Text = "";
            txtnnumpro.Text = "";
            txtcorreopro.Text = "";
            txtnombrepro.Text = "";
            txtladapro.Text = "";
            rbactivo.Checked = false;
            txtidpro.ReadOnly = false; // Deshabilitar la edición
        }

        private void dgvdata_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.check.Width;
                var h = Properties.Resources.check.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.check, new System.Drawing.Rectangle(x, y, w, h));
                e.Handled = true;
            }




        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = coBD.obtenerProveedores();
                if (dt != null)
                {
                    dgvdata.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No se pudieron obtener los datos.", "Advertencia",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar la tabla: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool ValidarDatos()
        {
            if (string.IsNullOrEmpty(txtidpro.Text) ||
                string.IsNullOrEmpty(txtnombrepro.Text) ||
                string.IsNullOrEmpty(txtnnumpro.Text))
            {
                MessageBox.Show("Por favor, complete los campos obligatorios.", "Advertencia",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            // Validar que haya una opción seleccionada y texto en el cuadro de búsqueda
            if (cboBusqueda.SelectedItem == null || string.IsNullOrWhiteSpace(txtbusque.Text))
            {
                MessageBox.Show("Por favor, selecciona un filtro y escribe un texto para buscar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener la columna a filtrar
            string columnafiltro = ((OpcionCombo)cboBusqueda.SelectedItem).valor.ToString();

            // Suspender temporalmente el enlace
            dgvdata.CurrentCell = null; // Esto desconecta la celda seleccionada
            dgvdata.SuspendLayout();    // Suspende el diseño para evitar errores gráficos

            try
            {
                foreach (DataGridViewRow row in dgvdata.Rows)
                {
                    // Manejar valores nulos y aplicar filtro
                    var celdaValor = row.Cells[columnafiltro].Value;

                    if (celdaValor != null && celdaValor.ToString().Trim().ToUpper().Contains(txtbusque.Text.Trim().ToUpper()))
                    {
                        row.Visible = true; // Mostrar la fila que coincide
                    }
                    else
                    {
                        row.Visible = false; // Ocultar la fila que no coincide
                    }
                }
            }
            finally
            {
                dgvdata.ResumeLayout(); // Reanudar el diseño después de procesar
            }
        }

        private void btlim_Click(object sender, EventArgs e)
        {
            txtbusque.Text = "";
            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                row.Visible = true;
            }

        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            prueba prueba = new prueba();
            prueba.Visible = true;
        }





        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Limpia_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void iconButton1_Click_2(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Archivo PDF (*.pdf)|*.pdf",
                Title = "Guardar como",
                FileName = "proveedores.pdf"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string ruta = saveFileDialog.FileName;
                Document documento = new Document(PageSize.A4, 25, 25, 30, 30);

                try
                {
                    PdfWriter writer = PdfWriter.GetInstance(documento, new FileStream(ruta, FileMode.Create));
                    documento.Open();

                    // Configurar fuentes
                    BaseFont bf = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                    iTextSharp.text.Font fontTitle = new iTextSharp.text.Font(bf, 16, iTextSharp.text.Font.BOLD);
                    iTextSharp.text.Font fontNormal = new iTextSharp.text.Font(bf, 12);
                    iTextSharp.text.Font fontHeader = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.BOLD);

                    // Agregar logo
                    string rutaLogo = Path.Combine(Application.StartupPath, "LogoCRUMAR.png");
                    if (File.Exists(rutaLogo))
                    {
                        iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(rutaLogo);
                        logo.ScaleToFit(140f, 140f);
                        logo.Alignment = Element.ALIGN_LEFT;
                        documento.Add(logo);
                    }

                    // Información de la empresa
                    Paragraph infoEmpresa = new Paragraph();
                    infoEmpresa.Alignment = Element.ALIGN_RIGHT;
                    infoEmpresa.Add(new Chunk("TIENDA DE ABARROTES CRUMAR\n", fontTitle));
                    infoEmpresa.Add(new Chunk("La puta casa del chucho\n", fontNormal));
                    infoEmpresa.Add(new Chunk("Teléfono: (776) 120-9157\n", fontNormal));
                    infoEmpresa.Add(new Chunk("Email: contacto@tuempresa.com\n", fontNormal));
                    infoEmpresa.SpacingAfter = 20f;
                    documento.Add(infoEmpresa);

                    // Línea separadora
                    LineSeparator linea = new LineSeparator(0.5f, 100f, BaseColor.BLACK, Element.ALIGN_CENTER, -1);
                    documento.Add(new Chunk(linea));

                    // Título del reporte
                    Paragraph titulo = new Paragraph("LISTADO DE PROVEEDORES", fontTitle);
                    titulo.Alignment = Element.ALIGN_CENTER;
                    titulo.SpacingBefore = 20f;
                    titulo.SpacingAfter = 20f;
                    documento.Add(titulo);

                    // Fecha del reporte
                    Paragraph fecha = new Paragraph($"Fecha: {DateTime.Now:dd/MM/yyyy HH:mm}", fontNormal);
                    fecha.Alignment = Element.ALIGN_RIGHT;
                    fecha.SpacingAfter = 20f;
                    documento.Add(fecha);

                    // Crear tabla
                    PdfPTable tabla = new PdfPTable(dgvdata.Columns.Count);
                    tabla.WidthPercentage = 100;

                    // Establecer anchos relativos de las columnas
                    float[] anchos = new float[dgvdata.Columns.Count];
                    for (int i = 0; i < dgvdata.Columns.Count; i++)
                    {
                        anchos[i] = 4f; // Asegúrate de usar valores flotantes
                    }
                    tabla.SetWidths(anchos);

                    // Encabezados
                    foreach (DataGridViewColumn columna in dgvdata.Columns)
                    {
                        PdfPCell celda = new PdfPCell(new Phrase(columna.HeaderText, fontHeader));
                        celda.BackgroundColor = new BaseColor(240, 240, 240);
                        celda.HorizontalAlignment = Element.ALIGN_CENTER;
                        celda.VerticalAlignment = Element.ALIGN_MIDDLE;
                        celda.Padding = 8;
                        tabla.AddCell(celda);
                    }

                    // Datos
                    foreach (DataGridViewRow fila in dgvdata.Rows)
                    {
                        if (!fila.IsNewRow) // Evita la última fila vacía
                        {
                            foreach (DataGridViewCell celda in fila.Cells)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(celda.Value?.ToString() ?? "", fontNormal));
                                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                                cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                                cell.Padding = 6;
                                tabla.AddCell(cell);
                            }
                        }
                    }

                    documento.Add(tabla);

                    // Pie de página
                    Paragraph pie = new Paragraph("Este documento es confidencial y para uso interno.", fontNormal);
                    pie.Alignment = Element.ALIGN_CENTER;
                    pie.SpacingBefore = 20f;
                    documento.Add(pie);

                    MessageBox.Show("PDF guardado exitosamente en: " + ruta, "Éxito",
                                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al generar el PDF: " + ex.Message, "Error",
                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    documento.Close();
                }
            }
        }

    }

}
