// C# Snack 3
// Prendere due parole dall'utente e dirgli quali delle due è più lunga.
// Continuare fintanto che l'utente desidera

using static Utilities.Input;

namespace csharp_snacks {
    public class Snack3 {

        public static void MainSnack() {
            bool continuare;
            do {
                // Prendiamo le parole dall'utente
                string? parola1, parola2;
                parola1 = InputConMessaggio("Inserisci la prima parola: ");
                parola2 = InputConMessaggio("Inserisci la seconda parola: ");

                // Calcoliamo qual'è più lunga
                string parolaPiuLunga;
                if (parola1?.Length > parola2?.Length) {
                    parolaPiuLunga = "parola1";
                }
                else if (parola2?.Length > parola1?.Length) {
                    parolaPiuLunga = "parola2";
                }
                else {
                    parolaPiuLunga = "uguali";
                }

                // Mostriamo il risultato all'utente
                switch (parolaPiuLunga) {
                    case "parola1":
                        Console.WriteLine($"La prima parola, {parola1}, è più lunga!");
                        break;

                    case "parola2":
                        Console.WriteLine($"La seconda parola, {parola2}, è più lunga!");
                        break;

                    case "uguali":
                        Console.WriteLine($"Le parole {parola1} e {parola2} sono uguali in lunghezza!");
                        break;

                    default:
                        Console.WriteLine("Errore! Questo messaggio non dovrebbe venire mostrato!");
                        break;
                }

                continuare = ChiediConferma("Vuoi continuare?");
            } while (continuare == true);
        }
    }
}