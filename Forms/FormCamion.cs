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
    public partial class FormCamion : Form
    {
        public FormCamion()
        {
            InitializeComponent();
        }

        private void FormCamion_Load(object sender, EventArgs e)
        {

        }

        private void comboBox_Modele_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Modele.SelectedIndex == 0)
            {
                listBox_Prix.Items.Clear();
                listBox_Prix.Items.Add("11.99$ / journée");
            }
            if (comboBox_Modele.SelectedIndex == 1)
            {
                listBox_Prix.Items.Clear();
                listBox_Prix.Items.Add("9.99$ / journée\"");
            }
            if (comboBox_Modele.SelectedIndex == 2)
            {
                listBox_Prix.Items.Clear();
                listBox_Prix.Items.Add("10.99$ / journée\"");
            }
            if (comboBox_Modele.SelectedIndex == 3)
            {
                listBox_Prix.Items.Clear();
                listBox_Prix.Items.Add("12.99$ / journée\"");
            }
            if (comboBox_Modele.SelectedIndex == 4)
            {
                listBox_Prix.Items.Clear();
                listBox_Prix.Items.Add("8.99$ / journée\"");
            }
            if (comboBox_Modele.SelectedIndex == 5)
            {
                listBox_Prix.Items.Clear();
                listBox_Prix.Items.Add("14.00$ / journée\"");
            }
        }

        private void button_Annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
