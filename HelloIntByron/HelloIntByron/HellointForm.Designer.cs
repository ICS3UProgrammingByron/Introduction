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
            this.GrpRadioButton = new System.Windows.Forms.GroupBox();
            this.RadSpanish = new System.Windows.Forms.RadioButton();
            this.RadEnglish = new System.Windows.Forms.RadioButton();
            this.RadFrancais = new System.Windows.Forms.RadioButton();
            this.Radعربى = new System.Windows.Forms.RadioButton();
            this.GrpRadioButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblGreeting
            // 
            this.LblGreeting.AutoSize = true;
            this.LblGreeting.Font = new System.Drawing.Font("Segoe Script", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGreeting.Location = new System.Drawing.Point(167, 158);
            this.LblGreeting.Name = "LblGreeting";
            this.LblGreeting.Size = new System.Drawing.Size(477, 106);
            this.LblGreeting.TabIndex = 0;
            this.LblGreeting.Text = "Hello World ";
            this.LblGreeting.Click += new System.EventHandler(this.LblGreeting_Click);
            // 
            // GrpRadioButton
            // 
            this.GrpRadioButton.Controls.Add(this.Radعربى);
            this.GrpRadioButton.Controls.Add(this.RadFrancais);
            this.GrpRadioButton.Controls.Add(this.RadSpanish);
            this.GrpRadioButton.Controls.Add(this.RadEnglish);
            this.GrpRadioButton.Location = new System.Drawing.Point(235, 278);
            this.GrpRadioButton.Name = "GrpRadioButton";
            this.GrpRadioButton.Size = new System.Drawing.Size(308, 119);
            this.GrpRadioButton.TabIndex = 1;
            this.GrpRadioButton.TabStop = false;
            this.GrpRadioButton.Text = "groupBox1";
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
            // RadFrancais
            // 
            this.RadFrancais.AutoSize = true;
            this.RadFrancais.Location = new System.Drawing.Point(56, 84);
            this.RadFrancais.Name = "RadFrancais";
            this.RadFrancais.Size = new System.Drawing.Size(65, 17);
            this.RadFrancais.TabIndex = 2;
            this.RadFrancais.TabStop = true;
            this.RadFrancais.Text = "Francais";
            this.RadFrancais.UseVisualStyleBackColor = true;
            this.RadFrancais.CheckedChanged += new System.EventHandler(this.RadFrancais_CheckedChanged);
            // 
            // Radعربى
            // 
            this.Radعربى.AutoSize = true;
            this.Radعربى.Location = new System.Drawing.Point(200, 84);
            this.Radعربى.Name = "Radعربى";
            this.Radعربى.Size = new System.Drawing.Size(51, 17);
            this.Radعربى.TabIndex = 3;
            this.Radعربى.TabStop = true;
            this.Radعربى.Text = "عربى";
            this.Radعربى.UseVisualStyleBackColor = true;
            this.Radعربى.CheckedChanged += new System.EventHandler(this.Radعربى_CheckedChanged);
            // 
            // HellointFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GrpRadioButton);
            this.Controls.Add(this.LblGreeting);
            this.Name = "HellointFrm";
            this.Text = "Hello World Internatioanal By Byron";
            this.GrpRadioButton.ResumeLayout(false);
            this.GrpRadioButton.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblGreeting;
        private System.Windows.Forms.GroupBox GrpRadioButton;
        private System.Windows.Forms.RadioButton RadEnglish;
        private System.Windows.Forms.RadioButton RadSpanish;
        private System.Windows.Forms.RadioButton Radعربى;
        private System.Windows.Forms.RadioButton RadFrancais;
    }
}

