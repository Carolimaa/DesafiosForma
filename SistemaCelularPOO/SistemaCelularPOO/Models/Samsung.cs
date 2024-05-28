using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCelular.Models;

public class Samsung : Smartphone
{
    public Samsung(string numero, string modelo, string iMEI, int memoria) : base(numero, modelo, iMEI, memoria)
    {

    }

    public override void InstalarApp(string nomeApp)
    {
        Console.WriteLine($"Instalando o aplicativo {nomeApp} no Samsung");
    }
}
