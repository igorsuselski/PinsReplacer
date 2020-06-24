using Newtonsoft.Json;
using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PinterestPinsIdsReplacer
{
    public partial class FrmPPReplacer : Form
    {
        private dynamic Response { get; set; }

        private string Url { get; set; }

        private const string ProtoShema = "pin_ids *% *22 *% *3A *% *5B *% *22BELGIUM *% *22 *% *2C *% *22CROATIA *% *22 *% *2C *% *22HUNGARY *% *22 *% *2C *% *22MACEDONIA *% *22 *% *2C *% *22RUSSIA *% *22 *% *2C *% *22TANGO *% *22 *% *2C *% *22AJVAR *% *22 *% *2C *% *22RISTE *% *22 *% *2C *% *22KINEZI *% *22 *% *2C *% *22PARMA *% *22 *% *2C *% *22JUVENTUS *% *22 *% *2C *% *22MILAN *% *22 *% *2C *% *22INTER *% *22 *% *2C *% *22REGINA *% *22 *% *2C *% *22LAZIO *% *22 *% *2C *% *22CHIEVO *% *22 *% *2C *% *22SIENA *% *22 *% *2C *% *22FIORENTINA *% *22 *% *2C *% *22BELVEDERE *% *22 *% *2C *% *22LASVEGAS *% *22 *% *2C *% *22KICEVO *% *22 *% *2C *% *22BERLIN *% *22 *% *2C *% *22MOSCOW *% *22 *% *2C *% *22JAPAN *% *22 *% *2C *% *22TOKYO *% *22 *% *2C *% *22SRBIJA *% *22 *% *2C *% *22BASKET *% *22 *% *2C *% *22TENNIS *% *22 *% *2C *% *22PISTOL *% *22 *% *2C *% *22STREET *% *22 *% *2C *% *22KOZITE *% *22 *% *2C *% *22OVCITE *% *22 *% *2C *% *22GOVEDA *% *22 *% *2C *% *22KRAVI *% *22 *% *2C *% *22VOLOVI *% *22 *% *2C *% *22VOLVO *% *22 *% *2C *% *22DANSKA *% *22 *% *2C *% *22SIBIR *% *22 *% *2C *% *22KAMCHATKA *% *22 *% *2C *% *22FLORIDA *% *22 *% *2C *% *22AJDAHO *% *22 *% *2C *% *22NEVADA *% *22 *% *2C *% *22TEXAS *% *22 *% *2C *% *22DETROIT *% *22 *% *2C *% *22PHOENIX *% *22 *% *2C *% *22DALLAS *% *22 *% *2C *% *22DENVER *% *22 *% *2C *% *22OKLAHOMA *% *22 *% *5D *% *7D *% *2C *% *22context *% *22 *% *3A *% *7B *% *7D *% *7D *";

        private string[] WordsToReplace = new string[] { "BELGIUM", "CROATIA", "HUNGARY", "MACEDONIA", "RUSSIA", "TANGO", "AJVAR", "RISTE", "KINEZI", "PARMA", "JUVENTUS", "MILAN", "INTER", "REGINA", "LAZIO", "CHIEVO", "SIENA", "FIORENTINA", "BELVEDERE", "LASVEGAS", "KICEVO", "BERLIN", "MOSCOW", "JAPAN", "TOKYO", "SRBIJA", "BASKET", "TENNIS", "PISTOL", "STREET", "KOZITE", "OVCITE", "GOVEDA", "KRAVI", "VOLOVI", "VOLVO", "DANSKA", "SIBIR", "KAMCHATKA", "FLORIDA", "AJDAHO", "NEVADA", "TEXAS", "DETROIT", "PHOENIX", "DALLAS", "DENVER", "OKLAHOMA" };


        public FrmPPReplacer()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PicLoader.Hide();
            PicIsValidJson.Hide();
            TxtUrl.Focus();
            BtnGenerateIDs.Enabled = false;
        }

        private async void TxtUrl_TextChanged(object sender, EventArgs e)
        {
            Url = TxtUrl.Text.Trim();

            if (IsValidURL(Url))
            {
                TxtConsole.Text += "> Get JSON" + Environment.NewLine;
                PicLoader.Show();
                Task<bool> getJson = new Task<bool>(GetJson);
                getJson.Start();
                bool success = await getJson;

                if (success)
                {
                    TxtConsole.Text += "> ЈSОN is valid" + Environment.NewLine + "> JSON object created" + Environment.NewLine;
                    PicLoader.Hide();
                    PicIsValidJson.Show();
                    BtnGenerateIDs.Enabled = true;
                }
                else
                {
                    TxtConsole.Clear();
                    PicIsValidJson.Hide();
                    PicLoader.Hide();
                    BtnGenerateIDs.Enabled = false;
                }
            }

            if (TxtUrl.Text == "")
            {
                TxtConsole.Clear();
                PicIsValidJson.Hide();
                PicLoader.Hide();
                BtnGenerateIDs.Enabled = false;
            }
        }

        private bool GetJson()
        {
            try
            {
                WebClient client = new WebClient();
                string json = client.DownloadString(Url);
                Response = JsonConvert.DeserializeObject(json);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        bool IsValidURL(string URL)
        {
            string Pattern = @"^(?:http(s)?:\/\/)?[\w.-]+(?:\.[\w\.-]+)+[\w\-\._~:/?#[\]@!\$&'\(\)\*\+,;=.]+$";
            Regex Rgx = new Regex(Pattern, RegexOptions.Compiled | RegexOptions.IgnoreCase);
            return Rgx.IsMatch(URL);
        }

        private void BtnPrototype_Click(object sender, EventArgs e)
        {
            FrmProto proto = new FrmProto() { ProtoText = ProtoShema };
            proto.ShowDialog();
        }

        private void TxtConsole_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void TxtUrl_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

                if (System.IO.Directory.Exists(files[0]))
                    TxtUrl.Text = files[0];
            }
        }

        private void TxtUrl_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void BtnGenerateIDs_Click(object sender, EventArgs e)
        {          
            int count = Response["data"]["pins"].Count;
            string[] idS = new string[count];
            for (int i = 0; i < count; i++)
            {
                string id = Response["data"]["pins"][i]["id"];
                TxtConsole.Text += $" pins[{i}].id = {id}" + Environment.NewLine;
                idS[i] = id;
            }

            TxtConsole.Text += "> Replace unique words with pins IDs:" + Environment.NewLine;
            string protoString = ProtoShema;

            for (int i = 0; i < idS.Length; i++)
            {
                if (ProtoShema.Contains(WordsToReplace[i]))
                {
                    protoString = protoString.Replace(WordsToReplace[i], idS[i]);
                }
            }

            protoString = protoString.Replace("*", "\"");
            protoString = protoString.Replace(" ", "");

            TxtConsole.Text += "> " + protoString.ToString() + Environment.NewLine;
            TxtConsole.ForeColor = Color.DarkCyan;
            TxtConsole.Text += "> Operation Completed";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (Stream s = File.Open(saveFileDialog.FileName, FileMode.CreateNew))
                using (TextWriter sw = new StreamWriter(s))
                {
                    TxtConsole.Text = protoString;
                    sw.Write(TxtConsole.Text);
                }
            }
        }

        private void TxtConsole_TextChanged(object sender, EventArgs e)
        {
            TxtConsole.SelectionStart = TxtConsole.Text.Length;
            TxtConsole.ScrollToCaret();
        }
    }
}
