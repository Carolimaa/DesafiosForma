using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPessoa.Models
{
    public class Pessoa
    {
        public Pessoa(string nome, string sobrenome, DateTime dataNascimento, decimal altura)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            DataNascimento = dataNascimento;
            Altura = altura;
        }

        private string _nome;
        private string _sobrenome;
        private DateTime _dataNascimento;
        private decimal _altura;

        public string Nome
        {
            get => _nome.ToUpper();

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }
                _nome = value;
            }
        }

        public string Sobrenome
        {
            get => _sobrenome.ToUpper();

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("O sobrenome não pode ser vazio");
                }
                _sobrenome = value;
            }
        }

        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();

        public DateTime DataNascimento
        {
            get => _dataNascimento;
            set
            {
                if (value >= DateTime.Now)
                {
                    throw new ArgumentException("A data de nascimento deve ser anterior à data atual");
                }
                _dataNascimento = value;
            }
        }

        public int CalcularIdade()
        {
            DateTime anoAtual = DateTime.Today;
            int idade = anoAtual.Year - DataNascimento.Year;
            if (DataNascimento.Date > anoAtual.AddYears(-idade)) idade--;
            return idade;
        }

        public decimal Altura
        {
            get => _altura;
            set => _altura = value;
        }

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {NomeCompleto}, Data de Nascimento: {DataNascimento.ToShortDateString()}, Idade: {CalcularIdade()}, Altura: {Altura}");
            Console.ReadLine();
        }
    }
}