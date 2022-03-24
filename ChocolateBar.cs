using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U_Harchi;

public class ChocolateBar : ISnacks
{
    public string Name => "Шоколадный батончик";

    public bool Proteins => false;

    public bool Fats => false;

    public bool Carbohydrates => true;
}
