using U_Harchi;

U_Market market = new();
ConsoleKey type = ConsoleKey.D4;
Console.WriteLine("Добро пожаловать в наш интернет-магазин продуктов!\n" +
    "Хотите выбрать категорию товаров?");
string? ans1 = Console.ReadLine();
while (ans1 != "Да" && ans1 != "Нет")
{
    Console.WriteLine("Ответ некорректный - введите 'Да' или 'Нет'.");
    ans1 = Console.ReadLine();
}
if (ans1 == "Да")
{
    Console.WriteLine("Категории товаров:\n1. Закуски\n2. Здоровая пища\n3. Полуфабрикаты\n( выберите цифру )\n");
    ConsoleKey key = Console.ReadKey().Key;
    while (key != ConsoleKey.D1 && key != ConsoleKey.D2 && key != ConsoleKey.D3)
    {
        Console.WriteLine("\nОтвет некорректный - выберите цифру (1,2,3)...");
        key = Console.ReadKey().Key;
    }
    type = key;
    if (key == ConsoleKey.D1)
    {
        //market.CartTyping(out Cart<ISnacks> FoodCart);
        Console.WriteLine($"\nВыберете товар:\n1. {market.Things[0].Name}\n2. {market.Things[1].Name}\n3. {market.Things[2].Name}\nQ. Стоп\n");
        ConsoleKey keySnacks = Console.ReadKey().Key;
        while (keySnacks != ConsoleKey.Q)
        {
            switch (keySnacks)
            {
                case ConsoleKey.D1:
                    market.FoodCart.Foodstuffs.Add((ISnacks)market.Things[0]);
                    keySnacks = Console.ReadKey().Key;
                    continue;
                case ConsoleKey.D2:
                    market.FoodCart.Foodstuffs.Add((ISnacks)market.Things[1]);
                    keySnacks = Console.ReadKey().Key;
                    continue;
                case ConsoleKey.D3:
                    market.FoodCart.Foodstuffs.Add((ISnacks)market.Things[2]);
                    keySnacks = Console.ReadKey().Key;
                    continue;
                default:
                    keySnacks = Console.ReadKey().Key;
                    continue;
            }
        }
    }
    if (key == ConsoleKey.D2)
    {
        //market.CartTyping(out Cart<IHeathyFood> FoodCart);
        Console.WriteLine($"\nВыберете товар:\n1. {market.Things[3].Name}\n2. {market.Things[4].Name}\n3. {market.Things[5].Name}\nQ. Стоп\n");
        ConsoleKey keyHealths = Console.ReadKey().Key;
        while (keyHealths != ConsoleKey.Q)
        {
            switch (keyHealths)
            {
                case ConsoleKey.D1:
                    market.FoodCart.Foodstuffs.Add((IHeathyFood)market.Things[3]);
                    keyHealths = Console.ReadKey().Key;
                    continue;
                case ConsoleKey.D2:
                    market.FoodCart.Foodstuffs.Add((IHeathyFood)market.Things[4]);
                    keyHealths = Console.ReadKey().Key;
                    continue;
                case ConsoleKey.D3:
                    market.FoodCart.Foodstuffs.Add((IHeathyFood)market.Things[5]);
                    keyHealths = Console.ReadKey().Key;
                    continue;
                default:
                    keyHealths = Console.ReadKey().Key;
                    continue;
            }
        }
    }
    if (key == ConsoleKey.D3)
    {
        //market.CartTyping(out Cart<ISemiFinishedFood> FoodCart);
        Console.WriteLine($"\nВыберете товар:\n1. {market.Things[6].Name}\n2. {market.Things[7].Name}\n3. {market.Things[8].Name}\nQ. Стоп\n");
        ConsoleKey keySemis = Console.ReadKey().Key;
        while (keySemis != ConsoleKey.Q)
        {
            switch (keySemis)
            {
                case ConsoleKey.D1:
                    market.FoodCart.Foodstuffs.Add((ISemiFinishedFood)market.Things[6]);
                    keySemis = Console.ReadKey().Key;
                    continue;
                case ConsoleKey.D2:
                    market.FoodCart.Foodstuffs.Add((ISemiFinishedFood)market.Things[7]);
                    keySemis = Console.ReadKey().Key;
                    continue;
                case ConsoleKey.D3:
                    market.FoodCart.Foodstuffs.Add((ISemiFinishedFood)market.Things[8]);
                    keySemis = Console.ReadKey().Key;
                    continue;
                default:
                    keySemis = Console.ReadKey().Key;
                    continue;
            }
        }
    }
}
else
{
    Cart<IFood> FoodCart = new();
    Console.WriteLine($"\nВыберете товар:\n1. {market.Things[0].Name}\n2. {market.Things[1].Name}\n3. {market.Things[2].Name}\n" +
        $"4. {market.Things[3].Name}\n5. {market.Things[4].Name}\n6. {market.Things[5].Name}\n" +
        $"7. {market.Things[6].Name}\n8. {market.Things[7].Name}\n9. {market.Things[8].Name}\nQ. Стоп\n");
    ConsoleKey keys = Console.ReadKey().Key;
    while (keys != ConsoleKey.Q)
    {
        switch (keys)
        {
            case ConsoleKey.D1:
                FoodCart.Foodstuffs.Add((IFood)market.Things[0]);
                keys = Console.ReadKey().Key;
                continue;
            case ConsoleKey.D2:
                market.FoodCart.Foodstuffs.Add((IFood)market.Things[1]);
                keys = Console.ReadKey().Key;
                continue;
            case ConsoleKey.D3:
                market.FoodCart.Foodstuffs.Add((IFood)market.Things[2]);
                keys = Console.ReadKey().Key;
                continue;
            case ConsoleKey.D4:
                market.FoodCart.Foodstuffs.Add((IFood)market.Things[3]);
                keys = Console.ReadKey().Key;
                continue;
            case ConsoleKey.D5:
                market.FoodCart.Foodstuffs.Add((IFood)market.Things[4]);
                keys = Console.ReadKey().Key;
                continue;
            case ConsoleKey.D6:
                market.FoodCart.Foodstuffs.Add((IFood)market.Things[5]);
                keys = Console.ReadKey().Key;
                continue;
            case ConsoleKey.D7:
                market.FoodCart.Foodstuffs.Add((IFood)market.Things[6]);
                keys = Console.ReadKey().Key;
                continue;
            case ConsoleKey.D8:
                market.FoodCart.Foodstuffs.Add((IFood)market.Things[7]);
                keys = Console.ReadKey().Key;
                continue;
            case ConsoleKey.D9:
                market.FoodCart.Foodstuffs.Add((IFood)market.Things[8]);
                keys = Console.ReadKey().Key;
                continue;
            default:
                keys = Console.ReadKey().Key;
                continue;
        }
    }
}
string? ans2;
if (!market.FoodCart.IsBalansing())
{
    Console.WriteLine("\nВаша корзина не сбалансированна! Хотите сбалансировать?");
    ans2 = Console.ReadLine();
    while (ans2 != "Да" && ans2 != "Нет")
    {
        Console.WriteLine("Ответ некорректный - введите 'Да' или 'Нет'.");
        ans2 = Console.ReadLine();
    }
    if (ans2 == "Да")
    {
        market.FoodCart.CartBalansing(market, type);
        Console.WriteLine("Балансировка...");
    }
}
Console.WriteLine("\nВаша корзина содержит: ");
foreach (IFood food in market.FoodCart.Foodstuffs)
    Console.WriteLine($"{food.Name}");

Console.WriteLine("\nGood Bye!");
Console.ReadKey();