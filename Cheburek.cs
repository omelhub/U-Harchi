using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U_Harchi;

public class Cheburek : ISemiFinishedFood
{
    public string Name => "Чебурек";

    public bool Proteins => false;

    public bool Fats => true;

    public bool Carbohydrates => false;
}
