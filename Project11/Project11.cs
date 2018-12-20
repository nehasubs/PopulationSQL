using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Populations_of_Cities
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'populationDBDataSet.City' table. You can move, or remove it, as needed.
            this.cityTableAdapter.Fill(this.populationDBDataSet.City);

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            this.cityTableAdapter.FillByPopulationAsc(populationDBDataSet.City);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.cityTableAdapter.FillByPopulationDesc(populationDBDataSet.City);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.cityTableAdapter.FillByCityAlpha(populationDBDataSet.City);
        }

        private void button3_Click(object sender, EventArgs e)
        {
           label4.Text= (this.cityTableAdapter.TotalPopulation()).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label3.Text = (this.cityTableAdapter.AvgPopulation()).ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label2.Text = (this.cityTableAdapter.MaxPopulation()).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = (this.cityTableAdapter.MinPopulation()).ToString();
        }

       
    }
}
