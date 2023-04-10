// See https://aka.ms/new-console-template for more information

using System;
using System.IO;
using Newtonsoft.Json;
using modul8_1302210113;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

class Program
{
    private static string json;

    static void Main()
    {
        try
        {
            json = File.ReadAllText(@"C:\Users\Yakup Asmaidy\OneDrive\Dokumen\Semester_4\Kontruksi Perangkat Lunak\modul8_1302210113\modul8_1302210113\bank_transfer_config.json");

        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("");
        }
        BankTransferConfig config = JsonConvert.DeserializeObject<BankTransferConfig>(json);
        config.translate();

        int angka;
        
        while (!int.TryParse(Console.ReadLine(), out angka))
        {
            Console.Write("Masukkan invalid, ulangi : ");

        }

        
        if(angka <= config.threshold)
        {
            Console.WriteLine($"Total Biaya Transfer  {config.low_fee}" );
        }

        else if(angka >= config.threshold)
        {
            Console.WriteLine($"Total Biaya Transfer  {config.high_fee}");
        }
        


        /*
        if (config.threshold <= angka)
        {

        }
        */

        /*
        if (config.lang == "en")
        {
            Console.WriteLine("P");
            //###############
        }
        */




    }
}

