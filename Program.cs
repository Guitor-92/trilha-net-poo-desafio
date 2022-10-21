using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Iphone");
Smartphone iphone = new Iphone(numero: "99999-9999", modelo: "5c", imei: "123456-01-010000-1", memoria: 16);
iphone.Ligar();
iphone.InstalarAplicativo("Digital Innovation One");

Console.WriteLine("----------------------------");

Console.WriteLine("Telefone Nokia");
Smartphone nokia = new Nokia(numero: "99999-9999", modelo: "Lumia", imei: "123456-01-010000-1", memoria: 8);
nokia.Ligar();
nokia.InstalarAplicativo("Dio ME");