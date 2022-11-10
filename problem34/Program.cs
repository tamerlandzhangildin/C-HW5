
int size = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[size];
            int k = 0;

            Random rnd = new Random();
 
            Console.WriteLine("Исходный массив");
            for (int i = 0; i < size; i++)
            {
                arr[i] = rnd.Next(100,1000);
                Console.Write("{0} ", arr[i]);
            }
            Console.WriteLine();
        
        
            foreach(int element in arr)
            {
                Console.Write("{0} ", element);
                if (element % 2 == 0)
                {
                    k++;
                    
                }
            }
            Console.WriteLine();
            Console.WriteLine("Количество четных элементов {0}", k);
