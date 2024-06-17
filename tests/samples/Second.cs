using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace tests.samples
{
    public class Second
    {
        /*
        There are two threads. The first one prints “ping”, the second one prints “pong”.
        Please write code that synchronizes these threads and sequentially prints “ping” and “pong”.

        Есть два потока. Первый выводит “ping”, второй - “pong”.
        Пожалуйста, напишите код, который синхронизирует эти потоки и последовательно выводит “ping” и “pong”.
         */
        int _count = 0;
        AutoResetEvent waitHandlerPing = new AutoResetEvent(false);
        AutoResetEvent waitHandlerPong = new AutoResetEvent(false);

        public Second(int count = 10) 
        {
            _count = count;
        }

        public void PingPong()
        {

            var pingThread = new Thread(new ThreadStart(Ping));
            pingThread.Start();

            var pongThread = new Thread(new ThreadStart(Pong));
            pongThread.Start();
        }

        public void Ping()
        {
            for (int i = 0; i < _count; i++)
            {
                Console.WriteLine("Ping");
                waitHandlerPing.Set();
                waitHandlerPong.WaitOne();
            }
        }

        public void Pong()
        {
            for (int i = 0; i < _count; i++)
            {
                waitHandlerPing.WaitOne();
                Console.WriteLine("Pong");
                waitHandlerPong.Set();
            }
        }
    }
}
