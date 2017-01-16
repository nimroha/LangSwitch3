using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LangSwitch3
{
    class Switcher
    {
        public string switchLang(string str, bool to_eng)
        {
            char[] arr = str.ToCharArray();
            int i = 0;

            foreach (char c in arr) {
                switch (c) // very long code, but fastest implementation I could think of
                {
                    case 'q':
                    case 'Q':
                        arr[i] = 'ש';
                        break;
                    case 'w':
                    case 'W':
                        arr[i] = '\'';
                        break;
                    case 'e':
                    case 'E':
                        arr[i] = 'ק';
                        break;
                    case 'r':
                    case 'R':
                        arr[i] = 'ר';
                        break;
                    case 't':
                    case 'T':
                        arr[i] = 'א';
                        break;
                    case 'y':
                    case 'Y':
                        arr[i] = 'ט';
                        break;
                    case 'u':
                    case 'U':
                        arr[i] = 'ו';
                        break;
                    case 'i':
                    case 'I':
                        arr[i] = 'ן';
                        break;
                    case 'o':
                    case 'O':
                        arr[i] = 'ם';
                        break;
                    case 'p':
                    case 'P':
                        arr[i] = 'פ';
                        break;
                    case 'a':
                    case 'A':
                        arr[i] = 'ש';
                        break;
                    case 's':
                    case 'S':
                        arr[i] = 'ד';
                        break;
                    case 'd':
                    case 'D':
                        arr[i] = 'ג';
                        break;
                    case 'f':
                    case 'F':
                        arr[i] = 'כ';
                        break;
                    case 'g':
                    case 'G':
                        arr[i] = 'ע';
                        break;
                    case 'h':
                    case 'H':
                        arr[i] = 'י';
                        break;
                    case 'j':
                    case 'J':
                        arr[i] = 'ח';
                        break;
                    case 'k':
                    case 'K':
                        arr[i] = 'ל';
                        break;
                    case 'l':
                    case 'L':
                        arr[i] = 'ך';
                        break;
                    case ';':
                        if (to_eng) {
                            arr[i] = '`';
                        } else {
                            arr[i] = 'ף';
                        }
                        break;
                    case 'z':
                    case 'Z':
                        arr[i] = 'ז';
                        break;
                    case 'x':
                    case 'X':
                        arr[i] = 'ס';
                        break;
                    case 'c':
                    case 'C':
                        arr[i] = 'ב';
                        break;
                    case 'v':
                    case 'V':
                        arr[i] = 'ה';
                        break;
                    case 'b':
                    case 'B':
                        arr[i] = 'נ';
                        break;
                    case 'n':
                    case 'N':
                        arr[i] = 'מ';
                        break;
                    case 'm':
                    case 'M':
                        arr[i] = 'צ';
                        break;
                    case ',':
                        if (to_eng) {
                            arr[i] = '\'';
                        } else {
                            arr[i] = 'ת';
                        }
                        break;
                    case '.':
                        if (to_eng) {
                            arr[i] = '/';
                        } else {
                            arr[i] = 'ץ';
                        }
                        break;
                    case '/':
                        if (to_eng) {
                            arr[i] = 'q';
                        } else {
                            arr[i] = '.';
                        }
                        break;
                    case '\'':
                        if (to_eng) {
                            arr[i] = 'w';
                        } else {
                            arr[i] = ',';
                        }
                        break;

                    case 'ק':
                        arr[i] = 'e';
                        break;
                    case 'ר':
                        arr[i] = 'r';
                        break;
                    case 'א':
                        arr[i] = 't';
                        break;
                    case 'ט':
                        arr[i] = 'y';
                        break;
                    case 'ו':
                        arr[i] = 'u';
                        break;
                    case 'ן':
                        arr[i] = 'i';
                        break;
                    case 'ם':
                        arr[i] = 'o';
                        break;
                    case 'פ':
                        arr[i] = 'p';
                        break;
                    case 'ש':
                        arr[i] = 'a';
                        break;
                    case 'ד':
                        arr[i] = 's';
                        break;
                    case 'ג':
                        arr[i] = 'd';
                        break;
                    case 'כ':
                        arr[i] = 'f';
                        break;
                    case 'ע':
                        arr[i] = 'g';
                        break;
                    case 'י':
                        arr[i] = 'h';
                        break;
                    case 'ח':
                        arr[i] = 'j';
                        break;
                    case 'ל':
                        arr[i] = 'k';
                        break;
                    case 'ך':
                        arr[i] = 'l';
                        break;
                    case 'ף':
                        arr[i] = ';';
                        break;
                    case 'ז':
                        arr[i] = 'z';
                        break;
                    case 'ס':
                        arr[i] = 'x';
                        break;
                    case 'ב':
                        arr[i] = 'c';
                        break;
                    case 'ה':
                        arr[i] = 'v';
                        break;
                    case 'נ':
                        arr[i] = 'b';
                        break;
                    case 'מ':
                        arr[i] = 'n';
                        break;
                    case 'צ':
                        arr[i] = 'm';
                        break;
                    case 'ת':
                        arr[i] = ',';
                        break;
                    case 'ץ':
                        arr[i] = '.';
                        break;

                    default:
                        Console.Write("case not covered - " + c);
                        break;
                }
                i++;
            }


            return new string(arr);
        }

        public Switcher()
        {
            //TODO do something?
        }
    }
}
