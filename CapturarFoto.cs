using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AForge.Video.DirectShow;
using AForge.Video;
using System.Windows.Forms;

namespace LoginCRUMAR
{
    public partial class CapturarFoto : Form
    {

        private bool hayDispositivos;
        private FilterInfoCollection misDispositivos;
        private VideoCaptureDevice miWebCAm;
        //pictureBox2.Image = Image.FromFile(@"C:\Users\jgarr\source\repos\WebCam\WebCamSave\usuario.jpeg");
        private string path = @"C:\Users\jgarr\source\repos\LoginCRUMAR\EmpleadosFotos\";
        private string usuario;
        private Image img;
        private Panel panelCont;
        private PictureBox pic;

        public CapturarFoto(string usuario, Panel panelCont, PictureBox pb)
        {
            InitializeComponent();
            this.usuario = usuario;
            misDispositivos = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            ActivarCamara();
            this.panelCont = panelCont;
            this.pic = pb;
        }

        private void ActivarCamara()
        {
            CerrarWebCam();
            string NombreVide = misDispositivos[0].MonikerString;
            miWebCAm = new VideoCaptureDevice(NombreVide);
            miWebCAm.NewFrame += new NewFrameEventHandler(Capturando);
            miWebCAm.Start();
        }

        private void CapturarFoto_Load(object sender, EventArgs e)
        {

        }

        public void CerrarWebCam()
        {
            if (miWebCAm != null && miWebCAm.IsRunning)
            {
                miWebCAm.SignalToStop();
                miWebCAm = null;
            }

        }

        private void Capturando(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap imagen = (Bitmap)eventArgs.Frame.Clone();
            fPbFoto.Image = imagen;
        }

        private void fBtnCapturar_Click(object sender, EventArgs e)
        {
            if (miWebCAm != null && miWebCAm.IsRunning)
            {
                CerrarWebCam();
                img = fPbFoto.Image;
            }
        }

        private void fBtnGuardar_Click(object sender, EventArgs e)
        {
            if (img != null)
            {
                img.Save(path + usuario +".jpeg", ImageFormat.Jpeg);
                pic.Image = img;
                panelCont.Hide();
            }    
        }

        private void fBtnReintentar_Click(object sender, EventArgs e)
        {
                ActivarCamara();
        }

        private void CapturarFoto_FormClosed(object sender, FormClosedEventArgs e)
        {
            CerrarWebCam();
        }
    }
}
