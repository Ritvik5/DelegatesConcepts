namespace DelegateExample
{
    public class Program
    {
        delegate void LogDel(string text);//Delegate Initialization
        static void Main(string[] args)
        {

            Log log = new Log();

            LogDel LogTextToScreen, LogTextToFile;

            LogTextToScreen = new LogDel(log.LogTextToScreen);

            LogTextToFile = new LogDel(log.LogTextToFile);

            LogDel multiLogDel = LogTextToScreen + LogTextToFile;//Multi cast Delegate

            Console.WriteLine("Please Enter Your Name ");
            string name = Console.ReadLine();
            multiLogDel(name);
        }
    } 
}