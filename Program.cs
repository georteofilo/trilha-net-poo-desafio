using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smarthphone Nokia: ");
Smartphone nokia = new Nokia(numero: "1234567899", modelo: "Modelo 1", imei: "111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smarthphone IPhone: ");
Smartphone iphone = new Iphone(numero: "999998866", modelo: "Modelo Plus", imei: "123334455", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");
