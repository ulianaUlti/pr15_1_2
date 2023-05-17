using System;
using System.IO;

namespace _15
{
    class Program
    {
        static void Main(string[] args)
        {
            string str, newstr, newrts = null;
            string glasnie = "аиоыуэяюё";
            char[] s = glasnie.ToCharArray();
            Console.WriteLine("Введите текст для записи в файл ");
            str = Console.ReadLine();
            FileStream file1 = new FileStream("C:\\new_file.txt", FileMode.Create);
            StreamWriter writer = new StreamWriter(file1);
            writer.Write(str);
            writer.Close();
            FileStream file2 = new FileStream("C:\\new_file.txt", FileMode.Open);
            StreamReader reader = new StreamReader(file2);
            newstr = (reader.ReadToEnd());
            for (int i = 0; i < newstr.Length; i++)
                for (int j = 0; j < s.Length; j++)
                    if (newstr[i] == s[j])
                        newrts = newrts + newstr[i];
            reader.Close();
            char[] v = newrts.ToCharArray();
            Array.Reverse(v);
            Console.WriteLine("Гласные файла в обратном порядке: ");
            for (int i = 0; i < v.Length; i++)
                Console.Write(v[i] + " ");
            Console.ReadKey();
        }
    }
}
