using MySql.Data.MySqlClient;
using System.Drawing;
using System.Reflection.Metadata.Ecma335;

namespace TheSpiritedCat
{
    public partial class PanelPrincipal : Form
    {
        // Class variables




        // Mysql Strings
        string query = "";
        string quantity = "";
        double total = 0;
        int rows = 0;
        MySqlConnection mysqlCon = new MySqlConnection("server=localhost;database=pos;uid=jban;pwd=;port=3306");

        public PanelPrincipal()
        {
            InitializeComponent();
        }

        private void PanelPrincipal_Load(object sender, EventArgs e)
        {

            // Fonts
            Font fontTitle = new Font("Arial", 29, FontStyle.Bold);
            Font font = new Font("Arial", 18);
            Font fontDataGrid = new Font("Arial", 18, FontStyle.Bold);
            Font fontDev = new Font("Arial", 18, FontStyle.Italic);
            labelTitle.Font = fontTitle;
            labelTitle.ForeColor = Color.FromArgb(237, 194, 242);
            labelDate.ForeColor = Color.FromArgb(237, 194, 242);
            labelTotal.ForeColor = Color.FromArgb(237, 194, 242);
            labelDeveloper.ForeColor = Color.FromArgb(237, 194, 242);

            labelTotal.Font = fontTitle;
            labelDate.Font = font;
            dataGridViewProductos.Font = font;
            labelDeveloper.Font = fontDev;
            textBoxCodigo.Font = font;

            // Data Properties
            pictureBoxIcon.Image = Image.FromFile("../../../img/the-spirited-cat-logo.png");
            pictureBoxIcon.SizeMode = PictureBoxSizeMode.Zoom;
            labelDeveloper.Text = "Developed By JBanS";
            labelTitle.Text = "The Spirited Cat";
            pictureBoxIcon.Size = new Size(200, labelTotal.Height + labelTitle.Height + labelDeveloper.Height + labelDate.Height);
            pictureBoxIcon.BorderStyle = BorderStyle.FixedSingle;
            button_secret.FlatStyle = FlatStyle.Flat;
            button_secret.ImageAlign = ContentAlignment.MiddleCenter;
            button_eliminar.FlatStyle = FlatStyle.Flat;
            button_eliminar.ImageAlign = ContentAlignment.MiddleCenter;
            button_ice.ImageAlign = ContentAlignment.MiddleCenter;
            button_ice.Font = new Font("Arial", 12, FontStyle.Bold);
            button_secret.Font = new Font("Arial", 12, FontStyle.Bold);
            button_secret.Size = new Size(120, 120);
            button_eliminar.Font = new Font("Arial", 12, FontStyle.Bold);
            button_eliminar.Size = new Size(120, 120);
            button_ice.Size = new Size(120, 120);
            button_secret.Text = "Servicio";
            button_ice.FlatStyle = FlatStyle.Flat;
            button_ice.Text = "Bebidas ICE";
            button_eliminar.Text = "Borrar";
            button_secret.TextAlign = ContentAlignment.BottomCenter;
            button_ice.TextAlign = ContentAlignment.BottomCenter;
            button_eliminar.TextAlign = ContentAlignment.BottomCenter;
            button_secret.BackColor = Color.FromArgb(237, 194, 242);
            button_ice.BackColor = Color.FromArgb(237, 194, 242);
            button_eliminar.BackColor = Color.FromArgb(237, 194, 242);




            // date label
            labelDate.Text = DateTime.Now.ToLongTimeString() + " " + DateTime.Now.ToLongDateString();
            // Items Location
            pictureBoxIcon.Location = new Point(10, 10);
            labelTitle.Location = new Point((this.Width / 2) - (labelTitle.Width / 2));
            labelDeveloper.Location = new Point(((this.Width / 2) - (labelDeveloper.Width / 2)), labelTitle.Height + labelDeveloper.Height);
            labelDate.Location = new Point((this.Width / 2) - (labelDate.Width / 2), (labelDate.Height + labelDeveloper.Height + labelTitle.Height));
            dataGridViewProductos.Location = new Point((20), (labelTotal.Height + labelTitle.Height + pictureBoxIcon.Height));
            dataGridViewProductos.Width = (this.Width / 3) * 2 + 60;
            dataGridViewProductos.Height = (this.Height / 4) * 2;
            dataGridViewProductos.BackgroundColor = Color.White;
            textBoxCodigo.Location = new Point(20, labelTitle.Height + pictureBoxIcon.Height);
            textBoxCodigo.Width = (this.Width / 3) * 2 + 60;


            button_secret.Location = new Point(this.Width / 2 - button_secret.Width / 2, dataGridViewProductos.Height + labelDeveloper.Height + labelTitle.Height + labelDate.Height + pictureBoxIcon.Height);
            button_ice.Location = new Point(this.Width / 2 - button_ice.Width / 2 - button_ice.Width, dataGridViewProductos.Height + labelDeveloper.Height + labelTitle.Height + labelDate.Height + pictureBoxIcon.Height);
            button_eliminar.Location = new Point(this.Width / 2 - button_eliminar.Width / 2 - button_eliminar.Width - button_ice.Width, dataGridViewProductos.Height + labelDeveloper.Height + labelTitle.Height + labelDate.Height + pictureBoxIcon.Height);

            labelTotal.Location = new Point(this.Width - dataGridViewProductos.Width / 3, this.Height - dataGridViewProductos.Height - pictureBoxIcon.Height);


            // datagrid rows and headers
            dataGridViewProductos.Columns.Add("cantidad", "Cantidad");
            dataGridViewProductos.Columns[0].HeaderCell.Style.Font = fontDataGrid;
            dataGridViewProductos.Columns[0].Width = dataGridViewProductos.Width * 15 / 100;

            dataGridViewProductos.Columns.Add("nombre", "Nombre");
            dataGridViewProductos.Columns[1].HeaderCell.Style.Font = fontDataGrid;
            dataGridViewProductos.Columns[1].Width = dataGridViewProductos.Width * 50 / 100;

            dataGridViewProductos.Columns.Add("precio", "Precio");
            dataGridViewProductos.Columns[2].HeaderCell.Style.Font = fontDataGrid;
            dataGridViewProductos.Columns[2].Width = dataGridViewProductos.Width * 15 / 100;

            dataGridViewProductos.Columns.Add("total", "Total");
            dataGridViewProductos.Columns[3].HeaderCell.Style.Font = fontDataGrid;
            dataGridViewProductos.Columns[3].Width = dataGridViewProductos.Width * 20 / 100;

            // style
            this.dataGridViewProductos.BorderStyle = BorderStyle.None;
            this.dataGridViewProductos.CellBorderStyle = DataGridViewCellBorderStyle.None;
            this.dataGridViewProductos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            this.dataGridViewProductos.RowHeadersVisible = false;
            // currency format
            dataGridViewProductos.Columns[2].DefaultCellStyle.Format = "C2";
            dataGridViewProductos.Columns[3].DefaultCellStyle.Format = "C2";

            // alingment
            dataGridViewProductos.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewProductos.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewProductos.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewProductos.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewProductos.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewProductos.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // only read

            dataGridViewProductos.ReadOnly = true;

            // setting always focused in the textBox
            textBoxCodigo.TabIndex = 0;



        }

