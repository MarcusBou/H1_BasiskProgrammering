using System;

namespace Morsecode
{
    class Program
    {
        static public string sentence, translatedSentence;

        static void Main(string[] args)
        {
            Console.Write("Sentence you want translated: ");
            sentence = Console.ReadLine();
            sentence = sentence.ToUpper();
            for (int i = 0; i < sentence.Length; i++)
            {
                switch (sentence[i])
                {
                    case 'A':
                        translatedSentence += ".--";
                        break;
                    case 'B':
                        translatedSentence += "-...";
                        break;
                    case 'C':
                        translatedSentence += "-.-.";
                        break;
                    case 'D':
                        translatedSentence += "-..";
                        break;
                    case 'E':
                        translatedSentence += ".";
                        break;
                    case 'F':
                        translatedSentence += "..-";
                        break;
                    case 'G':
                        translatedSentence += "--.";
                        break;
                    case 'H':
                        translatedSentence += "....";
                        break;
                    case 'I':
                        translatedSentence += "..";
                        break;
                    case 'J':
                        translatedSentence += ".---";
                        break;
                    case 'K':
                        translatedSentence += "-.-";
                        break;
                    case 'L':
                        translatedSentence += ".-..";
                        break;
                    case 'M':
                        translatedSentence += "--";
                        break;
                    case 'N':
                        translatedSentence += "-.";
                        break;
                    case 'O':
                        translatedSentence += "---";
                        break;
                    case 'P':
                        translatedSentence += ".--.";
                        break;
                    case 'Q':
                        translatedSentence += "--.-";
                        break;
                    case 'R':
                        translatedSentence += ".-.";
                        break;
                    case 'T':
                        translatedSentence += "-";
                        break;
                    case 'U':
                        translatedSentence += "..-";
                        break;
                    case 'V':
                        translatedSentence += "...-";
                        break;
                    case 'W':
                        translatedSentence += ".--";
                        break;
                    case 'X':
                        translatedSentence += "-..-";
                        break;
                    case 'Y':
                        translatedSentence += "-.--";
                        break;
                    case 'Z':
                        translatedSentence += "--..";
                        break;
                    case 'Æ':
                        translatedSentence += ".-.-";
                        break;
                    case 'Ø':
                        translatedSentence += "---.";
                        break;
                    case 'Å':
                        translatedSentence += ".--.-";
                        break;
                    case ' ':
                        translatedSentence += " ";
                        break;
                }
            }

            Console.WriteLine("Your translated sentence: " + translatedSentence);

            Console.ReadKey();
        }
    }
}

