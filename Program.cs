using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koneva24is
{
    class Computer
    {
        public int invNumber;
        public float cpuFrequency;
        public int hddCapacity;
        public static void Main()
        {
            Computer myComp = new Computer();
            myComp.invNumber = 12345;
            myComp.cpuFrequency = 1.5f;
            myComp.hddCapacity = 400;

            myComp.Show();

            float totalCost = myComp.CalculateMemoryCost(100f);
            Console.WriteLine($"Стоимость внешней памяти:{totalCost} руб.");
            Console.ReadKey();
        }
        public void Show()
        {
            Console.WriteLine($"Компьютер: №{invNumber},Частота: {cpuFrequency} ГГц,HDD: {hddCapacity} ГБ");
        }
        public float CalculateMemoryCost(float pricePerGb)
        {
            return hddCapacity * pricePerGb;
        }
    }

    
}
