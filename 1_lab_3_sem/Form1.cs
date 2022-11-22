using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_lab_3_sem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0 || textBox2.Text.Length == 0
                || textBox3.Text.Length == 0 ||
                (radioButton1.Checked == false && radioButton2.Checked == false))
            {
                if (textBox1.Text.Length == 0) { MessageBox.Show("Не введена фамилия"); }
                if (textBox2.Text.Length == 0) { MessageBox.Show("Не введено имя"); }
                if (textBox3.Text.Length == 0) { MessageBox.Show("Не введено Отчество"); }
                if (radioButton1.Checked == false && radioButton2.Checked == false)
                        { MessageBox.Show("Заполните сложность вопросов"); }
                return;
            }
            string name = textBox1.Text + " " + textBox2.Text + " " + textBox3.Text;
            bool questionHardnes = false;
            if (radioButton1.Checked == true)
            {
                questionHardnes = true;
            }
            TaskForm tf = new TaskForm(
                name,
                comboBox1.Text,
                numericUpDown1.Value,
                questionHardnes);
            tf.ShowDialog();
        }
    }
}
