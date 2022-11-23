// C# Snack 2
// Ciclare attraverso ad un array di numeri, e stampare pari o dispari per ogni numero

namespace csharp_snacks {
    public class Snack2 {

        public static void MainSnack() {

            int[] numeri = { 0, 5, 2, 5, 2, 6, 3, 4, 9, 12, 38, 17, 38, 29, 49, 27 };

            const string stringaPerPari = "Pari";
            const string stringaPerDispari = "Dispari";

            foreach (int num in numeri) {
                Console.WriteLine(num % 2 == 0 ? stringaPerPari : stringaPerDispari);
            }

            for (int i = 0; i < numeri.Length; i++) {
                int num = numeri[i];
                if (num % 2 != 0) {
                    numeri[i] = num + (i * 2) + 1;
                }
            }

            foreach (int num in numeri) {
                Console.WriteLine(num);
            }
        }
    }
}