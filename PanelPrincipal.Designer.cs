namespace TheSpiritedCat
{
    partial class PanelPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            labelTitle = new Label();
            labelDeveloper = new Label();
            labelDate = new Label();
            dataGridViewProductos = new DataGridView();
            textBoxCodigo = new TextBox();
            button_ice = new Button();
            button_secret = new Button();
            pictureBoxIcon = new PictureBox();
            labelTotal = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            button_eliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).BeginInit();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Location = new Point(346, 32);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(37, 15);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Titulo";
            // 
            // labelDeveloper
            // 
            labelDeveloper.AutoSize = true;
            labelDeveloper.Location = new Point(316, 59);
            labelDeveloper.Name = "labelDeveloper";
            labelDeveloper.Size = new Size(94, 15);
            labelDeveloper.TabIndex = 1;
            labelDeveloper.Text = "Desarrollado por";
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Location = new Point(345, 74);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(30, 15);
            labelDate.TabIndex = 2;
            labelDate.Text = "date";
            // 
            // dataGridViewProductos
            // 
            dataGridViewProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProductos.GridColor = SystemColors.ActiveBorder;
            dataGridViewProductos.Location = new Point(234, 117);
            dataGridViewProductos.Name = "dataGridViewProductos";
            dataGridViewProductos.ReadOnly = true;
            dataGridViewProductos.RowTemplate.Height = 25;
            dataGridViewProductos.Size = new Size(240, 150);
            dataGridViewProductos.TabIndex = 3;
            // 
            // textBoxCodigo
            // 
            textBoxCodigo.Location = new Point(518, 379);
            textBoxCodigo.Name = "textBoxCodigo";
            textBoxCodigo.Size = new Size(100, 23);
            textBoxCodigo.TabIndex = 4;
            textBoxCodigo.KeyPress += textBoxCodigo_KeyPress;
            textBoxCodigo.PreviewKeyDown += textBoxCodigo_PreviewKeyDown;
            // 
            // button_ice
            // 
            button_ice.Location = new Point(90, 418);
            button_ice.Name = "button_ice";
            button_ice.Size = new Size(75, 23);
            button_ice.TabIndex = 5;
            button_ice.Text = "btn2";
            button_ice.UseVisualStyleBackColor = true;
            // 
            // button_secret
            // 
            button_secret.Location = new Point(217, 418);
            button_secret.Name = "button_secret";
            button_secret.Size = new Size(130, 23);
            button_secret.TabIndex = 6;
            button_secret.Text = "btn1";
            button_secret.UseVisualStyleBackColor = true;
            // 
            // pictureBoxIcon
            // 
            pictureBoxIcon.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxIcon.Location = new Point(46, 74);
            pictureBoxIcon.Name = "pictureBoxIcon";
            pictureBoxIcon.Size = new Size(100, 50);
            pictureBoxIcon.TabIndex = 7;
            pictureBoxIcon.TabStop = false;
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Location = new Point(580, 109);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(32, 15);
            labelTotal.TabIndex = 8;
            labelTotal.Text = "Total";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += time_tick;
            // 
            // button_eliminar
            // 
            button_eliminar.Location = new Point(380, 418);
            button_eliminar.Name = "button_eliminar";
            button_eliminar.Size = new Size(75, 23);
            button_eliminar.TabIndex = 9;
            button_eliminar.Text = "btn3";
            button_eliminar.UseVisualStyleBackColor = true;
            button_eliminar.Click += button_eliminar_Click;
            // 
            // PanelPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(847, 469);
            Controls.Add(button_eliminar);
            Controls.Add(labelTotal);
            Controls.Add(pictureBoxIcon);
            Controls.Add(button_secret);
            Controls.Add(button_ice);
            Controls.Add(textBoxCodigo);
            Controls.Add(dataGridViewProductos);
            Controls.Add(labelDate);
            Controls.Add(labelDeveloper);
            Controls.Add(labelTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PanelPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TheSpiritedCat";
            WindowState = FormWindowState.Maximized;
            Load += PanelPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private Label labelDeveloper;
        private Label labelDate;
        private DataGridView dataGridViewProductos;
        private TextBox textBoxCodigo;
        private Button button_ice;
        private Button button_secret;
        private PictureBox pictureBoxIcon;
        private Label labelTotal;
        private System.Windows.Forms.Timer timer1;
        private Button button_eliminar;
    }
}