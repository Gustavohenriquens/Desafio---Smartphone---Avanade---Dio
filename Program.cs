using projeto_dio.Models;

Console.WriteLine("Nokia :");
Smartphone nokia = new Nokia(numero: "8199554477" , modelo: "Modelo 1", imei: "11111111", memoria: 64);
nokia.Apresentar();
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");


Console.WriteLine("\n");


Console.WriteLine("Iphone :");
Smartphone iphone = new Iphone(numero: "8199884455" , modelo: "Modelo 2", imei: "2222111", memoria: 124);
iphone.Apresentar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Linkedin");