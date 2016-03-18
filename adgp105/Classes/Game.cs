using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adgp105
{
    [Serializable]
    public class Game : ICombat
    {

        List<IUnit> Units = new List<IUnit>();
        bool CombatOver = false;
        public bool CombatCase()
        {
            if (NumberOfNotDead() <= 1)
                return false;

            return true;
        }

        public void CombatFinished()
        {
            CombatOver = true;   
        }

        public int AddUnit(IUnit unit)
        {
            if (unit == null)
                return -2;
            if (Units.Contains(unit))
                return -1;
            Units.Add(unit);

            return 1;
        }
        private int NumberOfNotDead()
        {
            int number = 0;



            foreach(IUnit un in CombatSystem.instance.Units)
            {
                if (un.UnitStatus != Status.DEAD)
                    number++;
            }
            return number;
        }
    }
}
