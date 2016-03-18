using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adgp105
{
    [Serializable]
   public class NonPlayerCharacter : IUnit
    {
        public NonPlayerCharacter(Game game, int speed, int maxhealth)
        {
            game.AddUnit(this);

            m_Attributes.Add("Health", maxhealth);
            m_Attributes.Add("MaxHealth", maxhealth);

            m_Attributes.Add("Speed", speed);

            Level = 1;
            m_UnitStatus = Status.ACTIVE;

        }
        public NonPlayerCharacter() { }

        int m_Level = 0;
        int m_Exp = 0;
        int m_ExpNextLVL;

        Status m_UnitStatus;

        Dictionary<string, int> m_Attributes = new Dictionary<string, int>();

        public int Exp
        {
            get
            {
                return m_Exp;
            }

            set
            {
                m_Exp = value;

                if (Exp > ExpNextLVL)
                    Level++;
            }
        }
        public int ExpNextLVL
        {
            get
            {
                return m_ExpNextLVL;
            }

            set
            {
                m_ExpNextLVL = value;
            }
        }
        public int ExpWorth
        {
            get
            {
                return LevelingSystem.ExpWorth(m_Level);
            }


        }
        public int Level
        {
            get
            {
                return m_Level;
            }

            set
            {
                m_Level = value;
                Exp = 0;
                m_ExpNextLVL = LevelingSystem.SetExpToNextLevel(value + 1);
            }
        }

        public int Speed
        {
            get
            {
                return m_Attributes["Speed"];
            }
        }


        public Status UnitStatus
        {
            get
            {
                return m_UnitStatus;
            }
        }

    

        public Dictionary<string, int> Attributes
        {
            get
            {
                return m_Attributes;
            }
        }

        public string Name
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int ActOn(IUnit target, IAction action)
        {
            throw new NotImplementedException();
        }
        public int ActedOn(IUnit source, IAction action)
        {
            throw new NotImplementedException();
        }

        public int End()
        {
            CombatSystem.instance.NextStep();
            return 1;
        }
        public int Init()
        {
            throw new NotImplementedException();
        }
        public int Main()
        {
            throw new NotImplementedException();
        }

        public int Start()
        {
            throw new NotImplementedException();
        }

        public bool GetAttribute(string attribute, out int value)
        {
            value = 0;
            if (!m_Attributes.ContainsKey(attribute))
                return false;

            value = m_Attributes[attribute];

            return true;
        }
    }
}
