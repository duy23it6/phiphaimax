using System;
using System.Threading;

class Program
{
    static void Main()
    {
        // Tạo một luồng mới và gán phương thức DoWork để thực hiện
        Thread thread = new Thread(new ThreadStart(ThreadExample.DoWork));
        thread.Start();

        // Luồng chính tiếp tục chạy
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Main thread: " + i);
            Thread.Sleep(100); // Tạm dừng luồng chính trong 100ms
        }

        // Chờ luồng worker kết thúc
        thread.Join();
    }
}

class ThreadExample
{
    public static void DoWork()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Worker thread: " + i);
            Thread.Sleep(100); // Tạm dừng luồng worker trong 100ms
        }
    }
}
