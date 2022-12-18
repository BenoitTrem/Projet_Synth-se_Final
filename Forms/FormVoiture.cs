using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_Synthèse_Final
{
    public partial class FormVoiture : Form
    {
        public FormVoiture()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Modele.SelectedIndex == 0)
            {
                listBox_Prix.Items.Clear();
                listBox_Prix.Items.Add("5.99$ / journée");
            }
            if (comboBox_Modele.SelectedIndex == 1)
            {
                listBox_Prix.Items.Clear();
                listBox_Prix.Items.Add("6.99$ / journée");
            }
            if (comboBox_Modele.SelectedIndex == 2)
            {
                listBox_Prix.Items.Clear();
                listBox_Prix.Items.Add("8.99$ / journée");
            }
            if (comboBox_Modele.SelectedIndex == 3)
            {
                listBox_Prix.Items.Clear();
                listBox_Prix.Items.Add("7.99$ / journée");
            }
            if (comboBox_Modele.SelectedIndex == 4)
            {
                listBox_Prix.Items.Clear();
                listBox_Prix.Items.Add("6.00$ / journée");
            }
            if (comboBox_Modele.SelectedIndex == 5)
            {
                listBox_Prix.Items.Clear();
                listBox_Prix.Items.Add("10.00$ / journée");
            }          
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormVoiture_Load(object sender, EventArgs e)
        {

        }

        private void button_Annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
