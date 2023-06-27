namespace DelegateExample
{
    public class Program
    {
        delegate void LogDel(string text);//Delegate Initialization
        static void Main(string[] args)
        {

            Log log = new Log();
            Console.WriteLine("Please Enter Your Name ");
            string name = Console.ReadLine();


            LogDel del = new LogDel(log.LogTextToScreen);//del refrence is pointing to LogTextToFile
            del(name);
        }
    }
}