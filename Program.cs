using System;

namespace atm{

    public class Program{

        public static void Main(string[] args ){

            


            
           var pinNames = new Dictionary<string, string>();
           pinNames.Add("1111","John Doe");
           pinNames.Add("2222","Evana Brr");
           pinNames.Add("9999","/Shale");



           string option ="";
           string pin ="";

           Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$\n");
    

           Console.WriteLine("         Welcome to $ CASH ATM\n");

           Console.WriteLine("{1} Withdraw                 Deposit {2}");
           Console.WriteLine("{3} Check Balance       Make Account {4}");

          
           Console.WriteLine("\n");
           
           while(true) {
    
                Console.Write("Choose Option: ");
                option = Console.ReadLine();
                if(option == "1" || option == "2"|| option =="3"|| option =="4"){
                    break;
                }
            
            }

           Console.WriteLine("\n");

           Console.Write("Enter Pin: ");
           pin = Console.ReadLine();

           Console.WriteLine($"\nWelcome {pinNames[pin]}!");
           Console.WriteLine("\n");



           Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$\n");

        }
    }
}