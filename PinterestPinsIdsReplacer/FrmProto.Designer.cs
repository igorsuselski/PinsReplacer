namespace PinterestPinsIdsReplacer
{
    partial class FrmProto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProto));
            this.button1 = new System.Windows.Forms.Button();
            this.TxtProtoString = new System.Windows.Forms.RichTextBox();
            this.BtnProtoShema = new System.Windows.Forms.Button();
            this.BtnWordsToReplace = new System.Windows.Forms.Button();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(2, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 51);
            this.button1.TabIndex = 5;
            this.toolTip1.SetToolTip(this.button1, "Back");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // TxtProtoString
            // 
            this.TxtProtoString.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtProtoString.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxtProtoString.Location = new System.Drawing.Point(2, 69);
            this.TxtProtoString.Name = "TxtProtoString";
            this.TxtProtoString.Size = new System.Drawing.Size(631, 309);
            this.TxtProtoString.TabIndex = 6;
            this.TxtProtoString.Text = "";
            this.TxtProtoString.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtProtoString_KeyPress);
            // 
            // BtnProtoShema
            // 
            this.BtnProtoShema.BackColor = System.Drawing.Color.Transparent;
            this.BtnProtoShema.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnProtoShema.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.BtnProtoShema.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnProtoShema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProtoShema.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnProtoShema.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.BtnProtoShema.Image = ((System.Drawing.Image)(resources.GetObject("BtnProtoShema.Image")));
            this.BtnProtoShema.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProtoShema.Location = new System.Drawing.Point(462, 1);
            this.BtnProtoShema.Name = "BtnProtoShema";
            this.BtnProtoShema.Size = new System.Drawing.Size(171, 32);
            this.BtnProtoShema.TabIndex = 7;
            this.BtnProtoShema.Text = "Proto Shema txt";
            this.BtnProtoShema.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnProtoShema.UseVisualStyleBackColor = false;
            this.BtnProtoShema.Click += new System.EventHandler(this.BtnProtoShema_Click);
            // 
            // BtnWordsToReplace
            // 
            this.BtnWordsToReplace.BackColor = System.Drawing.Color.Transparent;
            this.BtnWordsToReplace.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnWordsToReplace.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.BtnWordsToReplace.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnWordsToReplace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnWordsToReplace.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnWordsToReplace.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.BtnWordsToReplace.Image = ((System.Drawing.Image)(resources.GetObject("BtnWordsToReplace.Image")));
            this.BtnWordsToReplace.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnWordsToReplace.Location = new System.Drawing.Point(462, 35);
            this.BtnWordsToReplace.Name = "BtnWordsToReplace";
            this.BtnWordsToReplace.Size = new System.Drawing.Size(171, 32);
            this.BtnWordsToReplace.TabIndex = 8;
            this.BtnWordsToReplace.Text = "Words to Replace txt";
            this.BtnWordsToReplace.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnWordsToReplace.UseVisualStyleBackColor = false;
            this.BtnWordsToReplace.Click += new System.EventHandler(this.BtnWordsToReplace_Click);
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.BtnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.BtnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRefresh.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnRefresh.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.BtnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("BtnRefresh.Image")));
            this.BtnRefresh.Location = new System.Drawing.Point(263, 1);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(81, 51);
            this.BtnRefresh.TabIndex = 9;
            this.toolTip1.SetToolTip(this.BtnRefresh, "Refresh shemas");
            this.BtnRefresh.UseVisualStyleBackColor = false;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // FrmProto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(634, 380);
            this.ControlBox = false;
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.BtnWordsToReplace);
            this.Controls.Add(this.BtnProtoShema);
            this.Controls.Add(this.TxtProtoString);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmProto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proto shema";
            this.Load += new System.EventHandler(this.FrmProto_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox TxtProtoString;
        private System.Windows.Forms.Button BtnProtoShema;
        private System.Windows.Forms.Button BtnWordsToReplace;
        private System.Windows.Forms.Button BtnRefresh;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}