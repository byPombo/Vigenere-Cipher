using System;
using System.Xml.Schema;

namespace Vigenere_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-=-=- Vigere Cipher -=-=-");
            Console.Write("Insira o texto simples: ");
            string str = Console.ReadLine();
            Console.Write("Insira a palavra-chave: ");
            string keyword = Console.ReadLine();

            String key = GFG.generateKey(str.ToUpper(), keyword.ToUpper());
            String cipher_text = GFG.cipherText(str.ToUpper(), key.ToUpper());

            Console.WriteLine("Ciphertext : "
                + cipher_text + "\n");


            Console.WriteLine("Original/Decrypted Text : "
                + GFG.originalText(cipher_text, key));
        }
    }
}
