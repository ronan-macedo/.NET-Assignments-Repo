using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class DisplayQuote : Form
    {
        #region DisplayQuote Properties
        private string Customer;

        private double AreaCost;

        private double DrawerCost;

        private double MaterialCost;

        private double RushDaysCost;

        private double Total;

        private string Estimated;

        private string MaterialType;

        private double DeskWidth;

        private double DeskDepth;

        private double DeskDrawer;
        #endregion


        public DisplayQuote(string customer, double areaCost, double drawerCost,
            double materialCost, double rushDaysCost, double total, string estimated,
            string materialType, double width, double depth, double drawer)
        {
            InitializeComponent();
            Customer = customer;
            AreaCost = areaCost;
            DrawerCost = drawerCost;
            MaterialCost = materialCost;
            RushDaysCost = rushDaysCost;
            Total = total;
            Estimated = estimated;
            MaterialType = materialType;
            DeskWidth = width;
            DeskDepth = depth;
            DeskDrawer = drawer;
        }

        /// <summary>
        /// Internal Class to collect data for quotes.json.
        /// </summary>
        private class QuoteInfo
        {
            public string Name { get; set; }

            public string Width { get; set; }

            public string Depth { get; set; }

            public int Drawers { get; set; }

            public string Material { get; set; }

            public string Total { get; set; }

            public string Delivery { get; set; }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AddQuote addQuote = (AddQuote)Tag;
            addQuote.Show();
            Close();
        }

        private void DisplayQuote_Load(object sender, EventArgs e)
        {

            txtName.Text = Customer;
            txtAreaCost.Text = string.Format("{0:0.00}", AreaCost);
            txtDrawer.Text = string.Format("{0:0.00}", DrawerCost);
            txtMaterial.Text = string.Format("{0:0.00}", MaterialCost);
            txtRushDays.Text = string.Format("{0:0.00}", RushDaysCost);
            txtTotal.Text = string.Format("{0:0.00}", Total);
            txtDate.Text = Estimated;
        }

        #region Saving the Quote into a Json file
        private void btnAdd_Click(object sender, EventArgs e)
        {
            WriteToFile();
            MessageBox.Show("Quote confirmed!", "Success!");

            // Return to the Add Quote after the MessageBox
            AddQuote addQuote = (AddQuote)Tag;
            addQuote.Show();
            Close();
        }

        /// <summary>
        /// Writes the data collected into a json file.
        /// </summary>
        private void WriteToFile()
        {
            try
            {
                const string Path = @"Utils\quotes.json";

                //Gets the last json values and add new values to the file
                List<QuoteInfo> info = JsonConvert.DeserializeObject<List<QuoteInfo>>(File.ReadAllText(Path));

                info.Add(new QuoteInfo()
                {
                    Name = Customer,
                    Width = string.Format("{0} inches", DeskWidth),
                    Depth = string.Format("{0} inches", DeskDepth),
                    Drawers = (int)DeskDrawer,
                    Material = MaterialType,
                    Total = string.Format("$ {0:0.00}", Total),
                    Delivery = Estimated
                });

                string jsonWriter = JsonConvert.SerializeObject(info, Formatting.Indented, new JsonSerializerSettings
                {                    
                    NullValueHandling = NullValueHandling.Ignore
                });

                using (StreamWriter file = new StreamWriter(Path))
                {
                    file.WriteLine(jsonWriter);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Warning!");
            }
        }
        #endregion
    }
}
