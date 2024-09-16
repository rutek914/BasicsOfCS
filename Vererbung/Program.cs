namespace Vererbung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var mitarbeiter = new Mitarbeiter("Peter", "Peterovski", 2300);
            var boss = new Boss("Audi", "Klaus", "Klausovsky", 5600);
            var azubi = new Azubi("Monika", "Fantovsky", 800, 8);

            boss.Fuehren();
            azubi.Lernen();

            mitarbeiter.Arbeiten();
            azubi.Arbeiten();
            boss.Arbeiten();
        }
    }
}
