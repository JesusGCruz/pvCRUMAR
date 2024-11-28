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
    public partial class guardar : Form
    {
        Conexion coBD = new Conexion();
        public Action OnProveedorGuardado { get; set; }
        public guardar()
        {
            InitializeComponent();
            this.txtnnumprogu.Enter += new System.EventHandler(this.txtnnumprogu_Enter);
            this.txtnnumprogu.Leave += new System.EventHandler(this.txtnnumprogu_Leave);
            txtnnumprogu.Text = "Numero de Telefono";
            txtnnumprogu.ForeColor = Color.DimGray;
            lblnum.Visible = false;

            // Configuración para nombre (ya existente)
            this.txtnombrepro.Enter += new System.EventHandler(this.txtnombrepro_Enter);
            this.txtnombrepro.Leave += new System.EventHandler(this.txtnombrepro_Leave);
            txtnombrepro.Text = "Nombre Completo";
            txtnombrepro.ForeColor = Color.DimGray;
            lblnom.Visible = false;

            // Configuración para correo
            this.txtcorreopro.Enter += new System.EventHandler(this.txtcorreopro_Enter);
            this.txtcorreopro.Leave += new System.EventHandler(this.txtcorreopro_Leave);
            txtcorreopro.Text = "Correo Electronico";
            txtcorreopro.ForeColor = Color.DimGray;
            lblco.Visible = false;

            // Configuración para lada
            this.txtladapro.Enter += new System.EventHandler(this.txtladapro_Enter);
            this.txtladapro.Leave += new System.EventHandler(this.txtladapro_Leave);
            txtladapro.Text = "Lada";
            txtladapro.ForeColor = Color.DimGray;
            lblla.Visible = false;
        }

            private void btnguardar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                // Obtener los datos del formulario
                
                string nombre = txtnombrepro.Text;
                string numTelefono = txtnnumprogu.Text;
                int ladaPais = int.Parse(txtladapro.Text);
                string correo = txtcorreopro.Text;
                bool activo = rbactivo.Checked; // Un CheckBox para marcar si está activo
                bool noactivo = rbnoact.Checked;
                // Llamar al método para insertar el proveedor
                bool resultado = coBD.agregarproveedor( nombre, numTelefono, ladaPais, correo, activo, null);

                // Mostrar el resultado al usuario
                if (resultado)
                {
                    
                    MessageBox.Show("Proveedor guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    OnProveedorGuardado?.Invoke();
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


            txtnnumprogu.Text = "Numero de Telefono";
            txtcorreopro.Text = "Correo Electronico";
            txtnombrepro.Text = "Nombre Completo";
            txtladapro.Text = "Lada";
            rbactivo.Checked = false;

            // Restaurar colores y visibilidad
            txtnnumprogu.ForeColor = Color.White;
            txtcorreopro.ForeColor = Color.White;
            txtnombrepro.ForeColor = Color.White;
            txtladapro.ForeColor = Color.White;

            lblnum.Visible = false;
            lblco.Visible = false;
            lblnom.Visible = false;
            lblla.Visible = false;

        }
        private bool ValidarDatos()
        {
            if (
                string.IsNullOrEmpty(txtnombrepro.Text) ||
                string.IsNullOrEmpty(txtnnumprogu.Text))
            {
                MessageBox.Show("Por favor, complete los campos obligatorios.", "Advertencia",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
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
                txtnnumprogu.ForeColor = Color.DimGray;
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
                txtnombrepro.ForeColor = Color.DimGray;
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
                txtcorreopro.ForeColor = Color.DimGray;
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
                txtladapro.ForeColor = Color.DimGray;
                lblla.Visible = false;
            }
        }

    }
}
