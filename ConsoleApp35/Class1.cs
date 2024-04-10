using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp35
{
    class person
    {
        public string? förnamn;
        public string? efternamn;
        public int år;
        public int månad;
        private int längd;
        private int vikt;
        public int mymetod
        {
            get { return längd; }
            set { längd = value; }
        }
        public int mymetod2
        {
            get { return vikt; }
            set { vikt = value; }
        }
        public void Mymetod3()
        {
            person p = new person();
            int bmivikt = vikt;
            int dubbellängd = längd * längd;
            int bmi = 0;
            bmivikt / dubbellängd = bmi;
            Console.WriteLine("Din bmi är: " + bmi);
        }
        public void metod1()
        {
            person p = new person();
            Console.WriteLine("Skriv in ditt förnamn:");
            p.förnamn = Console.ReadLine();
            Console.WriteLine("Skriv in ditt efternamn:");
            p.efternamn = Console.ReadLine();
            Console.WriteLine(p.förnamn + " " + p.efternamn);
            
        }
        public void metod3()
        {
            person p = new person();
            Console.WriteLine("Vilket år föddes du?");
            p.år = int.Parse(Console.ReadLine());
            Console.WriteLine("Vilken månad föddes du? (1-12)");
            p.månad = int.Parse(Console.ReadLine());
            DateTime datetime = DateTime.Now;
            if (datetime.Year - p.år >= 18 && datetime.Month - p.månad >= 0)
            {
                Console.WriteLine("myndig");
            }
            else
            {
                Console.WriteLine("bäbis");
            }
            

        }
      

     

    }
}
