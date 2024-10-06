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
            axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            label1 = new Label();
            cboListaCanales = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).BeginInit();
            SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            axWindowsMediaPlayer1.Enabled = true;
            axWindowsMediaPlayer1.Location = new Point(12, 8);
            axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            axWindowsMediaPlayer1.OcxState = (AxHost.State)resources.GetObject("axWindowsMediaPlayer1.OcxState");
            axWindowsMediaPlayer1.Size = new Size(783, 428);
            axWindowsMediaPlayer1.TabIndex = 0;
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
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 536);
            Controls.Add(cboListaCanales);
            Controls.Add(label1);
            Controls.Add(axWindowsMediaPlayer1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private Label label1;
        private ComboBox cboListaCanales;
    }
}
