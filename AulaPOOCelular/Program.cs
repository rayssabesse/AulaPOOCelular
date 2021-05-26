using System;

namespace AulaPOOCelular
{

    class Program
    {
        static void Main(string[] args)
        {


            phone iPhone = new phone();
            iPhone.color = "preto";
            iPhone.model = "iPhone 11";
            iPhone.size = "6.1 polegadas";

            bool mv = false;

            if (iPhone.on == false)
            {
                Console.WriteLine("O celular está desligado.\nDeseja ligá-lo? (s/n)");
                char sn = char.Parse(Console.ReadLine());
                if (sn.Equals("n"))
                {
                    iPhone.turnoff();
                }
                if (sn.Equals("s"))
                {
                    iPhone.turnon();
                }
            }
            do
            {
                Console.Clear();
                Console.WriteLine(iPhone.menu());
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.WriteLine("Para quem deseja ligar?");
                        iPhone.person = Console.ReadLine();
                        Console.WriteLine(iPhone.call());
                        break;

                    case 2:
                        while (mv == false)
                        {
                            Console.WriteLine("Para quem deseja mandar a mensagem?");
                            iPhone.person = Console.ReadLine();
                            Console.WriteLine("Qual mensagem deseja mandar? (máx: 20 caracteres)");
                            iPhone.message = Console.ReadLine();
                            int l = iPhone.message.Length;

                            if (iPhone.message.Length <= 20)
                            {
                                mv = true;

                            }
                            if (iPhone.message.Length > 20)
                            {
                                mv = false;
                                Console.WriteLine($@"Mensagem inválida.\nA mensagem tem {l} caracteres, o máximo é de 20 caracteres.");
                            }
                        }
                        Console.WriteLine(iPhone.sms());
                        break;

                    case 3:
                        iPhone.turnoff();
                        break;

                    default:
                        Console.WriteLine("Inválido.");
                        break;
                }
            } while (iPhone.on == true);
        }
    }
}
