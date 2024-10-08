using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMVC.Views
{
    public class Display
    {
        public double Amount { get; set; }
        public double Percent { get; set; }
        public double TipSum { get; set; }
        public object TotalSum { get; set; }
        public void Input()
        {
            Console.Write("Vuvedi sumata za smetkata: ");
            double suma = double.Parse(Console.ReadLine());
            this.Amount = suma;

            Console.Write("vuvedi procenta na smetkata: ");
            double percent = double.Parse(Console.ReadLine());
            this.Percent = percent;
        }
        public void Output()
        {
            Console.WriteLine($"Sumata za servitiora e {this.TipSum} lv.");
            Console.WriteLine($"Sumata za plashtane e {this.TotalSum} lv.");
        }
    }
}
