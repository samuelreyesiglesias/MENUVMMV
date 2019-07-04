using System;
using System.Collections.Generic;
using System.Text;
using MENUVMMV.Model;

namespace MENUVMMV.ViewModel
{
    public class VMMenu
    {
        string mensaje;
        public VMMenu(string Nombre, double Precio, int NumeroIngredientes, string Nacionalidad, int Accion)
        {
            mensaje = "";
            Menu m = new Menu();
            m.Nombre = Nombre;
            m.Precio = Precio;
            m.NumeroIngredientes = NumeroIngredientes;
            m.Nacionalidad = Nacionalidad;
            mensaje = "Nombre:" + m.Nombre + " Nacionalidad:" + m.Nacionalidad + " Precio:" + m.Precio + " Ingedientes:" + m.NumeroIngredientes;
            if (Accion==1) {
                mensaje = "Accion seleccionada..Comprando ingredientes\n" + mensaje;
                
            }else if (Accion == 2)
            {
                mensaje = "Accion seleccionada..Preparar ingredientes\n" + mensaje;

            }
            else if(Accion==3)
            {
                mensaje = "Accion seleccionada..Cocinar \n" + mensaje;
            }
            else{
                mensaje = "Accion Invalida..Comprando ingredientes\n" + mensaje;
            }
            retornarMensaje();
        }
        public string retornarMensaje()
        {
            return mensaje;
        }
    }
}
