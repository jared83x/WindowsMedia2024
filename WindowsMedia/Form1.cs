namespace WindowsMedia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cboListaCanales_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboListaCanales.SelectedIndex)
            {
                case 0:
                    lblCanal.Text = "America";
                    lblURL.Text = "https://www.americatv.com.pe/";
                    break;
                case 1:
                    lblCanal.Text = "Latina";
                    lblURL.Text = "https://www.latina.pe/";
                    break;
                case 2:
                    lblCanal.Text = "Panamericana";
                    lblURL.Text = "https://panamericana.pe/";
                    break;
                case 3:
                    lblCanal.Text = "ATV";
                    lblURL.Text = "https://www.atv.pe/";
                    break;
                default:
                    break;
            }
        }

        private void btnReproducir_Click(object sender, EventArgs e)
        {
            wmReproductor.URL = @"D:\peliculas\accion\Furiosa De la Saga Mad Max (2024) 720p DUAL 2.28 GB.mkv";
        }
    }
}
