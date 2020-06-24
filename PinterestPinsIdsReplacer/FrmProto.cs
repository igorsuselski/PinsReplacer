using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PinterestPinsIdsReplacer
{
    public partial class FrmProto : Form
    {
        private  string ProtoFilePath { get; set; } = ConfigurationManager.AppSettings["ProtoShemaTxtPath"];

        private string WordsToReplacePath { get; set; } =  ConfigurationManager.AppSettings["WordsToReplaceTxtPath"];

        public FrmProto()
        {
            InitializeComponent();
        }

        public string  ProtoText { get; internal set; }

        public bool Refreshed { get; internal set; }

        private void FrmProto_Load(object sender, EventArgs e)
        {
            ProtoText = ProtoText.Replace("*", "\"");
            ProtoText = ProtoText.Replace(" ", "");
            TxtProtoString.Text = ProtoText;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TxtProtoString_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void BtnProtoShema_Click(object sender, EventArgs e)
        {
            if(File.Exists(ProtoFilePath))
{
                Process.Start(ProtoFilePath);
            }
        }

        private void BtnWordsToReplace_Click(object sender, EventArgs e)
        {
            if(File.Exists(WordsToReplacePath))
{
                Process.Start(WordsToReplacePath);
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            Refreshed = true;
            Close();
        }
    }
}
