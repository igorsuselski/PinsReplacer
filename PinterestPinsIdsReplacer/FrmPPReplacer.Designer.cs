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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPPReplacer));
            this.TxtUrl = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnGenerateIDs = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.PicJson = new System.Windows.Forms.PictureBox();
            this.TxtConsole = new System.Windows.Forms.RichTextBox();
            this.BtnPrototype = new System.Windows.Forms.Button();
            this.PicLoader = new System.Windows.Forms.PictureBox();
            this.PicIsValidJson = new System.Windows.Forms.PictureBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.PicClearLinc = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicJson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicLoader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicIsValidJson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicClearLinc)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtUrl
            // 
            this.TxtUrl.AllowDrop = true;
            this.TxtUrl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtUrl.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxtUrl.ForeColor = System.Drawing.Color.DimGray;
            this.TxtUrl.Location = new System.Drawing.Point(39, 29);
            this.TxtUrl.Name = "TxtUrl";
            this.TxtUrl.Size = new System.Drawing.Size(590, 25);
            this.TxtUrl.TabIndex = 1;
            this.toolTip1.SetToolTip(this.TxtUrl, "paste or drag & drop");
            this.TxtUrl.TextChanged += new System.EventHandler(this.TxtUrl_TextChanged);
            this.TxtUrl.DragEnter += new System.Windows.Forms.DragEventHandler(this.TxtUrl_DragEnter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(44, 8);
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
            this.BtnGenerateIDs.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnGenerateIDs.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.BtnGenerateIDs.Image = ((System.Drawing.Image)(resources.GetObject("BtnGenerateIDs.Image")));
            this.BtnGenerateIDs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGenerateIDs.Location = new System.Drawing.Point(212, 62);
            this.BtnGenerateIDs.Name = "BtnGenerateIDs";
            this.BtnGenerateIDs.Size = new System.Drawing.Size(214, 57);
            this.BtnGenerateIDs.TabIndex = 4;
            this.BtnGenerateIDs.TabStop = false;
            this.BtnGenerateIDs.Text = "Generate ";
            this.BtnGenerateIDs.UseVisualStyleBackColor = false;
            this.BtnGenerateIDs.Click += new System.EventHandler(this.BtnGenerateIDs_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(329, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 5;
            // 
            // PicJson
            // 
            this.PicJson.Image = ((System.Drawing.Image)(resources.GetObject("PicJson.Image")));
            this.PicJson.Location = new System.Drawing.Point(595, 59);
            this.PicJson.Name = "PicJson";
            this.PicJson.Size = new System.Drawing.Size(32, 33);
            this.PicJson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicJson.TabIndex = 6;
            this.PicJson.TabStop = false;
            this.toolTip1.SetToolTip(this.PicJson, "View json");
            this.PicJson.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // TxtConsole
            // 
            this.TxtConsole.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtConsole.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtConsole.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxtConsole.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.TxtConsole.Location = new System.Drawing.Point(6, 128);
            this.TxtConsole.Name = "TxtConsole";
            this.TxtConsole.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.TxtConsole.Size = new System.Drawing.Size(623, 442);
            this.TxtConsole.TabIndex = 0;
            this.TxtConsole.TabStop = false;
            this.TxtConsole.Text = "";
            this.TxtConsole.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.TxtConsole_LinkClicked);
            this.TxtConsole.TextChanged += new System.EventHandler(this.TxtConsole_TextChanged);
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
            this.BtnPrototype.Location = new System.Drawing.Point(6, 79);
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
            this.PicLoader.Location = new System.Drawing.Point(508, 59);
            this.PicLoader.Name = "PicLoader";
            this.PicLoader.Size = new System.Drawing.Size(81, 62);
            this.PicLoader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicLoader.TabIndex = 9;
            this.PicLoader.TabStop = false;
            // 
            // PicIsValidJson
            // 
            this.PicIsValidJson.BackColor = System.Drawing.Color.GhostWhite;
            this.PicIsValidJson.Image = ((System.Drawing.Image)(resources.GetObject("PicIsValidJson.Image")));
            this.PicIsValidJson.Location = new System.Drawing.Point(605, 3);
            this.PicIsValidJson.Name = "PicIsValidJson";
            this.PicIsValidJson.Size = new System.Drawing.Size(22, 22);
            this.PicIsValidJson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicIsValidJson.TabIndex = 10;
            this.PicIsValidJson.TabStop = false;
            this.toolTip1.SetToolTip(this.PicIsValidJson, "JSON downloaded");
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Text Format |*.txt";
            // 
            // PicClearLinc
            // 
            this.PicClearLinc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicClearLinc.Image = ((System.Drawing.Image)(resources.GetObject("PicClearLinc.Image")));
            this.PicClearLinc.Location = new System.Drawing.Point(177, 8);
            this.PicClearLinc.Name = "PicClearLinc";
            this.PicClearLinc.Size = new System.Drawing.Size(18, 17);
            this.PicClearLinc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicClearLinc.TabIndex = 12;
            this.PicClearLinc.TabStop = false;
            this.toolTip1.SetToolTip(this.PicClearLinc, "Clear url");
            this.PicClearLinc.Click += new System.EventHandler(this.PictureBox3_Click);
            // 
            // FrmPPReplacer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(634, 576);
            this.Controls.Add(this.PicClearLinc);
            this.Controls.Add(this.PicIsValidJson);
            this.Controls.Add(this.PicLoader);
            this.Controls.Add(this.BtnPrototype);
            this.Controls.Add(this.PicJson);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnGenerateIDs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TxtUrl);
            this.Controls.Add(this.TxtConsole);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmPPReplacer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PinsID Replacer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicJson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicLoader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicIsValidJson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicClearLinc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtUrl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnGenerateIDs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox PicJson;
        private System.Windows.Forms.RichTextBox TxtConsole;
        private System.Windows.Forms.Button BtnPrototype;
        private System.Windows.Forms.PictureBox PicLoader;
        private System.Windows.Forms.PictureBox PicIsValidJson;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.PictureBox PicClearLinc;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

