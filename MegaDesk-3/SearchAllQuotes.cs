using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_3
{
    public partial class SearchAllQuotes : Form
    {
        MainMenuForm mainMenu;
        public string searchBy { get; set; }

        public SearchAllQuotes(MainMenuForm mainMenuForm)
        {
            InitializeComponent();
            mainMenu = mainMenuForm;
            SearchComboBox.DataSource = Enum.GetValues(typeof(Desk.DesktopMaterial));
        }



        private void Search_Click(object sender, EventArgs e)
        {
            quoteGrid.Rows.Clear();
            DeskQuote deskQuote = new DeskQuote();
            List<DeskQuote> deskQuotes = new List<DeskQuote>();


            using (StreamReader r = new StreamReader("Quotes.json"))
            {


                while (!r.EndOfStream)
                {
                    deskQuote = JsonConvert.DeserializeObject<DeskQuote>(r.ReadLine());
                    deskQuotes.Add(deskQuote);
                }

                foreach (DeskQuote derp in deskQuotes)
                {
                    if(derp.desk.material == SearchComboBox.Text)
                    {
                        String[] herp = new String[8];
                        herp[0] = derp.date;
                        herp[1] = derp.clientName;
                        herp[2] = derp.desk.width.ToString();
                        herp[3] = derp.desk.depth.ToString();
                        herp[4] = derp.desk.numOfDrawers.ToString();
                        herp[5] = derp.desk.material;
                        herp[6] = derp.rushDays.ToString();
                        herp[7] = derp.price.ToString();
                        quoteGrid.Rows.Add(herp);
                    }
                    
                }
                
            }

        }

        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            mainMenu.Show();
            this.Hide();
        }

        private void SearchAllQuotes_Load(object sender, EventArgs e)
        {

        }
    }
}
