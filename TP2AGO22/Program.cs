namespace TP2AGO22
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Select what exercise should be executed
            string userValue = "";

            do
            {
                switch (userValue)
                {
                    case "1":
                        ExerciseOne.ExecuteMethod();
                        break;
                    default:
                        break;
                }

            } while (true);
        }
    }
}