using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "12345678910",modelo:"Modelo 1", imei: "111111111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone Iphone = new Iphone(numero: "12345678910",modelo:"Modelo 1", imei: "111111111111111", memoria: 128);
Iphone.ReceberLigacao();
Iphone.InstalarAplicativo("Instagram");