using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LoginCRUMAR
{
    public partial class editarfrm : Form
    {
        Conexion coBD = new Conexion();
        public editarfrm()
        {
            InitializeComponent();
            this.txtnnumprogu.Enter += new System.EventHandler(this.txtnnumprogu_Enter);
            this.txtnnumprogu.Leave += new System.EventHandler(this.txtnnumprogu_Leave);
            txtnnumprogu.Text = "Numero de Telefono";
            txtnnumprogu.ForeColor = Color.White;
            lblnum.Visible = false;

            // Configuración para nombre (ya existente)
            this.txtnombrepro.Enter += new System.EventHandler(this.txtnombrepro_Enter);
            this.txtnombrepro.Leave += new System.EventHandler(this.txtnombrepro_Leave);
            txtnombrepro.Text = "Nombre Completo";
            txtnombrepro.ForeColor = Color. White;
            lblnom.Visible = false;

            // Configuración para correo
            this.txtcorreopro.Enter += new System.EventHandler(this.txtcorreopro_Enter);
            this.txtcorreopro.Leave += new System.EventHandler(this.txtcorreopro_Leave);
            txtcorreopro.Text = "Correo Electronico";
            txtcorreopro.ForeColor = Color.White;
            lblco.Visible = false;

            // Configuración para lada
            this.txtladapro.Enter += new System.EventHandler(this.txtladapro_Enter);
            this.txtladapro.Leave += new System.EventHandler(this.txtladapro_Leave);
            txtladapro.Text = "Lada";
            txtladapro.ForeColor = Color.White;
            lblla.Visible = false;

            // Configuración para lada
            this.txtidpro.Enter += new System.EventHandler(this.txtidpro_Enter_1);
            this.txtidpro.Leave += new System.EventHandler(this.txtidpro_Leave_1);
            txtidpro.Text = "Id Proveedor";
            txtidpro.ForeColor = Color.White;
            lblid.Visible = false;
        }


        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                int idProveedor = Convert.ToInt32(txtidpro.Text);
                string nombre = txtnombrepro.Text;
                string numTelefono = txtnnumprogu.Text;
                string ladaPais = txtladapro.Text;
                string correo = txtcorreopro.Text;
                bool activo = rbactivo.Checked;

                bool resultado = coBD.actualizarProveedor(idProveedor, nombre, numTelefono,
                                                                     ladaPais, correo, activo, null);

                if (resultado)
                {
                    MessageBox.Show("Proveedor actualizado exitosamente.", "Éxito"+txtidpro,
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

        private void limpiar()
        {


            txtnnumprogu.Text = "Numero de Telefono";
            txtcorreopro.Text = "Correo Electronico";
            txtnombrepro.Text = "Nombre Completo";
            txtladapro.Text = "Lada";
            txtidpro.Text = "Id Proveedor";
            rbactivo.Checked = false;

            // Restaurar colores y visibilidad
            txtnnumprogu.ForeColor = Color.White;
            txtcorreopro.ForeColor = Color.White;
            txtnombrepro.ForeColor = Color.White;
            txtladapro.ForeColor = Color.White;
            txtidpro.ForeColor = Color.White;


            lblnum.Visible = false;
            lblco.Visible = false;
            lblnom.Visible = false;
            lblla.Visible = false;
            lblid.Visible = false;
        }
        private void editarfrm_Load(object sender, EventArgs e)
        {

        }
        private bool ValidarDatos()
        {
            if (string.IsNullOrEmpty(txtidpro.Text) ||
                string.IsNullOrEmpty(txtnombrepro.Text) ||
                string.IsNullOrEmpty(txtnnumprogu.Text))
            {
                MessageBox.Show("Por favor, complete los campos obligatorios.", "Advertencia",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
     

       

        private void btnbusque_Click(object sender, EventArgs e)
        {
            try
            {
                string codigo = txtidpro.Text.Trim();

                if (string.IsNullOrEmpty(codigo))
                {
                    MessageBox.Show("Por favor, ingrese un ID.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataTable producto = coBD.obtenerProveedores2(codigo);

                if (producto != null && producto.Rows.Count > 0)
                {
                    // Asignar valores desde la primera fila
                    DataRow fila = producto.Rows[0];

                    txtidpro.Text = fila["idProvedor"].ToString(); // Ajustar nombre del campo según tu base de datos
                    txtnombrepro.Text = fila["nombre"].ToString();
                    txtnnumprogu.Text = fila["numTelefono"].ToString(); // Convertir a decimal para asignar
                    txtladapro.Text = fila["ladaPais"].ToString();
                    txtcorreopro.Text = fila["correoElectronico"].ToString();
                    txtidpro.ReadOnly = true;

                    // Asignar el estado activo/inactivo
                    bool isActive = Convert.ToBoolean(fila["activo"]);

                    // Configurar los RadioButton
                    rbactivo.Checked = isActive;      // Si está activo, marcar rbactivo
                    rbnoact.Checked = !isActive;      // Si no está activo, marcar rbnoac

                }
                else
                {
                    MessageBox.Show("Producto no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    limpiar(); // Limpia los campos si no se encuentra el producto
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtidpro_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnnumprogu_Enter(object sender, EventArgs e)
        {
            if (txtnnumprogu.Text == "Numero de Telefono")
            {
                txtnnumprogu.Text = "";
                txtnnumprogu.ForeColor = Color.White; // Cambia a negro cuando está activo
                lblnum.Visible = true;
            }
        }

        private void txtnnumprogu_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtnnumprogu.Text))
            {
                txtnnumprogu.Text = "Numero de Telefono";
                txtnnumprogu.ForeColor = Color.White;
                lblnum.Visible = false;
            }
        }

        private void guardar_Load(object sender, EventArgs e)
        {

        }


        private void txtnombrepro_Enter(object sender, EventArgs e)
        {
            if (txtnombrepro.Text == "Nombre Completo")
            {
                txtnombrepro.Text = "";
                txtnombrepro.ForeColor = Color.White; // Cambia a negro cuando está activo
                lblnom.Visible = true;
            }
        }

        private void txtnombrepro_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtnombrepro.Text))
            {
                txtnombrepro.Text = "Nombre Completo"; // Corregido el texto
                txtnombrepro.ForeColor = Color.White;
                lblnom.Visible = false;
            }
        }
        private void txtcorreopro_Enter(object sender, EventArgs e)
        {
            if (txtcorreopro.Text == "Correo Electronico")
            {
                txtcorreopro.Text = "";
                txtcorreopro.ForeColor = Color.White;
                lblco.Visible = true;
            }
        }

        private void txtcorreopro_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtcorreopro.Text))
            {
                txtcorreopro.Text = "Correo Electronico";
                txtcorreopro.ForeColor = Color.White;
                lblco.Visible = false;
            }
        }

        // Eventos para lada
        private void txtladapro_Enter(object sender, EventArgs e)
        {
            if (txtladapro.Text == "Lada")
            {
                txtladapro.Text = "";
                txtladapro.ForeColor = Color.White;
                lblla.Visible = true;
            }
        }

        private void txtladapro_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtladapro.Text))
            {
                txtladapro.Text = "Lada";
                txtladapro.ForeColor = Color.White;
                lblla.Visible = false;
            }
        }

        private void txtidpro_Enter_1(object sender, EventArgs e)
        {
            if (txtidpro.Text == "Id Proveedor")
            {
                txtidpro.Text = "";
                txtidpro.ForeColor = Color.White;
                lblid.Visible = true;
            }
        }

        private void txtidpro_Leave_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtidpro.Text))
            {
                txtidpro.Text = "Id Proveedor";
                txtidpro.ForeColor = Color.White;
                lblid.Visible = false;
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btlim_Click(object sender, EventArgs e)
        {
            limpiar();
            txtidpro.ReadOnly = false;
        }
    }
    }
