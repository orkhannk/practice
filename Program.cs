using System;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;
using System.Timers;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //verilmis 3 ededden hansinin en boyuk oldugunu tapan program 
            //Console.WriteLine("1 ci ededi daxil edin ");

            //string num1Str = Console.ReadLine();
            //int num1 = Convert.ToInt32(num1Str);
            //Console.WriteLine("2 ci ededi daxil edin ");
            //string num2Str = Console.ReadLine();
            //int num2 = Convert.ToInt32(num2Str);
            //Console.WriteLine("3 cu ededi daxil edin ");
            //string num3Str = Console.ReadLine();
            //int num3 = Convert.ToInt32(num3Str);
            //int biggest;
            //if (num1 > num2)
            //{
            //    if (num1 > num3)
            //        biggest = num1;
            //    else biggest = num3;


            //}
            //else if (num2 > num3)

            //    biggest = num2;
            //else biggest = num3;
            //Console.WriteLine($"en boyuk eded : {biggest}");




            //Verilmiş yazının içində verilmis  hərfinin olub olmadığını tapan proqram
            //Console.WriteLine("bir yazi daxil edin ");
            //string text = Console.ReadLine();
            //Console.WriteLine("axtarilan herfi daxil edin ");
            //string letterStr = Console.ReadLine();
            //char letter = Convert.ToChar(letterStr);
            //bool hasletter = false;
            //for(int i = 0; i < text.Length; i++)
            //{
            //    if (text[i] == letter)
            //    {
            //        hasletter = true;
            //        break;
            //    }
            //}
            //if (hasletter) Console.WriteLine($"verilmis yazida {letter} herfi var");
            //else Console.WriteLine($"verilmis yazida {letter} herifi yoxdur");



            //Verilmiş yazıda neçə A hərfinin olduğunu tapan proqram

            //Console.WriteLine("bir yazi daxil edin ");
            //string text1 = Console.ReadLine();

            //int aCount = 0;
            //for (int i = 0; i < text1.Length; i++)

            //{
            //    if (text1[i] == 'A')
            //    {
            //        aCount++;
            //    }

            //}
            //Console.WriteLine($"yazida {aCount} sayda 'A' herifi var");


            //Verilmiş müsbət cüt ədədi kradtarına yüksəldən proqram
            //Daxil edilən ədə musbət və cüt olmadıqca yenidən daxil edilməlidir
            //Console.WriteLine("bir eded daxil edin ");
            //int eded;
            //do
            //{
            //    eded = Convert.ToInt32(Console.ReadLine());
            //} while (eded <= 0 || eded % 2 != 0);
            //int p = eded * eded;
            //Console.WriteLine("verilmis ededin kvadrati:" + p);



            //Verilmiş 5 uzunluqlu ədədlər siyahısındaki ədədlərin cəmini tapan proqram

            //int[] nums1 = new int[5];
            //for (int i = 0; i < nums1.Length; i++)
            //{
            //    Console.WriteLine($"{i + 1} ci ededi daxil edin ");
            //    string numStr = Console.ReadLine();
            //    int num = Convert.ToInt32(numStr);
            //    nums1[i] = num;
            //}
            //int sum = 0;
            //for (int i = 0; i < nums1.Length; i++)
            //{
            //    sum += nums1[i];

            //}
            //Console.WriteLine(" ededlerin cemi :" + sum);



            //Verilmiş təhsil növü dəyərinə əsasən o təhsilin saatını göstərən proqram.
            //Əgər verilmiş dəyər "programming"dirsə console-da 400 saat, "design"dırsa 250 saat, "system"dirsə 200 saat
            //heç biri deyilsə "təhsil novu yanlisdir" yazılmalıdır console-da.
            //tehsil novu yanlisdirsa yenide daxil edin


            //bool checkInput;
            //do
            //{
            //    Console.WriteLine("Tehsil novunu daxil edin:");
            //    string educationType = Console.ReadLine();
            //    checkInput = true;

            //    switch (educationType)
            //    {
            //        case "programming":
            //            Console.WriteLine("400 saat");
            //            break;
            //        case "design":
            //            Console.WriteLine("250 saat");
            //            break;
            //        case "system":
            //            Console.WriteLine("200 saat");
            //            break;
            //        default:
            //            checkInput = false;
            //            Console.WriteLine("Tehsil novu yanlisdir");
            //            break;
            //    }
            //} while (!checkInput);








            //Verilmiş yazıdan içində boşluqlar olmayan yeni bir yazı düzəltmək

            //Console.WriteLine("bir yazi daxil edin ");
            //string text3 = Console.ReadLine();
            //string newText3 = "";
            //for (int i = 0; i < text3.Length; i++)
            //{
            //    if (text3[i] != ' ')
            //    {
            //        newText3 += text3[i];
            //    }
            //}
            //Console.WriteLine(newText3)

            // Verilmiş ədədlər siyahısındaki verilmiş n ədədinin yerləşdiyi indexi tapan proqram
            //Console.WriteLine("ededler siyahisinin uzunluqunu daxil edin ");
            //string lengthStr = Console.ReadLine();
            //int length = Convert.ToInt32(lengthStr);
            //int[] array = new int[length];
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine($"{i + 1}ci ededi daxil edin ");
            //    array[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine("axtarilan ededi daxil edin ");
            //string axtarilanededStr = Console.ReadLine();
            //int axtarilaneded = Convert.ToInt32(axtarilanededStr);
            //for (int i=0; i < array.Length; i++)
            //{
            //    if (array[i] == axtarilaneded)
            //    {
            //        Console.WriteLine("axtarilan ededin indeksi :" + i);
            //        break;

            //    }
            //}




            //Verilmiş yazılar siyahısında verilmiş hərfdən neçə ədəd olduğunu tapan proqram
            //Console.WriteLine("yazilar siyahisinin uzunluqunu daxil edin ");
            //string length1Str = Console.ReadLine();
            //int length1 = Convert.ToInt32(length1Str);
            //string[] array1 = new string[length1];
            //for (int i = 0; i < array1.Length; i++)
            //{
            //    Console.WriteLine($"{i+1} ci yazini daxil edin" );
            //    array1[i] = Console.ReadLine();

            //}
            //Console.WriteLine("axtarilan herfi daxil edin : ");
            //char herf =Convert.ToChar(Console.ReadLine());
            //int count = 0; 
            //for (int i =0; i < array1.Length; i++)
            //{
            //    for(int p = 0; p < array1[i].Length; p++)
            //    {
            //        if (array1[i][p] == herf)
            //        {
            //            count++;

            //        }
            //    }
            //}
            //Console.WriteLine($"{count} sayda verilmis herfden var");




            ////Verilmiş yazının əvvəlindəki boşluqlar silinmiş bir string düzəldən proqram 
            //Console.WriteLine("bir yazi daxil edin ");
            //string text5 = Console.ReadLine();
            //string newText5 = "";
            //int startIndex = 0;
            //for (int i = 0; i < text5.Length; i++)
            //{
            //    if (text5[i] != ' ')
            //    {
            //        startIndex = i;
            //        break;

            //    }

            //}
            //for (int i = startIndex; i < text5.Length; i++)
            //{
            //    newText5 += text5[i];
            //}
            //Console.WriteLine(newText5);

            //Verilmiş 2 ədəd üzərində verilmiş simvola uyğun əməliyyat edən proqram
            //Simvol +,-,* və ya / olmalıdır, əks halda simvolu yenidən daxil edilməsi istənilməlidir.

            //Console.WriteLine("birinci ededi daxil edin ");
            //int eded1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("ikinci ededi daxil edin ");
            //int eded2 = Convert.ToInt32(Console.ReadLine());
            //bool check;
            //do
            //{
            //    Console.WriteLine("simvolu daxil edin :");
            //    string simvol = Console.ReadLine();
            //    check = true;
            //    switch (simvol)
            //    {
            //        case "+":
            //            Console.WriteLine($"verilmis ededlerin cemi {eded1 + eded2}");
            //            break;
            //        case "-":
            //            Console.WriteLine($"verilmis ededlerin cixilmasi {eded1 - eded2}");
            //            break;
            //        case "*":
            //            Console.WriteLine($"verilmis ededlerin vurulmasi {eded1 * eded2}");
            //            break;
            //        case "/":
            //            Console.WriteLine($"verilmis ededlerin bolunmesi {eded1 / eded2}");
            //            break;
            //        default:
            //            check = false;
            //            Console.WriteLine("Simvolu duzgun daxil et");
            //            break;
            //    }
            //} while (!check);

            //Verilmiş yazının sonundaki boşluları silinmiş yeni bir yazı düzəldən proqram yazırsınız

            //Console.WriteLine("bir yazi daxil edin :");
            //string text6 = Console.ReadLine();
            //string newText6 = "";
            //int startIndex = text6.Length-1;
            //for(int i = text6.Length-1; i >=0; i--)
            //{
            //    if (text6[i] != ' ')
            //    {
            //        startIndex = i;
            //        break;
            //    }
            //}
            //for (int i = 0; i <=startIndex ; i++)
            //{
            //    newText6 += text6[i];
            //}
            //Console.WriteLine(newText6);




            // lab:
            // Verilmis ededin kavadratini tapan proqram
            // Console.WriteLine("Ededi daxil Edin :");
            //string number1Str = Console.ReadLine();
            //int number1 =Convert.ToInt32 (number1Str);
            //   string number2Str = Console.ReadLine();
            //int number2 = Convert.ToInt32(number2Str); 
            //int Result  = 0;
            //   Result = number2 * number2;
            // Console.WriteLine(Result);



            // Verilmis ededin verilmis quvvetini tapan proqram
             Console.WriteLine("Ededi daxil et :");
            string numberStr = Console.ReadLine();
            Console.Write("Quvveti Daxil Edin :");
             string number2Str = Console.ReadLine();
            int number = Convert.ToInt32(numberStr);
            int power = Convert.ToInt32(number2Str);
            int Result = 1;
            for (int i = 0; i < power; i++)
            {
                Result *= number;
            }
            Console.WriteLine(Result);

        }
    }
}
