namespace ClassLibrary {
     public class Famous {
        public string publicInfo = "Intagram";

        protected string social = "Whatsapp";

        internal string cellphone = " 010 1 718 222 2222";

        protected internal string secrets = "I ate the whole cake";

        private protected string signs = "I have three little pink spots in my arm";

        int realAge =76;

        public void Info() {
            Console.WriteLine(publicInfo);
            Console.WriteLine(social);
            Console.WriteLine(cellphone);
            Console.WriteLine(secrets);
            Console.WriteLine(signs);
            Console.WriteLine(realAge);
        }
    }
    public class FamousChild : Famous {
        public new void Info() {
            Console.WriteLine(publicInfo);
            Console.WriteLine(social);
            Console.WriteLine(cellphone);
            Console.WriteLine(secrets);
            Console.WriteLine(signs);
           // Console.WriteLine(realAge);
        }

    }

    public class Friend {
        public readonly Famous friend = new Famous();
        public new void Info() {
            Console.WriteLine(friend.publicInfo);
            //Console.WriteLine(friend.social);
            Console.WriteLine(friend.cellphone);
            Console.WriteLine(friend.secrets);
            //Console.WriteLine(friend.signs);
            // Console.WriteLine(realAge);
        }
    }
}
