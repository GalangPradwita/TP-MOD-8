namespace tpmodul8_1302223015
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var covidConfig = new CovidConfig();

            Console.WriteLine("Pilih satuan suhu yang Anda inginkan:\n 1. Celcius \n 2. Fahrenheit ");
            var satuan_suhu = Console.ReadLine().ToLower();

            if (satuan_suhu == "2")
            {
                covidConfig.UbahSatuan();
            }

            Console.WriteLine($"Berapa suhu badan anda saat ini? Dalam nilai {covidConfig.satuan_suhu}");
            var suhu_badan = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Berapa hari yang lalu (perkiraan) anda terakhir memiliki gejala deman?");
            var hari_deman = Convert.ToInt32(Console.ReadLine());

            var valid_suhu = covidConfig.satuan_suhu == "celcius" ? suhu_badan >= 36.5 && suhu_badan <= 37.5 : suhu_badan >= 97.7 && suhu_badan <= 99.5;
            var valid_hari = hari_deman < covidConfig.batas_hari_deman;

            if (valid_suhu && valid_hari)
            {
                Console.WriteLine(covidConfig.pesan_diterima);
            }
            else
            {
                Console.WriteLine(covidConfig.pesan_ditolak);
            }

            covidConfig.UbahSatuan();
        }
    }
}
