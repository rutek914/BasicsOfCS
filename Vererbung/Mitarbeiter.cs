using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vererbung
{
    internal class Mitarbeiter
    {
        public string Name { get; set; }
        public string Vorname { get; set; }
        public double Gehalt { get; set; }

        public Mitarbeiter(string name, string vorname, double gehalt)
        {
            Name = name;
            Vorname = vorname;
            Gehalt = gehalt;
        }

        public virtual void Arbeiten()
        {
            Console.WriteLine($"Mein Name ist {Vorname} {Name} und ich verdiene {Gehalt} Euro");
        }
        public void Pausieren()
        {
            Console.WriteLine("Ich mache eine Pause");
        }
    }
}
