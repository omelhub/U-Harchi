using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U_Harchi;

public interface IFood : IThing
{
    public bool Proteins { get; }
    public bool Fats { get; }
    public bool Carbohydrates { get; }
}
