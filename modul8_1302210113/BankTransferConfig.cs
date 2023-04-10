using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul8_1302210113
{
    internal class BankTransferConfig
    {
        public string lang { get; set; } = "en";

        public int threshold { get; set; } = 25000000;

        public int low_fee { get; set; } = 6500;

        public int high_fee { get; set; } = 15000;

        //public string methods { get; set; } = "RTO (real-time)", "SKN", "RTGS", "BI FAST"]; //kurung siku blom

        public string en { get; set; } = "yes";

        public string id { get; set; } = "ya";

        public void translate()
        {
            if(lang == "en")
            {
                this.lang = "Please insert the amount of money to transfer: ";
                
            }
            else if(lang == "id")
            {
                lang = "Masukkan jumlah uang yang akan di transfer: ";
            }
            Console.WriteLine(lang);
        }
    }
}
