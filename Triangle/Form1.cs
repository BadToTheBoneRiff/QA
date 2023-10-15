using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangle 
{
    public partial class Form1 : Form 
    {
        public Form1() 
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e) 
        {
            int a, b, c;

            if(int.TryParse(aSide.Text, out a) && (int.TryParse(bSide.Text, out b) && (int.TryParse(cSide.Text, out c))))
            {
                if(a == b && b == c) 
                {
                    answer.Text = "Равносторонний";
                }
                else if (a == b || b == c || a == c)
                {
                    answer.Text = "Равнобедренный";
                }
                else
                {
                    answer.Text = "Разносторонний";
                }
            }
            else
            {
                answer.Text = "Введите стороны треугольника";
            }
        }
    }
}
