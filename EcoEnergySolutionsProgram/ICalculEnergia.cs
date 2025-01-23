using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EcoEnergySolutionsProgram
{
    public interface ICalculEnergia
    {
        /// <summary>
        /// Valida les dades introduïdes
        /// </summary>
        /// <param>No parametres</param>
        /// <returns>Retorna un boolea</returns>
        bool ValidarDades();
        /// <summary>
        /// Calcula l'energia
        /// </summary>
        /// <param>No parametres</param>
        /// <returns>Retorna un double</returns>
        double CalculEnergia();
        /// <summary>
        /// Printa la informacio
        /// </summary>
        /// <param>No parametres</param>
        /// <returns>No retorna res</returns>
        void MostrarInfo();
    }
}