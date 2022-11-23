namespace csharp_snacks {
    public static class Input {
        public static string? InputConMessaggio(string messaggio) {
            Console.WriteLine(messaggio);
            string? input = Console.ReadLine();
            return input;
        }
        public static string? InputConConferma(string messaggio) {
            string? conferma;
            string? input;
            do {
                input = InputConMessaggio(messaggio);
                Console.WriteLine($"Hai inserito {input}, confermi? y/n: ");
                conferma = Console.ReadLine();
            } while (conferma != "y");
            return input;
        }

        public static bool ChiediConferma(string messaggio) {
            string? conferma;
            do {
                Console.WriteLine(messaggio);
                Console.WriteLine(@"Inserisci ""y"" o ""n"" per scegliere: ");
                conferma = Console.ReadLine();
            } while (!(conferma == "y" || conferma == "n"));
            return conferma == "y";
        }
    }
}
