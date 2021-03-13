namespace Challenge.Lib
{
    public class Service
    {
        public string Get(int value)
        {
            return value % 7 == 0
                ? value % 9 == 0 ? "EG" : "E"
                : value % 9 == 0 ? "G" : value.ToString();
        }
    }
}