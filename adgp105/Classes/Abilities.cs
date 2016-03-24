using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adgp105
{
    class Attack : IAction
    {
        string m_Attribute = "Health";
        int m_Cost;
        int m_Value = -1;

        public string Attribute
        {
            get
            {
                return m_Attribute;
            }
        }
        public int Cost
        {
            get
            {
                return m_Cost;
            }
        }
        public int Value
        {
            get
            {
                return m_Value;
            }
        }

        public int Action(IUnit source, IUnit target)
        {
           return target.ActedOn(source, this);
        }
    }

    class Heal : IAction
    {
        string m_Attribute = "Health";
        int m_Cost;
        int m_Value = 2;

        public string Attribute
        {
            get
            {
                return m_Attribute;
            }
        }
        public int Cost
        {
            get
            {
                return m_Cost;
            }
        }
        public int Value
        {
            get
            {
                return m_Value;
            }
        }

        public int Action(IUnit source, IUnit target)
        {
            return target.ActedOn(source, this);
        }
    }

    class Slow : IAction
    {

        string m_Attribute = "Speed";
        int m_Cost;
        int m_Value = -2;

        public string Attribute
        {
            get
            {
                return m_Attribute;
            }
        }
        public int Cost
        {
            get
            {
                return m_Cost;
            }
        }
        public int Value
        {
            get
            {
                return m_Value;
            }
        }

        public int Action(IUnit source, IUnit target)
        {
            return target.ActedOn(source, this);
        }

    }
    
    class Rush : IAction
    {
        string m_Attribute = "Speed";
        int m_Cost;
        int m_Value = 2;

        public string Attribute
        {
            get
            {
                return m_Attribute;
            }
        }
        public int Cost
        {
            get
            {
                return m_Cost;
            }
        }
        public int Value
        {
            get
            {
                return m_Value;
            }
        }

        public int Action(IUnit source, IUnit target)
        {
            return target.ActedOn(source, this);
        }
    }

}
