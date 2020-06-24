using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PinterestPinsIdsReplacer
{
    public partial class FrmProto : Form
    {
        public FrmProto()
        {
            InitializeComponent();
        }

        public string  ProtoText { get; internal set; }

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
    }
}
