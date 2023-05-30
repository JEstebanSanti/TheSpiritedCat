using MySql.Data.MySqlClient;
using System.Reflection.Metadata.Ecma335;

namespace TheSpiritedCat
{
    public partial class PanelPrincipal : Form
    {
        // Class Variables

        // Mysql
        MySqlConnection mysqlCon = new MySqlConnection("server=localhost;database=pos;uid=root;pwd=123");
        MySqlCommand cmd;
        MySqlDataReader reader;

        // Mysql Strings
        string query = "";
        string quantity = "";
        double total = 0;

        public PanelPrincipal()
        {
            InitializeComponent();
        }

        private void PanelPrincipal_Load(object sender, EventArgs e)
        {
            // Fonts
            Font fontTitle = new Font("Arial", 29, FontStyle.Bold);
            Font font = new Font("Arial", 18);
            Font fontDev = new Font("Arial", 18, FontStyle.Italic);
            labelTitle.Font = fontTitle;
            labelTotal.Font = fontTitle;
            labelDate.Font = font;
            labelDeveloper.Font = font;
            textBoxCodigo.Font = font;

            // Data Propieties
            pictureBoxIcon.Image = Image.FromFile("../../../img/the-spirited-cat-logo.png");
            pictureBoxIcon.SizeMode = PictureBoxSizeMode.Zoom;
            labelDeveloper.Text = "Developed By JBanS";
            labelTitle.Text = "The Spirited Cat";
            pictureBoxIcon.Size = new Size(300, labelDate.Height + labelDeveloper.Height + labelTitle.Height + 90);
            this.BackColor = Color.FromArgb(242, 242, 242);
            buttonBeefService.FlatStyle = FlatStyle.Flat;
            buttonBeefService.Image = Image.FromFile("../../../img/filete-servicio-100.png");
            buttonBeefService.ImageAlign = ContentAlignment.MiddleCenter;
            buttonIce.ImageAlign = ContentAlignment.MiddleCenter;
            buttonIce.Font = new Font("Arial", 14, FontStyle.Bold);
            buttonBeefService.Font = new Font("Arial", 14, FontStyle.Bold);
            buttonBeefService.Size = new Size(180, 180);
            buttonIce.Size = new Size(180, 180);
            buttonBeefService.Text = "Servicio Carne";
            buttonIce.FlatStyle = FlatStyle.Flat;
            buttonIce.Text = "Bebidas ICE";
            buttonBeefService.TextAlign = ContentAlignment.BottomCenter;
            buttonIce.TextAlign = ContentAlignment.BottomCenter;
            buttonIce.Image = Image.FromFile("../../../img/soda-servicio-100.png");



            // date label
            labelDate.Text = DateTime.Now.ToLongTimeString() + " " + DateTime.Now.ToLongDateString();
            // Items Location
            pictureBoxIcon.Location = new Point(10, 10);
            labelTitle.Location = new Point((this.Width / 2) - (labelTitle.Width / 2), 10);
            labelDeveloper.Location = new Point(((this.Width / 2) - (labelDeveloper.Width / 2)), labelTitle.Height + labelDeveloper.Height);
            labelDate.Location = new Point((this.Width / 2) - (labelDate.Width / 2), (labelTitle.Height + labelDeveloper.Height + labelDate.Height));
            dataGridViewProductos.Location = new Point((10), (labelTitle.Height + labelDeveloper.Height + labelDate.Height + pictureBoxIcon.Height));
            dataGridViewProductos.Width = (this.Width - 20);
            dataGridViewProductos.Height = (this.Height / 4) * 2;
            dataGridViewProductos.BackgroundColor = Color.White;
            textBoxCodigo.Location = new Point(10, labelTitle.Height+pictureBoxIcon.Height);
            textBoxCodigo.Width = this.Width - 20;
            buttonBeefService.Location = new Point(this.Width/2-buttonBeefService.Width/2, dataGridViewProductos.Height + labelDeveloper.Height + labelTitle.Height + labelDate.Height + pictureBoxIcon.Height);
            buttonIce.Location = new Point(this.Width / 2 - buttonIce.Width / 2 - buttonIce.Width, dataGridViewProductos.Height + labelDeveloper.Height + labelTitle.Height + labelDate.Height + pictureBoxIcon.Height);
            labelTotal.Location = new Point((this.Width / 2) + pictureBoxIcon.Width + labelTitle.Width, labelTitle.Height + labelDeveloper.Height);







        }
    }
}