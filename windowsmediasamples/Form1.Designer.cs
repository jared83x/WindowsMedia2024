namespace windowsmediasamples
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
            groupBox1 = new GroupBox();
            lbl_volumen = new Label();
            label1 = new Label();
            volumen = new TrackBar();
            track_list = new ListBox();
            btn_abrir = new Button();
            btn_stop = new Button();
            btn_pause = new Button();
            btn_play = new Button();
            btn_anterior = new Button();
            lbl_mensaje = new Label();
            pb_progreso = new ProgressBar();
            lbl_track_end = new Label();
            lbl_track_star = new Label();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)volumen).BeginInit();
            SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            axWindowsMediaPlayer1.Enabled = true;
            axWindowsMediaPlayer1.Location = new Point(12, 36);
            axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            axWindowsMediaPlayer1.OcxState = (AxHost.State)resources.GetObject("axWindowsMediaPlayer1.OcxState");
            axWindowsMediaPlayer1.Size = new Size(642, 312);
            axWindowsMediaPlayer1.TabIndex = 0;
            axWindowsMediaPlayer1.Enter += axWindowsMediaPlayer1_Enter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbl_volumen);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(volumen);
            groupBox1.Controls.Add(track_list);
            groupBox1.Controls.Add(btn_abrir);
            groupBox1.Controls.Add(btn_stop);
            groupBox1.Controls.Add(btn_pause);
            groupBox1.Controls.Add(btn_play);
            groupBox1.Controls.Add(btn_anterior);
            groupBox1.Location = new Point(12, 374);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(643, 254);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Controles ";
            // 
            // lbl_volumen
            // 
            lbl_volumen.AutoSize = true;
            lbl_volumen.Location = new Point(584, 54);
            lbl_volumen.Name = "lbl_volumen";
            lbl_volumen.Size = new Size(33, 20);
            lbl_volumen.TabIndex = 8;
            lbl_volumen.Text = "0 %";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(565, 221);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 7;
            label1.Text = "Volumen";
            // 
            // volumen
            // 
            volumen.BackColor = Color.White;
            volumen.Location = new Point(575, 77);
            volumen.Name = "volumen";
            volumen.Orientation = Orientation.Vertical;
            volumen.Size = new Size(56, 141);
            volumen.TabIndex = 6;
            volumen.TickStyle = TickStyle.Both;
            volumen.Value = 1;
            // 
            // track_list
            // 
            track_list.FormattingEnabled = true;
            track_list.Location = new Point(6, 77);
            track_list.Name = "track_list";
            track_list.Size = new Size(552, 164);
            track_list.TabIndex = 5;
            track_list.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // btn_abrir
            // 
            btn_abrir.Location = new Point(464, 26);
            btn_abrir.Name = "btn_abrir";
            btn_abrir.Size = new Size(94, 29);
            btn_abrir.TabIndex = 4;
            btn_abrir.Text = "Abrir";
            btn_abrir.UseVisualStyleBackColor = true;
            // 
            // btn_stop
            // 
            btn_stop.Location = new Point(350, 26);
            btn_stop.Name = "btn_stop";
            btn_stop.Size = new Size(94, 29);
            btn_stop.TabIndex = 3;
            btn_stop.Text = "Stop";
            btn_stop.UseVisualStyleBackColor = true;
            // 
            // btn_pause
            // 
            btn_pause.Location = new Point(235, 26);
            btn_pause.Name = "btn_pause";
            btn_pause.Size = new Size(94, 29);
            btn_pause.TabIndex = 2;
            btn_pause.Text = "Pause";
            btn_pause.UseVisualStyleBackColor = true;
            // 
            // btn_play
            // 
            btn_play.Location = new Point(118, 26);
            btn_play.Name = "btn_play";
            btn_play.Size = new Size(94, 29);
            btn_play.TabIndex = 1;
            btn_play.Text = "Play";
            btn_play.UseVisualStyleBackColor = true;
            // 
            // btn_anterior
            // 
            btn_anterior.Location = new Point(6, 26);
            btn_anterior.Name = "btn_anterior";
            btn_anterior.Size = new Size(94, 29);
            btn_anterior.TabIndex = 0;
            btn_anterior.Text = "Anterior";
            btn_anterior.UseVisualStyleBackColor = true;
            btn_anterior.Click += button1_Click;
            // 
            // lbl_mensaje
            // 
            lbl_mensaje.AutoSize = true;
            lbl_mensaje.Location = new Point(14, 13);
            lbl_mensaje.Name = "lbl_mensaje";
            lbl_mensaje.Size = new Size(50, 20);
            lbl_mensaje.TabIndex = 2;
            lbl_mensaje.Text = "label1";
            // 
            // pb_progreso
            // 
            pb_progreso.Location = new Point(57, 354);
            pb_progreso.Name = "pb_progreso";
            pb_progreso.Size = new Size(547, 14);
            pb_progreso.TabIndex = 3;
            pb_progreso.Value = 85;
            // 
            // lbl_track_end
            // 
            lbl_track_end.AutoSize = true;
            lbl_track_end.Location = new Point(610, 351);
            lbl_track_end.Name = "lbl_track_end";
            lbl_track_end.Size = new Size(44, 20);
            lbl_track_end.TabIndex = 4;
            lbl_track_end.Text = "04:00";
            // 
            // lbl_track_star
            // 
            lbl_track_star.AutoSize = true;
            lbl_track_star.Location = new Point(1, 351);
            lbl_track_star.Name = "lbl_track_star";
            lbl_track_star.Size = new Size(44, 20);
            lbl_track_star.TabIndex = 5;
            lbl_track_star.Text = "00:00";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(667, 640);
            Controls.Add(lbl_track_star);
            Controls.Add(lbl_track_end);
            Controls.Add(pb_progreso);
            Controls.Add(lbl_mensaje);
            Controls.Add(groupBox1);
            Controls.Add(axWindowsMediaPlayer1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)volumen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private GroupBox groupBox1;
        private Button btn_anterior;
        private Button btn_abrir;
        private Button btn_stop;
        private Button btn_pause;
        private Button btn_play;
        private ListBox track_list;
        private TrackBar volumen;
        private Label lbl_mensaje;
        private Label lbl_volumen;
        private Label label1;
        private ProgressBar pb_progreso;
        private Label lbl_track_end;
        private Label lbl_track_star;
    }
}
