namespace HelloIntByron
{
    partial class HellointFrm
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
            this.LblGreeting = new System.Windows.Forms.Label();
            this.grbRadioButton = new System.Windows.Forms.GroupBox();
            this.Radsvenska = new System.Windows.Forms.RadioButton();
            this.RadFrancais = new System.Windows.Forms.RadioButton();
            this.RadSpanish = new System.Windows.Forms.RadioButton();
            this.RadEnglish = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helloWorldMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grbRadioButton.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblGreeting
            // 
            this.LblGreeting.AutoSize = true;
            this.LblGreeting.Font = new System.Drawing.Font("Segoe Script", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGreeting.Location = new System.Drawing.Point(83, 127);
            this.LblGreeting.Name = "LblGreeting";
            this.LblGreeting.Size = new System.Drawing.Size(477, 106);
            this.LblGreeting.TabIndex = 0;
            this.LblGreeting.Text = "Hello World ";
            this.LblGreeting.Click += new System.EventHandler(this.LblGreeting_Click);
            // 
            // grbRadioButton
            // 
            this.grbRadioButton.Controls.Add(this.Radsvenska);
            this.grbRadioButton.Controls.Add(this.RadFrancais);
            this.grbRadioButton.Controls.Add(this.RadSpanish);
            this.grbRadioButton.Controls.Add(this.RadEnglish);
            this.grbRadioButton.Location = new System.Drawing.Point(235, 278);
            this.grbRadioButton.Name = "grbRadioButton";
            this.grbRadioButton.Size = new System.Drawing.Size(308, 119);
            this.grbRadioButton.TabIndex = 1;
            this.grbRadioButton.TabStop = false;
            this.grbRadioButton.Text = "Language";
            // 
            // Radsvenska
            // 
            this.Radsvenska.AutoSize = true;
            this.Radsvenska.Location = new System.Drawing.Point(200, 84);
            this.Radsvenska.Name = "Radsvenska";
            this.Radsvenska.Size = new System.Drawing.Size(65, 17);
            this.Radsvenska.TabIndex = 3;
            this.Radsvenska.TabStop = true;
            this.Radsvenska.Text = "svenska";
            this.Radsvenska.UseVisualStyleBackColor = true;
            this.Radsvenska.CheckedChanged += new System.EventHandler(this.Radعربى_CheckedChanged);
            // 
            // RadFrancais
            // 
            this.RadFrancais.AutoSize = true;
            this.RadFrancais.Location = new System.Drawing.Point(56, 84);
            this.RadFrancais.Name = "RadFrancais";
            this.RadFrancais.Size = new System.Drawing.Size(62, 17);
            this.RadFrancais.TabIndex = 2;
            this.RadFrancais.TabStop = true;
            this.RadFrancais.Text = "français";
            this.RadFrancais.UseVisualStyleBackColor = true;
            this.RadFrancais.CheckedChanged += new System.EventHandler(this.RadFrancais_CheckedChanged);
            // 
            // RadSpanish
            // 
            this.RadSpanish.AutoSize = true;
            this.RadSpanish.Location = new System.Drawing.Point(56, 19);
            this.RadSpanish.Name = "RadSpanish";
            this.RadSpanish.Size = new System.Drawing.Size(62, 17);
            this.RadSpanish.TabIndex = 1;
            this.RadSpanish.TabStop = true;
            this.RadSpanish.Text = "español";
            this.RadSpanish.UseVisualStyleBackColor = true;
            this.RadSpanish.CheckedChanged += new System.EventHandler(this.RadSpanish_CheckedChanged);
            // 
            // RadEnglish
            // 
            this.RadEnglish.AutoSize = true;
            this.RadEnglish.Location = new System.Drawing.Point(200, 19);
            this.RadEnglish.Name = "RadEnglish";
            this.RadEnglish.Size = new System.Drawing.Size(59, 17);
            this.RadEnglish.TabIndex = 0;
            this.RadEnglish.TabStop = true;
            this.RadEnglish.Text = "English";
            this.RadEnglish.UseVisualStyleBackColor = true;
            this.RadEnglish.CheckedChanged += new System.EventHandler(this.RadEnglish_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helloWorldMenuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helloWorldMenuToolStripMenuItem
            // 
            this.helloWorldMenuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.helloWorldMenuToolStripMenuItem.Name = "helloWorldMenuToolStripMenuItem";
            this.helloWorldMenuToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.helloWorldMenuToolStripMenuItem.Text = "Hello World Menu";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // HellointFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbRadioButton);
            this.Controls.Add(this.LblGreeting);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HellointFrm";
            this.Text = "Hello World Internatioanal By Byron";
            this.grbRadioButton.ResumeLayout(false);
            this.grbRadioButton.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblGreeting;
        private System.Windows.Forms.GroupBox grbRadioButton;
        private System.Windows.Forms.RadioButton RadEnglish;
        private System.Windows.Forms.RadioButton RadSpanish;
        private System.Windows.Forms.RadioButton Radsvenska;
        private System.Windows.Forms.RadioButton RadFrancais;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helloWorldMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

