using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia("123456789", "Nokia 3310", "123456789012345", 64);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\nSmartphone iPhone:");
Smartphone iphone = new Iphone("987654321", "iPhone 12", "987654321098765", 128);
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");


Console.WriteLine("\n----------------------------♡----------------------------");