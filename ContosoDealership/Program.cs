
string? readResult;

menuOptions();

do {


    readResult = Console.ReadLine();

    switch (readResult) {
        
        case "0":
            Console.Clear();
            menuOptions();
        break;

        case "1":
            Console.Clear();
            System.Console.WriteLine("You selected option 1");
            System.Console.WriteLine("0 - Go back");
        break;

        case "2":
            Console.Clear();
            System.Console.WriteLine("You selected option 2");
            System.Console.WriteLine("0 - Go back");
        break;

        case "3":
            Console.Clear();
            System.Console.WriteLine("You selected option 3");
            System.Console.WriteLine("0 - Go back");
        break;

        case "4":
            Console.Clear();
            System.Console.WriteLine("You selected option 4");
            System.Console.WriteLine("0 - Go back");
        break;

        default:
            Console.Clear();
            menuOptions();
        break;
    };

} while (readResult != "exit");



void menuOptions() {
    System.Console.WriteLine("Welcome to Contoso Dealership");
    System.Console.WriteLine("-----------------------------");
    System.Console.WriteLine("1 - List all available cars");
    System.Console.WriteLine("2 - Rent a car");
    System.Console.WriteLine("3 - But a car");
    System.Console.WriteLine("4 - Sell a car");
    System.Console.WriteLine();
    System.Console.WriteLine("Type 'exit' anytime to exit the application");
}