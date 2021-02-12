using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Success");

            LinkedList<string> shoppingList = new LinkedList<string>();
            shoppingList.Add("Bob");
            shoppingList.Add("Bill");
            shoppingList.Add("Ben");
            shoppingList.Add("Brian");
            shoppingList.Add("Barry");
            shoppingList.RemoveAt(1);
            shoppingList.Remove("Ben");
            for (int i = 0; i < shoppingList.Count; i++)
            {
                Console.WriteLine("List item {0}:{1}",i,shoppingList[i]);
            }
            Console.WriteLine("Index of 'Barry' = {0}",shoppingList.IndexOf("Barry"));
        }
    }
}
