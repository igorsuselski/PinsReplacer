using System;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace PinterestPinsIdsReplacer
{
    public partial class FrmPPReplacer : Form
    {
        private dynamic Response { get; set; }

        private string Url { get; set; }

        private string ProtoShemaData { get; set; }

        private string[] WordsToReplaceFromShema { get; set; }
        public bool JsonPreview { get; private set; }

        public FrmPPReplacer()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PicLoader.Hide();
            PicIsValidJson.Hide();
            PicClearLinc.Hide();
            PicJson.Enabled = false;
            TxtUrl.Focus();
            
            BtnGenerateIDs.Enabled = false;
            SetProtoShema();
            SetReplaceWordsShema();
        }

        private void SetProtoShema()
        {
            try
            {
                using (StreamReader sr = new StreamReader(ConfigurationManager.AppSettings["ProtoShemaTxtPath"]))
                {
                    string text = sr.ReadToEnd();
                    ProtoShemaData = text;
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }

        private void SetReplaceWordsShema()
        {
            string line = "";
            int count = 0;
            try
            {
                using (StreamReader sr = new StreamReader(ConfigurationManager.AppSettings["WordsToReplaceTxtPath"]))
                {
                    while (sr.ReadLine() != null)
                    {
                        count++;
                    }
                    WordsToReplaceFromShema = new string[count];
                    count = 0;
                    sr.DiscardBufferedData();
                    sr.DiscardBufferedData();
                    sr.BaseStream.Seek(0, SeekOrigin.Begin);
                    while ((line = sr.ReadLine()) != null)
                    {
                        WordsToReplaceFromShema[count] = line;
                        count++;
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }

        private async void TxtUrl_TextChanged(object sender, EventArgs e)
        {
            Url = TxtUrl.Text.Trim();

            if (IsValidURL(Url))
            {
                TxtConsole.Clear();

                TxtConsole.Text += "> Get data" + Environment.NewLine;
                PicLoader.Show();
                Task<bool> getJson = new Task<bool>(GetJson);
                getJson.Start();
                bool success = await getJson;

                if (success)
                {
                    TxtConsole.Text += "> ЈSОN is valid" + Environment.NewLine + "> JSON deserialized object created" + Environment.NewLine;
                    PicLoader.Hide();
                    PicIsValidJson.Show();
                    PicClearLinc.Show();
                    PicJson.Enabled = true;
                    BtnGenerateIDs.Enabled = true;
                }
                else
                {
                    TxtConsole.Clear();
                    PicIsValidJson.Hide();
                    PicLoader.Hide();
                    PicClearLinc.Hide();
                    BtnGenerateIDs.Enabled = false;
                    PicJson.Enabled = false;
                }
            }

            if (TxtUrl.Text == "")
            {
                TxtConsole.Clear();
                PicClearLinc.Hide();
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
            FrmProto proto = new FrmProto() { ProtoText = ProtoShemaData };
            proto.ShowDialog();
            if (proto.Refreshed)
            {
                SetProtoShema();
                SetReplaceWordsShema();
            }
        }

        private void TxtConsole_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void TxtUrl_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
            TxtUrl.Text = e.Data.GetData(DataFormats.Text).ToString();
        }

        private void BtnGenerateIDs_Click(object sender, EventArgs e)
        {
            if (JsonPreview) TxtConsole.Clear();
            try
            {
                int count = Response["data"]["pins"].Count;
                string[] idS = new string[count];
                string id = "";

                for (int i = 0; i < count; i++)
                {
                    id = Response["data"]["pins"][i]["id"];
                    TxtConsole.Text += $" pins[{i}].id = {id}" + Environment.NewLine;
                    idS[i] = id;
                }

                TxtConsole.Text += $"> Number of IDs: {count}" + Environment.NewLine;
                TxtConsole.Text += "> Replace unique words with pins IDs:" + Environment.NewLine;

                string resultsShema = ProtoShemaData;
                int replaceCount = 0;        
                for (int i = 0; i < idS.Length; i++)
                {
                    if (resultsShema.Contains(WordsToReplaceFromShema[i]))
                    {
                        resultsShema = resultsShema.Replace(WordsToReplaceFromShema[i], idS[i]);
                        replaceCount++;
                    }
                }

                TxtConsole.Text += "> " + resultsShema.ToString() + Environment.NewLine;
                TxtConsole.ForeColor = Color.DarkCyan;
                TxtConsole.Text += $"> Total replaced: {replaceCount}." + Environment.NewLine + "Operation Completed";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (Stream s = File.Open(saveFileDialog.FileName, FileMode.CreateNew))
                    using (TextWriter sw = new StreamWriter(s))
                    {
                        TxtConsole.Text = resultsShema;
                        sw.Write(TxtConsole.Text);
                    }
                }
            }
            catch (Exception ex)
            {
                TxtConsole.ForeColor = Color.IndianRed;
                MessageBox.Show(ex.Message);
                TxtConsole.Text += "> Operation Failed";
            }
        }

        private void TxtConsole_TextChanged(object sender, EventArgs e)
        {
            TxtConsole.SelectionStart = TxtConsole.Text.Length;
            TxtConsole.ScrollToCaret();
        }

        private void PictureBox3_Click(object sender, EventArgs e) => TxtUrl.Clear();

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.pinterest.com/");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            TxtConsole.Clear();
            TxtConsole.Text = Response.ToString() ?? "no object";
            JsonPreview = true;
        }

        private void TxtConsole_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            if (IsHttpURL(e.LinkText)) Process.Start(e.LinkText);
        }

        private bool IsHttpURL(string url)
        {
            return ((!string.IsNullOrWhiteSpace(url)) &&
                   (url.ToLower().StartsWith("http")) || (url.ToLower().StartsWith("www")));
        }
    }
}
