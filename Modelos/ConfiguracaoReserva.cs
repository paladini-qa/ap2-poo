namespace Modelos;

public class ConfiguracaoReserva
{
  private DateTime _dataMinima;
  private DateTime _dataMaxima;
  private TimeSpan _horaMinima;
  private TimeSpan _horaMaxima;
  public string DataMinima
  {
    get { return _dataMinima.ToString(); }
    set { _dataMinima = ValidarDataInformada(value); }
  }
  public string DataMaxima
  {
    get { return _dataMaxima.ToString(); }
    set
    {
      _dataMaxima = ValidarDataInformada(value);
      ValidarDataMaximaMenorQueMinima();
    }
  }
  public string HoraMinima
  {
    get { return _horaMinima.ToString(); }
    set
    {
      _horaMinima = ValidarHoraInformada(value);
    }
  }
  public string HoraMaxima
  {
    get { return _horaMaxima.ToString(); }
    set
    {
      _horaMaxima = ValidarHoraInformada(value);
      ValidarHoraMaximaMenorQueMinima();
    }
  }
  private DateTime ValidarDataInformada(string data)
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
  private TimeSpan ValidarHoraInformada(string hora)
  {
    if (!TimeSpan.TryParse(hora, out TimeSpan _hora))
    {
      throw new Exception($"Hora {hora} Inválida!");
    }
    return _hora;
  }

  private void ValidarDataMaximaMenorQueMinima()
  {
    if (_dataMaxima < _dataMinima)
    {
      throw new Exception($"Data máxima {_dataMaxima:dd/MM/yyyy} menor que data mínima {_dataMinima:dd/MM/yyyy}!");
    }
  }
  private void ValidarHoraMaximaMenorQueMinima()
  {
    if (_horaMaxima < _horaMinima)
    {
      throw new Exception($"Hora máxima {HoraMaxima} menor que hora mínima {HoraMinima}!");
    }
  }
}
