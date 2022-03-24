using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U_Harchi;

public class Cart<T> where T: IFood
{
    public List<T> Foodstuffs { get; } = new List<T>();
    
    public void CartBalansing(U_Market market)
    {
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
    }
    public bool IsBalansing() //работает, но можно ли это написать компактнее?
    {
        if (Foodstuffs.Exists(x => x.Carbohydrates))
            if (Foodstuffs.Exists( x => x.Fats))
                if (Foodstuffs.Exists(x => x.Proteins))
                    return true;
                else
                    return false;
            else
                return false;
        else
            return false;
    }
}
