namespace Modelos;

public class ConfiguracaoReserva
{
  private DateTime _dataMinima;
  private DateTime _dataMaxima;
  private TimeSpan _horaMinima;
  private TimeSpan _horaMaxima;
  public String DataMinima
  {
    get { return _dataMinima.ToString(); }
    set { _dataMinima = _validarDataInformada(value); }
  }
  public String DataMaxima
  {
    get { return _dataMaxima.ToString(); }
    set
    {
      _dataMaxima = _validarDataInformada(value);
      _validarDataMaximaMenorQueMinima();
    }
  }
  public String HoraMinima
  {
    get { return _horaMinima.ToString(); }
    set
    {
      _horaMinima = _validarHoraInformada(value);
    }
  }
  public String HoraMaxima
  {
    get { return _horaMaxima.ToString(); }
    set
    {
      _horaMaxima = _validarHoraInformada(value);
      _validarHoraMaximaMenorQueMinima();
    }
  }
  private DateTime _validarDataInformada(string data)
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
  private TimeSpan _validarHoraInformada(string hora)
  {
    if (!TimeSpan.TryParse(hora, out TimeSpan _hora))
    {
      throw new Exception($"Hora {hora} Inválida!");
    }
    return _hora;
  }

  private void _validarDataMaximaMenorQueMinima()
  {
    if (_dataMaxima < _dataMinima)
    {
      throw new Exception($"Data máxima {_dataMaxima:dd/MM/yyyy} menor que data mínima {_dataMinima:dd/MM/yyyy}!");
    }
  }
  private void _validarHoraMaximaMenorQueMinima()
  {
    if (_horaMaxima < _horaMinima)
    {
      throw new Exception($"Hora máxima {HoraMaxima} menor que hora mínima {HoraMinima}!");
    }
  }
}
