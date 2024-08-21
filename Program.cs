using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Celular Nokia:");
Smartphone nokia = new Nokia("9999", "A20", "1234", 8);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("Celular Iphone:");
Smartphone iphone = new Iphone("1234", "15 PRO", "3213", 256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");