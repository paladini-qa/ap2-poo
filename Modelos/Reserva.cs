namespace Modelos;

public class Reserva
{
  private DateTime _dataMinima;
  private DateTime _dataMaxima;
  private TimeSpan _horaMinima;
  private TimeSpan _horaMaxima;

  public DateTime DataMinima
  {
    get { return _dataMinima; }
    set { _dataMinima = value; }
  }
  public DateTime DataMaxima
  {
    get { return _dataMaxima; }
    set { _dataMaxima = value; }
  }
  public TimeSpan HoraMinima
  {
    get { return _horaMinima; }
    set { _horaMinima = value; }
  }
  public TimeSpan HoraMaxima
  {
    get { return _horaMaxima; }
    set { _horaMaxima = value; }
  }
}