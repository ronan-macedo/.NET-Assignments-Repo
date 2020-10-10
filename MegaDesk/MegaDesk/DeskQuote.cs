using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk
{

    class DeskQuote
    {
        #region DeskQuote Properties
        public double SufMatCost { get; set; }

        public double AreaCost { get; set; }

        public double DrawerCost { get; set; }

        public double AdditionalCost { get; set; }

        public double DeskQuoteTotal { get; set; }

        public string CustomerName { get; set; }

        public DateTime CurrentDate { get; set; }

        public DateTime EstimateShip { get; set; }
        
        public string DisplayDate { get; set; }
        #endregion

        public DeskQuote()
        {

        }

        Desk deskData = new Desk();

        /// <summary>
        /// Rush days options that will be displayed in
        /// the Rush Days combo box.
        /// </summary>
        public enum RushDays
        {
            [Description("14 days(std)")]
            _14days = 14,
            [Description("7 days")]
            _7days = 7,
            [Description("5 days")]
            _5days = 5,
            [Description("3 days")]
            _3days = 3
        }

        #region DeskQuote Calculations
        /// <summary>
        /// Calculates the drawer cost based on how
        /// many drawers ordered.
        /// </summary>
        /// <param name="drawer"></param>
        /// <returns>Drawer Cost.</returns>
        public double CalcDrawerCost(int drawer)
        {
            deskData.DeskDrawer = drawer;
            DrawerCost = drawer * 50;
            return DrawerCost;
        }

        /// <summary>
        /// Calculates the sufarce material based on the kind
        /// of material selected.
        /// </summary>
        /// <param name="material"></param>
        /// <returns>
        /// The material after evaluate the material option.
        /// </returns>
        public double CalcSufCost(int material)
        {
            deskData.DeskSufMat = material;
            double cost = 0;

            switch (material)
            {
                case 0:
                    cost = 100;
                    break;
                case 1:
                    cost = 200;
                    break;
                case 2:
                    cost = 300;
                    break;
                case 3:
                    cost = 300;
                    break;
                case 4:
                    cost = 50;
                    break;
            }

            return SufMatCost = cost;
        }

        /// <summary>
        /// Calculates the addional cost based on the
        /// days required to finish the desk
        /// </summary>
        /// <param name="rushDays"></param>
        /// <param name="area"></param>
        /// <returns>
        /// Addional Cost after evaluate the number days. 
        /// </returns>
        public double CalcAdditionalCost(int rushDays, double area)
        {
            deskData.DeskArea = (int)area;

            if (rushDays != 14)
            {
                if (rushDays == 3)
                {
                    if (area < 1000)
                    {
                        AdditionalCost = 60;
                    }
                    else if (area < 2000)
                    {
                        AdditionalCost = 70;
                    }
                    else
                    {
                        AdditionalCost = 80;
                    }
                }
                else if (rushDays == 5)
                {
                    if (area < 1000)
                    {
                        AdditionalCost = 40;
                    }
                    else if (area < 2000)
                    {
                        AdditionalCost = 50;
                    }
                    else
                    {
                        AdditionalCost = 60;
                    }
                }
                else if (rushDays == 7)
                {
                    if (area < 1000)
                    {
                        AdditionalCost = 30;
                    }
                    else if (area < 2000)
                    {
                        AdditionalCost = 35;
                    }
                    else
                    {
                        AdditionalCost = 40;
                    }
                }
            }
            else
            {
                AdditionalCost = 0;
            }

            return AdditionalCost;
        }

        /// <summary>
        /// Calculates the Area Cost based on the size
        /// of the desk.
        /// </summary>
        /// <param name="area"></param>
        /// <returns>Area Cost.</returns>
        public double CalcAreaCost(double area)
        {
            deskData.DeskArea = (int)area;

            if (area < 1000)
            {
                AreaCost = 200;
            }
            else
            {
                AreaCost = (area - 1000)  + 200;
            }
            return AreaCost;
        }

        /// <summary>
        /// Calculates the total cost based on every calculated cost.
        /// </summary>
        /// <param name="areaCost"></param>
        /// <param name="sufMatCost"></param>
        /// <param name="drawerCost"></param>
        /// <param name="additionalCost"></param>
        /// <returns>Desk Quote Total.</returns>
        public double CalcDeskQuote(double areaCost, double sufMatCost, double drawerCost, double additionalCost)
        {
            AreaCost = areaCost;
            SufMatCost = sufMatCost;
            DrawerCost = drawerCost;
            AdditionalCost = additionalCost;

            DeskQuoteTotal = areaCost + sufMatCost + drawerCost + additionalCost;

            return DeskQuoteTotal;
        }
        #endregion
    }
}

