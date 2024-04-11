using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity18.RpgGame.Services.Implementations
{
	public class QuickSort
	{
		public void Sort_int(int[] array)
		{
			int cantidadTotal = array.Length;

			int k;
			for (int i = 0; i < cantidadTotal; i++)
			{
				for (int j = i + 1; j < cantidadTotal; j++)
				{
					if (array[i] >= array[j])
					{
						k = array[i];
						array[i] = array[j];
						array[j] = k;
					}
				}
			}

			for (int i = 0; i < cantidadTotal; i++)
			{
				Console.WriteLine(array[i]);
			}
		}
	}

}
