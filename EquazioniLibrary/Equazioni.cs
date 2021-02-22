namespace EquazioniLibrary
{
    public class Equazioni

    {
        public static bool IsDetermined(double a)
        {
            return a != 0;
        }
        public static bool IsInconstisted(double a, double b)
        {
            if (a != 0)
                return true;
            else
            {
                if (b == 0)
                    return false;
                else
                    return false;
            }
        }
        public static bool IsDegree2(double esponente, double a)
        {
            return esponente == 2 && a != 0;
        }

    }
  
}
