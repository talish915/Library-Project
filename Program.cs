using Library_Project.Models;
using Library_Project.Services;
using System;
using System.Collections.Generic;

namespace Library_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            do
            {
                Console.WriteLine("---------------------------Library---------------------------");
                Console.WriteLine("Yerine Yetirmek Istediyniz Emeliyyatin Qarsisindaki Nomreni Daxil Edin!");
                Console.WriteLine("1 - Yeni Kitab Elave Edin");
                Console.WriteLine("2 - Kitabxanadaki Kitablarin Siyahisi");
                Console.WriteLine("3 - Kitablari Adina Gore Axtarmaq");
                Console.WriteLine("4 - Kitablari Adina Gore Silmek");
                Console.WriteLine("5 - Kitabi Adina, Muellif Adina ve ya Sehife Sayina Gore Axtarmaq");
                Console.WriteLine("6 - Kitablari Sehifeye Gore Axtarmaq (Min, Max)");
                Console.WriteLine("7 - Kitablari Nomresine Gore Silmek");
                Console.Write("Daxil Edin: ");

                string select = Console.ReadLine();
                int selectNum;
                int.TryParse(select, out selectNum);

                switch (selectNum)
                {
                    case 1:
                        Console.Clear();
                        AddBook(ref library);
                        break;
                    case 2:
                        Console.Clear();
                        
                        break;
                    case 3:
                        Console.Clear();

                        break;
                    case 4:
                        Console.Clear();

                        break;
                    case 5:
                        Console.Clear();

                        break;
                    case 6:
                        Console.Clear();

                        break;
                    case 7:
                        Console.Clear();

                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Duzgun Daxil Edin!");
                        break;
                }
            } while (true);
        }
        static void AddBook(ref Library library)
        {
        reEnterBookName:
            Console.Write("Elave Etmek Istediyiniz Kitabin Adini Daxil Edin: ");
            string bookName = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(bookName))
            {
                Console.WriteLine("Duzgun Daxil Edin!");
                goto reEnterBookName;
            }

            
        reEnterAuthorName:
            Console.Write("Muellifin Adini Daxil Adin: ");
            string authorName = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(bookName))
            {
                Console.WriteLine("Duzgun Daxil Edin!");
                goto reEnterAuthorName;
            }

            
        reEnterPageCount:
            Console.Write("Sehife Sayini Daxil Edin: ");
            string pageCountStr = Console.ReadLine();
            int pageCount;
            if (!int.TryParse(pageCountStr, out pageCount) || pageCount <= 0)
            {
                Console.WriteLine("Duzgun Daxil Edin!");
                goto reEnterPageCount;
            }

            Console.Clear();
            Console.WriteLine("Kitab Elave Olundu!");

            library.AddBook(bookName, authorName, pageCount);
        }
    }
}
