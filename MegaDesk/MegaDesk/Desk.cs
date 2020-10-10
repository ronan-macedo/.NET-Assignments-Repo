using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk
{
    class Desk
    {
        #region Desk Properties
        public int DeskWidth { get; set; }

        public int DeskDepth { get; set; }

        public int DeskArea { get; set; }

        public int DeskSufMat { get; set; }

        public int DeskDrawer { get; set; }
        #endregion

        public Desk()
        {

        }

        /// <summary>
        /// Sufarce material options that will be displayed
        /// in the material combo box.
        /// </summary>
        public enum SufarceMaterial
        {
            [Description("Laminate")]
            Laminate,
            [Description("Oak")]
            Oak,
            [Description("Rosewood")]
            Rosewood,
            [Description("Veneer")]
            Veneer,
            [Description("Pine")]
            Pine
        }

        /// <summary>
        /// Calculates the area of the desk giving the depth and the 
        /// width sizes.
        /// </summary>
        /// <param name="deskDepth"></param>
        /// <param name="deskWidth"></param>
        /// <returns>Desk area.</returns>
        public int CalcArea(int deskDepth, int deskWidth)
        {
            DeskDepth = deskDepth;
            DeskWidth = deskWidth;

            DeskArea = deskDepth  * deskWidth;

            return DeskArea;
        }
    }
}
