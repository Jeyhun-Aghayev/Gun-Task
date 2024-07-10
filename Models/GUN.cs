using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Gun.Models
{
    public class GUN
    {
        private string silahinNovu;
        public string SilahinNovu
        {
            get { return silahinNovu; }
            set { silahinNovu = value; }
        }

        private int _gulleTutumu;
        public int GulleTutumu
        {
            get { return _gulleTutumu; }
            set
            {
                if (value >= 0)
                {
                    _gulleTutumu = value;
                }
            }
        }

        private int _hazirkiGwlleSayi;
        public int HazirkiGwlleSayi
        {
            get { return _hazirkiGwlleSayi; }
            set
            {
                if (value >= 0)
                {
                    _hazirkiGwlleSayi = value;
                }
            }
        }

        private int _milliSecondCount;
        public int MilliSecondCount
        {
            get { return _milliSecondCount; }
            set
            {
                if (value >= 0)
                {
                    _milliSecondCount = value;
                }
            }
        }

        public bool AutoIsTrue_OneShotIsFalse { get; set; }

        public bool Auto(int Millisecont)
        {
            if (AutoIsTrue_OneShotIsFalse is false) return false;
            if (Millisecont * _milliSecondCount > _hazirkiGwlleSayi) return false;
            _hazirkiGwlleSayi -= Millisecont * _milliSecondCount;
            return true;
        }
        public bool OneShot(int BulletCount)
        {
            if(AutoIsTrue_OneShotIsFalse is true) return false;
            if (BulletCount > _hazirkiGwlleSayi) return false;
            _hazirkiGwlleSayi -= BulletCount;
            return true;
        }
        public bool Reload()
        {
            _hazirkiGwlleSayi = GulleTutumu;
            return true;
        }
    }
}
