using EcoEnergySolutionsProgram;
using System;
using System.Diagnostics;

namespace EcoEnergySolutionsProgram
{
    public static class Program
    {
        public static void Main()
        {
            const string MsgArraySenseDades = "No hi han simulacions", MsgTryCatch = "Error de format";
            bool sortirMenu = true;
            int usuariInputMenu;
            SistemaEnergia[]? arrayEnergies = null;
            //Array mes gran on guardarem totes les dades (Anteriors i noves)
            SistemaEnergia[] arrayGranEnergies = new SistemaEnergia[100];
            try
            {
                do
                {
                    Metodes.Menu();
                    //Valida que el input sigui 1, 2 o 3
                    usuariInputMenu = Metodes.ValidateIntNum(0, 4);
                    switch (usuariInputMenu)
                    {
                        //Cas 1 Comença la simulacio
                        case 1:
                            arrayEnergies = Metodes.Simulacio();
                            break;
                        //Cas 2 Printa la taula amb les simulacions si s'han creat
                        case 2:
                            if (arrayEnergies == null)
                            {
                                Console.WriteLine(MsgArraySenseDades);
                            }
                            else
                            {
                                Metodes.PrintarSimulacions(arrayEnergies, arrayGranEnergies);
                            }
                            break;
                        //Surt del programa
                        case 3: sortirMenu = false; break;
                    }
                } while (sortirMenu);
            }
            catch (FormatException)
            {
                Console.WriteLine(MsgTryCatch);
            }
        }
    }
}