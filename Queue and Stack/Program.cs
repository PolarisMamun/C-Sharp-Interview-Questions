Queue<int> queue = new Queue<int>();
queue.Enqueue(1);
queue.Enqueue(2);
queue.Enqueue(3);
queue.Enqueue(4);

Console.WriteLine("Queue: " + queue.Peek());
queue.Dequeue();

Console.WriteLine("Queue: " + queue.Peek());

foreach (int item in queue)
{
    Console.WriteLine("Queue: " + item);
}


Stack<int> stack = new Stack<int>();
stack.Push(1);
stack.Push(2);
stack.Push(3);
stack.Push(4);

Console.WriteLine("Stack: " + stack.Peek());
stack.Pop();
Console.WriteLine("Stack: " + stack.Peek());
foreach (int item in stack)
{ 
    Console.WriteLine("Stack: " + item); 
}


Console.ReadLine();