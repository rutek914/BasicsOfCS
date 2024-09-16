using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vererbung
{
    internal class Azubi : Mitarbeiter
    {
        public double Schulstunden { get; set; }
        public Azubi(string name, string vorname, double gehalt, double schulstunden) : base(name, vorname, gehalt)
        {
            Schulstunden = schulstunden;
        }

        public void Lernen()
        {
            Console.WriteLine("Ich lerne C#");
        }

        public override void Arbeiten()
        {
            base.Arbeiten();
            Console.WriteLine("Ich werde heute die Vererbung lernen");
        }
    }
}
