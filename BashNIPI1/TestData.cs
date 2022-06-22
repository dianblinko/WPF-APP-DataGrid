using System;
using System.ComponentModel;
using System.Linq;

namespace BashNIPI1
{
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum EnumTypeFlowAtDepthL
    {
        [Description("Турбулентный")]
        Turbulent,
        [Description("Ламинарный")]
        Laminar
    }
    public class TestData
    {
        [DisplayName("Название")]
        public string Name { get; set;}

        [DisplayName("Давление, атм.")]
        public double Pressure { get; set; }

        [DisplayName("Температура на глубине L, °С.")]
        public double TemperatureAtDepthL { get; set; }

        [DisplayName("Объемный фактор газа.")]
        public double VolumeFactorGas { get; set; }

        [DisplayName("Объемный фактор нефти.")]
        public double VolumeFactorOil { get; set; }

        [DisplayName("Объемный фактор воды.")]
        public double VolumeFactorWater { get; set; }
        
        [DisplayName("Теплопроводность газа.")]
        public double ThermalConductivityGas { get; set; }

        [DisplayName("Теплопроводность нефти.")]
        public double ThermalConductivityOil { get; set; }

        [DisplayName("Теплопроводность воды.")]
        public double ThermalConductivityWater { get; set; }

        [DisplayName("Теплопроводность смеси.")]
        public double ThermalConductivityMixture { get; set; }

        [DisplayName("Тип потока на глубине L.")]
        public EnumTypeFlowAtDepthL TypeFlowAtDepthL { get; set; } 

        [DisplayName("Дебит смеси с водой.")]
        public double FlorRateMixtureWater { get; set; }

        [DisplayName("Дебит газа в условиях насоса.")]
        public double GasFlowRateUnderPumpConditions { get; set; }

        [DisplayName("Дебит нефти в условиях насоса.")]
        public double OilFlowRateUnderPumpConditions { get; set; }

        [DisplayName("Дебит воды в условиях насоса.")]
        public double WaterFlowRateUnderPumpConditions { get; set; }

        [DisplayName("Расход НГС (Объемный, Стд), м3/сутки.")]
        public double ConsumptionNgsStd { get; set; }

        [DisplayName("Расход НГС (Объемный, Действ), м3/сутки.")]
        public double ConsumptionNgsEffective { get; set; }

        [DisplayName("Массовый Расход воды.")]
        public double MassFlowRateWater { get; set; }

        [DisplayName("Расход НГС (Массовый), кг/с.")]
        public double ConsumptionNgsMassKg { get; set; }

        [DisplayName("Расход НГС (Массовый), Киломоль/сек.")]
        public double ConsumptionNgsMassKilomol { get; set; }

        [DisplayName("Обводненность в долях.")]
        public double WaterContentInFractions { get; set; }

        [DisplayName("Мольная доля газа (композиционный поток).")]
        public double MoleFractionOnGas { get; set; }

        [DisplayName("Объемная доля газа.")]
        public double VolumeFractionfGas { get; set; }

        [DisplayName("Вязкость газа.")]
        public double ViscosityOfGas { get; set; }

        [DisplayName("Вязкость жидкости.")]
        public double LiquidVicosity { get; set; }

        [DisplayName("Вязкость нефти.")]
        public double OilVicosity { get; set; }

        [DisplayName("Вязкость воды.")]
        public double WaterVicosity { get; set; }

        [DisplayName("Вязкость смеси.")]
        public double MixtureVicosity { get; set; }

        [DisplayName("Коэффициент  теплообмена")]
        public double HeatTransferCoefficient { get; set; }
        public int Property30 { get; set; }
        public int Property31 { get; set; }
        public int Property32 { get; set; }
        public int Property33 { get; set; }
        public int Property34 { get; set; }
        public int Property35 { get; set; }
        public int Property36 { get; set; }
        public int Property37 { get; set; }
        public int Property38 { get; set; }
        public int Property39 { get; set; }
        public int Property40 { get; set; }
        public int Property41 { get; set; }
        public int Property42 { get; set; }
        public int Property43 { get; set; }
        public int Property44 { get; set; }
        public int Property45 { get; set; }
        public int Property46 { get; set; }
        public int Property47 { get; set; }
        public int Property48 { get; set; }
        public int Property49 { get; set; }
        public int Property50 { get; set; }
        public int Property51 { get; set; }
        public int Property52 { get; set; }
        public int Property53 { get; set; }
        public int Property54 { get; set; }
        public int Property55 { get; set; }
        public int Property56 { get; set; }
        public int Property57 { get; set; }
        public int Property58 { get; set; }
        public int Property59 { get; set; }
        public int Property60 { get; set; }
        public int Property61 { get; set; }
        public int Property62 { get; set; }
        public int Property63 { get; set; }
        public int Property64 { get; set; }
        public int Property65 { get; set; }
        public int Property66 { get; set; }
        public int Property67 { get; set; }
        public int Property68 { get; set; }
        public int Property69 { get; set; }
        public int Property70 { get; set; }
        public int Property71 { get; set; }
        public int Property72 { get; set; }
        public int Property73 { get; set; }
        public int Property74 { get; set; }
        public int Property75 { get; set; }
        public int Property76 { get; set; }
        public int Property77 { get; set; }
        public int Property78 { get; set; }
        public int Property79 { get; set; }
        public int Property80 { get; set; }
        public int Property81 { get; set; }
        public int Property82 { get; set; }
        public int Property83 { get; set; }
        public int Property84 { get; set; }
        public int Property85 { get; set; }
        public int Property86 { get; set; }
        public int Property87 { get; set; }
        public int Property88 { get; set; }
        public int Property89 { get; set; }
        public int Property90 { get; set; }
        public int Property91 { get; set; }
        public int Property92 { get; set; }
        public int Property93 { get; set; }
        public int Property94 { get; set; }
        public int Property95 { get; set; }
        public int Property96 { get; set; }
        public int Property97 { get; set; }
        public int Property98 { get; set; }
        public int Property99 { get; set; }
        public int Property100 { get; set; }

