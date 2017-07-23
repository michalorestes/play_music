using System.Windows.Forms;

namespace PlayMusic_app
{
    partial class MainUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainUI));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_browse = new System.Windows.Forms.Button();
            this.btn_pinned = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_settings = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel_BG_tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel_Controls = new System.Windows.Forms.Panel();
            this.pb_Logo = new System.Windows.Forms.PictureBox();
            this.panel_mainContent = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.player = new PlayMusic_app.Controls.Player();
            this.mgItemContainer1 = new PlayMusic_app.Controls.ListMenu();
            this.customTabControl1 = new PlayMusic_app.Controls.CustomTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Cover = new System.Windows.Forms.DataGridViewImageColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Options = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Artist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Album = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_BG_tableLayoutPanel1.SuspendLayout();
            this.panel_Controls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).BeginInit();
            this.panel_mainContent.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.customTabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_browse
            // 
            this.btn_browse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_browse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_browse.FlatAppearance.BorderSize = 0;
            this.btn_browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_browse.Font = new System.Drawing.Font("Orator Std", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_browse.ForeColor = System.Drawing.Color.White;
            this.btn_browse.Location = new System.Drawing.Point(477, 0);
            this.btn_browse.Margin = new System.Windows.Forms.Padding(0);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(89, 42);
            this.btn_browse.TabIndex = 4;
            this.btn_browse.Text = "Browse";
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // btn_pinned
            // 
            this.btn_pinned.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_pinned.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_pinned.FlatAppearance.BorderSize = 0;
            this.btn_pinned.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pinned.Font = new System.Drawing.Font("Orator Std", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pinned.ForeColor = System.Drawing.Color.White;
            this.btn_pinned.Location = new System.Drawing.Point(340, -3);
            this.btn_pinned.Margin = new System.Windows.Forms.Padding(0);
            this.btn_pinned.Name = "btn_pinned";
            this.btn_pinned.Size = new System.Drawing.Size(95, 45);
            this.btn_pinned.TabIndex = 5;
            this.btn_pinned.Text = "Pinned";
            this.btn_pinned.UseVisualStyleBackColor = true;
            this.btn_pinned.Click += new System.EventHandler(this.btn_pinned_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(450, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 29);
            this.label1.TabIndex = 6;
            // 
            // btn_settings
            // 
            this.btn_settings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_settings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_settings.BackgroundImage")));
            this.btn_settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_settings.FlatAppearance.BorderSize = 0;
            this.btn_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_settings.Location = new System.Drawing.Point(779, -3);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(31, 42);
            this.btn_settings.TabIndex = 7;
            this.btn_settings.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(3, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 42);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel_BG_tableLayoutPanel1
            // 
            this.panel_BG_tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.panel_BG_tableLayoutPanel1.ColumnCount = 1;
            this.panel_BG_tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_BG_tableLayoutPanel1.Controls.Add(this.panel_Controls, 0, 0);
            this.panel_BG_tableLayoutPanel1.Controls.Add(this.panel_mainContent, 0, 1);
            this.panel_BG_tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_BG_tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.panel_BG_tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel_BG_tableLayoutPanel1.Name = "panel_BG_tableLayoutPanel1";
            this.panel_BG_tableLayoutPanel1.RowCount = 2;
            this.panel_BG_tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.panel_BG_tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_BG_tableLayoutPanel1.Size = new System.Drawing.Size(1264, 681);
            this.panel_BG_tableLayoutPanel1.TabIndex = 0;
            // 
            // panel_Controls
            // 
            this.panel_Controls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(177)))));
            this.panel_Controls.Controls.Add(this.player);
            this.panel_Controls.Controls.Add(this.pb_Logo);
            this.panel_Controls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Controls.Location = new System.Drawing.Point(0, 0);
            this.panel_Controls.Margin = new System.Windows.Forms.Padding(0);
            this.panel_Controls.Name = "panel_Controls";
            this.panel_Controls.Size = new System.Drawing.Size(1264, 150);
            this.panel_Controls.TabIndex = 2;
            // 
            // pb_Logo
            // 
            this.pb_Logo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pb_Logo.Image = ((System.Drawing.Image)(resources.GetObject("pb_Logo.Image")));
            this.pb_Logo.Location = new System.Drawing.Point(41, 49);
            this.pb_Logo.Name = "pb_Logo";
            this.pb_Logo.Size = new System.Drawing.Size(223, 60);
            this.pb_Logo.TabIndex = 1;
            this.pb_Logo.TabStop = false;
            // 
            // panel_mainContent
            // 
            this.panel_mainContent.ColumnCount = 2;
            this.panel_mainContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panel_mainContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panel_mainContent.Controls.Add(this.mgItemContainer1, 0, 0);
            this.panel_mainContent.Controls.Add(this.panel1, 1, 0);
            this.panel_mainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_mainContent.Location = new System.Drawing.Point(0, 150);
            this.panel_mainContent.Margin = new System.Windows.Forms.Padding(0);
            this.panel_mainContent.Name = "panel_mainContent";
            this.panel_mainContent.RowCount = 1;
            this.panel_mainContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_mainContent.Size = new System.Drawing.Size(1264, 531);
            this.panel_mainContent.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.customTabControl1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(431, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(833, 531);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(111)))), ((int)(((byte)(193)))));
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btn_settings);
            this.panel2.Controls.Add(this.btn_pinned);
            this.panel2.Controls.Add(this.btn_browse);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(833, 42);
            this.panel2.TabIndex = 2;
            // 
            // player
            // 
            this.player.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.player.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(177)))));
            this.player.Location = new System.Drawing.Point(564, 0);
            this.player.Margin = new System.Windows.Forms.Padding(0);
            this.player.MaximumSize = new System.Drawing.Size(700, 145);
            this.player.MinimumSize = new System.Drawing.Size(640, 100);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(700, 145);
            this.player.TabIndex = 2;
            // 
            // mgItemContainer1
            // 
            this.mgItemContainer1.BackColor = System.Drawing.Color.White;
            this.mgItemContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mgItemContainer1.Location = new System.Drawing.Point(0, 0);
            this.mgItemContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.mgItemContainer1.MaximumSize = new System.Drawing.Size(431, 0);
            this.mgItemContainer1.Name = "mgItemContainer1";
            this.mgItemContainer1.Size = new System.Drawing.Size(431, 531);
            this.mgItemContainer1.TabIndex = 0;
            // 
            // customTabControl1
            // 
            this.customTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customTabControl1.Controls.Add(this.tabPage1);
            this.customTabControl1.Controls.Add(this.tabPage2);
            this.customTabControl1.Location = new System.Drawing.Point(3, 45);
            this.customTabControl1.Name = "customTabControl1";
            this.customTabControl1.SelectedIndex = 0;
            this.customTabControl1.Size = new System.Drawing.Size(830, 486);
            this.customTabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(822, 460);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(822, 460);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.ColumnHeadersHeight = 45;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cover,
            this.Title,
            this.Options,
            this.Artist,
            this.Album,
            this.Duration,
            this.Rating});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.GridColor = System.Drawing.Color.White;
            this.dataGridView.Location = new System.Drawing.Point(3, 3);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(111)))), ((int)(((byte)(193)))));
            this.dataGridView.RowTemplate.Height = 70;
            this.dataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(816, 454);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.DoubleClick += new System.EventHandler(this.gridView_DoubleClick);
            // 
            // Cover
            // 
            this.Cover.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Cover.DefaultCellStyle = dataGridViewCellStyle3;
            this.Cover.FillWeight = 10F;
            this.Cover.HeaderText = "Cover";
            this.Cover.Name = "Cover";
            this.Cover.ReadOnly = true;
            this.Cover.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Cover.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Cover.Width = 80;
            // 
            // Title
            // 
            this.Title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Title.FillWeight = 60F;
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // Options
            // 
            this.Options.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Options.FillWeight = 5F;
            this.Options.HeaderText = "O";
            this.Options.Name = "Options";
            this.Options.ReadOnly = true;
            this.Options.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Options.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Options.Width = 30;
            // 
            // Artist
            // 
            this.Artist.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Artist.FillWeight = 20F;
            this.Artist.HeaderText = "Artist";
            this.Artist.Name = "Artist";
            this.Artist.ReadOnly = true;
            // 
            // Album
            // 
            this.Album.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Album.FillWeight = 20F;
            this.Album.HeaderText = "Album";
            this.Album.Name = "Album";
            this.Album.ReadOnly = true;
            // 
            // Duration
            // 
            this.Duration.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Duration.FillWeight = 10F;
            this.Duration.HeaderText = "Duration";
            this.Duration.Name = "Duration";
            this.Duration.ReadOnly = true;
            this.Duration.Width = 50;
            // 
            // Rating
            // 
            this.Rating.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Rating.FillWeight = 10F;
            this.Rating.HeaderText = "Rating";
            this.Rating.Name = "Rating";
            this.Rating.ReadOnly = true;
            this.Rating.Width = 80;
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel_BG_tableLayoutPanel1);
            this.HelpButton = true;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "MainUI";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Play Music";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainUI_FormClosed);
            this.panel_BG_tableLayoutPanel1.ResumeLayout(false);
            this.panel_Controls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).EndInit();
            this.panel_mainContent.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.customTabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button button1;
        private Button btn_settings;
        private Label label1;
        private Button btn_pinned;
        private Button btn_browse;
        private TableLayoutPanel panel_BG_tableLayoutPanel1;
        private TableLayoutPanel panel_mainContent;
        private Controls.ListMenu mgItemContainer1;
        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridView;
        private DataGridViewImageColumn Cover;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewButtonColumn Options;
        private DataGridViewTextBoxColumn Artist;
        private DataGridViewTextBoxColumn Album;
        private DataGridViewTextBoxColumn Duration;
        private DataGridViewTextBoxColumn Rating;
        private Panel panel_Controls;
        private Controls.Player player;
        private PictureBox pb_Logo;
        private Controls.CustomTabControl customTabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
    }
}

