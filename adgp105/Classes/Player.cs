using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adgp105
{
    [Serializable()]
    public class Player : IUnit
    {


        Hashtable m_Attributes = new Hashtable();

        public Hashtable Attributes { get { return m_Attributes; } set { m_Attributes = value; } }

        public Player(string Name, int speed, int maxhealth)
        {            
            m_Attributes.Add("Health", maxhealth);
            m_Attributes.Add("MaxHealth", maxhealth);

            m_Attributes.Add("Speed", speed);

            m_Name = Name;

            Level = 1;
            m_UnitStatus = Status.ACTIVE;

        }
        public Player() { }

        int m_Level;
        int m_Exp;
        int m_ExpNextLVL;
        int m_ExpWorth;

        string m_Name;

        Status m_UnitStatus;

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
            set
            {
                m_ExpWorth = value;
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
               
               return (int)m_Attributes["Speed"];
            }
            set
            {
                Attributes["Speed"] = value;
            }
          
        }

        public Status UnitStatus
        {
            get
            {
                return m_UnitStatus;
            }
            set { m_UnitStatus = value; }
        }

        public string Name
        {
            get
            {
                return m_Name;
            }
            set
            {
                m_Name = value;
            }
        }

        public int ActOn(IUnit target, IAction action)
        {
            action.Action(this, target);
            return 1;
        }
        public int ActedOn(IUnit source, IAction action)
        {
            int tmp = (int)m_Attributes[action.Attribute];

            tmp += action.Value;

            m_Attributes[action.Attribute] = tmp;

            return 1;
        }

        public int End()
        {
            CombatSystem.instance.NextStep();
            return 1;
        }
        public int Init()
        {


            return 1;
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
            value = -900000;
            if (!m_Attributes.ContainsKey(attribute))
                return false;

            value = (int)m_Attributes[attribute];

            return true;
        }
    }


}
