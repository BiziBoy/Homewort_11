using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homewort_11
{
  class Program
  {
    static int foundIndex(int [] _array, int _value)
    {
      int index = -1;
      for (int i = 0; i < _array.Length; i++)
      {
        if (_array[i] == _value)
        {
          index = i;
          break;
        }
      }
      if (index == -1)
      {
        Console.WriteLine("Не было найдено ни одного элемента с значением " + _value);
      }
      return index;
    }

    static void Main()
    {
      int[] array = new int[5];
      Random rand = new Random();
      for (int i = 0; i < array.Length; i++)
      {
        array[i] = rand.Next(100);
      }
      for (int i = 0; i < array.Length; i++)
      {
        Console.WriteLine("["+ i + "]: " + array[i] + " ");
      }
      Console.Write("Введите значение для поиска: ");
      int value = int.Parse(Console.ReadLine());
      Console.WriteLine("Индекс данного элемента: " + foundIndex(array, value));
      Console.ReadLine();
    }
  }
}
