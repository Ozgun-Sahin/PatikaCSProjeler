using BarcodeLib;
using IronBarCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarcodeUygulaması
{
    public class Process
    {
        static TYPE type = TYPE.PHARMACODE;

        public static Barcode CreateBarcode(string data)
        {
            Barcode barcode = new Barcode(data, type);

            barcode.Encode(type, data);
            barcode.SaveImage(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\barcode.png", BarcodeLib.SaveTypes.PNG);
            Console.WriteLine("Barcode Generated -> {0}", data);
            return barcode;
        }

        public static string ReadBarcode(Barcode barcode)
        {
            return "Barcode Value = " + barcode.RawData + "\n";
        }


    }
}
