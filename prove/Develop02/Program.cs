class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        bool isRunning = true;

        while (isRunning)
        {
            Console.WriteLine("Welcome to the Journal App");
            Console.WriteLine("Please choose an option:");
            Console.WriteLine(
                "1. Write a new entry\n" +
                "2. Display the journal\n" +
                "3. Save the journal to a file\n" +
                "4. Load the journal from a file\n" +
                "5. Quit");

            if (int.TryParse(Console.ReadLine(), out int input))
            {
                switch (input)
                {
                    case 1:
                        string promptText = promptGenerator.GetRandomPrompt();
                        Console.WriteLine($"Prompt: {promptText}");
                        Console.WriteLine("Enter your journal entry:");
                        string entryText = Console.ReadLine();

                        Entry newEntry = new Entry
                        {
                            _date = DateTime.Now.ToString("MM-dd HH:mm"),
                            _promptText = promptText,
                            _entryText = entryText
                        };

                        journal.AddEntry(newEntry);
                        break;
                    case 2:
                        journal.DisplayAll();
                        break;
                    case 3:
                        Console.WriteLine("Enter the filename to save the journal:");
                        string saveFileName = Console.ReadLine();
                        journal.SaveToFile(saveFileName);
                        Console.WriteLine("Journal saved to the file.");
                        break;
                    case 4:
                        Console.WriteLine("Enter the filename to load the journal:");
                        string loadFileName = Console.ReadLine();
                        journal.LoadFromFile(loadFileName);
                        Console.WriteLine("Journal loaded from the file.");
                        break;
                    case 5:
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please choose a valid option.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }
}