        public static double GenerateDoubleorNaN(Random rand)
        {
            return rand.Next() % 5 == 0 ? double.NaN : rand.NextDouble();
        }
        public TestData(int i, Random rand)
        {;
            Name = "Имя " + i;
            Pressure = GenerateDoubleorNaN(rand);
            TemperatureAtDepthL = rand.NextDouble();
            VolumeFactorGas = rand.NextDouble();
            VolumeFactorOil = rand.NextDouble();
            VolumeFactorWater = rand.NextDouble();
            ThermalConductivityGas = rand.NextDouble();
            ThermalConductivityOil = rand.NextDouble();
            ThermalConductivityWater = rand.NextDouble();
            ThermalConductivityMixture = rand.NextDouble();
            TypeFlowAtDepthL = (EnumTypeFlowAtDepthL)rand.Next(0, 2);
            FlorRateMixtureWater = rand.NextDouble();
            GasFlowRateUnderPumpConditions = rand.NextDouble();
            OilFlowRateUnderPumpConditions = rand.NextDouble();
            WaterFlowRateUnderPumpConditions = rand.NextDouble();
            ConsumptionNgsStd = rand.NextDouble();
            ConsumptionNgsEffective = rand.NextDouble();
            MassFlowRateWater = rand.NextDouble();
            ConsumptionNgsMassKg = rand.NextDouble();
            ConsumptionNgsMassKilomol = rand.NextDouble();
            WaterContentInFractions = rand.NextDouble();
            MoleFractionOnGas = rand.NextDouble();
            VolumeFractionfGas = rand.NextDouble();
            ViscosityOfGas = rand.NextDouble();
            LiquidVicosity = rand.NextDouble();
            OilVicosity = rand.NextDouble();
            WaterVicosity = rand.NextDouble();
            MixtureVicosity = rand.NextDouble();
            HeatTransferCoefficient = rand.NextDouble();
            Property30 = rand.Next();
            Property31 = rand.Next();
            Property32 = rand.Next();
            Property33 = rand.Next();
            Property34 = rand.Next();
            Property35 = rand.Next();
            Property36 = rand.Next();
            Property37 = rand.Next();
            Property38 = rand.Next();
            Property39 = rand.Next();
            Property40 = rand.Next();
            Property41 = rand.Next();
            Property42 = rand.Next();
            Property43 = rand.Next();
            Property44 = rand.Next();
            Property45 = rand.Next();
            Property46 = rand.Next();
            Property47 = rand.Next();
            Property48 = rand.Next();
            Property49 = rand.Next();
            Property50 = rand.Next();
            Property51 = rand.Next();
            Property52 = rand.Next();
            Property53 = rand.Next();
            Property54 = rand.Next();
            Property55 = rand.Next();
            Property56 = rand.Next();
            Property57 = rand.Next();
            Property58 = rand.Next();
            Property59 = rand.Next();
            Property60 = rand.Next();
            Property61 = rand.Next();
            Property62 = rand.Next();
            Property63 = rand.Next();
            Property64 = rand.Next();
            Property65 = rand.Next();
            Property66 = rand.Next();
            Property67 = rand.Next();
            Property68 = rand.Next();
            Property69 = rand.Next();
            Property70 = rand.Next();
            Property71 = rand.Next();
            Property72 = rand.Next();
            Property73 = rand.Next();
            Property74 = rand.Next();
            Property75 = rand.Next();
            Property76 = rand.Next();
            Property77 = rand.Next();
            Property78 = rand.Next();
            Property79 = rand.Next();
            Property80 = rand.Next();
            Property81 = rand.Next();
            Property82 = rand.Next();
            Property83 = rand.Next();
            Property84 = rand.Next();
            Property85 = rand.Next();
            Property86 = rand.Next();
            Property87 = rand.Next();
            Property88 = rand.Next();
            Property89 = rand.Next();
            Property90 = rand.Next();
            Property91 = rand.Next();
            Property92 = rand.Next();
            Property93 = rand.Next();
            Property94 = rand.Next();
            Property95 = rand.Next();
            Property96 = rand.Next();
            Property97 = rand.Next();
            Property98 = rand.Next();
            Property99 = rand.Next();
            Property100 = rand.Next();
        }

        public static string[] GetAttribute(object value)
        {
            string[] propertis = new string[100];
            int i = 0;
            foreach (var prop in value.GetType().GetProperties())
            {
                var propertyDsplayName = prop.GetCustomAttributes(false)
                    .OfType<DisplayNameAttribute>()
                    .FirstOrDefault();
                if (propertyDsplayName != null)
                {
                    propertis[i++] = propertyDsplayName.DisplayName;
                }
                else
                {
                    propertis[i++] = prop.Name;
                }
            }
            return propertis;
        }
        
    }

    

}
