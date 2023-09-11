namespace TestDateFormat;

/// <summary>
/// Esta clase implementa la funcionalidad de cambiar el formato de una fecha.
/// </summary>
public class DateFormatter
{

    /// <summary>
    /// Cambia el formato de la fecha que se recibe como argumento. La fecha que se recibe como argumento se asume en
    /// formato "dd/mm/yyyy" y se retorna en formato "yyyy-mm-dd". No se controla que la fecha recibida tenga el formato
    /// asumido.
    /// </summary>
    /// <param name="date">Una fecha en formato "dd/mm/yyyy".</param>
    /// <returns>La fecha convertida al formato "yyyy-mm-dd".</returns>
    public static string VerificarFecha(string dateD)
    {
        if (dateD.Length < 6)
        {
            return "";
        }
        foreach (char letra in dateD)
        {
            if (Convert.ToString(letra) == "-")
            {
                return "";
            }
        }
        return dateD;

    }
    public static string ChangeFormat(string dateS)
    {
        string date = VerificarFecha(dateS);
        
        try 
        {
            return date.Substring(6) + "-" + date.Substring(3, 2) + "-" + date.Substring(0, 2);
        }
        catch
        {
            return "";
        }
        
        
    }
}
