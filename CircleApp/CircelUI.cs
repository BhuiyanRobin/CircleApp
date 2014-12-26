using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircleApp
{
    public partial class CircelUI : Form
    {
        public CircelUI()
        {
            InitializeComponent();
        }
        Circle aCircle=new Circle();
        private void showButton_Click(object sender, EventArgs e)
        {
            aCircle.radious = Convert.ToDouble(radiusTextBox.Text);
            diameterTextBox.Text = aCircle.GetDiameter().ToString();
            perimeterTextBox.Text = aCircle.GetPeremeter().ToString();
            areaTextBox.Text = aCircle.GetArea().ToString();
        }
    }
}
