using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Área_del_Cuadrado
{
    public partial class area_cuadrado : Form
    {
        public area_cuadrado()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int lado, area;
            lado = Convert.ToInt32(textBox1.Text);
            area = lado * lado;
            label2.Text = Convert.ToString("El área del cuadrado, es igual a "+area);
            Graphics papel;
            papel = pictureBox1.CreateGraphics();
            SolidBrush rojo = new SolidBrush(Color.DarkRed);
            papel.FillRectangle(rojo, 10, 10, lado, lado);


        }
    }
}
