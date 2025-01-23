using System;


namespace EcoEnergySolutionsProgram
{
    public static class Metodes
    {
        /// <summary>
        /// Fa les simulacions
        /// </summary>
        /// <param >No parametres</param>
        /// <returns>Retorna l'array d'objectes</returns>
        public static SistemaEnergia[] Simulacio()
        {
            const string MsgQuantitatSimulacions = "Quantes simulacions vols? (0-100)",
                        MsgTipusSimulacio = "\nDe quin tipus d'energia vols la simulacio? (Escriu el numero al costat del tipus d'energia)\n" + "" +
                                            "1. Energia Solar\t\t(Dada mes gran que 1)\n" +
                                            "2. Energia Eolica\t\t(Dada mes gran que 5)\n" +
                                            "3. Energia Hidroelectrica\t(Dada mes gran que 20)\n",
                        MsgDadaEnergia = "Quina dada vols fer servir?",
                        MsgDadaEnergiaError = "Torna a indicar quina dada vols fer servir";
            int quantitatSimulacions, tipusSimulacio;
            Console.WriteLine(MsgQuantitatSimulacions);
            //Valida que el numero introduït estigui entre el 0 i el 100
            quantitatSimulacions = ValidateIntNum(0, 101);
            //Crea array amb l'allargada que a introduït
            SistemaEnergia[] arrayEnergias = new SistemaEnergia[quantitatSimulacions];
            //For que va guardan les simulacions en l'array
            for (int i = 0; i < quantitatSimulacions; i++)
            {
                Console.WriteLine(MsgTipusSimulacio);
                tipusSimulacio = ValidateIntNum(0, 4);
                //Valida que el input sigui l'esperat

                switch (Convert.ToInt32(tipusSimulacio))
                {
                    //Cas 1 Sistema Solar
                    case 1:
                        Console.WriteLine(MsgDadaEnergia);
                        SistemaSolar InstanciaSistemaSolar = new SistemaSolar(ValidateDoubleNum(1));
                        while (!InstanciaSistemaSolar.ValidarDades())
                        {
                            Console.WriteLine(MsgDadaEnergiaError);
                            InstanciaSistemaSolar = new SistemaSolar(ValidateDoubleNum(1));
                        }
                        arrayEnergias[i] = InstanciaSistemaSolar;
                        break;
                    //Cas 2 Sistema Eolic
                    case 2:
                        Console.WriteLine(MsgDadaEnergia);
                        SistemaEolic InstanciaSistemaEolic = new SistemaEolic(ValidateDoubleNum(5));
                        while (!InstanciaSistemaEolic.ValidarDades())
                        {
                            Console.WriteLine(MsgDadaEnergiaError);
                            InstanciaSistemaEolic = new SistemaEolic(ValidateDoubleNum(5));
                        }
                        arrayEnergias[i] = InstanciaSistemaEolic;
                        break;
                    //Cas 3 Sistema Hidroelectric
                    case 3:
                        Console.WriteLine(MsgDadaEnergia);
                        SistemaHidroelectric InstanciaSistemaHidro = new SistemaHidroelectric(ValidateDoubleNum(20));
                        while (!InstanciaSistemaHidro.ValidarDades())
                        {
                            Console.WriteLine(MsgDadaEnergiaError);
                            InstanciaSistemaHidro = new SistemaHidroelectric(ValidateDoubleNum(20));
                        }
                        arrayEnergias[i] = InstanciaSistemaHidro;
                        break;
                }
            }
            //Retorna array amb les simulacions
            return arrayEnergias;
        }
        /// <summary>
        /// Printa l'array d'objectes
        /// </summary>
        /// <param >array de objectes</param>
        /// <returns>No retorna res</returns>
        public static void PrintarSimulacions(SistemaEnergia[] arrayEnergies, SistemaEnergia[] arrayGranEnergies)
        {
            const string TipusTaula = "|\tTipus\t\t|\t\tData\t\t|\tEnergia Generada\t|\n"
                + "-----------------------------------------------------------------------------------------";
            int j = 0;
            //Possa les noves dades en un nou array mes gran per guardar les taules anteriors
            for (int i = 0; i < arrayGranEnergies.Length; i++)
            {
                while (arrayGranEnergies[i] == null && j < arrayEnergies.Length)
                {
                    arrayGranEnergies[i] = arrayEnergies[j];
                    j++;
                }
            }
            //Printa la taula amb les dades
            Console.WriteLine(TipusTaula);
            for (int i = 0; arrayGranEnergies[i] != null; i++)
            {
                arrayGranEnergies[i].MostrarInfo();
            }
        }
        /// <summary>
        /// Enseña la pantalla de menu
        /// </summary>
        /// <param >No parametres</param>
        /// <returns>No retorna res</returns>
        public static void Menu()
        {
            const string Titol = " _____          _____                            ____        _       _   _                 \r\n| ____|___ ___ | ____|_ __   ___ _ __ __ _ _   _/ ___|  ___ | |_   _| |_(_) ___  _ __  ___ \r\n|  _| / __/ _ \\|  _| | '_ \\ / _ \\ '__/ _` | | | \\___ \\ / _ \\| | | | | __| |/ _ \\| '_ \\/ __|\r\n| |__| (_| (_) | |___| | | |  __/ | | (_| | |_| |___) | (_) | | |_| | |_| | (_) | | | \\__ \\\r\n|_____\\___\\___/|_____|_| |_|\\___|_|  \\__, |\\__, |____/ \\___/|_|\\__,_|\\__|_|\\___/|_| |_|___/\r\n                                     |___/ |___/                                           ";
            const string MenuPrincipal = "1. Iniciar simulació\n2. Ensenyar simulacións\n3. Sortir",
                MsgInfo = "Per començar el programa escriu 1, per enseñar la taula escriu 2 i per sortir escriu 3";
            //Printa el menu principal
            Console.WriteLine(Titol);
            Console.WriteLine(MenuPrincipal);
            Console.WriteLine(MsgInfo);
        }
        /// <summary>
        /// Valida que el numero que escrius es un int i si no el torna a preguntar
        /// </summary>
        /// <param>
        /// Un numero minim i un numero maxim
        /// </param>
        /// <returns>Retorna un numero int</returns>
        public static int ValidateIntNum(int min, int max)
        {
            const string MsgError = "Escriu un numero en el rang";
            const string MsgTryCatch = "Escriu un numero";
            int numCheck = 0;
            bool exit = true;
            while (exit)
            {
                try
                {
                    numCheck = int.Parse(Console.ReadLine());
                    exit = false;
                    if (numCheck < min || numCheck > max)
                    {
                        exit = true;
                        Console.WriteLine(MsgError);
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine(MsgTryCatch);
                }
            }
            return numCheck;
        }
        /// <summary>
        /// Valida que el numero que escrius es un double i si no el torna a preguntar
        /// </summary>
        /// <param >Un numero minim</param>
        /// <returns>Retorna un numero double</returns>
        public static double ValidateDoubleNum(int min)
        {
            const string MsgTryCatch = "Escriu un numero";
            const string MsgMin = "Escriu un numero mes gran que {0}";
            double numCheck = 0;
            bool exit = true;
            while (exit)
            {
                try
                {
                    numCheck = double.Parse(Console.ReadLine());
                    exit = false;
                    //Valida si el minim es 5 o 20 per fer un if diferent   
                    if (min == 5 || min == 20)
                    {
                        if (numCheck <= min)
                        {
                            Console.WriteLine(MsgMin, min);
                            exit = true;
                        }
                    }
                    else
                    {
                        if (numCheck < min)
                        {
                            Console.WriteLine(MsgMin, min);
                            exit = true;
                        }
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine(MsgTryCatch);
                }
            }
            return numCheck;
        }
    }
}
