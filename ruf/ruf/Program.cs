/*
 * Создано в SharpDevelop.
 * Пользователь: Moy
 * Дата: 25.10.2022
 * Время: 14:07
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;
using System.IO;

namespace ruf
{
	class Program
	{
		public static string path;
		
		public static void Main(string[] args)
		{
			bool have = false;
			foreach(string s in args)
			{
				if(s == "ver")
				{
					Console.WriteLine("Alpha 1 by Innie");
					Console.ReadKey(true);
				}
				else if(s == "exit")
					Environment.Exit(0);
				else
				{
					path = s;
					have = true;
				}
			}
			if(!have)
				path = "main.ruf";
			if(File.Exists(path))
			{
				oth();
			}
			else
			{
				Console.WriteLine("Не найден файл - " + path);
				Console.ReadKey(true);
				Environment.Exit(0);
			}
		}
		
		public static void oth()
		{
			string[] l = File.ReadAllLines(path);
			for(int i = 0; i < l.Length; i++)
			{
				if(l[i].StartsWith("вывестистроку "))
				{
					string text = l[i].Remove(0, "вывестистроку ".Length);
					Console.WriteLine(text);
				}
				else if(l[i].StartsWith("вывести "))
				{
					string text = l[i].Remove(0, "вывести ".Length);
					Console.Write(text);
				}
				else if(l[i] == "пауза")
					Console.ReadKey(true);
				else if(l[i] == "очистить")
					Console.Clear();
			}
		}
	}
}