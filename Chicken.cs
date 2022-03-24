using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U_Harchi;

public class Chicken : IHeathyFood
{
    public string Name => "Курица";

    public bool Proteins => true;

    public bool Fats => false;

    public bool Carbohydrates => false;
}
