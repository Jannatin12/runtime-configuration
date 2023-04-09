using tpmodul8_1302213051;

class Program
{
    static void Main(string[] args)
    {
        var config = new CovidConfig();

        Console.Write($"Berapa suhu badan anda saat ini? Dalam nilai {config.SuhuUnit}? ");
        var inputSuhu = double.Parse(Console.ReadLine());

        Console.Write("Berapa hari yang lalu (perkiraan) Anda terakhir memiliki gejala demam? ");
        var inputHariDemam = int.Parse(Console.ReadLine());

        bool suhuValid, hariDemamValid;
        if (config.SuhuUnit == "celcius")
        {
            suhuValid = (inputSuhu >= 36.5 && inputSuhu <= 37.5);
        }
        else
        {
            suhuValid = (inputSuhu >= 97.7 && inputSuhu <= 99.5);
        }

        hariDemamValid = (inputHariDemam < config.BatasHariDemam);
        if (suhuValid && hariDemamValid)
        {
            Console.WriteLine(config.PesanDiterima);
        }
        else
        {
            Console.WriteLine(config.PesanDitolak);
        }

        config.UbahSatuan();

        Console.WriteLine($"Satuan suhu saat ini adalah {config.SuhuUnit}");
    }
}