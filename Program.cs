using DesafioPOO.Models;




Console.WriteLine("Testes para o Nokia");

Nokia tijolo = new Nokia(64, "+55 11 91234-5678", "Nokia 6.2", "354678109876543");
tijolo.Ligar();
tijolo.ReceberLigacao();
tijolo.InstalarAplicativo("Spotfy");

Console.WriteLine("Testes para o Iphone");

Iphone maca = new Iphone(128 , "+55 21 98765-4321" , "iPhone 13 Pro" , "358234098765432");
maca.Ligar();
maca.ReceberLigacao();
maca.InstalarAplicativo("Subway Surf");