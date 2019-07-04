using System;
using System.Collections.Generic;
using System.Text;
using MENUVMMV.Model;

namespace MENUVMMV.Model
{
    class Menu: IMenu
    {
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public int NumeroIngredientes { get; set; }
        public string Nacionalidad { get; set; }

        public string CocinarPlatillo()
        {
            return "Cocinando platillo";
        }

        public string ComprarIngredientes()
        {
            return "Comprando Ingredientes";
        }

        public string PrepararIngredientes()
        {
            return "Preparando Ingredientes";
        }
    }
}
