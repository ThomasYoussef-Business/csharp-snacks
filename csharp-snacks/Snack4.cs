// C# Snack 4
// Fate estrarre dal PC un numero casuale e decretate se questo numero è un multiplo di 3 o meno.
/* Chiedete poi all’utente di indovinare se il numero estratto dal PC è un multiplo di 3 o meno facendogli
 * scrivere “Si” o “No” (fate in modo che l’utente se scrive anche “si” o “no”
 * oppure “sI” o “nO” sono tutte contemplate come opzioni.
 * In tutti gli altri casi che non sono si o no,
 * richiedete l’opzione corretta [sanificazione dell’input]).
*/

using static Utilities.Input;

namespace csharp_snacks {
    public class Snack4 {
        public static void MainSnack() {
            Random rng = new();
            int randomInt = rng.Next();

            bool rispostaGiusta = randomInt % 3 == 0;
            bool rispostaUtente;

            rispostaUtente = ChiediConferma("Secondo te il numero casuale del PC è multiplo di 3?");

            if (rispostaUtente == rispostaGiusta) {
                Console.WriteLine($"Risposta esatta! Il numero generato era {randomInt}");
            }
            else {
                Console.WriteLine($"Risposta sbagliata... Il numero generato era {randomInt}");
            }
        }
    }
}