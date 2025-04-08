using System;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("введите количество предметов: ");
        int n = Convert.ToInt32(Console.ReadLine());
        while (n <= 0)
        {
            Console.WriteLine("введите положительное число: ");
            n = Convert.ToInt32(Console.ReadLine());
        }                   
        Console.WriteLine("введите вместимость рюкзака: ");
        int vmestimost = Convert.ToInt32(Console.ReadLine());
        while (vmestimost <= 0)
        {
            Console.WriteLine("введите положительное число: ");
            vmestimost = Convert.ToInt32(Console.ReadLine());
        }
        float[] weights = new float[n];
        Console.WriteLine("введите вес предметов: ");
        for (int i = 0; i < n; i++)
        {
            weights[i] = Convert.ToSingle(Console.ReadLine());
            while (weights[i] < 0)
            {
                Console.WriteLine("введите положительное число: ");
                weights[i] = Convert.ToSingle(Console.ReadLine());
            }
        }
        float[] cost = new float[n];
        Console.WriteLine("введите стоимость предметов: ");
        for (int i = 0; i < n; i++)
        {
            cost[i] = Convert.ToSingle(Console.ReadLine());
            while (cost[i] < 0)
            {
                Console.WriteLine("введите положительное число: ");
                cost[i] = Convert.ToSingle(Console.ReadLine());
            }
        }
        for (int i = 1; i < cost.Length; i++)
        {
            float k = cost[i];
            float p = weights[i];
            int j = i - 1;
            while (j >= 0 && cost[j] < k)
            {
                cost[j + 1] = cost[j];
                weights[j + 1] = weights[j];
                j--;
            }
            cost[j + 1] = k;
            weights[j + 1] = p;
        }
        float currentweight = 0;
        float totalcost = 0;
        for (int i = 0; i < n; i++)
        {
            if (currentweight + weights[i] <= vmestimost)
            {
                Console.WriteLine("Добавляем предмет с весом " + weights[i] + " и стоимостью " + cost[i]);
                currentweight += weights[i];
                totalcost += cost[i];
            }
        }
        Console.WriteLine();
        Console.WriteLine("общий вес: " + currentweight);
        Console.WriteLine("общая стоимость: " + totalcost);
        Console.ReadLine();
    }
}
