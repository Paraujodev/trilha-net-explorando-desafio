using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Hóspede 1");
Pessoa p2 = new Pessoa(nome: "Hóspede 2");

hospedes.Add(p1);
hospedes.Add(p2);

Console.WriteLine("Qual a capacidade da Suite?");
int capacidade = int.Parse(Console.ReadLine());

Console.WriteLine("Qual o Valor da Diaria?");
int valorDiaria = int.Parse(Console.ReadLine());

// Cria a suíte
Suite suite = new Suite(tipoSuite: "Premium", capacidade, valorDiaria);

// Cria uma nova reserva, passando a suíte e os hóspedes
Console.WriteLine("Quantos dias vai reservar?");
int diasReservados = int.Parse(Console.ReadLine());
Reserva reserva = new Reserva(diasReservados);

reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);


// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Quantidade de Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor total das diária: R${reserva.CalcularValorDiaria()} Reais");