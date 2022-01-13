using System;

namespace UserInput{

    class Program{

        static void Main(string[] args){
            // Introduction & Ask user for name
            Console.WriteLine("Hello." + "\n" + "My name is Dex."  + "\n" + "What is your first name?" + "\n");
            Console.WriteLine("My name is:");
            Program.GetNameFunction();
        }

        public static void GetNameFunction()
        {
            // Take in user input and perform some checks
            string userName = Console.ReadLine();
            char[] name = userName.ToCharArray();
            int num;

            // Check if user entry contains special characters
            for(int i = 0; i < name.Length; i++) {
                if(!Char.IsLetterOrDigit(name[i])){
                  Console.WriteLine("Your entry contains special characters!" + "\n" + "Hit any key to close the program, and try again.");
                  Console.ReadKey();
                  return;
                }
                else if (Char.IsDigit(name[i])){ // Check if user entry contains numbers
                    Console.WriteLine("Your entry contains a number!" + "\n" + "Hit any key to close the program, and try again.");
                    Console.ReadKey();
                    return;
                }
            }
            
            // Check if user entry contains nothing (they just hit "enter")
            if (string.IsNullOrWhiteSpace(userName)) {
                Console.WriteLine("You didn't type anything!" + "\n" + "Hit any key to close the program, and try again.");
                Console.ReadKey();
                return;
            }
            else if (int.TryParse(userName, out num)){ // Check if user entry is just a number
                Console.WriteLine("That's a number, you idiot." + "\n" + "Hit any key to close the program, and try again.");
                Console.ReadKey();
                return;
            }
            else
            {
                Console.WriteLine("Hello, " + userName + "." + "\n" + "It's wonderful to meet you!" + "\n"); // Greet the user with their entered name
            }
        }
    }
}