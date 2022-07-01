namespace HistoGram
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pfButton4 = new APP.pfButton();
            this.pfButton3 = new APP.pfButton();
            this.pfButton2 = new APP.pfButton();
            this.pfButton1 = new APP.pfButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.pictureBox1.Location = new System.Drawing.Point(36, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(423, 463);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.pictureBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.pictureBox2.Location = new System.Drawing.Point(568, 23);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(406, 463);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pfButton4
            // 
            this.pfButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(70)))));
            this.pfButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pfButton4.GraphicsColor = System.Drawing.Color.Empty;
            this.pfButton4.Location = new System.Drawing.Point(36, 591);
            this.pfButton4.Name = "pfButton4";
            this.pfButton4.Size = new System.Drawing.Size(164, 68);
            this.pfButton4.TabIndex = 8;
            this.pfButton4.Text = "About";
            this.pfButton4.UseVisualStyleBackColor = false;
            this.pfButton4.Click += new System.EventHandler(this.pfButton4_Click);
            // 
            // pfButton3
            // 
            this.pfButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(70)))));
            this.pfButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pfButton3.GraphicsColor = System.Drawing.Color.Empty;
            this.pfButton3.Location = new System.Drawing.Point(810, 507);
            this.pfButton3.Name = "pfButton3";
            this.pfButton3.Size = new System.Drawing.Size(164, 68);
            this.pfButton3.TabIndex = 7;
            this.pfButton3.Text = "Save";
            this.pfButton3.UseVisualStyleBackColor = false;
            this.pfButton3.Click += new System.EventHandler(this.pfButton3_Click);
            // 
            // pfButton2
            // 
            this.pfButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(70)))));
            this.pfButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pfButton2.GraphicsColor = System.Drawing.Color.Empty;
            this.pfButton2.Location = new System.Drawing.Point(36, 507);
            this.pfButton2.Name = "pfButton2";
            this.pfButton2.Size = new System.Drawing.Size(164, 68);
            this.pfButton2.TabIndex = 6;
            this.pfButton2.Text = "Browse";
            this.pfButton2.UseVisualStyleBackColor = false;
            this.pfButton2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pfButton1
            // 
            this.pfButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(70)))));
            this.pfButton1.Enabled = false;
            this.pfButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pfButton1.GraphicsColor = System.Drawing.Color.Empty;
            this.pfButton1.Location = new System.Drawing.Point(810, 591);
            this.pfButton1.Name = "pfButton1";
            this.pfButton1.Size = new System.Drawing.Size(164, 68);
            this.pfButton1.TabIndex = 5;
            this.pfButton1.Text = "Test";
            this.pfButton1.UseVisualStyleBackColor = false;
            this.pfButton1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlueViolet;
            this.ClientSize = new System.Drawing.Size(1024, 677);
            this.Controls.Add(this.pfButton4);
            this.Controls.Add(this.pfButton3);
            this.Controls.Add(this.pfButton2);
            this.Controls.Add(this.pfButton1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HistoGram";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private APP.pfButton pfButton1;
        private APP.pfButton pfButton2;
        private APP.pfButton pfButton3;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private APP.pfButton pfButton4;
    }
}

