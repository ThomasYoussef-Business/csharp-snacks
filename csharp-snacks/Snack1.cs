// C# Snack 1
// Stampare tutti i mesi dell'anno da un array

namespace csharp_snacks {
    public class Snack1 {
        public static void MainSnack() {
            string[] mesi = { "Gennaio", "Febbraio", "Marzo", "Aprile", "Maggio", "Giugno",
                "Luglio", "Agosto", "Settembre", "Ottobre", "Novembre", "Dicembre" };

            foreach (string mese in mesi) {
                Console.WriteLine(mese);
            }
        }
    }
}