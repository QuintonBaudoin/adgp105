using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adgp105
{
    static class LevelingSystem
    {
        public static void GainEXP(IUnit target, IUnit source)
        {
            source.Exp += target.ExpWorth;
        }

        public static void GainExp(IUnit target, int amount)
        {
            target.Exp += amount;
        }

        public static int SetExpToNextLevel(int extlevel)
        {
            int number = 0;

            number = extlevel * 2;
            number = number << 10;

            return number;
        }

        public static int ExpWorth(int level)
        {
            return level;
        }

    }
}
