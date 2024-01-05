using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Abstractexample2;

class Program
{
    static void Main(string[] args)
    {   
        Console.WriteLine("|||Telefonunuz aşağıdaki işlemleri yapıyor.|||"); 
        Phoneinfo phoneinfo = new();
        phoneinfo.Call();
        phoneinfo.SendSms();
        phoneinfo.connectwifi();
        
        Console.WriteLine("|||Nokia Telefonunuz||| \n |||aşağıdaki işlemleri yapıyor.|||");
        Nokia nokia = new();
        nokia.Call();
        nokia.SendSms();
        nokia.connectwifi();
        nokia.PlaySnakeGame();
    }   
    

    
}



public class Phoneinfo : Phonegeneral
{
    public override void Call()
    {
        Console.WriteLine("Telefon arama yapıyor");
    }
    public override void SendSms()
    {
        Console.WriteLine("Telefonunun sms gönderiyor");

    }
    public override void connectwifi()
    {
        Console.WriteLine("Telefonunuz internete bağlanıyor");
    }


}



class Nokia:Phoneinfo//Nokia telefon için tekrar override yapmamıza gerek yoktu,hızlı bir şekilde Nokia nokia = new(); ile phone info sınıfındaki metotları kullanabiliriz.
{
        public void PlaySnakeGame()
        {
            Console.WriteLine("Nokia telefonunda Yılan Oyunu oynanıyor.");
        }

    // Phoneinfo sınıfındaki metotları override etmek istersek.
        public override void Call()
        {
         Console.WriteLine("Nokia marka cep telefonunuz arama yapıyor.");
        }
        public override void SendSms()
        {
            Console.WriteLine("Nokia telefonu sms gönderiyor");
        }

        // ConnectWifi metodu Phoneinfo sınıfında zaten override edildiği için burada tekrar implemente etmeye gerek yok.
    }






