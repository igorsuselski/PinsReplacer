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
            this.TxtUrlPins = new System.Windows.Forms.TextBox();
            this.TxtUrlBoard = new System.Windows.Forms.TextBox();
            this.LbaEnterInfo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
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
            this.TxtUrl.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxtUrl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TxtUrl.Location = new System.Drawing.Point(33, 29);
            this.TxtUrl.Name = "TxtUrl";
            this.TxtUrl.Size = new System.Drawing.Size(336, 24);
            this.TxtUrl.TabIndex = 1;
            this.toolTip1.SetToolTip(this.TxtUrl, "paste or drag & drop, and press enter to load");
            this.TxtUrl.TextChanged += new System.EventHandler(this.TxtUrl_TextChanged);
            this.TxtUrl.DragEnter += new System.Windows.Forms.DragEventHandler(this.TxtUrl_DragEnter);
            this.TxtUrl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtUrl_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "widgets.pinterest.com");
            this.pictureBox1.Click += new System.EventHandler(this.Postebins_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(36, 9);
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
            this.BtnGenerateIDs.Location = new System.Drawing.Point(215, 62);
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
            this.PicJson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicJson.Image = ((System.Drawing.Image)(resources.GetObject("PicJson.Image")));
            this.PicJson.Location = new System.Drawing.Point(599, 59);
            this.PicJson.Name = "PicJson";
            this.PicJson.Size = new System.Drawing.Size(32, 33);
            this.PicJson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicJson.TabIndex = 6;
            this.PicJson.TabStop = false;
            this.toolTip1.SetToolTip(this.PicJson, "View json");
            this.PicJson.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // TxtConsole
            // 
            this.TxtConsole.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtConsole.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtConsole.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxtConsole.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.TxtConsole.Location = new System.Drawing.Point(3, 128);
            this.TxtConsole.Name = "TxtConsole";
            this.TxtConsole.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.TxtConsole.Size = new System.Drawing.Size(628, 442);
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
            this.BtnPrototype.Location = new System.Drawing.Point(3, 79);
            this.BtnPrototype.Name = "BtnPrototype";
            this.BtnPrototype.Size = new System.Drawing.Size(107, 40);
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
            this.PicLoader.Location = new System.Drawing.Point(512, 62);
            this.PicLoader.Name = "PicLoader";
            this.PicLoader.Size = new System.Drawing.Size(81, 57);
            this.PicLoader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicLoader.TabIndex = 9;
            this.PicLoader.TabStop = false;
            // 
            // PicIsValidJson
            // 
            this.PicIsValidJson.BackColor = System.Drawing.Color.White;
            this.PicIsValidJson.Image = ((System.Drawing.Image)(resources.GetObject("PicIsValidJson.Image")));
            this.PicIsValidJson.Location = new System.Drawing.Point(607, 7);
            this.PicIsValidJson.Name = "PicIsValidJson";
            this.PicIsValidJson.Size = new System.Drawing.Size(24, 18);
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
            this.PicClearLinc.Location = new System.Drawing.Point(169, 9);
            this.PicClearLinc.Name = "PicClearLinc";
            this.PicClearLinc.Size = new System.Drawing.Size(30, 17);
            this.PicClearLinc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicClearLinc.TabIndex = 12;
            this.PicClearLinc.TabStop = false;
            this.toolTip1.SetToolTip(this.PicClearLinc, "Clear ");
            this.PicClearLinc.Click += new System.EventHandler(this.PictureBox3_Click);
            // 
            // TxtUrlPins
            // 
            this.TxtUrlPins.AllowDrop = true;
            this.TxtUrlPins.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtUrlPins.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxtUrlPins.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TxtUrlPins.Location = new System.Drawing.Point(517, 29);
            this.TxtUrlPins.Name = "TxtUrlPins";
            this.TxtUrlPins.Size = new System.Drawing.Size(114, 24);
            this.TxtUrlPins.TabIndex = 3;
            this.toolTip1.SetToolTip(this.TxtUrlPins, "paste or drag & drop, and press enter to load");
            this.TxtUrlPins.DragEnter += new System.Windows.Forms.DragEventHandler(this.TxtUrl_DragEnter);
            this.TxtUrlPins.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtUrl_KeyPress);
            // 
            // TxtUrlBoard
            // 
            this.TxtUrlBoard.AllowDrop = true;
            this.TxtUrlBoard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtUrlBoard.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxtUrlBoard.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TxtUrlBoard.Location = new System.Drawing.Point(386, 29);
            this.TxtUrlBoard.Name = "TxtUrlBoard";
            this.TxtUrlBoard.Size = new System.Drawing.Size(114, 24);
            this.TxtUrlBoard.TabIndex = 2;
            this.toolTip1.SetToolTip(this.TxtUrlBoard, "paste or drag & drop, and press enter to load");
            this.TxtUrlBoard.DragEnter += new System.Windows.Forms.DragEventHandler(this.TxtUrl_DragEnter);
            this.TxtUrlBoard.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtUrl_KeyPress);
            // 
            // LbaEnterInfo
            // 
            this.LbaEnterInfo.AutoSize = true;
            this.LbaEnterInfo.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LbaEnterInfo.ForeColor = System.Drawing.Color.DarkGray;
            this.LbaEnterInfo.Location = new System.Drawing.Point(205, 8);
            this.LbaEnterInfo.Name = "LbaEnterInfo";
            this.LbaEnterInfo.Size = new System.Drawing.Size(0, 17);
            this.LbaEnterInfo.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(390, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Board";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(521, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Pins";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Open Sans Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label5.Location = new System.Drawing.Point(369, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 24);
            this.label5.TabIndex = 17;
            this.label5.Text = "/";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Open Sans Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label7.Location = new System.Drawing.Point(500, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 24);
            this.label7.TabIndex = 19;
            this.label7.Text = "/";
            // 
            // FrmPPReplacer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(634, 576);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtUrlBoard);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtUrlPins);
            this.Controls.Add(this.LbaEnterInfo);
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
        private System.Windows.Forms.Label LbaEnterInfo;
        private System.Windows.Forms.TextBox TxtUrlPins;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtUrlBoard;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
    }
}

