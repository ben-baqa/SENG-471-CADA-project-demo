
namespace CarAttempt
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
            this.extView = new System.Windows.Forms.PictureBox();
            this.extBlue = new System.Windows.Forms.RadioButton();
            this.extBlack = new System.Windows.Forms.RadioButton();
            this.extSilver = new System.Windows.Forms.RadioButton();
            this.extBeige = new System.Windows.Forms.RadioButton();
            this.extWhite = new System.Windows.Forms.RadioButton();
            this.extColourButtons = new System.Windows.Forms.Panel();
            this.majorOptions = new System.Windows.Forms.Panel();
            this.save = new System.Windows.Forms.RadioButton();
            this.interior = new System.Windows.Forms.RadioButton();
            this.exterior = new System.Windows.Forms.RadioButton();
            this.model = new System.Windows.Forms.RadioButton();
            this.extMenu = new System.Windows.Forms.Panel();
            this.intMenu = new System.Windows.Forms.Panel();
            this.interiorColourButtons = new System.Windows.Forms.Panel();
            this.intBeige = new System.Windows.Forms.RadioButton();
            this.intBrown = new System.Windows.Forms.RadioButton();
            this.intRed = new System.Windows.Forms.RadioButton();
            this.intView = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.extView)).BeginInit();
            this.extColourButtons.SuspendLayout();
            this.majorOptions.SuspendLayout();
            this.extMenu.SuspendLayout();
            this.intMenu.SuspendLayout();
            this.interiorColourButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.intView)).BeginInit();
            this.SuspendLayout();
            // 
            // extView
            // 
            this.extView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.extView.Image = global::CarAttempt.Properties.Resources.extBlue;
            this.extView.Location = new System.Drawing.Point(531, 174);
            this.extView.Name = "extView";
            this.extView.Size = new System.Drawing.Size(1290, 610);
            this.extView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.extView.TabIndex = 1;
            this.extView.TabStop = false;
            // 
            // extBlue
            // 
            this.extBlue.BackColor = System.Drawing.Color.Transparent;
            this.extBlue.Checked = true;
            this.extBlue.Image = global::CarAttempt.Properties.Resources.Ext_blue;
            this.extBlue.Location = new System.Drawing.Point(32, 17);
            this.extBlue.Name = "extBlue";
            this.extBlue.Size = new System.Drawing.Size(94, 83);
            this.extBlue.TabIndex = 9;
            this.extBlue.TabStop = true;
            this.extBlue.UseVisualStyleBackColor = false;
            this.extBlue.CheckedChanged += new System.EventHandler(this.extBlue_CheckedChanged);
            // 
            // extBlack
            // 
            this.extBlack.BackColor = System.Drawing.Color.Transparent;
            this.extBlack.Image = global::CarAttempt.Properties.Resources.Ext_black;
            this.extBlack.Location = new System.Drawing.Point(202, 17);
            this.extBlack.Name = "extBlack";
            this.extBlack.Size = new System.Drawing.Size(94, 83);
            this.extBlack.TabIndex = 10;
            this.extBlack.UseVisualStyleBackColor = false;
            this.extBlack.CheckedChanged += new System.EventHandler(this.extBlack_CheckedChanged);
            // 
            // extSilver
            // 
            this.extSilver.BackColor = System.Drawing.Color.Transparent;
            this.extSilver.Image = global::CarAttempt.Properties.Resources.Ext_Silver;
            this.extSilver.Location = new System.Drawing.Point(372, 17);
            this.extSilver.Name = "extSilver";
            this.extSilver.Size = new System.Drawing.Size(94, 83);
            this.extSilver.TabIndex = 11;
            this.extSilver.UseVisualStyleBackColor = false;
            this.extSilver.CheckedChanged += new System.EventHandler(this.extSilver_CheckedChanged);
            // 
            // extBeige
            // 
            this.extBeige.BackColor = System.Drawing.Color.Transparent;
            this.extBeige.Image = global::CarAttempt.Properties.Resources.Ext_beige;
            this.extBeige.Location = new System.Drawing.Point(541, 17);
            this.extBeige.Name = "extBeige";
            this.extBeige.Size = new System.Drawing.Size(94, 83);
            this.extBeige.TabIndex = 12;
            this.extBeige.UseVisualStyleBackColor = false;
            this.extBeige.CheckedChanged += new System.EventHandler(this.extBeige_CheckedChanged);
            // 
            // extWhite
            // 
            this.extWhite.BackColor = System.Drawing.Color.Transparent;
            this.extWhite.Image = global::CarAttempt.Properties.Resources.Ext_white;
            this.extWhite.Location = new System.Drawing.Point(700, 17);
            this.extWhite.Name = "extWhite";
            this.extWhite.Size = new System.Drawing.Size(94, 83);
            this.extWhite.TabIndex = 13;
            this.extWhite.UseVisualStyleBackColor = false;
            this.extWhite.CheckedChanged += new System.EventHandler(this.extWhite_CheckedChanged);
            // 
            // extColourButtons
            // 
            this.extColourButtons.BackColor = System.Drawing.Color.Transparent;
            this.extColourButtons.Controls.Add(this.extWhite);
            this.extColourButtons.Controls.Add(this.extBlue);
            this.extColourButtons.Controls.Add(this.extBeige);
            this.extColourButtons.Controls.Add(this.extBlack);
            this.extColourButtons.Controls.Add(this.extSilver);
            this.extColourButtons.Location = new System.Drawing.Point(732, 920);
            this.extColourButtons.Name = "extColourButtons";
            this.extColourButtons.Size = new System.Drawing.Size(866, 109);
            this.extColourButtons.TabIndex = 14;
            // 
            // majorOptions
            // 
            this.majorOptions.BackColor = System.Drawing.Color.Transparent;
            this.majorOptions.Controls.Add(this.save);
            this.majorOptions.Controls.Add(this.interior);
            this.majorOptions.Controls.Add(this.exterior);
            this.majorOptions.Controls.Add(this.model);
            this.majorOptions.Location = new System.Drawing.Point(0, 266);
            this.majorOptions.Name = "majorOptions";
            this.majorOptions.Size = new System.Drawing.Size(420, 518);
            this.majorOptions.TabIndex = 15;
            // 
            // save
            // 
            this.save.Appearance = System.Windows.Forms.Appearance.Button;
            this.save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.save.Image = global::CarAttempt.Properties.Resources.Save_button;
            this.save.Location = new System.Drawing.Point(28, 341);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(340, 52);
            this.save.TabIndex = 3;
            this.save.UseVisualStyleBackColor = true;
            // 
            // interior
            // 
            this.interior.Appearance = System.Windows.Forms.Appearance.Button;
            this.interior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.interior.Image = global::CarAttempt.Properties.Resources.Interior_Button;
            this.interior.Location = new System.Drawing.Point(28, 247);
            this.interior.Name = "interior";
            this.interior.Size = new System.Drawing.Size(340, 52);
            this.interior.TabIndex = 2;
            this.interior.UseVisualStyleBackColor = true;
            this.interior.CheckedChanged += new System.EventHandler(this.interior_CheckedChanged);
            // 
            // exterior
            // 
            this.exterior.Appearance = System.Windows.Forms.Appearance.Button;
            this.exterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exterior.Checked = true;
            this.exterior.Image = global::CarAttempt.Properties.Resources.Exterior_button;
            this.exterior.Location = new System.Drawing.Point(28, 147);
            this.exterior.Name = "exterior";
            this.exterior.Size = new System.Drawing.Size(340, 52);
            this.exterior.TabIndex = 1;
            this.exterior.TabStop = true;
            this.exterior.UseVisualStyleBackColor = true;
            this.exterior.CheckedChanged += new System.EventHandler(this.exterior_CheckedChanged);
            // 
            // model
            // 
            this.model.Appearance = System.Windows.Forms.Appearance.Button;
            this.model.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.model.Image = global::CarAttempt.Properties.Resources.Model_button;
            this.model.Location = new System.Drawing.Point(28, 41);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(340, 52);
            this.model.TabIndex = 0;
            this.model.UseVisualStyleBackColor = true;
            // 
            // extMenu
            // 
            this.extMenu.BackColor = System.Drawing.Color.Transparent;
            this.extMenu.Controls.Add(this.extColourButtons);
            this.extMenu.Controls.Add(this.extView);
            this.extMenu.Location = new System.Drawing.Point(0, 0);
            this.extMenu.Name = "extMenu";
            this.extMenu.Size = new System.Drawing.Size(1897, 1029);
            this.extMenu.TabIndex = 16;
            // 
            // intMenu
            // 
            this.intMenu.BackColor = System.Drawing.Color.Transparent;
            this.intMenu.Controls.Add(this.interiorColourButtons);
            this.intMenu.Controls.Add(this.intView);
            this.intMenu.Location = new System.Drawing.Point(0, 0);
            this.intMenu.Name = "intMenu";
            this.intMenu.Size = new System.Drawing.Size(1897, 1029);
            this.intMenu.TabIndex = 17;
            // 
            // interiorColourButtons
            // 
            this.interiorColourButtons.BackColor = System.Drawing.Color.Transparent;
            this.interiorColourButtons.Controls.Add(this.intBeige);
            this.interiorColourButtons.Controls.Add(this.intBrown);
            this.interiorColourButtons.Controls.Add(this.intRed);
            this.interiorColourButtons.Location = new System.Drawing.Point(732, 920);
            this.interiorColourButtons.Name = "interiorColourButtons";
            this.interiorColourButtons.Size = new System.Drawing.Size(866, 109);
            this.interiorColourButtons.TabIndex = 14;
            // 
            // intBeige
            // 
            this.intBeige.BackColor = System.Drawing.Color.Transparent;
            this.intBeige.Image = global::CarAttempt.Properties.Resources.Int_beige;
            this.intBeige.Location = new System.Drawing.Point(541, 17);
            this.intBeige.Name = "intBeige";
            this.intBeige.Size = new System.Drawing.Size(94, 83);
            this.intBeige.TabIndex = 12;
            this.intBeige.TabStop = true;
            this.intBeige.UseVisualStyleBackColor = false;
            this.intBeige.CheckedChanged += new System.EventHandler(this.intBeige_CheckedChanged);
            // 
            // intBrown
            // 
            this.intBrown.BackColor = System.Drawing.Color.Transparent;
            this.intBrown.Checked = true;
            this.intBrown.Image = global::CarAttempt.Properties.Resources.Int_brown;
            this.intBrown.Location = new System.Drawing.Point(202, 17);
            this.intBrown.Name = "intBrown";
            this.intBrown.Size = new System.Drawing.Size(94, 83);
            this.intBrown.TabIndex = 10;
            this.intBrown.TabStop = true;
            this.intBrown.UseVisualStyleBackColor = false;
            this.intBrown.CheckedChanged += new System.EventHandler(this.intBrown_CheckedChanged);
            // 
            // intRed
            // 
            this.intRed.BackColor = System.Drawing.Color.Transparent;
            this.intRed.Image = global::CarAttempt.Properties.Resources.Int_red;
            this.intRed.Location = new System.Drawing.Point(372, 17);
            this.intRed.Name = "intRed";
            this.intRed.Size = new System.Drawing.Size(94, 83);
            this.intRed.TabIndex = 11;
            this.intRed.TabStop = true;
            this.intRed.UseVisualStyleBackColor = false;
            this.intRed.CheckedChanged += new System.EventHandler(this.intRed_CheckedChanged);
            // 
            // intView
            // 
            this.intView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.intView.Image = global::CarAttempt.Properties.Resources.intBrown;
            this.intView.Location = new System.Drawing.Point(531, 174);
            this.intView.Name = "intView";
            this.intView.Size = new System.Drawing.Size(1290, 610);
            this.intView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.intView.TabIndex = 1;
            this.intView.TabStop = false;
            // 
            // Form1
            // 
            this.AccessibleName = "Automobile Colour Selection";
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = global::CarAttempt.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.majorOptions);
            this.Controls.Add(this.extMenu);
            this.Controls.Add(this.intMenu);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "Form1";
            this.Text = "Automobile Colour Selection";
            ((System.ComponentModel.ISupportInitialize)(this.extView)).EndInit();
            this.extColourButtons.ResumeLayout(false);
            this.majorOptions.ResumeLayout(false);
            this.extMenu.ResumeLayout(false);
            this.intMenu.ResumeLayout(false);
            this.interiorColourButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.intView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox extView;
        private System.Windows.Forms.RadioButton extBlue;
        private System.Windows.Forms.RadioButton extBlack;
        private System.Windows.Forms.RadioButton extSilver;
        private System.Windows.Forms.RadioButton extBeige;
        private System.Windows.Forms.RadioButton extWhite;
        private System.Windows.Forms.Panel extColourButtons;
        private System.Windows.Forms.Panel majorOptions;
        private System.Windows.Forms.RadioButton model;
        private System.Windows.Forms.RadioButton save;
        private System.Windows.Forms.RadioButton interior;
        private System.Windows.Forms.RadioButton exterior;
        private System.Windows.Forms.Panel extMenu;
        private System.Windows.Forms.Panel intMenu;
        private System.Windows.Forms.Panel interiorColourButtons;
        private System.Windows.Forms.RadioButton intBeige;
        private System.Windows.Forms.RadioButton intBrown;
        private System.Windows.Forms.RadioButton intRed;
        private System.Windows.Forms.PictureBox intView;
    }
}

