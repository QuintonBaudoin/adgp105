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
        bool m_CombatOver = false;

        public bool CombatOver { get { return m_CombatOver; } }
        public bool CombatCase()
        {
            if (NumberOfNotDead() <= 1 || !PlayerAlive())
                return false;

            return true;
        }

        public void CombatFinished()
        {
            m_CombatOver = true;
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



            foreach (IUnit un in CombatSystem.instance.Units)
            {
                if (un.UnitStatus != Status.DEAD)
                    number++;
            }
            return number;
        }
        private bool PlayerAlive()
        {
            bool ret = false;

            foreach (IUnit unit in Units)
            {
                object test = unit;


                if (test.GetType() == typeof(Player))
                {
                    Player p = (Player)test;
                    if (p.UnitStatus == Status.ACTIVE)
                    { ret = true; break; }
                }

               
            }
            return ret;
        }
    }

}

