using DesafioPOO.Models;

Console.WriteLine("Iphone:");
Iphone iphone = new Iphone(numero:"123456", modelo:"Modelo 1", imei:"11111111", memoria:128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("X");

Console.WriteLine("\n");

Console.WriteLine("Nokia:");
Nokia nokia = new Nokia(numero: "78910", modelo:"Modelo 2", imei:"22222222", memoria:64);
nokia.Ligar();
nokia.InstalarAplicativo("Facebook");
// TODO: Realizar os testes com as classes Nokia e Iphone 
// *FEITO!*