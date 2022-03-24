using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U_Harchi;

public class OliveOil : IHeathyFood
{
    public string Name => "Оливковое масло";

    public bool Proteins => false;

    public bool Fats => true;

    public bool Carbohydrates => false;
}
