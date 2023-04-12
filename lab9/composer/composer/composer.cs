using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace composer
{
    public abstract class JewelryBoxComponent
    {
        public string Name { get; set; }
        public abstract void Add(JewelryBoxComponent component);
        public abstract void Remove(JewelryBoxComponent component);
        public abstract void Display(int depth, TextBox textBox);
    }

    public class JewelryBox : JewelryBoxComponent
    {
        private List<JewelryBoxComponent> coomponents = new List<JewelryBoxComponent>();
        public override void Add(JewelryBoxComponent component)
        {
            coomponents.Add(component);
        }
        public override void Display(int depth, TextBox textBox)
        {
            textBox.AppendText(new string('-', depth) + " " + Name + Environment.NewLine);
            foreach (var component in coomponents)
            {
                component.Display(depth + 2, textBox);
            }
        }
        public override void Remove(JewelryBoxComponent component)
        {
            coomponents.Remove(component);
        }
    }
    public class Tray : JewelryBoxComponent
    {
        private List<JewelryBoxComponent> coomponents = new List<JewelryBoxComponent>();
        public override void Add(JewelryBoxComponent component)
        {
            coomponents.Add(component);
        }
        public override void Display(int depth, TextBox textBox)
        {
            textBox.AppendText(new string('-', depth) + " " + Name + Environment.NewLine);
            foreach (var component in coomponents)
            {
                component.Display(depth + 2, textBox);
            }
        }
        public override void Remove(JewelryBoxComponent component)
        {
            coomponents.Remove(component);
        }
    }
    public class Compartment : JewelryBoxComponent
    {
        private List<string> contents = new List<string>();
        public void AddContent(string item)
        {
            contents.Add(item);
        }
        public override void Add(JewelryBoxComponent component)
        {
            throw new NotImplementedException();
        }
        public override void Display(int depth, TextBox textBox)
        {
            textBox.AppendText(new string('-', depth) + " " + Name + Environment.NewLine);
            foreach (var item in contents)
            {
                textBox.AppendText(new string('-', depth + 2) + " " + item + Environment.NewLine);
            }
        }
        public override void Remove(JewelryBoxComponent component)
        {
            throw new NotImplementedException();
            //coomponents.Add(component);
        }
    }
}






