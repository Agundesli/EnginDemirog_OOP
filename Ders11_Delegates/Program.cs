using System;

namespace Ders11_Delegates
{
    public delegate void MyDelegate();
    public delegate void MyDelegate2(string text);
    public delegate void MyDelegate3(int s1, int s2);
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.SendMessage();
            customerManager.ShowAlert();
            Console.WriteLine("****************************************");
            MyDelegate myDelegate = customerManager.SendMessage;
            myDelegate += customerManager.ShowAlert;
            myDelegate();
            Console.WriteLine("*******************************************************");
            MyDelegate2 myDelegate2 = customerManager.SendMessage2;
            myDelegate2+= customerManager.ShowAlert2;
            myDelegate2("Hello");
            Console.WriteLine("******************************************************");
            Mat mat = new Mat();
            MyDelegate3 myDelegate3 = 
        }
    }
    public class CustomerManager
    {
        public void SendMessage()
        {
            Console.WriteLine("Hello");
        }
        public void ShowAlert()
        {
            Console.WriteLine("Be Careful");
        }
        public void SendMessage2(String Message)
        {
            Console.WriteLine(Message);
        }
        public void ShowAlert2(string Alert)
        {
            Console.WriteLine(Alert);
        }
    }
    public class Mat
    {
        public int Topla(int s1, int s2)
        {
            return s1 + s2;
        }
        public int Carp(int s1, int s2)
        {
            return s1 * s2;
        }
    }
}
