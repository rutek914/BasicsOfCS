using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vererbung
{
    internal class Boss : Mitarbeiter
    {
        public string Firmenwagen { get; set; }
        public Boss(string firmenwagen, string name, string vorname, double gehalt) : base(name,vorname,gehalt)
        {
            Firmenwagen = firmenwagen;
        }

        public void Fuehren()
        {
            Console.WriteLine("Ich führe dieses Unternehmen");
        }

        public override void Arbeiten()
        {
            base.Arbeiten();
            Console.WriteLine("Ich bin der Boss und werde den ganzen Tag lang nichts machen");
        }
    }
}
