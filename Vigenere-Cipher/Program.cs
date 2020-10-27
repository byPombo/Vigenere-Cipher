using System;
using System.Xml.Schema;

namespace Vigenere_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            menu();
            static void menu()
            {
                string key = "";
                string cipher_text = "";
                Console.WriteLine("-=-=- Vigere Cipher -=-=-");
                Console.Write("Insira o texto simples: ");
                string str = Console.ReadLine();
                Console.Write("Insira a palavra-chave: ");
                string keyword = Console.ReadLine();
                Console.Clear();

                Console.WriteLine("-=-=- Menu de opções -=-=-");
                Console.WriteLine("[1] - Criptografar");
                Console.WriteLine("[2] - Descriptografar");
                Console.Write("[+] - Opção: ");
                int opc = Convert.ToInt32(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        key = GFG.generateKey(str.ToUpper(), keyword.ToUpper());
                        cipher_text = GFG.cipherText(str.ToUpper(), key.ToUpper());

                        Console.WriteLine("Texto criptografado : "
                            + cipher_text + "\n");
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("-=-=- Menu de opções -=-=-");
                        Console.WriteLine("[1] - Criptografar");
                        Console.WriteLine("[2] - Descriptografar");
                        Console.Write("[+] - Opção: ");
                        opc = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        if (opc == 1)
                        {
                            key = GFG.generateKey(str.ToUpper(), keyword.ToUpper());
                            cipher_text = GFG.cipherText(str.ToUpper(), key.ToUpper());

                            Console.WriteLine("Texto criptografado : "
                                + cipher_text + "\n");
                            Console.ReadKey();
                            Console.Clear();
                            menu();
                        }
                        else
                        {
                            if (opc == 2)
                            {
                                Console.WriteLine("Texto descriptografado : "
                                    + GFG.originalText(cipher_text, key));
                            }
                            else
                            {
                                Console.WriteLine("Opção inválida.");
                                Console.ReadKey();
                                menu();
                            }
                        }

                        menu();
                        break;
                    case 2:
                        if (cipher_text == "")
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("[x] - Nenhum texto foi criptografado ainda.");
                            Console.ResetColor();
                            Console.ReadKey();
                            Console.Clear();
                            menu();
                        }
                        else
                        {
                            Console.WriteLine("Texto descriptografado : "
                                + GFG.originalText(cipher_text, key));
                        }
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        menu();
                        break;
                }
            }
        }
    }
}
