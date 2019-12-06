using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IGDB_API.Objects;

namespace IGDB_Application
{
    public partial class Form1 : Form
    {
        IGDB_API.API _api = new IGDB_API.API();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelectGame_Click(object sender, EventArgs e)
        {  
           var gameTitles = _api.GetGameTitles(txtSelectedGame.Text);
           lstGameTitles.DataSource = gameTitles;
           lstGameTitles.DisplayMember = "name";
           lstGameTitles.ValueMember = "id";                    
        }

        private void lstGameTitles_Click(object sender, EventArgs e)
        {
            var gameDetails = _api.GetGameInfo(int.Parse(lstGameTitles.SelectedValue.ToString()));
            lblGameSummary.AutoSize = true;
            lblGameSummary.MaximumSize = new Size(300, 0);

            lblGameName.Text = gameDetails.FirstOrDefault().name;
            lblGameSummary.Text = gameDetails.FirstOrDefault().summary;            
        }
    }
}
