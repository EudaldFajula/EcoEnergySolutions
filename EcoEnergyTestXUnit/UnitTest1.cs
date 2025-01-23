using EcoEnergySolutionsProgram;

namespace EcoEnergyTestXUnit
{
    public class EnergiaSolar
    {
        [Fact]
        //Dona false
        public void EnergiaSolarMenysUn()
        {
            //Arrange i Act
            SistemaEnergia result = new SistemaSolar(-1);
            //Assert
            Assert.False(result.ValidarDades());
        }
        [Fact]
        //Dona false
        public void EnergiaSolarUn()
        {
            //Arrange i Act
            SistemaEnergia result = new SistemaSolar(1);
            //Assert
            Assert.False(result.ValidarDades());
        }
        [Fact]
        //Dona true
        public void EnergiaSolarDos()
        {
            //Arrange i Act
            SistemaEnergia result = new SistemaSolar(2);
            //Assert
            Assert.True(result.ValidarDades());
        }
    }
    public class EnergiaEolica
    {
        [Fact]
        //Dona true
        public void EnergiaEolicaCinc()
        {
            //Arrange i Act
            SistemaEnergia result = new SistemaEolic(5);
            //Assert
            Assert.True(result.ValidarDades());
        }
        [Fact]
        //Dona true
        public void EnergiaEolicaSis()
        {
            //Arrange i Act
            SistemaEnergia result = new SistemaEolic(6);
            //Assert
            Assert.True(result.ValidarDades());
        }
        [Fact]
        //Dona false
        public void EnergiaEolicaQuatre()
        {
            //Arrange i Act
            SistemaEnergia result = new SistemaEolic(4);
            //Assert
            Assert.False(result.ValidarDades());
        }
    }
    public class EnergiaHidroelectrica
    {
        [Fact]
        //Dona true
        public void EnergiaHidroVint()
        {
            //Arrange i Act
            SistemaEnergia result = new SistemaHidroelectric(20);
            //Assert
            Assert.True(result.ValidarDades());
        }
        [Fact]
        //Dona true
        public void EnergiaHidroVintIUn()
        {
            //Arrange i Act
            SistemaEnergia result = new SistemaHidroelectric(21);
            //Assert
            Assert.True(result.ValidarDades());

        }
        [Fact]
        //Dona false
        public void EnergiaHidroDinou()
        {
            //Arrange i Act
            SistemaEnergia result = new SistemaHidroelectric(19);
            //Assert
            Assert.False(result.ValidarDades());
        }
    }
}