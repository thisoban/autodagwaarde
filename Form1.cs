using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoDagWaarde
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            carCmbBoc.Items.Add(Auto());
            Auto();
        }
        public void Auto()
        {
            List<Auto> cars = new List<Auto>
            {
                new Auto("33-33-zf", BrandstofSoort.lpg),
                new Auto("33-66-zf", BrandstofSoort.benzine)
            };


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
