using Labb2;

bool running = true;
List<Appliance> appliances = new List<Appliance>();


while (running)
{
    MenuManager.BuildMenu();
    int selection = MenuManager.Selection(6);
    
    switch (selection)
    {
        // Activate
        case 1:
            break;

        // Register new
        case 2:
            ItemManager.AddAppliance(ref appliances);
            MenuManager.AwaitConfirm();
            break;

        // List registered
        case 3:
            ItemManager.ListAppliance(appliances);
            MenuManager.AwaitConfirm();
            break;

        // Remove
        case 4:
            ItemManager.RemoveAppliance(ref appliances);
            MenuManager.AwaitConfirm();
            break;

        // Exit app
        case 5:
            Console.Write("Är du säker på att du vill avsluta?\n" +
                "(Y/N): ");
            if (MenuManager.InterpretTrueFalse(Console.ReadLine())) running = false;
            else MenuManager.AwaitConfirm();
            break;

        default:
            break;
    }
}