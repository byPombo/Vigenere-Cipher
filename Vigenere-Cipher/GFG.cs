using System;
using System.Collections.Generic;
using System.Text;

namespace Vigenere_Cipher
{
	// C# code to implement Vigenere Cipher 
	public class GFG
	{

		// This function generates the key in 
		// a cyclic manner until it's length isi'nt 
		// equal to the length of original text 
		public static String generateKey(String str, String key)
		{
			int x = str.Length;

			for (int i = 0; ; i++)
			{
				if (x == i)
					i = 0;
				if (key.Length == str.Length)
					break;
				key += (key[i]);
			}
			return key;
		}

		// Essa função deve retornar o texto encriptado
		// gerado com a ajuda do key
		public static String cipherText(String str, String key)
		{
			String cipher_text = "";

			for (int i = 0; i < str.Length; i++)
			{
				
				int x = (str[i] + key[i]) % 26;


				x += 'A';

				cipher_text += (char)(x);
			}
			return cipher_text;
		}

		// This function decrypts the encrypted text 
		// and returns the original text 
		public static String originalText(String cipher_text, String key)
		{
			String orig_text = "";

			for (int i = 0; i < cipher_text.Length &&
									i < key.Length; i++)
			{
				// converting in range 0-25 
				int x = (cipher_text[i] -
							key[i] + 26) % 26;

				// convert into alphabets(ASCII) 
				x += 'A';
				orig_text += (char)(x);
			}
			return orig_text;
		}
	}
}
/* This code contributed by PrinciRaj1992 */
