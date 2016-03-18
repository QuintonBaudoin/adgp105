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
                throw new NotImplementedException();
            }
        }
        public int Cost
        {
            get
            {
                throw new NotImplementedException();
            }
        }
        public int Value
        {
            get
            {
                throw new NotImplementedException();
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
        int m_Value = 1;

        public string Attribute
        {
            get
            {
                throw new NotImplementedException();
            }
        }
        public int Cost
        {
            get
            {
                throw new NotImplementedException();
            }
        }
        public int Value
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int Action(IUnit source, IUnit target)
        {
            return target.ActedOn(source, this);
        }
    }

}
