// See https://aka.ms/new-console-template for more information
using BarcodeLib;
using BarcodeUygulaması;

Barcode barcode = Process.CreateBarcode("66666");
Console.WriteLine(Process.ReadBarcode(barcode));
