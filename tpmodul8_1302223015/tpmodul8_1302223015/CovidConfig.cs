using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace tpmodul8_1302223015
{
    internal class CovidConfig
    {
        public string satuan_suhu { get; set; }
        public int batas_hari_deman { get; set; }
        public string pesan_ditolak { get; set; }
        public string pesan_diterima { get; set; }

        public CovidConfig()
        {
            if (File.Exists("covid_config.json"))
            {
                var configJson = File.ReadAllText("D:\\Telkom University\\SEMESTER 4\\KONTRUKSI PERANGKAT LUNAK\\TUGAS\\WEEK 8\\tpmodul8_1302223015\\tpmodul8_1302223015\\covid_config.json");
                var config = JsonConvert.DeserializeObject<CovidConfig>(configJson);
                this.satuan_suhu = config.satuan_suhu;
                this.batas_hari_deman = config.batas_hari_deman;
                this.pesan_ditolak = config.pesan_ditolak;
                this.pesan_diterima = config.pesan_diterima;
            }
            else
            {
                this.satuan_suhu = "celcius";
                this.batas_hari_deman = 14;
                this.pesan_ditolak = "Anda tidak diperbolehkan masuk ke dalam gedung ini";
                this.pesan_diterima = "Anda dipersilahkan untuk masuk ke dalam gedung ini";
            }
        }

        public void UbahSatuan()
        {
            this.satuan_suhu = this.satuan_suhu == "celcius" ? "fahrenheit" : "celcius";
        }

        internal void ReadJSON()
        {
            throw new NotImplementedException();
        }
    }


}

