using System;
using System.Collections.Generic;
using System.Text;

namespace MENUVMMV.Model
{
    public interface IMenu
    {
        string ComprarIngredientes();
        string PrepararIngredientes();
        string CocinarPlatillo();
    }
}
