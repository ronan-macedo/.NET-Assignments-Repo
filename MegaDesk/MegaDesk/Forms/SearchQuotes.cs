using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class SearchQuotes : Form
    {
        public SearchQuotes()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        #region Bind the Enum to the Combo Box
        /// <summary>
        /// Get the description of a Enum.
        /// </summary>
        /// <param name="value"></param>
        /// <returns>String with a Enum description.</returns>
        public static string GetDescription(Enum value)
        {
            FieldInfo fieldInfo = value.GetType().GetField(value.ToString());
            DescriptionAttribute[] attributes = (DescriptionAttribute[])fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);
            return attributes.Length > 0 ? attributes[0].Description ?? "Null" : value.ToString();
        }

        /// <summary>
        /// Returns a list of enum values.
        /// </summary>
        /// <param name="type"></param>
        /// <returns>List with enum values.</returns>
        public static IList List(Type type)
        {
            ArrayList list = new ArrayList();
            if (type != null)
            {
                Array enumValues = Enum.GetValues(type);
                foreach (Enum value in enumValues)
                {
                    list.Add(new KeyValuePair<Enum, string>(value, GetDescription(value)));
                }
            }

            return list;
        }

        private void SearchQuotes_Load(object sender, EventArgs e)
        {
            //Bind Material ComboBox with SurfaceMaterial Enum
            cmbMat.DataSource = List(typeof(Desk.SufarceMaterial));
            cmbMat.DisplayMember = "Value";
            cmbMat.ValueMember = "Key";
        }

        #endregion

        private void cmbMat_SelectedIndexChanged(object sender, EventArgs e)
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
           
            string material = cmbMat.SelectedValue.ToString();

            List<QuoteInfo> infoFiltered = info.Where(f => (f.Material.Equals(material))).ToList();
            DataTable dataTable = ConvertTo(infoFiltered);
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
