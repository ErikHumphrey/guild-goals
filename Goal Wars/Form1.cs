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

namespace Goal_Wars
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string json = new WebClient().DownloadString("https://api.guildwars2.com/v2/items/24");
            dynamic stuff = JsonConvert.DeserializeObject(json);
            string funkyType = stuff.details.type;
            MessageBox.Show(funkyType);
        }
    }
}
