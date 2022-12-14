using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RnadomGenerationLCGModels;
namespace RnadomGenerationLCGSimulation
{
    public partial class Form1 : Form
    {
        public Form1(SimulationSystem sys)
        {
            this.sys = sys;
            InitializeComponent();
        }

        public SimulationSystem sys { get; set; }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            sys.SimulationTable.Clear();
            if (textBox1.Text.Length == 0 || textBox2.Text.Length == 0 || textBox3.Text.Length == 0
                || textBox4.Text.Length == 0 || textBox5.Text.Length == 0)
            {
                MessageBox.Show("Enter The Missing Data", "Error");
            }
            else
            {
                sys.Seed = int.Parse(textBox4.Text);
                sys.Increment = int.Parse(textBox3.Text);
                sys.Modulus = int.Parse(textBox2.Text);
                sys.Multiplier = int.Parse(textBox1.Text);
                sys.NumberofIterations = int.Parse(textBox5.Text);
            }
            FillTable.FillSimulationTable(sys);
            dataGridView1.DataSource = sys.SimulationTable;
            textBox6.Text = sys.Cyclelength.ToString();
            if (textBox6.Text == "-1")
                label7.Text = "Note: If Actual Period Length = -1 Its Mean That The Number of Itration is to Small";
            else
                label7.Text = "";

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
