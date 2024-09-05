namespace poo {

    internal class Challenge {

        int a = 10;
        //access parameter 'a' by moving only inside the static method;
        public static void Challenge_test() {
           var Challenge = new Challenge();
            Console.WriteLine(Challenge.a);
        }
    }
}
