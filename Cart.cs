using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U_Harchi;

public class Cart<T> where T: IFood
{
    public List<T> Foodstuffs { get; } = new List<T>();
    
    public void CartBalansing(U_Market market, ConsoleKey type)
    {
        switch (type)
        {
            case ConsoleKey.D1:
                if (!Foodstuffs.Exists(x => x.Carbohydrates))
                {
                    foreach (T food in market.Things.FindAll(x => x is ISnacks))
                    {
                        if (food.Carbohydrates)
                        {
                            Foodstuffs.Add(food);
                            break;
                        }
                    }
                }
                if (!Foodstuffs.Exists(x => x.Fats))
                {
                    foreach (T food in market.Things.FindAll(x => x is ISnacks))
                    {
                        if (food.Fats)
                        {
                            Foodstuffs.Add(food);
                            break;
                        }
                    }
                }
                if (!Foodstuffs.Exists(x => x.Proteins))
                {
                    foreach (T food in market.Things.FindAll(x => x is ISnacks))
                    {
                        if (food.Proteins)
                        {
                            Foodstuffs.Add(food);
                            break;
                        }
                    }
                }
                break;
            case ConsoleKey.D2:
                if (!Foodstuffs.Exists(x => x.Carbohydrates))
                {
                    foreach (T food in market.Things.FindAll(x => x is IHeathyFood))
                    {
                        if (food.Carbohydrates)
                        {
                            Foodstuffs.Add(food);
                            break;
                        }
                    }
                }
                if (!Foodstuffs.Exists(x => x.Fats))
                {
                    foreach (T food in market.Things.FindAll(x => x is IHeathyFood))
                    {
                        if (food.Fats)
                        {
                            Foodstuffs.Add(food);
                            break;
                        }
                    }
                }
                if (!Foodstuffs.Exists(x => x.Proteins))
                {
                    foreach (T food in market.Things.FindAll(x => x is IHeathyFood))
                    {
                        if (food.Proteins)
                        {
                            Foodstuffs.Add(food);
                            break;
                        }
                    }
                }
                break;
            case ConsoleKey.D3:
                if (!Foodstuffs.Exists(x => x.Carbohydrates))
                {
                    foreach (T food in market.Things.FindAll(x => x is ISemiFinishedFood))
                    {
                        if (food.Carbohydrates)
                        {
                            Foodstuffs.Add(food);
                            break;
                        }
                    }
                }
                if (!Foodstuffs.Exists(x => x.Fats))
                {
                    foreach (T food in market.Things.FindAll(x => x is ISemiFinishedFood))
                    {
                        if (food.Fats)
                        {
                            Foodstuffs.Add(food);
                            break;
                        }
                    }
                }
                if (!Foodstuffs.Exists(x => x.Proteins))
                {
                    foreach (T food in market.Things.FindAll(x => x is ISemiFinishedFood))
                    {
                        if (food.Proteins)
                        {
                            Foodstuffs.Add(food);
                            break;
                        }
                    }
                }
                break;
            case ConsoleKey.D4:
                if (!Foodstuffs.Exists(x => x.Carbohydrates))
                {
                    foreach (T food in market.Things.FindAll(x => x is T))
                    {
                        if (food.Carbohydrates)
                        {
                            Foodstuffs.Add(food);
                            break;
                        }
                    }
                }
                if (!Foodstuffs.Exists(x => x.Fats))
                {
                    foreach (T food in market.Things.FindAll(x => x is T))
                    {
                        if (food.Fats)
                        {
                            Foodstuffs.Add(food);
                            break;
                        }
                    }
                }
                if (!Foodstuffs.Exists(x => x.Proteins))
                {
                    foreach (T food in market.Things.FindAll(x => x is T))
                    {
                        if (food.Proteins)
                        {
                            Foodstuffs.Add(food);
                            break;
                        }
                    }
                }
                break;
        }
    }
    public bool IsBalansing()
    {
        if (Foodstuffs.Exists(x => x.Carbohydrates) && Foodstuffs.Exists(x => x.Fats) && Foodstuffs.Exists(x => x.Proteins))
            return true;
        else
            return false;
    }
}
