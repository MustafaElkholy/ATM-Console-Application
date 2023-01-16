namespace ATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<CardHolder> cardHolders = new List<CardHolder>();
            cardHolders.Add(new CardHolder("4532772818527395", 1234, "Mustafa", "Elkholy", 150.31));
            cardHolders.Add(new CardHolder("2546314586423648", 4321, "Moaz", "S", 321.13));
            cardHolders.Add(new CardHolder("1453367543645067", 9999, "Ahmed", "M", 105.59));
            cardHolders.Add(new CardHolder("2487961416644345", 2468, "Ali", "A", 851.48));
            cardHolders.Add(new CardHolder("1478956324878964", 4826, "Mahmoud", "B", 54.27));

            Console.WriteLine("Welcome To ATM");

            string depitCartNum = "";
            CardHolder currentUser;

          
            while (true)
            {
                Console.WriteLine("Enter 1 To login or 2 to sign up new user: ");
                int input = Convert.ToInt32(Console.ReadLine());

                if (input == 1)
                {
                    while (true)
                    {
                        try
                        {
                            Console.WriteLine("Please Enter Your Depit Car Number");

                            depitCartNum = Console.ReadLine();
                            // check if the card Number is there
                            currentUser = cardHolders.FirstOrDefault(x => x.cardNumber == depitCartNum);

                            if (currentUser != null)
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Sorry, Card Not Recognized. Please Try Again.");
                            }
                        }
                        catch (Exception)
                        {

                            Console.WriteLine("Sorry, Card Not Recognized. Please Try Again.");
                        }

                    }

                    Console.WriteLine("Please Enter Your Pin: ");
                    int userPin = 0;


                    while (true)
                    {
                        try
                        {
                            userPin = Convert.ToInt32(Console.ReadLine());
                            // check if the Pin Number is there

                            if (currentUser.GetPin() == userPin)
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Sorry, You Entered Wrong Pin. Please Try Again.");
                            }
                        }
                        catch (Exception)
                        {

                            Console.WriteLine("Sorry, You Entered Wrong Pin. Please Try Again.");

                        }

                    }
                    Console.WriteLine($"Welcome {currentUser.GetFirstName()} {currentUser.GetLastName()} :).");
                    int option = 0;
                    do
                    {

                        PrintOtions();

                        try
                        {
                            option = Convert.ToInt32(Console.ReadLine());

                        }
                        catch (Exception)
                        {

                            throw;
                        }

                        if (option == 1)
                        {
                            Deposit(currentUser);
                        }
                        else if (option == 2)
                        {
                            WithdDraw(currentUser);
                        }
                        else if (option == 3)
                        {
                            ShowBalance(currentUser);

                        }
                        else if (option == 4)
                        {
                            break;
                        }
                        else
                        {
                            option = 0;
                            Console.WriteLine("Please Enter The right opthion number");
                        }
                    } while (option != 4);
                    Console.WriteLine("Thank You  Have a nice day. :)");


                }
                else
                {
                    try
                    {
                        Console.Write("Enter a new CardNumber: ");
                        string cardNo = Console.ReadLine();
                        Console.Write("Enter a new Pin: ");
                        int newPin = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Your First Name: ");
                        string Fname = Console.ReadLine();
                        Console.Write("Enter Your Last Name: ");
                        string Lname = Console.ReadLine();
                        Console.Write("Enter Your Balance: ");
                        double newBalance = Convert.ToDouble(Console.ReadLine());




                        CardHolder newCardHolder = new CardHolder(cardNo, newPin, Fname, Lname, newBalance);
                        cardHolders.Add(newCardHolder);
                    }
                    catch (Exception e)
                    {

                        Console.WriteLine($"Wrong Data. {e.Message}.");
                    }
                }
            }





        }
        static void PrintOtions()
        {
            Console.WriteLine("Please Choose One Of The Following Options: ");
            Console.WriteLine("1. To Deposit");
            Console.WriteLine("2. To WithDraw");
            Console.WriteLine("3. To ShowBalance");
            Console.WriteLine("4. To Exit");

        }
        static void Deposit(CardHolder currentUser)
        {
            Console.WriteLine("How Much Money would You Like To Deposit? ");
            double deposit = Convert.ToDouble(Console.ReadLine());
            currentUser.SetBalance(currentUser.GetBalance() + deposit);
            Console.WriteLine($"Thanks. Your Balance = {currentUser.GetBalance()}");
        }
        static void WithdDraw(CardHolder currentUer)
        {
            Console.WriteLine("How Much Money would You Like To Withdraw? ");
            double withdraw = Convert.ToDouble(Console.ReadLine());
            // check if the user does have enough money
            if (currentUer.GetBalance() < withdraw)
            {
                Console.WriteLine("Insufficient Balance :(.");

            }
            else
            {
                double newBalance = currentUer.GetBalance() - withdraw;
                currentUer.SetBalance(newBalance);
                Console.WriteLine($"You are Good To go. Your Balance is {currentUer.GetBalance()}");
            }
        }
        static void ShowBalance(CardHolder currentUser)
        {
            Console.WriteLine($"Current Balance is: {currentUser.GetBalance()}");
        }
    }
}