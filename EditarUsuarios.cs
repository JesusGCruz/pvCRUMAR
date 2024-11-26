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
    public partial class EditarUsuarios : Form
    {
        public EditarUsuarios()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            GestionarUsuarios gesInven = new GestionarUsuarios();
            AddOwnedForm(gesInven);
            gesInven.FormBorderStyle = FormBorderStyle.None;
            gesInven.TopLevel = false;
            gesInven.Dock = DockStyle.Fill;
            this.Controls.Add(gesInven);
            this.Tag = gesInven;
            gesInven.BringToFront();
            gesInven.Show();
        }
    }
}
