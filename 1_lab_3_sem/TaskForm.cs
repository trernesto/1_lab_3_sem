using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_lab_3_sem
{
    public partial class TaskForm : Form
    {
        private static string[] questionsEasy = {
        "1 question",
        "2 question",
        "3 question",
        "4 question",
        "5 question",
        "6 question",
        "7 question",
        "8 question",
        "9 question",
        "10 question"};

        private static string[] questionsHard = {
        "1 question hard",
        "2 question hard",
        "3 question hard",
        "4 question hard",
        "5 question hard",
        "6 question hard",
        "7 question hard",
        "8 question hard",
        "9 question hard",
        "10 question hard"};

        public TaskForm(string text)
        {
            InitializeComponent();
        }

        public TaskForm(string p1, string p2, decimal p3, bool questionHardnes)
        {
            InitializeComponent();
            label1.Text = "Ученик: " + p1 + "\n" + "Класс " + p2;
            int n = Convert.ToInt32(p3);
            for (int i = 0; i < n; i++)
            {
                TextBox t = new TextBox();
                CheckBox ch = new CheckBox();
                ComboBox cb = new ComboBox();
                int x, y;
                x = 20;
                y = 100 + i * 30;
                if (questionHardnes == false)
                {
                    t.Text = questionsEasy[i % 10];
                    ch.Text = "hello";
                    ch.Height = 40;
                    ch.Width = 100;
                    ch.Location = new Point(x + 140, y - 10);
                    this.Controls.Add(ch);
                }
                else
                {
                    t.Text = questionsHard[i % 10];
                    cb.Text = "hello";
                    cb.Height = 40;
                    cb.Width = 100;
                    cb.Location = new Point(x + 140, y);
                    Random rd = new Random();
                    for (int j = 0; j < 5; ++j)
                    {
                        int rand_num = rd.Next(100, 200);
                        cb.Items.Add(rand_num);
                    }
                    this.Controls.Add(cb);
                }
                t.Location = new Point(x, y);
                this.Controls.Add(t);
            }
        }
    }
}
