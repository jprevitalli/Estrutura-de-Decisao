using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstruturaDecisão
{
    public partial class TelaEstrutura : Form
    {
        public TelaEstrutura()
        {
            InitializeComponent();
        }

        private void btnDescobrir_Click(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt32 (nNum01.Value);
            int n2 = Convert.ToInt32(nNum02.Value);
            int n3 = Convert.ToInt32(nNum03.Value);
            int maior;
            
            
            if (n1 == n2 && n2 == n3)
            {
                lblResultado.Text = ("Valores são iguais");
                return;
            }

            if (n1 == n2 && n1 > n3 && n2 > n3)
            {
                lblResultado.Text = ("Valores " + n1 + " e " + n2 + " são maiores");
                return;
            }

            if (n1 == n3 && n1 > n2 && n3 > n2)
            {
                lblResultado.Text = ("Valores " + n1 + " e " + n3 + " são maiores");
                return;
            }

            if (n2 == n3 && n2 > n1 && n3 > n1)
            {
                lblResultado.Text = ("Valores " + n2 + " e " + n3 + " são maiores");
                return;
            }


            if (n1 > n2 && n1 > n3)
            {
                maior = n1;
            }else if (n2 > n1 && n2 > n3)
            {
                maior = n2;
            }
            else
            {
                maior = n3;
            }

            lblResultado.Text = "O número " + maior + " é o maior.";

           
        }
    }
}
