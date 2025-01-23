using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EcoEnergySolutionsProgram
{
    public abstract class SistemaEnergia : ICalculEnergia
    {
        public System.DateTime Data { get; set; }
        public string? TipusEnergia { get; set; }
        public virtual bool ValidarDades() => true;
        public virtual double CalculEnergia() => 0;
        public virtual void MostrarInfo() { }
    }
}