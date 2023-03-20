namespace _08.TrafficJam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();
            int n = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int counter = 0;
            while (command != "end")
            {
                if (command == "green" && queue.Count > 0)
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (queue.Count > 0)
                        {
                            string currentCar = queue.Dequeue();
                            Console.WriteLine($"{currentCar} passed!");
                            counter++;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                else
                {
                    queue.Enqueue(command);

                }

                command = Console.ReadLine();
            }
            Console.WriteLine($"{counter} cars passed the crossroads.");
            return;
        }
    }
}