using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U_Harchi;

public class Crisps : ISnacks
{
    public string Name => "Чипсы";

    public bool Proteins => false;

    public bool Fats => true;

    public bool Carbohydrates => false;
}
