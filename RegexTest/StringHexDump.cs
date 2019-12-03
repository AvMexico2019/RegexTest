using System;

namespace RegexTest
{
    static class StringHexDump
    {
        public static string CharToString(char[] CharArray)
        {
            string res = "";
            for (int i = 0; i < CharArray.Length; i++)
            {
                if (Char.IsControl((char)i))
                {
                    res += " ";
                }
                else
                {
                    res += (char)i;
                }
            }
            return res;
        }

        private static string byte2hex(byte b)
        {
            char[] hexChars = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9',
                            'A', 'B', 'C', 'D', 'E', 'F' };
            return hexChars[((b & 0xf0) >> 4)].ToString() + hexChars[(b & 0x0f)].ToString();
        }

        public static string HexDump(string cadena, int size)
        {
            char[] chars = cadena.ToCharArray();
            string salida1 = "";
            string salida2 = "";
            string result = "";
            int i = 0;
            foreach (char c in chars)
            {
                i++;
                if (Char.IsControl(c))
                {
                    switch ((int) c)
                    {
                        case 7:
                            salida1 += "\\a"; // bell
                            break;
                        case 8:
                            salida1 += "\\b"; // back space
                            break;
                        case 9:
                            salida1 += "\\t"; // tab
                            break;
                        case 10:
                            salida1 += "\\n"; // linefeed
                            break;
                        case 11:
                            salida1 += "\\v"; // vertical tab
                            break;
                        case 12:
                            salida1 += "\\f"; // form feed
                            break;

                        case 13:
                            salida1 += "\\r"; // carriage return
                            break;
                        case 27:
                            salida1 += "\\e"; // escape
                            break;

                        default:
                            salida1 += "..";
                            break;
                    }
                    
                }
                else
                {
                    switch ((int) c)
                    {
                        case 32:
                            salida1 += "\\s"; // space
                            break;
                        default:
                            salida1 += c + " ";
                            break;
                    }
                }

                salida2 += byte2hex((byte)c);
                if ((i % size) == 0)
                {
                    result += salida1 + "\n" + salida2 + "\n\n";
                    salida1 = "";
                    salida2 = "";
                }

            }
            if (!salida1.Equals(""))
            {
                result += salida1 + "\n" + salida2;
            }
            else
            {
                char[] NL = { '\n' };
                result = result.TrimEnd(NL);
            }
            return result;
        }

        public static string ASCIITable(int size)
        {
            char[] ASCII = new char[256];
            for (int i = 0; i < 256; i++)
            {
                ASCII[i] = (char)i;
            }
            return HexDump(new string(ASCII), size);
        }
    }
}


