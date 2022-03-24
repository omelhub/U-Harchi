using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U_Harchi;

public class Fruit : IHeathyFood
{
    public string Name => "Фрукт";

    public bool Proteins => false;

    public bool Fats => false;

    public bool Carbohydrates => true;
}
