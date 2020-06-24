namespace PinterestPinsIdsReplacer
{
    partial class FrmPPReplacer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPPReplacer));
            this.TxtUrl = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnGenerateIDs = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.TxtConsole = new System.Windows.Forms.RichTextBox();
            this.BtnPrototype = new System.Windows.Forms.Button();
            this.PicLoader = new System.Windows.Forms.PictureBox();
            this.PicIsValidJson = new System.Windows.Forms.PictureBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.TxtFinalSaveResult = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicLoader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicIsValidJson)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtUrl
            // 
            this.TxtUrl.AllowDrop = true;
            this.TxtUrl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtUrl.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxtUrl.ForeColor = System.Drawing.Color.DimGray;
            this.TxtUrl.Location = new System.Drawing.Point(40, 25);
            this.TxtUrl.Name = "TxtUrl";
            this.TxtUrl.Size = new System.Drawing.Size(747, 24);
            this.TxtUrl.TabIndex = 1;
            this.TxtUrl.TextChanged += new System.EventHandler(this.TxtUrl_TextChanged);
            this.TxtUrl.DragDrop += new System.Windows.Forms.DragEventHandler(this.TxtUrl_DragDrop);
            this.TxtUrl.DragOver += new System.Windows.Forms.DragEventHandler(this.TxtUrl_DragOver);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(45, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pinterest widget URL";
            // 
            // BtnGenerateIDs
            // 
            this.BtnGenerateIDs.BackColor = System.Drawing.Color.Transparent;
            this.BtnGenerateIDs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGenerateIDs.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.BtnGenerateIDs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnGenerateIDs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGenerateIDs.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnGenerateIDs.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.BtnGenerateIDs.Location = new System.Drawing.Point(333, 72);
            this.BtnGenerateIDs.Name = "BtnGenerateIDs";
            this.BtnGenerateIDs.Size = new System.Drawing.Size(155, 40);
            this.BtnGenerateIDs.TabIndex = 4;
            this.BtnGenerateIDs.TabStop = false;
            this.BtnGenerateIDs.Text = "Generate ID\'s";
            this.BtnGenerateIDs.UseVisualStyleBackColor = false;
            this.BtnGenerateIDs.Click += new System.EventHandler(this.BtnGenerateIDs_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(330, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(754, 54);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // TxtConsole
            // 
            this.TxtConsole.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtConsole.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtConsole.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.TxtConsole.Location = new System.Drawing.Point(7, 125);
            this.TxtConsole.Name = "TxtConsole";
            this.TxtConsole.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.TxtConsole.Size = new System.Drawing.Size(780, 440);
            this.TxtConsole.TabIndex = 0;
            this.TxtConsole.TabStop = false;
            this.TxtConsole.Text = "";
            this.TxtConsole.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtConsole_KeyPress);
            // 
            // BtnPrototype
            // 
            this.BtnPrototype.BackColor = System.Drawing.Color.Transparent;
            this.BtnPrototype.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPrototype.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.BtnPrototype.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnPrototype.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPrototype.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnPrototype.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.BtnPrototype.Image = ((System.Drawing.Image)(resources.GetObject("BtnPrototype.Image")));
            this.BtnPrototype.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPrototype.Location = new System.Drawing.Point(7, 72);
            this.BtnPrototype.Name = "BtnPrototype";
            this.BtnPrototype.Size = new System.Drawing.Size(109, 40);
            this.BtnPrototype.TabIndex = 8;
            this.BtnPrototype.TabStop = false;
            this.BtnPrototype.Text = "Prototype";
            this.BtnPrototype.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnPrototype.UseVisualStyleBackColor = false;
            this.BtnPrototype.Click += new System.EventHandler(this.BtnPrototype_Click);
            // 
            // PicLoader
            // 
            this.PicLoader.BackColor = System.Drawing.Color.Transparent;
            this.PicLoader.Image = ((System.Drawing.Image)(resources.GetObject("PicLoader.Image")));
            this.PicLoader.Location = new System.Drawing.Point(667, 55);
            this.PicLoader.Name = "PicLoader";
            this.PicLoader.Size = new System.Drawing.Size(81, 62);
            this.PicLoader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicLoader.TabIndex = 9;
            this.PicLoader.TabStop = false;
            // 
            // PicIsValidJson
            // 
            this.PicIsValidJson.BackColor = System.Drawing.SystemColors.Window;
            this.PicIsValidJson.Image = ((System.Drawing.Image)(resources.GetObject("PicIsValidJson.Image")));
            this.PicIsValidJson.Location = new System.Drawing.Point(753, 27);
            this.PicIsValidJson.Name = "PicIsValidJson";
            this.PicIsValidJson.Size = new System.Drawing.Size(33, 21);
            this.PicIsValidJson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicIsValidJson.TabIndex = 10;
            this.PicIsValidJson.TabStop = false;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Text Format |*.txt";
            // 
            // TxtFinalSaveResult
            // 
            this.TxtFinalSaveResult.Location = new System.Drawing.Point(250, 214);
            this.TxtFinalSaveResult.Multiline = true;
            this.TxtFinalSaveResult.Name = "TxtFinalSaveResult";
            this.TxtFinalSaveResult.Size = new System.Drawing.Size(100, 20);
            this.TxtFinalSaveResult.TabIndex = 11;
            // 
            // FrmPPReplacer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(797, 568);
            this.Controls.Add(this.PicIsValidJson);
            this.Controls.Add(this.PicLoader);
            this.Controls.Add(this.TxtConsole);
            this.Controls.Add(this.BtnPrototype);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnGenerateIDs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TxtUrl);
            this.Controls.Add(this.TxtFinalSaveResult);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmPPReplacer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PinsID Replacer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicLoader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicIsValidJson)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtUrl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnGenerateIDs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RichTextBox TxtConsole;
        private System.Windows.Forms.Button BtnPrototype;
        private System.Windows.Forms.PictureBox PicLoader;
        private System.Windows.Forms.PictureBox PicIsValidJson;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.TextBox TxtFinalSaveResult;
    }
}

