using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U_Harchi;

public class U_Market
{
    public List<IThing> Things { get; } = new List<IThing>() { new ChocolateBar(), new Crisps(), new BalykCheese(),
        new Chicken(), new OliveOil(), new Fruit(), new DumplingsMeat(), new Cheburek(), new DumplingsBerries(),
        new Pen(), new Notebook()};

    public Cart<IFood> FoodCart { get; set; } = new Cart<IFood>();

    //public void CartTyping<T>(out Cart<T> FoodCart) where T : IFood
    //{
    //    FoodCart = new Cart<T>();
    //}

}
