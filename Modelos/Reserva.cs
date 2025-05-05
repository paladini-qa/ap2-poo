namespace Modelos;

public class Reserva
{
  private DateTime _dataReserva;
  private TimeSpan _horaReserva;
  private string? _descricaoSala;
  private string? _capacidadeSala;

  public string DataReserva
  {
    get { return _dataReserva.ToString(); }
    set { _dataReserva = RegistrarData(value); }
  }
  public string HoraReserva
  {
    get { return _horaReserva.ToString(); }
    set { _horaReserva = RegistrarHora(value); }
  }
  public string? DescricaoSala
  {
    get { return _descricaoSala; }
    set { _descricaoSala = value is not null ? RegistrarDescricao(value) : throw new ArgumentNullException(nameof(value), "Descrição da sala não pode ser nula!"); }
  }
  public string? CapacidadeSala
  {
    get { return _capacidadeSala; }
    set
    {
      _capacidadeSala = value is not null ? RegistrarCapacidade(value) : throw new ArgumentNullException(nameof(value), "Capacidade da sala não pode ser nula!");
    }
  }
  public List<string> ErrosDeValidacao = new List<string>();
  public Reserva(string dataReserva, string horaReserva, string descricaoSala, string capacidadeSala)
  {
    DataReserva = dataReserva;
    HoraReserva = horaReserva;
    DescricaoSala = descricaoSala;
    CapacidadeSala = capacidadeSala;
    if (!ValidarReserva())
    {
      throw new ArgumentException(string.Join("\n", ErrosDeValidacao));
    }
  }
  private DateTime RegistrarData(string data)
  {
    if (!DateTime.TryParseExact(data,
                   "dd/MM/yyyy",
                   System.Globalization.CultureInfo.GetCultureInfo("pt-BR"),
                   System.Globalization.DateTimeStyles.None,
                   out DateTime _data))
    {
      throw new Exception($"Data {data} Inválida!");
    }
    return _data;
  }
  private TimeSpan RegistrarHora(string hora)
  {
    if (!TimeSpan.TryParse(hora, out TimeSpan _hora))
    {
      throw new Exception($"Hora {hora} Inválida!");
    }
    return _hora;
  }
  private string RegistrarDescricao(string descricao)
  {
    if (descricao.Length < 5 || descricao.Length > 50)
    {
      throw new Exception($"Descrição da sala deve ter entre 5 e 50 caracteres!");
    }
    return descricao.ToString();
  }
  private string RegistrarCapacidade(string capacidade)
  {
    if (!int.TryParse(capacidade, out int capacidadeInt) || capacidadeInt <= 0 || capacidadeInt >= 40)
    {
      throw new Exception($"Capacidade da sala deve ser um número maior que 0 e menor que 40!");
    }
    return capacidade.ToString();
  }
  public bool ValidarReserva()
  {
    ErrosDeValidacao.Clear();

    if (string.IsNullOrEmpty(_descricaoSala))
    {
      ErrosDeValidacao.Add("Descrição da sala não pode ser nula ou vazia!");
    }
    else if (_descricaoSala.Length < 5 || _descricaoSala.Length > 50)
    {
      ErrosDeValidacao.Add("Descrição da sala deve ter entre 5 e 50 caracteres!");
    }

    if (string.IsNullOrEmpty(_capacidadeSala))
    {
      ErrosDeValidacao.Add("Capacidade da sala não pode ser nula ou vazia!");
    }
    else if (!int.TryParse(_capacidadeSala, out int capacidadeInt) || capacidadeInt <= 0 || capacidadeInt >= 40)
    {
      ErrosDeValidacao.Add("Capacidade da sala deve ser um número maior que 0 e menor que 40!");
    }

    if (!DateTime.TryParseExact(_dataReserva.ToString("dd/MM/yyyy"), "dd/MM/yyyy", System.Globalization.CultureInfo.GetCultureInfo("pt-BR"), System.Globalization.DateTimeStyles.None, out _))
    {
      ErrosDeValidacao.Add("Data da reserva inválida!");
    }

    if (!TimeSpan.TryParse(_horaReserva.ToString(), out _))
    {
      ErrosDeValidacao.Add("Hora da reserva inválida!");
    }

    return !ErrosDeValidacao.Any();
  }
  public override string ToString()
  {
    return $"Data: {DataReserva}, Hora: {HoraReserva}, Descrição da sala: {DescricaoSala}, Capacidade da sala: {CapacidadeSala}";
  }
}