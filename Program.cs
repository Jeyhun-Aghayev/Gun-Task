using Gun.Models;

namespace Gun
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GUN gun = new GUN()
            {
                SilahinNovu = "AK-47",
                GulleTutumu = 30,
                HazirkiGwlleSayi = 25,
                AutoIsTrue_OneShotIsFalse = true,
                MilliSecondCount = 5,
            };
            
        }
    }
}
