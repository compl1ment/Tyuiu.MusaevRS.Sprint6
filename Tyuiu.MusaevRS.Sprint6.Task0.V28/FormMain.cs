using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.MusaevRS.Sprint6.Task0.V28.Lib;

namespace Tyuiu.MusaevRS.Sprint6.Task0.V28
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBoxMain_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonMain_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                TextBoxResult.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxInPut.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxInPut_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxInPut_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar<= 47 || e.KeyChar>=58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }

        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Task 0 выполнил студент ПКТБ 23-2 Мусаев Руслан");
        }
    }
}
