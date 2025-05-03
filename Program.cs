using Modelos;

ConfiguracaoReserva configuracao = new();

Console.WriteLine("==CONFIGURAR RESERVAS==");
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
    Console.Write($"Erro: {e.Message}\nDigite uma nova data mínima (dd/MM/yyyy): ");
  }
}

Console.WriteLine("Informe a data máxima (dd/MM/yyyy):");
while (true)
{
  try
  {
    configuracao.DataMaxima = Console.ReadLine() ?? string.Empty;
    break;
  }
  catch (Exception e)
  {
    Console.Write($"Erro: {e.Message}\nDigite uma nova data máxima (dd/MM/yyyy): ");
  }
}

Console.WriteLine("Informe a hora mínima (HH:mm):");
while (true)
{
  try
  {
    configuracao.HoraMinima = Console.ReadLine() ?? string.Empty;
    break;
  }
  catch (Exception e)
  {
    Console.Write($"Erro: {e.Message}\nDigite uma nova hora mínima (HH:mm): ");
  }
}

Console.WriteLine("Informe a hora máxima (HH:mm):");
while (true)
{
  try
  {
    configuracao.HoraMaxima = Console.ReadLine() ?? string.Empty;
    break;
  }
  catch (Exception e)
  {
    Console.Write($"Erro: {e.Message}\nDigite uma nova hora máxima (HH:mm): ");
  }
}

Console.WriteLine("==AGENDAR RESERVA==");

Reserva reserva = new();

Console.WriteLine("Informe a data da reserva (dd/MM/yyyy):");
while (true)
{
  try
  {
    reserva.DataReserva = Console.ReadLine() ?? string.Empty;

    if (DateTime.Parse(reserva.DataReserva) < DateTime.Parse(configuracao.DataMinima) || DateTime.Parse(reserva.DataReserva) > DateTime.Parse(configuracao.DataMaxima))
    {
      throw new Exception($"A data da reserva deve estar entre {configuracao.DataMinima} e {configuracao.DataMaxima}.");
    }
    break;
  }
  catch (Exception e)
  {
    Console.Write($"Erro: {e.Message}\nDigite uma nova data da reserva (dd/MM/yyyy): ");
  }
}

Console.WriteLine("Informe a hora da reserva (HH:mm):");
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
      throw new Exception($"A hora da reserva deve estar entre {configuracao.HoraMinima} e {configuracao.HoraMaxima}.");
    }

    break;
  }
  catch (Exception e)
  {
    Console.Write($"Erro: {e.Message}\nDigite uma nova hora da reserva (HH:mm): ");
  }
}

Console.WriteLine("Informe a descrição da sala:");
while (true)
{
  try
  {
    reserva.DescricaoSala = Console.ReadLine() ?? string.Empty;
    break;
  }
  catch (Exception e)
  {
    Console.Write($"Erro: {e.Message}\nDigite uma nova descrição da sala: ");
  }
}

Console.WriteLine("Informe a capacidade da sala:");
while (true)
{
  try
  {
    reserva.CapacidadeSala = Console.ReadLine() ?? string.Empty;
    break;
  }
  catch (Exception e)
  {
    Console.Write($"Erro: {e.Message}\nDigite uma nova capacidade da sala: ");
  }
}

Console.WriteLine("Reserva agendada com sucesso!");
Console.WriteLine($"Data: {reserva.DataReserva}");
Console.WriteLine($"Hora: {reserva.HoraReserva}");
Console.WriteLine($"Descrição da sala: {reserva.DescricaoSala}");
Console.WriteLine($"Capacidade da sala: {reserva.CapacidadeSala}");
