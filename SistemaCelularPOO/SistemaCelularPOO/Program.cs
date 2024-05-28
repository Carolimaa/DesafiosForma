using SistemaCelular.Models;

Console.WriteLine("Smartphone Samsung:");
Smartphone samsung = new Samsung(numero: "654321", modelo: "Modelo 1", iMEI: "444444444", memoria: 32);
samsung.Ligar();
samsung.InstalarApp("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "4987234", modelo: "Modelo 2", iMEI: "555555555", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarApp("Telegram");