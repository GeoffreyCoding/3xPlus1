using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3xPlus1
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Calc_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// gets the list of values
        /// </summary>
        private void getDataFromList(List<Int64> formulaConjectures)
        {

        }
        /// <summary>
        /// takes the list of values and inputs them onto the graph or onto the rich text box where all conjectures will be placed.
        /// </summary>
        private void insertDataOnToGraph(List<Int64> formulaConjectures)
        {
            
        }
        /// <summary>
        /// gets the initial starting value and then starts collatz conjecture using the 3x+1 formula. If the number is even
        /// it will be divided by 2. If the number is odd it will follow the formula (3x+1)/2. X will always be equal to either the initial
        /// value or the newly calculated value. All values will be stored in a list.
        /// </summary>
        private void calculateFormulaUsingInputedValue()
        {
            List<Int64> formulaConjectures = new List<Int64>();
            int currentValue = (int)Convert.ToInt64(tb_Number.Text);
            while (currentValue > 1)
            {
                formulaConjectures.Add(currentValue);
                if (currentValue % 2 == 0)
                {
                    currentValue = currentValue / 2;
                }
                else
                {
                    currentValue = (3 * currentValue + 1) / 2;
                }
            }
            
        }
    }
}
