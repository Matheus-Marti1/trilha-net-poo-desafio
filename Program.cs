using DesafioPOO.Models;

// Implementado

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "+5511999999999", modelo: "Nokia G60 5G", imei: 123456789, memoria: 128);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Facebook");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone");
Smartphone iphone = new Iphone(numero: "+5511888888888", modelo: "iPhone 15", imei: 987654321, memoria: 256);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("WhatsApp");