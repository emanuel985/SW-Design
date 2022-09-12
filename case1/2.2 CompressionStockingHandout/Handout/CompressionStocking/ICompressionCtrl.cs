using System;
using System.Threading;
using System.Timers;
using CompressionStocking;

namespace CompressionStocking
{
    public interface ICompressionCtrl
    {
        void Compress();
        void Decompress();
    }



    public class CompressionCtrl : ICompressionCtrl
    {
        public void Compress()
        {

        }

        public void Decompress()
        {

        }
    }


    public class pump : CompressionCtrl
    {
        public void Compress()
        {
            Console.WriteLine("Pump compressing");
        }

        public void Decompress()
        {
            Console.WriteLine("Pump decompressing");
        }
    }

    public class Timer : ICompressionCtrl
    {
        public void Compress()
        {
            Thread.Sleep(500);
        }

        public void Decompress()
        {
            Thread.Sleep(200);
        }
    }
}

