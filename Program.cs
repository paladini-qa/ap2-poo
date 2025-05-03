using Modelos;

Reserva reserva = new();

Console.WriteLine("Informe a data mínima (yyyy-MM-dd):");
DateTime dataMinima = DateTime.Parse(Console.ReadLine());

Console.WriteLine("Informe a data máxima (yyyy-MM-dd):");
DateTime dataMaxima = DateTime.Parse(Console.ReadLine());

Console.WriteLine("Informe a hora mínima (HH:mm):");
TimeSpan horaMinima = TimeSpan.Parse(Console.ReadLine());

Console.WriteLine("Informe a hora máxima (HH:mm):");
TimeSpan horaMaxima = TimeSpan.Parse(Console.ReadLine());

// Criar a instância da configuração
ConfiguracaoReserva configuracao = new()
{
  DataMinima = dataMinima,
  DataMaxima = dataMaxima,
  HoraMinima = horaMinima,
  HoraMaxima = horaMaxima
};

Console.WriteLine("Informe a data da reserva (yyyy-MM-dd):");
DateTime dataReserva = DateTime.Parse(Console.ReadLine());

Console.WriteLine("Informe a hora da reserva (HH:mm):");
TimeSpan horaReserva = TimeSpan.Parse(Console.ReadLine());

Console.WriteLine("Informe a descrição da sala:");
string descricaoSala = Console.ReadLine();

Console.WriteLine("Informe a capacidade da sala:");
int capacidadeSala = int.Parse(Console.ReadLine());

// Criar a instância da reserva, validando as informações conforme a configuração
if (dataReserva < configuracao.DataMinima || dataReserva > configuracao.DataMaxima)
{
  Console.WriteLine("Erro: A data da reserva está fora do intervalo permitido.");
}
else if (horaReserva < configuracao.HoraMinima || horaReserva > configuracao.HoraMaxima)
{
  Console.WriteLine("Erro: A hora da reserva está fora do intervalo permitido.");
}
else
{
  reserva.Data = dataReserva;
  reserva.Hora = horaReserva;
  reserva.DescricaoSala = descricaoSala;
  reserva.CapacidadeSala = capacidadeSala;

  Console.WriteLine("Reserva criada com sucesso!");
}