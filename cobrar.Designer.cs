namespace TheSpiritedCat
{
    partial class cobrar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelCobrar = new Label();
            textBoxCobrar = new TextBox();
            SuspendLayout();
            // 
            // labelCobrar
            // 
            labelCobrar.AutoSize = true;
            labelCobrar.Location = new Point(196, 34);
            labelCobrar.Name = "labelCobrar";
            labelCobrar.Size = new Size(38, 15);
            labelCobrar.TabIndex = 0;
            labelCobrar.Text = "label1";
            // 
            // textBoxCobrar
            // 
            textBoxCobrar.Location = new Point(178, 108);
            textBoxCobrar.Name = "textBoxCobrar";
            textBoxCobrar.Size = new Size(100, 23);
            textBoxCobrar.TabIndex = 1;
            textBoxCobrar.KeyDown += textBoxCobrar_KeyDown;
            // 
            // cobrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxCobrar);
            Controls.Add(labelCobrar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "cobrar";
            StartPosition = FormStartPosition.CenterParent;
            Text = "cobrar";
            Load += cobrar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCobrar;
        private TextBox textBoxCobrar;
    }
}