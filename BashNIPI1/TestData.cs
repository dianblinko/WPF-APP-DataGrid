using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BashNIPI1
{
    public enum EnumTypeFlowAtDepthL
    {
        [Description("Турбулентный")]
        turbulent,
        [Description("Ламинарный")]
        laminar
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
        public EnumTypeFlowAtDepthL TypeFlowAtDepthL { get; set; } //// ENUM ламинарный турбулентный

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
        
        public int Property1 { get; set; }
        public int Property2 { get; set; }
        public int Property3 { get; set; }
        public int Property4 { get; set; }
        public int Property5 { get; set; }
        public int Property6 { get; set; }
        public int Property7 { get; set; }
        public int Property8 { get; set; }
        public int Property9 { get; set; }
        public int Property10 { get; set; }
        public int Property11 { get; set; }
        public int Property12 { get; set; }
        public int Property13 { get; set; }
        public int Property14 { get; set; }
        public int Property15 { get; set; }
        public int Property16 { get; set; }
        public int Property17 { get; set; }
        public int Property18 { get; set; }
        public int Property19 { get; set; }
        public int Property20 { get; set; }
        public int Property21 { get; set; }
        public int Property22 { get; set; }
        public int Property23 { get; set; }
        public int Property24 { get; set; }
        public int Property25 { get; set; }
        public int Property26 { get; set; }
        public int Property27 { get; set; }
        public int Property28 { get; set; }
        public int Property29 { get; set; }
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
    }

}
