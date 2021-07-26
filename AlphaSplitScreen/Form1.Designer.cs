
namespace AlphaSplitScreen
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
            this.saveButton = new System.Windows.Forms.Button();
            this.RestoreButton = new System.Windows.Forms.Button();
            this.M1ResSelector = new System.Windows.Forms.ComboBox();
            this.M2ResSelector = new System.Windows.Forms.ComboBox();
            this.BGImage = new System.Windows.Forms.PictureBox();
            this.HelpButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BGImage)).BeginInit();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.saveButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.saveButton.FlatAppearance.BorderSize = 2;
            this.saveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.SystemColors.Control;
            this.saveButton.Location = new System.Drawing.Point(188, 153);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(110, 34);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // RestoreButton
            // 
            this.RestoreButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RestoreButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.RestoreButton.FlatAppearance.BorderSize = 3;
            this.RestoreButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.RestoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RestoreButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestoreButton.ForeColor = System.Drawing.Color.White;
            this.RestoreButton.Location = new System.Drawing.Point(19, 153);
            this.RestoreButton.Name = "RestoreButton";
            this.RestoreButton.Size = new System.Drawing.Size(110, 34);
            this.RestoreButton.TabIndex = 9;
            this.RestoreButton.Text = "Restore";
            this.RestoreButton.UseVisualStyleBackColor = false;
            this.RestoreButton.Click += new System.EventHandler(this.RestoreButton_Click);
            // 
            // M1ResSelector
            // 
            this.M1ResSelector.FormattingEnabled = true;
            this.M1ResSelector.Items.AddRange(new object[] {
            "1920 x 1080",
            "1680 x 1050",
            "1600 x 900",
            "1440 x 900",
            "1400 x 900",
            "1400 x 1050",
            "1366 x 768",
            "1360 x 768",
            "1280 x 1024",
            "1280 x 960",
            "1280 x 768",
            "1280 x 720",
            "1280 x 600",
            "1152 x 864",
            "1024 x 768",
            "800 x 600"});
            this.M1ResSelector.Location = new System.Drawing.Point(116, 56);
            this.M1ResSelector.Name = "M1ResSelector";
            this.M1ResSelector.Size = new System.Drawing.Size(182, 21);
            this.M1ResSelector.TabIndex = 11;
            this.M1ResSelector.Text = "Click me to select a resolution";
            // 
            // M2ResSelector
            // 
            this.M2ResSelector.FormattingEnabled = true;
            this.M2ResSelector.Items.AddRange(new object[] {
            "1920 x 1080",
            "1680 x 1050",
            "1600 x 900",
            "1440 x 900",
            "1400 x 900",
            "1400 x 1050",
            "1366 x 768",
            "1360 x 768",
            "1280 x 1024",
            "1280 x 960",
            "1280 x 768",
            "1280 x 720",
            "1280 x 600",
            "1152 x 864",
            "1024 x 768",
            "800 x 600"});
            this.M2ResSelector.Location = new System.Drawing.Point(116, 111);
            this.M2ResSelector.Name = "M2ResSelector";
            this.M2ResSelector.Size = new System.Drawing.Size(182, 21);
            this.M2ResSelector.TabIndex = 12;
            this.M2ResSelector.Text = "Click me to select a resolution";
            // 
            // BGImage
            // 
            this.BGImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BGImage.Image = global::AlphaSplitScreen.Properties.Resources.BG;
            this.BGImage.Location = new System.Drawing.Point(0, 0);
            this.BGImage.Name = "BGImage";
            this.BGImage.Size = new System.Drawing.Size(319, 236);
            this.BGImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BGImage.TabIndex = 10;
            this.BGImage.TabStop = false;
            this.BGImage.Click += new System.EventHandler(this.BGImage_Click);
            // 
            // HelpButton
            // 
            this.HelpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.HelpButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.HelpButton.FlatAppearance.BorderSize = 3;
            this.HelpButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.HelpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HelpButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton.ForeColor = System.Drawing.SystemColors.Control;
            this.HelpButton.Location = new System.Drawing.Point(127, 153);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(62, 34);
            this.HelpButton.TabIndex = 13;
            this.HelpButton.Text = "Help";
            this.HelpButton.UseVisualStyleBackColor = false;
            this.HelpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(319, 236);
            this.Controls.Add(this.HelpButton);
            this.Controls.Add(this.M2ResSelector);
            this.Controls.Add(this.M1ResSelector);
            this.Controls.Add(this.RestoreButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.BGImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "AlphaSplitScreen";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BGImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button RestoreButton;
        private System.Windows.Forms.PictureBox BGImage;
        private System.Windows.Forms.ComboBox M1ResSelector;
        private System.Windows.Forms.ComboBox M2ResSelector;
        private System.Windows.Forms.Button HelpButton;
    }
}

