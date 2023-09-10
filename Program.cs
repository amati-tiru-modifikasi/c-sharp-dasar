using System;

class Program
{
    static void Main(string[] args)
    {   
        // #1 ourAnimals array
        string animalSpecies = "";
        string animalId = "";
        string animalAge = "";
        string animalPhysicalDescription = "";
        string animalPersonalityDescription = "";
        string animalNickName = "";
        string suggestedDonations = "";

        // #2 variabel for data
        int maxPets = 8;
        string? readResult; // non-nullable variable type to avoid warning when build project
        string menuSelection = "";
        decimal decimalDonation = 0.00m;

        // #3 array store runtime data, no persisted data
        string[,] ourAnimals = new string[maxPets, 7]; // multidimensional array string

        // #4 create a sample data
        for (int i = 0; i < maxPets; i++)
        {
            switch (i)
            {
                case 0:
                    animalSpecies = "cat";
                    animalId = "c1";
                    animalAge = "3";
                    animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 45 pounds. housebroken.";
                    animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
                    animalNickName = "Yola";
                    suggestedDonations = "85";
                    break;
                case 1:
                    animalSpecies = "cat";
                    animalId = "c1";
                    animalAge = "9";
                    animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 45 pounds. housebroken.";
                    animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
                    animalNickName = "Gous";
                    suggestedDonations = "49.99";
                    break;

                // case 2: deleted for brevity
                // case 3: deleted for brevity

                default:
                    animalSpecies = "";
                    animalId = "";
                    animalAge = "";
                    animalPhysicalDescription = "";
                    animalPersonalityDescription = "";
                    animalNickName = "";
                    suggestedDonations = "";
                    break;
            }

            ourAnimals[i, 0] = "ID #: " + animalId;
            ourAnimals[i, 1] = "Species: " + animalSpecies;
            ourAnimals[i, 2] = "Age: " + animalAge;
            ourAnimals[i, 3] = "Nickname: " + animalNickName;
            ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
            ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;            

            // cast suggestionDonation() as decimal to validate
            if (!decimal.TryParse(suggestedDonations, out decimalDonation))
            {
                decimalDonation =  45.00M; // if not number, default to 45
            }
            ourAnimals[i, 6] = $"Suggestion Donation: {decimalDonation:C2}";
        }

        // #5 display top level menu options
        do
        {
            // NOTE: to clear throwing an exceptions in debug session
            Console.Clear();

            Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
            Console.WriteLine(" 1. List all of our current pet information");
            Console.WriteLine(" 2. Display all dogs with a specified characteristic");
            Console.WriteLine();
            Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

            readResult = Console.ReadLine(); // by default it's null, but readResult is use non-nullable value by default, for avoid warning when build project
            if (readResult != null)
            {
                menuSelection = readResult.ToLower();
            }

            // switch-case to selected option menu
            switch (menuSelection)
            {
                case "1":
                    // list all pet info
                    for (int i = 0; i < maxPets; i++)
                    {
                        if (ourAnimals[i, 0] != "ID #: ")
                        {
                            Console.WriteLine();
                            for (int j = 0; j < 7; j++)
                            {
                                Console.WriteLine(ourAnimals[i, j]);
                            }
                        }
                    }
                    Console.WriteLine("\n\rPress the Enter key to Continue");
                    readResult = Console.ReadLine();
                    break;
                
                case "2":
                    // Display all cat with specified characteristic
                    string catCharacteristic = "";
                    while (catCharacteristic == "")
                    {
                        // have the user enter characteristik search for
                        Console.WriteLine($"Enter one desired cat characteristic to search for");
                        readResult = Console.ReadLine();
                        if (readResult != null)
                        {
                            catCharacteristic = readResult.ToLower().Trim();
                        }
                    }
                    break;

                default:
                    break;
            }
            
        } while (menuSelection != "exit");

    }
}