using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

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
            calculateFormulaUsingInputedValue();
        }
        /// <summary>
        /// gets the list of values
        /// </summary>
        private void getDataFromListAndInputIntoRTB(List<Int64> formulaConjectures)
        {
            string allConjectures = "";
            foreach (Int64 value in formulaConjectures)
            {
                allConjectures = value.ToString() + ',';
            }
            rtb_NumbersChosen.Text = allConjectures;
        }
        /// <summary>
        /// takes the list of values and inputs them onto the graph or onto the rich text box where all conjectures will be placed.
        /// </summary>
        private void insertDataOnToGraph(List<Int64> formulaConjectures)
        {
            // Initialize a Random object
            Random rnd = new Random();
            //creating a new series dynamically by taking the current total number of series and adding 1 to it
            var newSeries = new Series("Series" + (cht_Collatz.Series.Count() + 1));
            //Choosing a random colour
            newSeries.Color = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            //adding the new series to the graph
            cht_Collatz.Series.Add(newSeries);
            cht_Collatz.Series[newSeries.Name].ChartType = SeriesChartType.Line;
            cht_Collatz.Series[newSeries.Name].Points.DataBindY(formulaConjectures);
            getDataFromListAndInputIntoRTB(formulaConjectures);
            formulaConjectures = null;
        }
        /// <summary>
        /// gets the initial starting value and then starts collatz conjecture using the 3x+1 formula. If the number is even
        /// it will be divided by 2. If the number is odd it will follow the formula (3x+1)/2 as 3x+1 when used
        /// on an odd number is always even, hence to speed up the calculation it is automatically
        /// divided by 2. X will always be equal to either the initial value or the newly calculated value. 
        /// All values will be stored in a list.
        /// </summary>
        private void calculateFormulaUsingInputedValue()
        {
            List<Int64> formulaConjectures = new List<Int64>();
            int currentValue = (int)Convert.ToInt64(tb_Number.Text);
            while (currentValue > 1)
            {
                formulaConjectures.Add(currentValue);
                //determines if a number is even or odd
                if (currentValue % 2 == 0)
                {
                    //even numbers
                    currentValue /= 2;
                }
                else
                {
                    //odd numbers
                    currentValue = (3 * currentValue + 1) / 2;
                }
            }
            formulaConjectures.Add(currentValue);
            insertDataOnToGraph(formulaConjectures);
        }

        private void tb_Number_TextChanged(object sender, EventArgs e)
        {
            if (tb_Number.Text == "")
            {
                tb_Number.Text = "Please enter a starting value!";
            }
        }

        private void btn_ClearGraph_Click(object sender, EventArgs e)
        {
           cht_Collatz.Series.Clear();
        }
    }
}
