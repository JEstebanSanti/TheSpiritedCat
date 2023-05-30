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
            labelTitle = new Label();
            labelDeveloper = new Label();
            labelDate = new Label();
            dataGridViewProductos = new DataGridView();
            textBoxCodigo = new TextBox();
            buttonIce = new Button();
            buttonBeefService = new Button();
            pictureBoxIcon = new PictureBox();
            labelTotal = new Label();
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
            labelDate.Size = new Size(38, 15);
            labelDate.TabIndex = 2;
            labelDate.Text = "label3";
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
            // 
            // buttonIce
            // 
            buttonIce.Location = new Point(90, 418);
            buttonIce.Name = "buttonIce";
            buttonIce.Size = new Size(75, 23);
            buttonIce.TabIndex = 5;
            buttonIce.Text = "Bebidas";
            buttonIce.UseVisualStyleBackColor = true;
            // 
            // buttonBeefService
            // 
            buttonBeefService.Location = new Point(217, 418);
            buttonBeefService.Name = "buttonBeefService";
            buttonBeefService.Size = new Size(130, 23);
            buttonBeefService.TabIndex = 6;
            buttonBeefService.Text = "Servicio de Carne Asada";
            buttonBeefService.UseVisualStyleBackColor = true;
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
            // PanelPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(847, 469);
            Controls.Add(labelTotal);
            Controls.Add(pictureBoxIcon);
            Controls.Add(buttonBeefService);
            Controls.Add(buttonIce);
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
        private Button buttonIce;
        private Button buttonBeefService;
        private PictureBox pictureBoxIcon;
        private Label labelTotal;
    }
}