using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace tpmodul8_1302213051
{
    internal class CovidConfig
    {
        public string SuhuUnit { get; set; } = "celcius";
        public int BatasHariDemam { get; set; } = 14;
        public string PesanDitolak { get; set; } = "Anda tidak diperbolehkan masuk ke dalam gedung ini";
        public string PesanDiterima { get; set; } = "Anda dipersilakan untuk masuk ke dalam gedung ini";

        public CovidConfig()
        {
            if (File.Exists("covid_config.json"))
            {
                var json = File.ReadAllText("covid config.json");
                var config = JsonConvert.DeserializeObject<CovidConfig>(json);

                SuhuUnit = config.SuhuUnit;
                BatasHariDemam = config.BatasHariDemam;
                PesanDitolak = config.PesanDitolak;
                PesanDiterima = config.PesanDiterima;
            }
        }

        public void UbahSatuan()
        {
            if (SuhuUnit == "celcius")
            {
                SuhuUnit = "fahrenheit";
            }
            else if (SuhuUnit == "fahrenheit")
            {
                SuhuUnit = "celcius";
            }
        }
    }
}
