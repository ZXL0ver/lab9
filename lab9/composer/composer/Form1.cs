using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace composer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var jewelryBox = new JewelryBox { Name = "Велосипед" };
            var topTray = new Tray { Name = "Деталі" };
            var ringCompartment = new Compartment { Name = "------------" };

            ringCompartment.AddContent("Колесо");
            ringCompartment.AddContent("Рама");
            ringCompartment.AddContent("Дзвінок");
            topTray.Add(ringCompartment);
            jewelryBox.Add(topTray);
            jewelryBox.Display(0, textBox1);



        }

        private void button2_Click(object sender, EventArgs e)
        {
            var jewelryBox = new JewelryBox { Name = "" };
            var topTray = new Tray { Name = "" };
            var ringCompartment = new Compartment { Name = "---Новий деталь---" };
            ringCompartment.AddContent("Тормоза");
            topTray.Add(ringCompartment);
            jewelryBox.Add(ringCompartment);
            jewelryBox.Display(0, textBox1);
        }
    }
}
