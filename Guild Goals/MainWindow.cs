using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

// TODO: Change the last four currencies to items (Obsidian Shards, Karka Shells, Passion Flowers, and Stabilizing Matrices)

namespace Guild_Goals
{
    public partial class frmMain : Form
    {
        const string API_URL = "https://api.guildwars2.com/v2";
        string apiKey;
        int[] currencyCount = new int[6];

        public frmMain() => InitializeComponent();

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.txtApiKey.GotFocus += new EventHandler(TxtApiKey_Focus);

            FetchIcons();
        }

        private void FetchAccountInfo()
        {
            String request = new WebClient().DownloadString(API_URL + "/account/wallet" + "?access_token=" + apiKey);
            dynamic netObj = JsonConvert.DeserializeObject(request);

            Label[] currencyCounter = { lblCurrencyCount1, lblCurrencyCount2, lblCurrencyCount3, lblCurrencyCount4, lblCurrencyCount5, lblCurrencyCount6 };
            int[] currencyID = { 27, 25, 5, 6, 19, 16 }; // TODO: Remove duplication

            for (int i = 0; i < currencyCounter.Length; i++)
            {
                for (int j = 0; j < netObj.Count; j++)
                {
                    if (netObj[j].id == currencyID[i])
                    {
                        currencyCount[i] = netObj[j].value;
                        currencyCounter[i].Text = currencyCount[i].ToString();
                    }
                }
            }

            DisplayProgress();
        }

        private void FetchIcons()
        {
            PictureBox[] currencyIcon = { pboCurrencyIcon1, pboCurrencyIcon2, pboCurrencyIcon3, pboCurrencyIcon4, pboCurrencyIcon5, pboCurrencyIcon6 };
            Label[] currencyName = { lblCurrencyName1, lblCurrencyName2, lblCurrencyName3, lblCurrencyName4, lblCurrencyName5, lblCurrencyName6 };
            int[] currencyID = { 27, 25, 5, 6, 19, 16 };

            for (int i = 0; i < currencyIcon.Length; i++)
            {
                string json = new WebClient().DownloadString(API_URL + "/currencies/" + currencyID[i]);
                dynamic netObj = JsonConvert.DeserializeObject(json);
                string imageUrl = netObj.icon;
                var request = WebRequest.Create(imageUrl);

                using (var response = request.GetResponse())
                using (var stream = response.GetResponseStream())
                {
                    currencyIcon[i].Image = Bitmap.FromStream(stream);
                }

                currencyName[i].Text = netObj.name;
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            FetchAccountInfo();
        }

        private void TxtApiKey_TextChanged(object sender, EventArgs e)
        {
            apiKey = txtApiKey.Text;

            if (apiKey.Length == 72)
            {
                FetchAccountInfo();
            }
        }

        private void TmrCounter_Tick(object sender, EventArgs e)
        {
            Tick();
        }

        private void DisplayProgress()
        {
            ProgressBar[] currencyProgress = { prgCurrency1, prgCurrency2, prgCurrency3, prgCurrency4, prgCurrency5, prgCurrency6 };

            for (int i = 0; i < currencyProgress.Length; i++)
            {
                currencyProgress[i].Maximum = currencyCount[i] + 100;
            }

            tmrCounter.Start();
        }

        private void Tick()
        {
            ProgressBar[] currencyProgress = { prgCurrency1, prgCurrency2, prgCurrency3, prgCurrency4, prgCurrency5, prgCurrency6 };

            for (int i = 0; i < currencyProgress.Length; i++)
            {
                if (currencyProgress[i].Value >= currencyCount[i]) { }
                else if (currencyProgress[i].Value + 17 > currencyCount[i])
                {
                    currencyProgress[i].Value += 1;
                }
                else if (currencyProgress[i].Value + 500 > currencyCount[i])
                {
                    currencyProgress[i].Value += 7;
                }
                else
                {
                    currencyProgress[i].Value += 17;
                }
            }
        }

        private void TxtApiKey_Focus(Object sender, EventArgs e)
        {
            txtApiKey.Text = ""; // Clear TextBox on focus
        }
    }
}
