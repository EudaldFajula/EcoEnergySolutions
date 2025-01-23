using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EcoEnergySolutionsProgram
{
    public class SistemaEolic : SistemaEnergia
    {
        public double VelocitatVent { get; set; }
        public override bool ValidarDades() => this.VelocitatVent >= 5;
        public override double CalculEnergia() => Math.Pow(this.VelocitatVent, 3) * 0.2;
        public override void MostrarInfo()
        {
            Console.WriteLine($"|\t{this.TipusEnergia}\t\t|\t{this.Data}\t|\t{this.CalculEnergia()}\t|");
        }
        public SistemaEolic(double velocitatVent)
        {
            VelocitatVent = velocitatVent;
            Data = DateTime.Now;
            TipusEnergia = "Eolic";
        }
        public SistemaEolic() { }
    }
}