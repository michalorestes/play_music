namespace PlayMusic_app.Controls
{
    partial class MGItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MGItem));
            this.lb_sepLine = new System.Windows.Forms.Label();
            this.lb_mainHeading = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_heading2 = new System.Windows.Forms.Label();
            this.lb_heading1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_sepLine
            // 
            this.lb_sepLine.AutoSize = true;
            this.lb_sepLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sepLine.ForeColor = System.Drawing.Color.Gray;
            this.lb_sepLine.Location = new System.Drawing.Point(142, 44);
            this.lb_sepLine.Name = "lb_sepLine";
            this.lb_sepLine.Size = new System.Drawing.Size(11, 16);
            this.lb_sepLine.TabIndex = 9;
            this.lb_sepLine.Text = "|";
            // 
            // lb_mainHeading
            // 
            this.lb_mainHeading.AutoSize = true;
            this.lb_mainHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mainHeading.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_mainHeading.Location = new System.Drawing.Point(81, 19);
            this.lb_mainHeading.Name = "lb_mainHeading";
            this.lb_mainHeading.Size = new System.Drawing.Size(107, 20);
            this.lb_mainHeading.TabIndex = 7;
            this.lb_mainHeading.Text = "Lose Yourself";
            this.lb_mainHeading.Click += new System.EventHandler(this.lb_mainHeading_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(300, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 45);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(5, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(3);
            this.pictureBox1.Size = new System.Drawing.Size(65, 65);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // lb_heading2
            // 
            this.lb_heading2.AutoSize = true;
            this.lb_heading2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_heading2.ForeColor = System.Drawing.Color.Gray;
            this.lb_heading2.Location = new System.Drawing.Point(156, 44);
            this.lb_heading2.Name = "lb_heading2";
            this.lb_heading2.Size = new System.Drawing.Size(93, 16);
            this.lb_heading2.TabIndex = 10;
            this.lb_heading2.Text = "Lose Yourself ";
            // 
            // lb_heading1
            // 
            this.lb_heading1.AutoSize = true;
            this.lb_heading1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_heading1.ForeColor = System.Drawing.Color.Gray;
            this.lb_heading1.Location = new System.Drawing.Point(82, 44);
            this.lb_heading1.Name = "lb_heading1";
            this.lb_heading1.Size = new System.Drawing.Size(57, 16);
            this.lb_heading1.TabIndex = 11;
            this.lb_heading1.Text = "Eminem";
            // 
            // MGItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb_heading1);
            this.Controls.Add(this.lb_heading2);
            this.Controls.Add(this.lb_sepLine);
            this.Controls.Add(this.lb_mainHeading);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximumSize = new System.Drawing.Size(360, 75);
            this.MinimumSize = new System.Drawing.Size(360, 75);
            this.Name = "MGItem";
            this.Size = new System.Drawing.Size(358, 73);
            this.Click += new System.EventHandler(this.lb_mainHeading_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_sepLine;
        private System.Windows.Forms.Label lb_mainHeading;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_heading2;
        private System.Windows.Forms.Label lb_heading1;
    }
}
