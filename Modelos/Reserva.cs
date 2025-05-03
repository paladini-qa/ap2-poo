namespace Modelos;

public class Reserva
{
  private DateTime _dataReserva;
  private TimeSpan _horaReserva;
  private String? _descricaoSala;
  private String? _capacidadeSala;

  public String DataReserva
  {
    get { return _dataReserva.ToString(); }
    set { _dataReserva = RegistrarData(value); }
  }
  public String HoraReserva
  {
    get { return _horaReserva.ToString(); }
    set { _horaReserva = RegistrarHora(value); }
  }
  public String? DescricaoSala
  {
    get { return _descricaoSala; }
    set { _descricaoSala = value; }
  }
  public String? CapacidadeSala
  {
    get { return _capacidadeSala; }
    set
    {
      _capacidadeSala = RegistrarCapacidade(value);
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
  private String RegistrarCapacidade(string capacidade)
  {
    if (!int.TryParse(capacidade, out int capacidadeInt) || capacidadeInt <= 0 || capacidadeInt >= 40)
    {
      throw new Exception($"Capacidade da sala deve ser um número maior que 0 e menor que 40!");
    }
    return capacidade.ToString();
  }
}