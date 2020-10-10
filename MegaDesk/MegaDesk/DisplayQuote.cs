using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class DisplayQuote : Form
    {
        private string Customer;

        private double AreaCost;

        private double Drawer;

        private double MaterialCost;

        private double RushDaysCost;

        private double Total;

        private string Estimated;

        public DisplayQuote(string customer, double areaCost, double drawer, double materialCost, double rushDaysCost, double total, string estimated)
        {
            InitializeComponent();
            Customer = customer;
            AreaCost = areaCost;
            Drawer = drawer;
            MaterialCost = materialCost;
            RushDaysCost = rushDaysCost;
            Total = total;
            Estimated = estimated;
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
            txtDrawer.Text = string.Format("{0:0.00}", Drawer);
            txtMaterial.Text = string.Format("{0:0.00}", MaterialCost);
            txtRushDays.Text = string.Format("{0:0.00}", RushDaysCost);
            txtTotal.Text = string.Format("{0:0.00}", Total);
            txtDate.Text = Estimated;
        }
    }
}
