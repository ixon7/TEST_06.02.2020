using System;
using System.Collections.Generic;
using System.Text;

namespace TEST_06._02._2020
{
    class ZamekPIN : IZamek
    {
        private string _pin;
        private bool _otwarte;

        public ZamekPIN(string pin)
        {
            if (pin.Length != 4) throw new ArgumentException("invalid pin", "pin");
            _pin = pin;
        }
        public void Otworz(string toCheck)
        {
            if (toCheck == pin && !otwarte)
            {
                Console.WriteLine("Otwarte");
                _otwarte = true;
            }
        }

        public void Zamknij()
        {
            throw new System.NotImplementedException();
        }
    }
}