        // live timer
        private void time_tick(object sender, EventArgs e)
        {
            labelDate.Text = DateTime.Now.ToLongTimeString() + " " + DateTime.Now.ToLongDateString();
        }

        private void textBoxCodigo_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                e.IsInputKey = true;
            }
        }

        private void textBoxCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) // key Enter
            {

                try
                {


                    if (textBoxCodigo.Text.IndexOf('*') != -1)
                    {

                        String[] producto = textBoxCodigo.Text.Split('*');
                        quantity = producto[0];
                        query = "SELECT * FROM productos WHERE codigo = " + "'" + producto[1] + "'";
                    }
                    else
                    {
                        quantity = "1";
                        query = "SELECT * FROM productos WHERE codigo = " + "'" + textBoxCodigo.Text + "'";
                    }

                    mysqlCon.Open();
                    MessageBox.Show(mysqlCon.State.ToString());

                    MySqlCommand cmd = new MySqlCommand(query, mysqlCon);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        rows = dataGridViewProductos.Rows.Add(quantity.ToString(), reader.GetString(2), Math.Round(reader.GetDouble(3), 2), (double.Parse(reader.GetString(3)) * double.Parse(quantity.ToString())));
                        dataGridViewProductos.ClearSelection();
                        dataGridViewProductos.Rows[rows].Selected = true;
                        if (rows < dataGridViewProductos.Rows.Count - 1)
                        {

                            dataGridViewProductos.CurrentCell = dataGridViewProductos.Rows[rows + 1].Cells[0];
                        }
                        updatePrice();
                    }
                    mysqlCon.Close();

                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    int errorcode = ex.Number;
                    MessageBox.Show("ERROR mysql" + ex.Message);

                }
                catch (Exception error)
                {
                    MessageBox.Show($"Error: {error.Message}");
                }
                finally
                {
                    textBoxCodigo.Clear();
                }


            }

            if (e.KeyChar == (char)112 || e.KeyChar == (char)80)
            {

                e.Handled = true;
                if (total != double.Parse(textBoxCodigo.Text))
                {



                }
                dataGridViewProductos.Rows.Clear();
                textBoxCodigo.Clear();


            }

        }

        private void updatePrice()
        {

            total = 0;
            int i = 0;
            foreach (DataGridViewRow row in dataGridViewProductos.Rows)
            {

                DataGridViewCell cell = row.Cells[3];
                if (cell.Value != null)
                {

                    double tempTotal = double.Parse(cell.Value.ToString());
                    total += tempTotal;
                    i++;

                }
                labelTotal.Text = "Total $ " + Math.Round(total, 2).ToString();
            }


        }

        private void button_eliminar_Click(object sender, EventArgs e)
        {
            int index = dataGridViewProductos.CurrentCell.RowIndex;

            if (dataGridViewProductos.CurrentRow != null && index >= 1)
            {
                dataGridViewProductos.Rows.RemoveAt(index - 1);
            }
            else 
            {
                MessageBox.Show("No hay mas que eliminar");
                return;

            }


        }
    }



}