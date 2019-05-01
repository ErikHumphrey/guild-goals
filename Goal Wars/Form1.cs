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

namespace Goal_Wars
{
    public partial class frmMain : Form
    {
        int count = 0;
        int fakeCount = 0;
        const string API_URL = "https://api.guildwars2.com/v2";
        string apiKey;

        public frmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            string json = new WebClient().DownloadString(API_URL + "/currencies/25");
            dynamic stuff = JsonConvert.DeserializeObject(json);
            string imageURL = stuff.icon;
            Console.WriteLine(imageURL);
            var request = WebRequest.Create(imageURL);

            FetchIcons();

            lblCurrencyName1.Text = stuff.name + "s";

            for (int i = 1; i < 47; i++)
            {
                if (i != 8 && i != 17 && i != 21)
                {
                    json = new WebClient().DownloadString(API_URL + "/currencies/" + i);
                    stuff = JsonConvert.DeserializeObject(json);
                    Console.WriteLine(i.ToString() + " " + stuff.name);
                }
            }
        }

        private void FetchAccountInfo()
        {
            String request = new WebClient().DownloadString(API_URL + "/account/wallet" + "?access_token=" + apiKey);
            dynamic stuff = JsonConvert.DeserializeObject(request);
            count = stuff[21].value;
            prgCurrency1.Maximum = count + 500;
            tmrCounter.Start();
        }

        private void FetchIcons()
        {
            PictureBox[] pbo = { pboCurrencyIcon1, pboCurrencyIcon2, pboCurrencyIcon3, pboCurrencyIcon4, pboCurrencyIcon5, pboCurrencyIcon6 };
            int[] currencyID = { 27, 25, 5, 6, 19, 16 };

            for (int i = 0; i < pbo.Length; i++)
            {
                string json = new WebClient().DownloadString(API_URL + "/currencies/" + currencyID[i]);
                dynamic netObj = JsonConvert.DeserializeObject(json);
                string imageUrl = netObj.icon;
                var request = WebRequest.Create(imageUrl);

                using (var response = request.GetResponse())
                using (var stream = response.GetResponseStream())
                {
                    pbo[i].Image = Bitmap.FromStream(stream);
                }
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
            if (fakeCount >= count) { }
            else if (fakeCount + 17 > count)
            {
                fakeCount += 1;
            }
            else if (fakeCount + 500 > count)
            {
                fakeCount += 7;
            }
            else
            {
                fakeCount += 17;
            }

            lblCurrencyCount1.Text = fakeCount.ToString();
            prgCurrency1.Value = fakeCount;

            if (fakeCount >= count)
                tmrCounter.Stop();
        }


    }
}
