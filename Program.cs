using System;

namespace EjercicioArray
{
    public static class Program
    {
        public static elementoVajilla[] Append<elementoVajilla>(this elementoVajilla[] array, elementoVajilla item)
        {
            List<elementoVajilla> list = new List<elementoVajilla>(array);
            list.Add(item);

            return list.ToArray();
        }
    }

    public class aniadir
    {
        public static void Main()
        {
            int[] array = { 1, 2, 3, 4 };
            int item = 5;

            int[] result = (int[])array.Append(item);
            Console.WriteLine(String.Join(",", result));
        }
    }
}
