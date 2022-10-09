// Init application

using Labb2;

bool running = true;
List<KitchenApp> apps = new List<KitchenApp>();

while (running)
{
    MenuManager.BuildMenu();
    int selection = MenuManager.MenuSelection(5);
    switch (selection)
    {
        // Use application
        case 1:
            MenuManager.BuildSubMenu(apps);

            int subSelection = MenuManager.MenuSelection(3);

            switch (subSelection)
            {
                case 1:
                    break;

                case 2:
                    break;

                case 3:
                    break;

                default:
                    break;
            }
            MenuManager.AwaitConfirm();
            break;

        // Add new
        case 2:
            MenuManager.AwaitConfirm();
            break;

        // List apps
        case 3:
            MenuManager.AwaitConfirm();
            break;

        // Remove apps
        case 4:
            MenuManager.AwaitConfirm();
            break;

        // Exit software
        case 5:
            MenuManager.AwaitConfirm();
            running = false;
            break;
    }
}