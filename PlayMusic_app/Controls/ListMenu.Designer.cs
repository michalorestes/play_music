namespace PlayMusic_app.Controls
{
    partial class ListMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListMenu));
            this.panel_tabs = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_albums = new System.Windows.Forms.Button();
            this.btn_artists = new System.Windows.Forms.Button();
            this.btn_queue = new System.Windows.Forms.Button();
            this.btn_playlists = new System.Windows.Forms.Button();
            this.panel_displaysContainer = new System.Windows.Forms.Panel();
            this.panel_albumsDisplay = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_artistsDisplay = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_playlistsDisplay = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_queueDisplay = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_allSongs = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_tabs.SuspendLayout();
            this.panel_displaysContainer.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_tabs
            // 
            this.panel_tabs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(111)))), ((int)(((byte)(193)))));
            this.panel_tabs.Controls.Add(this.label4);
            this.panel_tabs.Controls.Add(this.label3);
            this.panel_tabs.Controls.Add(this.label2);
            this.panel_tabs.Controls.Add(this.btn_albums);
            this.panel_tabs.Controls.Add(this.btn_artists);
            this.panel_tabs.Controls.Add(this.btn_queue);
            this.panel_tabs.Controls.Add(this.btn_playlists);
            this.panel_tabs.Location = new System.Drawing.Point(0, 0);
            this.panel_tabs.Margin = new System.Windows.Forms.Padding(0);
            this.panel_tabs.Name = "panel_tabs";
            this.panel_tabs.Size = new System.Drawing.Size(431, 42);
            this.panel_tabs.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(111)))), ((int)(((byte)(193)))));
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(126, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 29);
            this.label4.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(111)))), ((int)(((byte)(193)))));
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(242, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 29);
            this.label3.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(111)))), ((int)(((byte)(193)))));
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(342, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 29);
            this.label2.TabIndex = 15;
            // 
            // btn_albums
            // 
            this.btn_albums.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(111)))), ((int)(((byte)(193)))));
            this.btn_albums.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_albums.FlatAppearance.BorderSize = 0;
            this.btn_albums.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_albums.Font = new System.Drawing.Font("Orator Std", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_albums.ForeColor = System.Drawing.Color.White;
            this.btn_albums.Location = new System.Drawing.Point(254, -3);
            this.btn_albums.Margin = new System.Windows.Forms.Padding(0);
            this.btn_albums.Name = "btn_albums";
            this.btn_albums.Size = new System.Drawing.Size(86, 45);
            this.btn_albums.TabIndex = 13;
            this.btn_albums.Text = "Albums";
            this.btn_albums.UseVisualStyleBackColor = false;
            this.btn_albums.Click += new System.EventHandler(this.btn_playlists_Click);
            // 
            // btn_artists
            // 
            this.btn_artists.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(111)))), ((int)(((byte)(193)))));
            this.btn_artists.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_artists.FlatAppearance.BorderSize = 0;
            this.btn_artists.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_artists.Font = new System.Drawing.Font("Orator Std", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_artists.ForeColor = System.Drawing.Color.White;
            this.btn_artists.Location = new System.Drawing.Point(139, -6);
            this.btn_artists.Margin = new System.Windows.Forms.Padding(0);
            this.btn_artists.Name = "btn_artists";
            this.btn_artists.Size = new System.Drawing.Size(102, 54);
            this.btn_artists.TabIndex = 12;
            this.btn_artists.Text = "Artists";
            this.btn_artists.UseVisualStyleBackColor = false;
            this.btn_artists.Click += new System.EventHandler(this.btn_playlists_Click);
            // 
            // btn_queue
            // 
            this.btn_queue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(111)))), ((int)(((byte)(193)))));
            this.btn_queue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_queue.FlatAppearance.BorderSize = 0;
            this.btn_queue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_queue.Font = new System.Drawing.Font("Orator Std", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_queue.ForeColor = System.Drawing.Color.White;
            this.btn_queue.Location = new System.Drawing.Point(354, -3);
            this.btn_queue.Margin = new System.Windows.Forms.Padding(0);
            this.btn_queue.Name = "btn_queue";
            this.btn_queue.Size = new System.Drawing.Size(75, 45);
            this.btn_queue.TabIndex = 14;
            this.btn_queue.Text = "Queue";
            this.btn_queue.UseVisualStyleBackColor = false;
            this.btn_queue.Click += new System.EventHandler(this.btn_playlists_Click);
            // 
            // btn_playlists
            // 
            this.btn_playlists.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_playlists.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(111)))), ((int)(((byte)(193)))));
            this.btn_playlists.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_playlists.FlatAppearance.BorderSize = 0;
            this.btn_playlists.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_playlists.Font = new System.Drawing.Font("Orator Std", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_playlists.ForeColor = System.Drawing.Color.White;
            this.btn_playlists.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_playlists.Location = new System.Drawing.Point(0, -3);
            this.btn_playlists.Margin = new System.Windows.Forms.Padding(0);
            this.btn_playlists.Name = "btn_playlists";
            this.btn_playlists.Size = new System.Drawing.Size(124, 45);
            this.btn_playlists.TabIndex = 11;
            this.btn_playlists.Text = "Playlists";
            this.btn_playlists.UseVisualStyleBackColor = false;
            this.btn_playlists.Click += new System.EventHandler(this.btn_playlists_Click);
            // 
            // panel_displaysContainer
            // 
            this.panel_displaysContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_displaysContainer.Controls.Add(this.panel_albumsDisplay);
            this.panel_displaysContainer.Controls.Add(this.panel_artistsDisplay);
            this.panel_displaysContainer.Controls.Add(this.panel_playlistsDisplay);
            this.panel_displaysContainer.Controls.Add(this.panel_queueDisplay);
            this.panel_displaysContainer.Location = new System.Drawing.Point(0, 0);
            this.panel_displaysContainer.Margin = new System.Windows.Forms.Padding(0);
            this.panel_displaysContainer.Name = "panel_displaysContainer";
            this.panel_displaysContainer.Size = new System.Drawing.Size(425, 335);
            this.panel_displaysContainer.TabIndex = 7;
            // 
            // panel_albumsDisplay
            // 
            this.panel_albumsDisplay.AutoScroll = true;
            this.panel_albumsDisplay.AutoScrollMargin = new System.Drawing.Size(0, 50);
            this.panel_albumsDisplay.AutoScrollMinSize = new System.Drawing.Size(0, 5);
            this.panel_albumsDisplay.BackColor = System.Drawing.Color.White;
            this.panel_albumsDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_albumsDisplay.Location = new System.Drawing.Point(0, 0);
            this.panel_albumsDisplay.Margin = new System.Windows.Forms.Padding(0);
            this.panel_albumsDisplay.Name = "panel_albumsDisplay";
            this.panel_albumsDisplay.Padding = new System.Windows.Forms.Padding(30, 0, 20, 0);
            this.panel_albumsDisplay.Size = new System.Drawing.Size(425, 335);
            this.panel_albumsDisplay.TabIndex = 3;
            // 
            // panel_artistsDisplay
            // 
            this.panel_artistsDisplay.AutoScroll = true;
            this.panel_artistsDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_artistsDisplay.Location = new System.Drawing.Point(0, 0);
            this.panel_artistsDisplay.Margin = new System.Windows.Forms.Padding(0);
            this.panel_artistsDisplay.Name = "panel_artistsDisplay";
            this.panel_artistsDisplay.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.panel_artistsDisplay.Size = new System.Drawing.Size(425, 335);
            this.panel_artistsDisplay.TabIndex = 2;
            // 
            // panel_playlistsDisplay
            // 
            this.panel_playlistsDisplay.AutoScroll = true;
            this.panel_playlistsDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_playlistsDisplay.Location = new System.Drawing.Point(0, 0);
            this.panel_playlistsDisplay.Margin = new System.Windows.Forms.Padding(0);
            this.panel_playlistsDisplay.Name = "panel_playlistsDisplay";
            this.panel_playlistsDisplay.Size = new System.Drawing.Size(425, 335);
            this.panel_playlistsDisplay.TabIndex = 1;
            // 
            // panel_queueDisplay
            // 
            this.panel_queueDisplay.AutoScroll = true;
            this.panel_queueDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_queueDisplay.Location = new System.Drawing.Point(0, 0);
            this.panel_queueDisplay.Margin = new System.Windows.Forms.Padding(0);
            this.panel_queueDisplay.Name = "panel_queueDisplay";
            this.panel_queueDisplay.Size = new System.Drawing.Size(425, 335);
            this.panel_queueDisplay.TabIndex = 0;
            // 
            // btn_allSongs
            // 
            this.btn_allSongs.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_allSongs.BackgroundImage")));
            this.btn_allSongs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_allSongs.FlatAppearance.BorderSize = 0;
            this.btn_allSongs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_allSongs.Location = new System.Drawing.Point(126, 7);
            this.btn_allSongs.Margin = new System.Windows.Forms.Padding(3, 3, 3, 100);
            this.btn_allSongs.Name = "btn_allSongs";
            this.btn_allSongs.Size = new System.Drawing.Size(188, 43);
            this.btn_allSongs.TabIndex = 8;
            this.btn_allSongs.UseVisualStyleBackColor = true;
            this.btn_allSongs.Click += new System.EventHandler(this.btn_allSongs_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel_tabs, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(431, 460);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_allSongs);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(425, 56);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel_displaysContainer);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 107);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(425, 350);
            this.panel2.TabIndex = 8;
            // 
            // ListMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(431, 0);
            this.Name = "ListMenu";
            this.Size = new System.Drawing.Size(431, 460);
            this.panel_tabs.ResumeLayout(false);
            this.panel_displaysContainer.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_tabs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_albums;
        private System.Windows.Forms.Button btn_artists;
        private System.Windows.Forms.Button btn_queue;
        private System.Windows.Forms.Button btn_playlists;
        private System.Windows.Forms.Panel panel_displaysContainer;
        private System.Windows.Forms.FlowLayoutPanel panel_albumsDisplay;
        private System.Windows.Forms.FlowLayoutPanel panel_artistsDisplay;
        private System.Windows.Forms.FlowLayoutPanel panel_playlistsDisplay;
        private System.Windows.Forms.FlowLayoutPanel panel_queueDisplay;
        private System.Windows.Forms.Button btn_allSongs;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}
