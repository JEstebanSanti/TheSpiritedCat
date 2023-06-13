using LibPrintTicket;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheSpiritedCat
{
    public partial class cobrar : Form
    {
        double total = PanelPrincipal.total;
        public static double cambio = 0;
        double dineroRecibido = 0;
        public cobrar()
        {
            InitializeComponent();
        }

        private void cobrar_Load(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(241, 228, 247);
            this.StartPosition = FormStartPosition.CenterParent;
            this.Width = 500;
            this.Height = 200;
            labelCobrar.Font = new Font("Arial", 16, FontStyle.Bold);
            labelCobrar.Location = new Point(this.Width / 2 -textBoxCobrar.Width/2, 10);
            labelCobrar.Text = "COBRAR $ "+this.total;
            textBoxCobrar.Width = this.Width / 2;
            textBoxCobrar.Location = new Point(this.Width / 2 -textBoxCobrar.Width/2, labelCobrar.Height + 10);
        }

        private void textBoxCobrar_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                dineroRecibido += double.Parse(textBoxCobrar.Text);
                textBoxCobrar.Clear();
                cambioCheck(dineroRecibido);


            }
        }
        public void cambioCheck(double recibido) 
        {
            if (recibido > total) 
            {
                cambio = recibido - total;
                MessageBox.Show(cambio.ToString());
                this.Close();
            }
            labelCobrar.Text = "COBRAR $" + (total - recibido);
        }

        
    }
}
