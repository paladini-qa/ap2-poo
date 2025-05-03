using Modelos;

ConfiguracaoReserva configuracao = new();

Console.WriteLine("\n==CONFIGURAR RESERVAS==\n");
Console.WriteLine("Informe a data mínima (dd/MM/yyyy):");
while (true)
{
  try
  {
    configuracao.DataMinima = Console.ReadLine() ?? string.Empty;
    break;
  }
  catch (Exception e)
  {
    Console.Write($"\nErro: {e.Message}\n\nDigite uma nova data mínima (dd/MM/yyyy):\n");
  }
}

Console.WriteLine("\nInforme a data máxima (dd/MM/yyyy):");
while (true)
{
  try
  {
    configuracao.DataMaxima = Console.ReadLine() ?? string.Empty;
    break;
  }
  catch (Exception e)
  {
    Console.Write($"\nErro: {e.Message}\n\nDigite uma nova data máxima (dd/MM/yyyy):\n");
  }
}

Console.WriteLine("\nInforme a hora mínima (HH:mm):");
while (true)
{
  try
  {
    configuracao.HoraMinima = Console.ReadLine() ?? string.Empty;
    break;
  }
  catch (Exception e)
  {
    Console.Write($"\nErro: {e.Message}\n\nDigite uma nova hora mínima (HH:mm):\n");
  }
}

Console.WriteLine("\nInforme a hora máxima (HH:mm):");
while (true)
{
  try
  {
    configuracao.HoraMaxima = Console.ReadLine() ?? string.Empty;
    break;
  }
  catch (Exception e)
  {
    Console.Write($"\nErro: {e.Message}\n\nDigite uma nova hora máxima (HH:mm):\n");
  }
}

Console.WriteLine("\n==AGENDAR RESERVA==\n");

Reserva reserva = new();

Console.WriteLine("Informe a data da reserva (dd/MM/yyyy):");
while (true)
{
  try
  {
    reserva.DataReserva = Console.ReadLine() ?? string.Empty;

    if (DateTime.Parse(reserva.DataReserva) < DateTime.Parse(configuracao.DataMinima) || DateTime.Parse(reserva.DataReserva) > DateTime.Parse(configuracao.DataMaxima))
    {
      throw new Exception($"A data da reserva deve estar entre {DateTime.Parse(configuracao.DataMinima):dd/MM/yyyy} e {DateTime.Parse(configuracao.DataMaxima):dd/MM/yyyy}.");
    }
    break;
  }
  catch (Exception e)
  {
    Console.Write($"\nErro: {e.Message}\n\nDigite uma nova data da reserva (dd/MM/yyyy):\n");
  }
}

Console.WriteLine("\nInforme a hora da reserva (HH:mm):");
while (true)
{
  try
  {
    reserva.HoraReserva = Console.ReadLine() ?? string.Empty;

    if (!TimeSpan.TryParse(reserva.HoraReserva, out TimeSpan horaReserva))
    {
      throw new Exception($"Hora {reserva.HoraReserva} inválida!");
    }

    if (horaReserva < TimeSpan.Parse(configuracao.HoraMinima) || horaReserva > TimeSpan.Parse(configuracao.HoraMaxima))
    {
      throw new Exception($"A hora da reserva deve estar entre {TimeSpan.Parse(configuracao.HoraMinima):hh\\:mm} e {TimeSpan.Parse(configuracao.HoraMaxima):hh\\:mm}.");
    }

    break;
  }
  catch (Exception e)
  {
    Console.Write($"\nErro: {e.Message}\n\nDigite uma nova hora da reserva (HH:mm):\n");
  }
}

Console.WriteLine("\nInforme a descrição da sala:");
while (true)
{
  try
  {
    reserva.DescricaoSala = Console.ReadLine() ?? string.Empty;
    break;
  }
  catch (Exception e)
  {
    Console.Write($"\nErro: {e.Message}\n\nDigite uma nova descrição da sala:\n");
  }
}

Console.WriteLine("\nInforme a capacidade da sala:");
while (true)
{
  try
  {
    reserva.CapacidadeSala = Console.ReadLine() ?? string.Empty;
    break;
  }
  catch (Exception e)
  {
    Console.Write($"\nErro: {e.Message}\n\nDigite uma nova capacidade da sala:\n");
  }
}

Console.WriteLine("\n==RESERVA AGENDADA COM SUCESSO==\n");
Console.WriteLine($"Data: {DateTime.Parse(reserva.DataReserva):dd/MM/yyyy}");
Console.WriteLine($"Hora: {TimeSpan.Parse(reserva.HoraReserva):hh\\:mm}");
Console.WriteLine($"Descrição da sala: {reserva.DescricaoSala}");
Console.WriteLine($"Capacidade da sala: {reserva.CapacidadeSala}");
