using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
        // Testando com Nokia
        Smartphone nokia = new Nokia(numero: "123456", modelo: "Nokia 3310", imei: "111111111", memoria: 64);
        nokia.Ligar();
        nokia.InstalarAplicativo("WhatsApp");

        Console.WriteLine();

        // Testando com iPhone
        Smartphone iphone = new Iphone(numero: "987654", modelo: "iPhone 13", imei: "222222222", memoria: 128);
        iphone.Ligar();
        iphone.InstalarAplicativo("Instagram");
    }
}
