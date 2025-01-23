using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EcoEnergySolutionsProgram
{
    public class SistemaSolar : SistemaEnergia
    {
        public double HoresDeSol { get; set; }
        public override bool ValidarDades() => this.HoresDeSol > 1;
        public override double CalculEnergia() => this.HoresDeSol * 1.5;
        public override void MostrarInfo()
        {
            Console.WriteLine($"|\t{this.TipusEnergia}\t\t|\t{this.Data}\t|\t{this.CalculEnergia()}\t|");
        }
        public SistemaSolar(double horesDeSol)
        {
            HoresDeSol = horesDeSol;
            Data = DateTime.Now;
            TipusEnergia = "Solar";
        }
        public SistemaSolar() { }
    }
}