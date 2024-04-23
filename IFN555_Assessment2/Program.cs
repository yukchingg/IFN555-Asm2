namespace IFN555_Assessment2;
class Program
{
    static void Main(string[] args)
    {
        //Task1: Display name and student ID with asterisks border
        Console.WriteLine("***************************");
        Console.WriteLine("* Wing Yuk Chan n11359081 *");
        Console.WriteLine("***************************");

        //Task2:
        //Declare the number of adult ticket, children ticket and senior ticket
        int adultTicketNo, childTicketNo, seniorTicketNo;

        /*Prompt the user for the number of adult tickets,
        number of children tickets and number of senior tickets*/
        Console.WriteLine("Please enter the number of adult tickets: ");
        adultTicketNo = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Please enter the number of children tickets: ");
        childTicketNo = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Please enter the number of senior tickets: ");
        seniorTicketNo = Convert.ToInt32(Console.ReadLine());

        //Make sure the inputs are non-negative
        if (adultTicketNo < 0 || childTicketNo < 0 || seniorTicketNo < 0)
            Console.WriteLine("Invalid input, the inputs must be non-negative");
        else
        {
            //Task3:
            //Display number of ticket of each type
            Console.WriteLine("The number of adult tickets is: {0}" +
                "\nThe number of children ticket is: {1}" +
                "\nThe number of senior ticket is: {2}", adultTicketNo, childTicketNo, seniorTicketNo);

            //Delcare the ticket prices and discounts
            const double adultPrice = 20.00, childDiscount = 0.50, seniorDiscount = 0.75;
            double childPrice, seniorPrice, totalPrice;

            //Calculate and display the total revenue
            childPrice = adultPrice * childDiscount;
            seniorPrice = adultPrice * seniorDiscount;
            totalPrice = adultPrice * adultTicketNo + childPrice * childTicketNo + seniorPrice * seniorTicketNo;
            Console.WriteLine("The total revenue from selling tickets for the event is {0}", totalPrice.ToString("C"));

            //Task4: Display a statement that shows a statistic of visitors attending
            if (adultTicketNo <= (childTicketNo + seniorTicketNo))
                Console.WriteLine("The event is becoming a festival for everyone!");
            else if (childTicketNo >= seniorTicketNo)
                Console.WriteLine("The event is attracting more young people!");
            else
                Console.WriteLine("The event should have more space for kids!");
        }
        //Task5:
        //Declare 
        const int lowerLimit = 0, upperLimit = 40;
        int inputValue;
        bool stopLoop = false;

        //Ask user for Input
        do
        {
            Console.WriteLine("Please enter the number of participants " +
                "in this year's event (between {0} and {1})", lowerLimit, upperLimit);
            inputValue = Convert.ToInt32(Console.ReadLine());
            if (inputValue < lowerLimit || inputValue > upperLimit)
                Console.WriteLine("Invalid Input!");
            else
                stopLoop = true;
        }
        //If user enter an invalid input, the do-while loop would keep asking the user for a correct input.
        while (stopLoop != true);
        Console.WriteLine("Valid input.");

        //Task 6:
        //Declare
        string[] participants = new string[inputValue];
        char[] sportCodes = new char[inputValue];
        int skating = 0, boxing = 0, football = 0, volleyball = 0;

        //Using for loop to prompt user to input participants' name and sporting codes,
        //inputValue is the number of participants
        for (int i = 0; i < inputValue; i++)
        {
            Console.WriteLine("\nPlease enter the participant {0} name: ", i+1);
            participants[i] = Console.ReadLine();
            Console.WriteLine("Please enter the sporting codes: " +
                "\nS for Skating, B for Boxing, F for Football and V for Volleyball.");
            sportCodes[i] = Convert.ToChar(Console.ReadLine());

            //Reject if invalid sporting entered, i-1 is to reduce the count caused by invalid enter
            if (sportCodes[i] != 'S' && sportCodes[i] != 'B' && sportCodes[i] != 'F' && sportCodes[i] != 'V')
            {
                Console.WriteLine("Invalid input, Please enter 'S', 'B', 'F' or 'V'.");
                i = i - 1;
            }
            //Counting sporting codes
            else
            {
                if (sportCodes[i] == 'S')
                    skating++;
                else if (sportCodes[i] == 'B')
                    boxing++;
                else if (sportCodes[i] == 'F')
                    football++;
                else volleyball++;
            }
        }
        //Output the sporting code counts
        Console.WriteLine("\nThe total count of skating is {0}," +
            " \nThe total count of boxing is {1}, " +
            "\nThe total count of football is {2}," +
            " \nThe total count of volleyball is {3}",
            skating, boxing, football, volleyball);

        //Declare
        char inputType;
        const char endLoop = '!';
        string name = "0";

        //Prompt user for a sporting code
        Console.WriteLine("\nPlease enter the sporting code: ");
        inputType = Convert.ToChar(Console.ReadLine());

        //Prompt the user for a sporting code until the user enters '!'
        while (inputType != endLoop)
        {
            if (inputType == 'S' || inputType == 'B' || inputType == 'F' || inputType == 'V')
            {
                //Find the names with a specific sporting codes
                for (int j = 0; j < inputValue; j++)
                    if (inputType == sportCodes[j])
                    {
                        name = participants[j];
                        Console.WriteLine(name);
                    }
            }
            else Console.WriteLine("Invalid input, Please enter 'S', 'B', 'F' or 'V'.");
            //Avoid infinite loop
            Console.WriteLine("\nPlease enter the sport code or enter ! to end: ");
            inputType = Convert.ToChar(Console.ReadLine());
        }
    }
}
