using System.Text;
using HospedagemHotel.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Caroline", sobrenome: "Lima");
Pessoa p2 = new Pessoa(nome: "Carol");

hospedes.Add(p1);
hospedes.Add(p2);

// Cria a suíte
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 80);

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new Reserva(diasReservados: 3);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Nome dos Hóspedes:{p1.NomeCompleto}, {p2.NomeCompleto}");
Console.WriteLine($"Quantidade de Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Suíte Escolhida: {suite.TipoSuite}");
Console.WriteLine($"Dias Reservados: {reserva.DiasReservados}");
Console.WriteLine($"Valor Total da diária: {reserva.CalcularValorDiaria()}".ToUpper());
Console.ReadLine();
Console.WriteLine("Obrigado, Volte Sempre!");