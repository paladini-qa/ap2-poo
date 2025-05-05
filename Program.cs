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

string dataReserva = string.Empty;
string horaReserva = string.Empty;
string descricaoSala = string.Empty;
string capacidadeSala = string.Empty;

Console.WriteLine("Informe a data da reserva (dd/MM/yyyy):");
while (true)
{
  try
  {
    dataReserva = DateTime.Parse(Console.ReadLine() ?? string.Empty).ToString("dd/MM/yyyy");

    if (DateTime.Parse(dataReserva) < DateTime.Parse(configuracao.DataMinima) || DateTime.Parse(dataReserva) > DateTime.Parse(configuracao.DataMaxima))
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
    horaReserva = Console.ReadLine() ?? string.Empty;

    if (!TimeSpan.TryParse(horaReserva, out TimeSpan horaReservaParsed))
    {
      throw new Exception($"Hora {horaReserva} inválida!");
    }

    if (horaReservaParsed < TimeSpan.Parse(configuracao.HoraMinima) || horaReservaParsed > TimeSpan.Parse(configuracao.HoraMaxima))
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
    descricaoSala = Console.ReadLine() ?? string.Empty;
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
    capacidadeSala = Console.ReadLine() ?? string.Empty;
    break;
  }
  catch (Exception e)
  {
    Console.Write($"\nErro: {e.Message}\n\nDigite uma nova capacidade da sala:\n");
  }
}

try
{
  Reserva reserva = new(dataReserva, horaReserva, descricaoSala, capacidadeSala);
  Console.WriteLine(reserva.ToString());
}
catch (Exception e)
{
  Console.WriteLine($"\nErro ao criar reserva: {e.Message}");
}