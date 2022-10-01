using Labb2;

bool running = true;
List<Appliance> appliances = new List<Appliance>();

while (running)
{
    MenuManager.BuildMenu();
    int selection = MenuManager.Selection(5);
    
    switch (selection)
    {
        // Activate
        case 1:
            break;

        // Register new
        case 2:
            ItemManager.AddAppliance(ref appliances);
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