using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> witryna = new List<Product>();
            witryna.Add(new Product() {id = 1 ,Nazwa="Banana",Data = new DateTime(2029,09,20),Cena=5 });
            witryna.Add(new Product() {id = 2, Nazwa ="Water",Data = new DateTime(2025,01,11),Cena=2 });
            witryna.Add(new Product() {id = 3, Nazwa ="Coke",Data = new DateTime(2021,08,13),Cena=3 });
            witryna.Add(new Product() {id = 4, Nazwa ="Ham",Data = new DateTime(2018,05,17),Cena=15 });
            witryna.Add(new Product() {id = 5, Nazwa ="Fries",Data = new DateTime(2019,03,14),Cena=18 });
            witryna.Add(new Product() {id = 6, Nazwa ="Apple",Data = new DateTime(2019,01,21),Cena=1 });

            foreach (var item in witryna)
            {
                Console.WriteLine("Product nr: " + item.id +" "+"Product: "+  item.Nazwa+ " " +"Price: "+ item.Cena);
            }
            Shop buy = new Shop();
            Console.WriteLine(buy.buy);
            Console.Read();
        }
    }
}
