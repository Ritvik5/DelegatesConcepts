namespace DelegateExample
{
    public class Program
    {
        delegate void LogDel(string text);//Delegate Initialization
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Your Name ");
            string name = Console.ReadLine();


            LogDel del = new LogDel(LogTextToFile);//del refrence is pointing to LogTextToFile
            del(name);
        }

        static void LogTextToScreen(string text)
        {
            Console.WriteLine($"{DateTime.Now}: {text}");
        }

        static void LogTextToFile(string text)
        {
            using(StreamWriter sw = new StreamWriter(Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"Log.txt"),true))
            {
                 sw.WriteLine($"{DateTime.Now}: {text}");
            }
        }
    }
}