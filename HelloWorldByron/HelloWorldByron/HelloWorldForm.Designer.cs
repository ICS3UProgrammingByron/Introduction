namespace HelloWorldByron
{
    partial class FrmHelloWorld
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
            this.lblHelloWorld = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picDaBaby = new System.Windows.Forms.PictureBox();
            this.picBigShaq = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDaBaby)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBigShaq)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHelloWorld
            // 
            this.lblHelloWorld.AutoSize = true;
            this.lblHelloWorld.BackColor = System.Drawing.Color.Transparent;
            this.lblHelloWorld.Font = new System.Drawing.Font("Swis721 BlkOul BT", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelloWorld.Location = new System.Drawing.Point(2, 1);
            this.lblHelloWorld.Name = "lblHelloWorld";
            this.lblHelloWorld.Size = new System.Drawing.Size(325, 57);
            this.lblHelloWorld.TabIndex = 0;
            this.lblHelloWorld.Text = "Hello,World";
            this.lblHelloWorld.Click += new System.EventHandler(this.Label1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::HelloWorldByron.Properties.Resources.download__1_2;
            this.pictureBox3.Location = new System.Drawing.Point(0, 61);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(327, 220);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // picDaBaby
            // 
            this.picDaBaby.Image = global::HelloWorldByron.Properties.Resources.download__1_;
            this.picDaBaby.Location = new System.Drawing.Point(0, 277);
            this.picDaBaby.Name = "picDaBaby";
            this.picDaBaby.Size = new System.Drawing.Size(327, 173);
            this.picDaBaby.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDaBaby.TabIndex = 3;
            this.picDaBaby.TabStop = false;
            // 
            // picBigShaq
            // 
            this.picBigShaq.Image = global::HelloWorldByron.Properties.Resources.download__1_1;
            this.picBigShaq.Location = new System.Drawing.Point(324, 61);
            this.picBigShaq.Name = "picBigShaq";
            this.picBigShaq.Size = new System.Drawing.Size(476, 389);
            this.picBigShaq.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBigShaq.TabIndex = 4;
            this.picBigShaq.TabStop = false;
            // 
            // FrmHelloWorld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lblHelloWorld);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picDaBaby);
            this.Controls.Add(this.picBigShaq);
            this.Name = "FrmHelloWorld";
            this.Text = "Hello World By Byron";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDaBaby)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBigShaq)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHelloWorld;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox picDaBaby;
        private System.Windows.Forms.PictureBox picBigShaq;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

