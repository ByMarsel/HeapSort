using System;

namespace HeapSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            HeapSort(new []{9,5,10,8,2,2,25,1,0,3,11,4,6,7});
        }


        static void HeapSort(int[] array)
        {
            for (int i = array.Length; i  > 0; i--)
            {
                BuildHeapTwo(array, i);
                Swap(array, 0, i - 1);
            }
            
            foreach (var num in array)
            {
                Console.Write(num+", ");
            }
        }

        static void BuildHeapTwo(int[] array, int length)
        {
            for (int i = length / 2; i >= 0; i--)
            {
                var r = RightChild(i);
                var l = LeftChild(i);
                var larg = i;
                var j = i;
                while (true)
                {
                    if (l < length && array[l] > array[larg])
                    {
                        larg = l;
                    }

                    if (r < length && array[r] > array[larg])
                    {
                        larg = r; 
                    }

                    if (larg != j)
                    {
                        Swap(array, j, larg);
                        r = RightChild(larg);
                        l = LeftChild(larg);
                        j = larg;
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        static int LeftChild(int indx)
        {
            return indx * 2 + 1;
        }

        static int RightChild(int indx)
        {
            return indx * 2 + 2;
        }

        static void Swap(int[] arr, int left, int right)
        {
            var temp = arr[left];
            arr[left] = arr[right];
            arr[right] = temp;
        }
    }
}