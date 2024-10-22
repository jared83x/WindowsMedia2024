namespace WindowsMedia
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            wmReproductor = new AxWMPLib.AxWindowsMediaPlayer();
            label1 = new Label();
            cboListaCanales = new ComboBox();
            lblCanal = new Label();
            lblURL = new Label();
            btnReproducir = new Button();
            ((System.ComponentModel.ISupportInitialize)wmReproductor).BeginInit();
            SuspendLayout();
            // 
            // wmReproductor
            // 
            wmReproductor.Enabled = true;
            wmReproductor.Location = new Point(12, 8);
            wmReproductor.Name = "wmReproductor";
            wmReproductor.OcxState = (AxHost.State)resources.GetObject("wmReproductor.OcxState");
            wmReproductor.Size = new Size(783, 428);
            wmReproductor.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 468);
            label1.Name = "label1";
            label1.Size = new Size(142, 20);
            label1.TabIndex = 1;
            label1.Text = "Seleccionar canales ";
            // 
            // cboListaCanales
            // 
            cboListaCanales.FormattingEnabled = true;
            cboListaCanales.Items.AddRange(new object[] { "America", "Latina", "Panamericana", "ATV" });
            cboListaCanales.Location = new Point(160, 460);
            cboListaCanales.Name = "cboListaCanales";
            cboListaCanales.Size = new Size(166, 28);
            cboListaCanales.TabIndex = 2;
            cboListaCanales.SelectedIndexChanged += cboListaCanales_SelectedIndexChanged;
            // 
            // lblCanal
            // 
            lblCanal.AutoSize = true;
            lblCanal.Location = new Point(388, 460);
            lblCanal.Name = "lblCanal";
            lblCanal.Size = new Size(50, 20);
            lblCanal.TabIndex = 3;
            lblCanal.Text = "label2";
            // 
            // lblURL
            // 
            lblURL.AutoSize = true;
            lblURL.Location = new Point(388, 489);
            lblURL.Name = "lblURL";
            lblURL.Size = new Size(50, 20);
            lblURL.TabIndex = 4;
            lblURL.Text = "label3";
            // 
            // btnReproducir
            // 
            btnReproducir.Location = new Point(530, 450);
            btnReproducir.Name = "btnReproducir";
            btnReproducir.Size = new Size(149, 46);
            btnReproducir.TabIndex = 5;
            btnReproducir.Text = "Reproducir";
            btnReproducir.UseVisualStyleBackColor = true;
            btnReproducir.Click += btnReproducir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 536);
            Controls.Add(btnReproducir);
            Controls.Add(lblURL);
            Controls.Add(lblCanal);
            Controls.Add(cboListaCanales);
            Controls.Add(label1);
            Controls.Add(wmReproductor);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)wmReproductor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer wmReproductor;
        private Label label1;
        private ComboBox cboListaCanales;
        private Label lblCanal;
        private Label lblURL;
        private Button btnReproducir;
    }
}
