namespace PlayMusic_app.Controls
{
    partial class Player
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Player));
            this.scroll_volume = new System.Windows.Forms.VScrollBar();
            this.lb_timer = new System.Windows.Forms.Label();
            this.lb_albumName = new System.Windows.Forms.Label();
            this.lb_artistName = new System.Windows.Forms.Label();
            this.lb_trackTitle = new System.Windows.Forms.Label();
            this.btn_repeat = new System.Windows.Forms.Button();
            this.btn_shuffle = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_play = new System.Windows.Forms.Button();
            this.btn_prev = new System.Windows.Forms.Button();
            this.CoverArt = new System.Windows.Forms.PictureBox();
            this.slider_trackBar = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.CoverArt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider_trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // scroll_volume
            // 
            this.scroll_volume.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.scroll_volume.Location = new System.Drawing.Point(627, 13);
            this.scroll_volume.Margin = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.scroll_volume.Name = "scroll_volume";
            this.scroll_volume.Size = new System.Drawing.Size(13, 76);
            this.scroll_volume.TabIndex = 67;
            this.scroll_volume.ValueChanged += new System.EventHandler(this.scroll_volume_ValueChanged);
            // 
            // lb_timer
            // 
            this.lb_timer.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lb_timer.AutoSize = true;
            this.lb_timer.Font = new System.Drawing.Font("Myriad Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_timer.ForeColor = System.Drawing.Color.White;
            this.lb_timer.Location = new System.Drawing.Point(139, 122);
            this.lb_timer.Name = "lb_timer";
            this.lb_timer.Size = new System.Drawing.Size(60, 16);
            this.lb_timer.TabIndex = 62;
            this.lb_timer.Text = "2:34/4:55";
            // 
            // lb_albumName
            // 
            this.lb_albumName.AccessibleDescription = "";
            this.lb_albumName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lb_albumName.AutoSize = true;
            this.lb_albumName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_albumName.ForeColor = System.Drawing.Color.Silver;
            this.lb_albumName.Location = new System.Drawing.Point(139, 58);
            this.lb_albumName.Name = "lb_albumName";
            this.lb_albumName.Size = new System.Drawing.Size(69, 16);
            this.lb_albumName.TabIndex = 59;
            this.lb_albumName.Text = "Linkin Park";
            // 
            // lb_artistName
            // 
            this.lb_artistName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lb_artistName.AutoSize = true;
            this.lb_artistName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_artistName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lb_artistName.Location = new System.Drawing.Point(139, 39);
            this.lb_artistName.Name = "lb_artistName";
            this.lb_artistName.Size = new System.Drawing.Size(68, 16);
            this.lb_artistName.TabIndex = 58;
            this.lb_artistName.Text = "Last Stand";
            // 
            // lb_trackTitle
            // 
            this.lb_trackTitle.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lb_trackTitle.AutoSize = true;
            this.lb_trackTitle.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_trackTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lb_trackTitle.Location = new System.Drawing.Point(137, 77);
            this.lb_trackTitle.Name = "lb_trackTitle";
            this.lb_trackTitle.Size = new System.Drawing.Size(106, 19);
            this.lb_trackTitle.TabIndex = 57;
            this.lb_trackTitle.Text = "In My Remains";
            // 
            // btn_repeat
            // 
            this.btn_repeat.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_repeat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_repeat.BackgroundImage")));
            this.btn_repeat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_repeat.FlatAppearance.BorderSize = 0;
            this.btn_repeat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_repeat.Location = new System.Drawing.Point(653, 64);
            this.btn_repeat.Margin = new System.Windows.Forms.Padding(0);
            this.btn_repeat.Name = "btn_repeat";
            this.btn_repeat.Size = new System.Drawing.Size(25, 25);
            this.btn_repeat.TabIndex = 66;
            this.btn_repeat.UseVisualStyleBackColor = true;
            this.btn_repeat.Click += new System.EventHandler(this.btn_repeat_Click);
            // 
            // btn_shuffle
            // 
            this.btn_shuffle.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_shuffle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_shuffle.BackgroundImage")));
            this.btn_shuffle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_shuffle.FlatAppearance.BorderSize = 0;
            this.btn_shuffle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_shuffle.Location = new System.Drawing.Point(653, 25);
            this.btn_shuffle.Margin = new System.Windows.Forms.Padding(0);
            this.btn_shuffle.Name = "btn_shuffle";
            this.btn_shuffle.Size = new System.Drawing.Size(25, 25);
            this.btn_shuffle.TabIndex = 65;
            this.btn_shuffle.UseVisualStyleBackColor = true;
            this.btn_shuffle.Click += new System.EventHandler(this.btn_shuffle_Click);
            // 
            // btn_next
            // 
            this.btn_next.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_next.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_next.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_next.BackgroundImage")));
            this.btn_next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_next.FlatAppearance.BorderSize = 0;
            this.btn_next.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(177)))));
            this.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_next.Location = new System.Drawing.Point(535, 13);
            this.btn_next.Margin = new System.Windows.Forms.Padding(0);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(73, 81);
            this.btn_next.TabIndex = 64;
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_play
            // 
            this.btn_play.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_play.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_play.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_play.BackgroundImage")));
            this.btn_play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_play.FlatAppearance.BorderSize = 0;
            this.btn_play.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(177)))));
            this.btn_play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_play.Location = new System.Drawing.Point(434, 13);
            this.btn_play.Margin = new System.Windows.Forms.Padding(0);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(73, 81);
            this.btn_play.TabIndex = 63;
            this.btn_play.UseVisualStyleBackColor = true;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // btn_prev
            // 
            this.btn_prev.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_prev.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_prev.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_prev.BackgroundImage")));
            this.btn_prev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_prev.FlatAppearance.BorderSize = 0;
            this.btn_prev.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(177)))));
            this.btn_prev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_prev.Location = new System.Drawing.Point(333, 13);
            this.btn_prev.Margin = new System.Windows.Forms.Padding(0);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(73, 81);
            this.btn_prev.TabIndex = 60;
            this.btn_prev.UseVisualStyleBackColor = true;
            this.btn_prev.Click += new System.EventHandler(this.btn_prev_Click);
            // 
            // CoverArt
            // 
            this.CoverArt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CoverArt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CoverArt.Image = ((System.Drawing.Image)(resources.GetObject("CoverArt.Image")));
            this.CoverArt.Location = new System.Drawing.Point(6, 8);
            this.CoverArt.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.CoverArt.MaximumSize = new System.Drawing.Size(120, 135);
            this.CoverArt.Name = "CoverArt";
            this.CoverArt.Size = new System.Drawing.Size(120, 130);
            this.CoverArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CoverArt.TabIndex = 56;
            this.CoverArt.TabStop = false;
            // 
            // slider_trackBar
            // 
            this.slider_trackBar.LargeChange = 1;
            this.slider_trackBar.Location = new System.Drawing.Point(129, 100);
            this.slider_trackBar.Margin = new System.Windows.Forms.Padding(0);
            this.slider_trackBar.Name = "slider_trackBar";
            this.slider_trackBar.Size = new System.Drawing.Size(553, 45);
            this.slider_trackBar.TabIndex = 68;
            this.slider_trackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.slider_trackBar.Scroll += new System.EventHandler(this.slider_trackBar_Scroll);
            this.slider_trackBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.slider_trackBar_MouseDown);
            // 
            // Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(177)))));
            this.Controls.Add(this.lb_timer);
            this.Controls.Add(this.slider_trackBar);
            this.Controls.Add(this.scroll_volume);
            this.Controls.Add(this.btn_repeat);
            this.Controls.Add(this.btn_shuffle);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_play);
            this.Controls.Add(this.btn_prev);
            this.Controls.Add(this.lb_albumName);
            this.Controls.Add(this.lb_artistName);
            this.Controls.Add(this.lb_trackTitle);
            this.Controls.Add(this.CoverArt);
            this.MaximumSize = new System.Drawing.Size(700, 145);
            this.MinimumSize = new System.Drawing.Size(640, 100);
            this.Name = "Player";
            this.Size = new System.Drawing.Size(700, 145);
            ((System.ComponentModel.ISupportInitialize)(this.CoverArt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider_trackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.VScrollBar scroll_volume;
        private System.Windows.Forms.Button btn_repeat;
        private System.Windows.Forms.Button btn_shuffle;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Label lb_timer;
        private System.Windows.Forms.Button btn_prev;
        private System.Windows.Forms.Label lb_albumName;
        private System.Windows.Forms.Label lb_artistName;
        private System.Windows.Forms.Label lb_trackTitle;
        private System.Windows.Forms.PictureBox CoverArt;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.TrackBar slider_trackBar;
    }
}
