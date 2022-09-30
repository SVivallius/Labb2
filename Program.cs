using Labb2;

bool running = true;

while (running)
{
    MenuManager.BuildMenu();

    // Felhantering: validOpt blir false om konverteringen misslyckas.
    // Annars initieras variabeln selection med det konverterade värdet.
    bool validOpt = Int32.TryParse(Console.ReadLine(), out int selection);
    while (!validOpt)
    {
        Console.Write("Ogiltigt val! Försök igen: ");
        validOpt = Int32.TryParse(Console.ReadLine(), out selection);
    }

    switch (selection)
    {
        // Activate
        case 1:
            break;

        // Register new
        case 2:
            break;

        // List registered
        case 3:
            break;

        // Remove
        case 4:
            break;

        // Exit app
        case 5:
            break;

        default:
            break;
    }
}