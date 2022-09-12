using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompressionStocking
{
    public interface IBtnHandler
    {
        void StartBtnPushed();
        void StopBtnPushed();
    }

    public class Button_driver : IBtnHandler
    {
        public void StartBtnPushed()
        {
            Console.WriteLine("Checks if startBtn is pushed");
        }

        public void StopBtnPushed()
        {
            Console.WriteLine("Checks if StopBtn is pushed");
        }
    }


    public class StockingCtrl : IBtnHandler
    {
        private readonly ICompressionCtrl _compressionCtrl;
        

        public StockingCtrl(ICompressionCtrl compressionCtrl)
        {
            _compressionCtrl = compressionCtrl;
        }


        // From IBtnHandler
        public void StartBtnPushed()
        {
            _compressionCtrl.Compress();
        }

        public void StopBtnPushed()
        {
            _compressionCtrl.Decompress();
        }


    }


