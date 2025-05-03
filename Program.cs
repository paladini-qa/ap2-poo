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