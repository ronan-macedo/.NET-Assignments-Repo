using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class AddQuote : Form
    {
        private string Customer;

        private double AreaCost;

        private double Drawer;

        private double MaterialCost;

        private double RushDaysCost;

        private double Total;

        private string Estimated;

        public AddQuote()
        {
            InitializeComponent();
        }


        #region Navigation Buttons
        private void btnBack_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            CalculateQuote();

            DisplayQuote displayQuote = new DisplayQuote(Customer, AreaCost, Drawer, MaterialCost, RushDaysCost, Total, Estimated);
            displayQuote.Tag = this;
            displayQuote.Show(this);           
        }
        #endregion

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
        #endregion

        #region Validating Material Combo Box
        private void cmbMat_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (!ValidMaterial(cmbMat.SelectedValue))
                {
                    e.Cancel = true;
                    cmbMat.SelectedIndex = 0;

                    MessageBox.Show("No material selected!", "Warning!");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Warning!");
            }
        }

        /// <summary>
        /// Validates if there is a valid option selected.
        /// </summary>
        /// <param name="material"></param>
        /// <returns>True or false.</returns>
        public bool ValidMaterial(object material)
        {
            object sufarceMaterial = cmbMat.SelectedValue;

            if (material == null)
                return false;
            if (material == sufarceMaterial)
                return true;

            return false;
        }
        #endregion

        #region Validating RushDays Combo Box
        private void cmbRushDays_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (!ValidDays(cmbRushDays.SelectedValue))
                {
                    e.Cancel = true;
                    cmbRushDays.SelectedIndex = 0;

                    MessageBox.Show("No rush day selected!", "Warning!");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Warning!");
            }
        }

        /// <summary>
        /// Validates if there is a valid option selected.
        /// </summary>
        /// <param name="days"></param>
        /// <returns>True or false.</returns>
        public bool ValidDays(object days)
        {
            object rushDays = cmbRushDays.SelectedValue;

            if (days == null)
                return false;
            else if (days == rushDays)
                return true;

            return false;
        }
        #endregion

        #region Validating Name
        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (!ValidName(txtName.Text))
                {
                    e.Cancel = true;
                    txtName.Text = "None";
                    MessageBox.Show("There is no name declared!", "Warning!");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Warning!");
            }
        }

        /// <summary>
        /// Validates if there is a name in TextBox.
        /// </summary>
        /// <param name="name"></param>
        /// <returns>True or false.</returns>
        public bool ValidName(string name)
        {
            if (string.IsNullOrEmpty(name))
                return false;
            else if (name.Length > 0)
                return true;

            return false;
        }
        #endregion

        /// <summary>
        /// Calculates all the inputs and set the class properties
        /// to be displayed in the DisplayQuote.
        /// </summary>
        public void CalculateQuote()
        {
            // Gettomg the Desk and DeskQuote properties
            Desk desk = new Desk();
            DeskQuote deskQuote = new DeskQuote();

            // Getting the values from NumericUpDown control and ComboBox
            int drawers = (int)deskDrawers.Value;

            int material = (int)cmbMat.SelectedValue;

            int rushDays = (int)cmbRushDays.SelectedValue;
            
            //Setting the Customer property
            deskQuote.CustomerName = txtName.Text;

            Customer = deskQuote.CustomerName;

            // Making all the calculations and setting other properties
            desk.CalcArea((int)deskWidth.Value, (int)deskDepth.Value);

            AreaCost = deskQuote.CalcAreaCost(desk.DeskArea);

            Drawer = deskQuote.CalcDrawerCost(drawers);

            MaterialCost = deskQuote.CalcSufCost(material);

            RushDaysCost = deskQuote.CalcAdditionalCost(rushDays, desk.DeskArea);

            Total = deskQuote.CalcDeskQuote(deskQuote.AreaCost, deskQuote.SufMatCost, deskQuote.DrawerCost, deskQuote.AdditionalCost);

            // Estamite the delivery date
            deskQuote.CurrentDate = DateTime.Now;

            deskQuote.EstimateShip = deskQuote.CurrentDate.AddDays(rushDays);

            deskQuote.DisplayDate = deskQuote.EstimateShip.ToString("dd MMMM yyyy", CultureInfo.CreateSpecificCulture("en-US"));

            Estimated = deskQuote.DisplayDate;
        }

        private void value_Enter(object sender, EventArgs e)
        {
            // Select the whole value in the NumericUpDown control.
            NumericUpDown valueBox = sender as NumericUpDown;

            if (valueBox != null)
            {
                int lengthOfAnswer = valueBox.Value.ToString().Length;
                valueBox.Select(0, lengthOfAnswer);
            }
        }

        private void AddQuote_Load(object sender, EventArgs e)
        {
            //Bind Material ComboBox with SurfaceMaterial Enum
            cmbMat.DataSource = List(typeof(Desk.SufarceMaterial));
            cmbMat.DisplayMember = "Value";
            cmbMat.ValueMember = "Key";

            //Bind RushDays ComboBox with RushDays Enum
            cmbRushDays.DataSource = List(typeof(DeskQuote.RushDays));
            cmbRushDays.DisplayMember = "Value";
            cmbRushDays.ValueMember = "Key";
        }
    }
}
