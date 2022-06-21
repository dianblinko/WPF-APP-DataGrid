using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BashNIPI1
{
    public class TableGenerator
    {
        private static Random rand = new Random(); 
        public static double GenerateDoubleorNaN()
        {
            return rand.Next() % 5 == 0 ? double.NaN : rand.NextDouble();
        }
        public static List<TestData> GenerateTable()
        {
            List<TestData> testDataList = new List<TestData>();
            for (int i = 0; i < 100; i++)
            {
                testDataList.Add(new TestData()
                {
                    Name = "Имя " + i,
                    Pressure = GenerateDoubleorNaN(),
                    TemperatureAtDepthL = rand.NextDouble(),
                    VolumeFactorGas = rand.NextDouble(),
                    VolumeFactorOil = rand.NextDouble(),
                    VolumeFactorWater = rand.NextDouble(),
                    ThermalConductivityGas = rand.NextDouble(),
                    ThermalConductivityOil = rand.NextDouble(),
                    ThermalConductivityWater = rand.NextDouble(),
                    ThermalConductivityMixture = rand.NextDouble(),
                    TypeFlowAtDepthL = (EnumTypeFlowAtDepthL)rand.Next(0,2),
                    FlorRateMixtureWater = rand.NextDouble(),
                    GasFlowRateUnderPumpConditions = rand.NextDouble(),
                    OilFlowRateUnderPumpConditions = rand.NextDouble(),
                    WaterFlowRateUnderPumpConditions = rand.NextDouble(),
                    ConsumptionNgsStd = rand.NextDouble(),
                    ConsumptionNgsEffective = rand.NextDouble(),
                    MassFlowRateWater = rand.NextDouble(),
                    ConsumptionNgsMassKg = rand.NextDouble(),
                    ConsumptionNgsMassKilomol = rand.NextDouble(),
                    WaterContentInFractions = rand.NextDouble(),
                    MoleFractionOnGas = rand.NextDouble(),
                    VolumeFractionfGas = rand.NextDouble(),
                    ViscosityOfGas = rand.NextDouble(),
                    LiquidVicosity = rand.NextDouble(),
                    OilVicosity = rand.NextDouble(),
                    WaterVicosity = rand.NextDouble(),
                    MixtureVicosity = rand.NextDouble(),
                    HeatTransferCoefficient = rand.NextDouble(),
                    Property1 = rand.Next(),
                    Property2 = rand.Next(),   
                    Property3 = rand.Next(),
                    Property4 = rand.Next(),
                    Property5 = rand.Next(),
                    Property6 = rand.Next(),
                    Property7 = rand.Next(),
                    Property8 = rand.Next(),
                    Property9 = rand.Next(),
                    Property10 = rand.Next(),
                    Property11 = rand.Next(),
                    Property12 = rand.Next(),
                    Property13 = rand.Next(),
                    Property14 = rand.Next(),
                    Property15 = rand.Next(),
                    Property16 = rand.Next(),
                    Property17 = rand.Next(),
                    Property18 = rand.Next(),
                    Property19 = rand.Next(),
                    Property20 = rand.Next(),
                    Property21 = rand.Next(),
                    Property22 = rand.Next(),
                    Property23 = rand.Next(),
                    Property24 = rand.Next(),
                    Property25 = rand.Next(),
                    Property26 = rand.Next(),
                    Property27 = rand.Next(),
                    Property28 = rand.Next(),
                    Property29 = rand.Next(),
                    Property30 = rand.Next(),
                    Property31 = rand.Next(),
                    Property32 = rand.Next(),
                    Property33 = rand.Next(),
                    Property34 = rand.Next(),
                    Property35 = rand.Next(),
                    Property36 = rand.Next(),
                    Property37 = rand.Next(),
                    Property38 = rand.Next(),
                    Property39 = rand.Next(),
                    Property40 = rand.Next(),
                    Property41 = rand.Next(),
                    Property42 = rand.Next(),
                    Property43 = rand.Next(),
                    Property44 = rand.Next(),
                    Property45 = rand.Next(),
                    Property46 = rand.Next(),
                    Property47 = rand.Next(),
                    Property48 = rand.Next(),
                    Property49 = rand.Next(),
                    Property50 = rand.Next(),
                    Property51 = rand.Next(),
                    Property52 = rand.Next(),
                    Property53 = rand.Next(),
                    Property54 = rand.Next(),
                    Property55 = rand.Next(),
                    Property56 = rand.Next(),
                    Property57 = rand.Next(),
                    Property58 = rand.Next(),
                    Property59 = rand.Next(),
                    Property60 = rand.Next(),
                    Property61 = rand.Next(),
                    Property62 = rand.Next(),
                    Property63 = rand.Next(),
                    Property64 = rand.Next(),
                    Property65 = rand.Next(),
                    Property66 = rand.Next(),
                    Property67 = rand.Next(),
                    Property68 = rand.Next(),
                    Property69 = rand.Next(),
                    Property70 = rand.Next(),
                    Property71 = rand.Next()
                });
            }

            return testDataList;
        }
    }
}
