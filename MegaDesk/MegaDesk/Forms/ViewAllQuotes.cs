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

namespace MegaDesk
{
    public partial class ViewAllQuotes : Form
    {
        public ViewAllQuotes()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void ViewAllQuotes_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        #region Display the GridView Data
        /// <summary>
        /// Internal Class to collect data from quotes.json.
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

        private void ShowData()
        {
            const string Path = @"Utils\quotes.json";

            //Gets the last json values and add new values to the file
            List<QuoteInfo> info = JsonConvert.DeserializeObject<List<QuoteInfo>>(File.ReadAllText(Path));

            DataTable dataTable = ConvertTo(info);

            dataView.DataSource = dataTable;
        }

        /// <summary>
        /// Converts the list into a DataTable.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <returns>Table.</returns>
        public static DataTable ConvertTo<T>(IList<T> list)
        {
            DataTable table = CreateTable<T>();
            Type entityType = typeof(T);
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(entityType);

            foreach (T item in list)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                {
                    row[prop.Name] = prop.GetValue(item);
                }
                table.Rows.Add(row);
            }
            return table;
        }

        /// <summary>
        /// Creates the table to the GridView.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns>Table.</returns>
        public static DataTable CreateTable<T>()
        {
            Type entityType = typeof(T);
            DataTable table = new DataTable(entityType.Name);
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(entityType);

            foreach (PropertyDescriptor prop in properties)
            {
                table.Columns.Add(prop.Name, prop.PropertyType);
            }
            return table;
        }
        #endregion
    }
}

