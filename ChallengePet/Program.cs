//TODO
//on option 1
//instead of displaying the whole list as one thing, create a menu that shows the ID, species and nick (if available)
//user then select what animal wants to see information about



int animalRow = 1;
int animalLimit = 6;
string[,] ourAnimals = new string[animalLimit,6];
ourAnimals[0,0] = "Pet ID#: ";
ourAnimals[0,1] = "Pet species (cat or dog): ";
ourAnimals[0,2] = "Pet age (years): ";
ourAnimals[0,3] = "A description of the pet's physical appearance: ";
ourAnimals[0,4] = "A description of the pet's personality: ";
ourAnimals[0,5] = "The pet's nickname: ";



//menu
string? userInput;
menuOptions();
do {
    userInput = Console.ReadLine();
    switch (userInput) {
        case "0":
            Console.Clear();
            menuOptions();
        break;

        case "1":
            Console.Clear();
            listAnimals();
            //menuOptions();
        break;

        case "2":
            Console.Clear();
            assinValues();
            menuOptions();
        break;

        case "3":
            Console.Clear();
            //
            menuOptions();
        break;

        case "4":
            Console.Clear();
            //
            menuOptions();
        break;

        case "5":
            Console.Clear();
            //
            menuOptions();
        break;

        case "6":
            Console.Clear();
            //
            menuOptions();
        break;

        case "7":
            Console.Clear();
            //
            menuOptions();
        break;

        case "8":
            Console.Clear();
            //
            menuOptions();
        break;

        default:
            Console.Clear();
            menuOptions();
        break;
    }
} while (userInput != "exit");








void menuOptions() {
    Console.Clear();
    System.Console.WriteLine("1 - List all of our current pet information");
    System.Console.WriteLine($"2 - Assign values to the ourAnimals array fields ({animalRow-1}/{animalLimit-1})");
    System.Console.WriteLine("3 - Ensure animal ages and physical descriptions are complete");
    System.Console.WriteLine("4 - Ensure animal nicknames and personality descriptions are complete");
    System.Console.WriteLine("5 - Edit an animal's age");
    System.Console.WriteLine("6 - Edit an animal's personality description");
    System.Console.WriteLine("7 - Display all cats with a specified characteristic");
    System.Console.WriteLine("8 - Display all dogs with a specified characteristic");
    System.Console.WriteLine();
    System.Console.WriteLine();
    System.Console.WriteLine("Enter menu item selection or type 'exit' to exit the program");

}


void assinValues() {
    if (animalRow < animalLimit) {
        for (int i=0; i<animalLimit; i++) {
            System.Console.Write(ourAnimals[0,i]);
            ourAnimals[animalRow,i] = Console.ReadLine() ?? "";
        }
        animalRow++;
    };
}


void listAnimals() {

    for (int i=1; i<animalLimit; i++) {
        
        if (ourAnimals[i,0] != "" && ourAnimals[i,0] != null) {
            System.Console.Write(ourAnimals[0,i-1]); //header
            System.Console.Write(ourAnimals[i,i-1]);
            
            System.Console.WriteLine();
        }

    }
}