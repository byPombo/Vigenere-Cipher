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

                Console.WriteLine("[1] - Criptografar");
                Console.WriteLine("[2] - Descriptografar");
                int opc = Convert.ToInt32(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        key = GFG.generateKey(str.ToUpper(), keyword.ToUpper());
                        cipher_text = GFG.cipherText(str.ToUpper(), key.ToUpper());

                        Console.WriteLine("Ciphertext : "
                            + cipher_text + "\n");
                        break;
                    case 2:
                        if (cipher_text == "")
                        {
                            Console.WriteLine("[x] - Nenhum texto foi criptografado ainda.");
                            Console.ReadKey();
                            Console.Clear();
                            menu();
                        }
                        Console.WriteLine("Original/Decrypted Text : "
                            + GFG.originalText(cipher_text, key));
                        break;
                }
            }
        }
    }
}
