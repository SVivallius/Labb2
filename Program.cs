// Init application

using Labb2;

bool running = true;
List<KitchenApp> apps = new();
Flood.List(ref apps);
    
while (running)
{
    MenuManager.BuildMenu();
    int selection = MenuManager.MenuSelection(5);
    switch (selection)
    {
        // Use application
        case 1:
            MenuManager.BuildSubMenu(apps);
            MenuManager.AwaitConfirm();
            break;

        // Add new
        case 2:
            ItemMngr.AddItem(ref apps);
            MenuManager.AwaitConfirm();
            break;

        // List apps
        case 3:
            ItemMngr.ListItems(apps);
            MenuManager.AwaitConfirm();
            break;

        // Remove apps
        case 4:
            ItemMngr.RemoveItem(ref apps);
            MenuManager.AwaitConfirm();
            break;

        // Exit software
        case 5:
            Console.WriteLine("Avslutar styrprogrammet! Vi ses nässta gång!");
            MenuManager.AwaitConfirm();
            running = false;
            break;
    }
}