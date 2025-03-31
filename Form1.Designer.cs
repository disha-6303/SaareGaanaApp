namespace SaareGaaneAap
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.track_list = new System.Windows.Forms.ListBox();
            this.btn_stop = new System.Windows.Forms.Button();
            this.btn_pause = new System.Windows.Forms.Button();
            this.btn_play = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_preview = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_track_end = new System.Windows.Forms.Label();
            this.lbl_track_start = new System.Windows.Forms.Label();
            this.lbl_volume = new System.Windows.Forms.Label();
            this.track_volume = new System.Windows.Forms.TrackBar();
            this.pic_art = new System.Windows.Forms.PictureBox();
            this.p_bar = new System.Windows.Forms.ProgressBar();
            this.btn_open = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.track_volume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_art)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // track_list
            // 
            this.track_list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.track_list.ForeColor = System.Drawing.Color.IndianRed;
            this.track_list.FormattingEnabled = true;
            this.track_list.ItemHeight = 16;
            this.track_list.Location = new System.Drawing.Point(244, 108);
            this.track_list.Name = "track_list";
            this.track_list.Size = new System.Drawing.Size(489, 212);
            this.track_list.TabIndex = 23;
            this.track_list.SelectedIndexChanged += new System.EventHandler(this.track_list_SelectedIndexChanged);
            // 
            // btn_stop
            // 
            this.btn_stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stop.ForeColor = System.Drawing.Color.HotPink;
            this.btn_stop.Location = new System.Drawing.Point(477, 381);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(89, 32);
            this.btn_stop.TabIndex = 20;
            this.btn_stop.Text = "Stop";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // btn_pause
            // 
            this.btn_pause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pause.ForeColor = System.Drawing.Color.HotPink;
            this.btn_pause.Location = new System.Drawing.Point(363, 381);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(89, 32);
            this.btn_pause.TabIndex = 19;
            this.btn_pause.Text = "Pause";
            this.btn_pause.UseVisualStyleBackColor = true;
            this.btn_pause.Click += new System.EventHandler(this.btn_pause_Click);
            // 
            // btn_play
            // 
            this.btn_play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_play.ForeColor = System.Drawing.Color.HotPink;
            this.btn_play.Location = new System.Drawing.Point(253, 381);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(89, 32);
            this.btn_play.TabIndex = 18;
            this.btn_play.Text = "Play";
            this.btn_play.UseVisualStyleBackColor = true;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // btn_next
            // 
            this.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_next.ForeColor = System.Drawing.Color.HotPink;
            this.btn_next.Location = new System.Drawing.Point(144, 381);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(89, 32);
            this.btn_next.TabIndex = 17;
            this.btn_next.Text = "Next";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_preview
            // 
            this.btn_preview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_preview.ForeColor = System.Drawing.Color.HotPink;
            this.btn_preview.Location = new System.Drawing.Point(32, 381);
            this.btn_preview.Name = "btn_preview";
            this.btn_preview.Size = new System.Drawing.Size(89, 32);
            this.btn_preview.TabIndex = 16;
            this.btn_preview.Text = "Preview";
            this.btn_preview.UseVisualStyleBackColor = true;
            this.btn_preview.Click += new System.EventHandler(this.btn_preview_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Thistle;
            this.label1.Font = new System.Drawing.Font("Harrington", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepPink;
            this.label1.Location = new System.Drawing.Point(746, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Volume";
            // 
            // lbl_track_end
            // 
            this.lbl_track_end.AutoSize = true;
            this.lbl_track_end.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_track_end.ForeColor = System.Drawing.Color.HotPink;
            this.lbl_track_end.Location = new System.Drawing.Point(601, 37);
            this.lbl_track_end.Name = "lbl_track_end";
            this.lbl_track_end.Size = new System.Drawing.Size(132, 56);
            this.lbl_track_end.TabIndex = 28;
            this.lbl_track_end.Text = "00:00";
            // 
            // lbl_track_start
            // 
            this.lbl_track_start.AutoSize = true;
            this.lbl_track_start.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_track_start.ForeColor = System.Drawing.Color.HotPink;
            this.lbl_track_start.Location = new System.Drawing.Point(76, 40);
            this.lbl_track_start.Name = "lbl_track_start";
            this.lbl_track_start.Size = new System.Drawing.Size(132, 56);
            this.lbl_track_start.TabIndex = 27;
            this.lbl_track_start.Text = "00:00";
            // 
            // lbl_volume
            // 
            this.lbl_volume.AutoSize = true;
            this.lbl_volume.BackColor = System.Drawing.Color.Thistle;
            this.lbl_volume.Font = new System.Drawing.Font("Harrington", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_volume.ForeColor = System.Drawing.Color.DeepPink;
            this.lbl_volume.Location = new System.Drawing.Point(739, 110);
            this.lbl_volume.Name = "lbl_volume";
            this.lbl_volume.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_volume.Size = new System.Drawing.Size(58, 24);
            this.lbl_volume.TabIndex = 26;
            this.lbl_volume.Text = "100%";
            // 
            // track_volume
            // 
            this.track_volume.BackColor = System.Drawing.Color.Thistle;
            this.track_volume.Location = new System.Drawing.Point(739, 129);
            this.track_volume.Maximum = 100;
            this.track_volume.Name = "track_volume";
            this.track_volume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.track_volume.Size = new System.Drawing.Size(56, 191);
            this.track_volume.TabIndex = 25;
            this.track_volume.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.track_volume.Scroll += new System.EventHandler(this.track_volume_Scroll);
            // 
            // pic_art
            // 
            this.pic_art.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_art.Image = global::SaareGaaneAap.Properties.Resources.P7;
            this.pic_art.Location = new System.Drawing.Point(32, 108);
            this.pic_art.Name = "pic_art";
            this.pic_art.Size = new System.Drawing.Size(201, 212);
            this.pic_art.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_art.TabIndex = 24;
            this.pic_art.TabStop = false;
            // 
            // p_bar
            // 
            this.p_bar.Location = new System.Drawing.Point(32, 353);
            this.p_bar.Name = "p_bar";
            this.p_bar.Size = new System.Drawing.Size(734, 10);
            this.p_bar.TabIndex = 22;
            this.p_bar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.p_bar_MouseDown);
            // 
            // btn_open
            // 
            this.btn_open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_open.ForeColor = System.Drawing.Color.HotPink;
            this.btn_open.Location = new System.Drawing.Point(598, 381);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(168, 32);
            this.btn_open.TabIndex = 21;
            this.btn_open.Text = "Open";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Thistle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-13, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(827, 248);
            this.panel1.TabIndex = 29;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // player
            // 
            this.player.Dock = System.Windows.Forms.DockStyle.Top;
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(0, 0);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(800, 147);
            this.player.TabIndex = 30;
            this.player.Enter += new System.EventHandler(this.player_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.track_list);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_pause);
            this.Controls.Add(this.btn_play);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_preview);
            this.Controls.Add(this.lbl_track_end);
            this.Controls.Add(this.lbl_track_start);
            this.Controls.Add(this.lbl_volume);
            this.Controls.Add(this.track_volume);
            this.Controls.Add(this.pic_art);
            this.Controls.Add(this.p_bar);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.player);
            this.Name = "Form1";
            this.Text = "SaareGaaneApp";
            ((System.ComponentModel.ISupportInitialize)(this.track_volume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_art)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox track_list;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button btn_pause;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_preview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_track_end;
        private System.Windows.Forms.Label lbl_track_start;
        private System.Windows.Forms.Label lbl_volume;
        private System.Windows.Forms.TrackBar track_volume;
        private System.Windows.Forms.PictureBox pic_art;
        private System.Windows.Forms.ProgressBar p_bar;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.Panel panel1;
        private AxWMPLib.AxWindowsMediaPlayer player;
        private System.Windows.Forms.Timer timer1;
    }
}

