using DesafioPessoa.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Globalization;
using System;

Pessoa p1 = new Pessoa("Caroline", "Lima", new DateTime(2005, 3, 9), 1.62m);
p1.Apresentar();


//Requisitos:
//1 - Nome, data de nascimento, altura
//2 - Métodos públicos necessários para sets e gets
//3 - Método para imprimir todos dados de uma pessoa 
//4 - Método para calcular a idade da pessoa 