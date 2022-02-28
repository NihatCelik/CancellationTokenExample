using System;
using System.Threading;

namespace CancellationTokenThrowIfCancellationRequest
{
    class Program
    {
        static void Main(string[] args)
        {
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
            CancellationToken cancellationToken = cancellationTokenSource.Token;

            for (int i = 1; true; i++)
            {
                cancellationToken.ThrowIfCancellationRequested();

                if (i % 100 == 0) cancellationTokenSource.Cancel();
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
