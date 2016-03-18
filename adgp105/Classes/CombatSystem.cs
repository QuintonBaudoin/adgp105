using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace adgp105
{


    /// <summary>
    /// Turnbased Combat system that uses ICombat, IUnit
    /// 
    /// Error Codes:
    ///         4 : Combat System successfully Terminated 
    ///         3 : Successful transition to Termination
    ///         2 : Successful transition
    ///         1 : Successful
    ///         0 : List of Units not assigned;
    ///        -1 : Broken State Transistion : Causes incorrect state transition IE main from end;
    ///        -2 : Instance of the Combat System is already in existance
    /// 
    /// </summary>

    class CombatSystem
    {
        /// <summary>
        /// Private Constructor that takes in an ICombat to be used as the end case for the combat system
        /// </summary>
        /// <param name="rules">ICombat that is used to determin end case for the system</param>
        private CombatSystem(ICombat rules) { m_Rules = rules;  m_State = States.INIT; } 

        private  static CombatSystem _instance;
        public static CombatSystem instance
        {
            get
            {
                return _instance;
            }
        }
        List<IUnit> m_Units;
        public List<IUnit> Units
        {
            get { return m_Units; }
        }

        IUnit m_CurrentUnit = null;
        ICombat m_Rules;
        public IUnit CurrentUnit
        {
            get { return m_CurrentUnit; }
        }

        public enum States { INIT, START, MAIN, END, TERM};

        private States m_State;
        public States State
        {
            get { return m_State; }
        }



        public static  int InitiateCombat(ref List<IUnit> units, ICombat rules)
        {
            if (_instance != null)
                return -2;
            _instance = new CombatSystem(rules);

            if (instance.m_State != States.INIT)
                return -1;

            instance.m_Units = units;
            if (instance.m_Units == null)
            {
                return 0;
            }
            instance.m_State = States.START;



            instance.m_Units = instance.m_Units.OrderBy(x => x.Speed).ToList();
            return 1;
        }

        private int Start()
        {
            if (m_State != States.START)
                return -1;

            if (m_Units == null)
                return 0;

            m_CurrentUnit = m_Units.First();
            m_State = States.START;
            return 2;

        }
        private int Main(IUnit unit)
        {
            if (m_State != States.MAIN)
                return -1;
            if (m_CurrentUnit.UnitStatus == Status.ACTIVE)
                m_CurrentUnit.Init();
            else m_CurrentUnit.End();

            return 1;
        }
        private int End()
        {
            if (m_State != States.END)
                return -1;
            if (m_Units == null)
                return 0;
            if (!m_Rules.CombatCase())
            {
                m_State = States.TERM;
                return 3;
            }

            for (int i = 0; i < m_Units.Count; i++)
            {
                if (m_Units[i] == null)
                    m_Units.Remove(m_Units[i]);
            }

            m_Units = m_Units.OrderBy(x => x.Speed).ToList();
            m_State = States.START;
            return 2;
        }

        private int TerminateCombat()
        {
            if (m_State != States.TERM)
                return -1;
           
            m_Rules.CombatFinished();

            _instance = null;
            return 4;
        }

        public int NextStep()
        {
            if (m_State == States.MAIN)
            {
                if (m_Units.IndexOf(m_CurrentUnit) + 1 >= m_Units.Count)
                {
                    m_State = States.END;
                    return 2;
                }
                m_CurrentUnit = m_Units[m_Units.IndexOf(m_CurrentUnit) + 1];

                return Main(m_CurrentUnit);
            }
            else if(m_State == States.START)
            {
                return Start();
            }
            else if(m_State == States.END)
            {
                return End();
            }
            else if(m_State == States.TERM)
            {
                return TerminateCombat();
            }
            return -1;
        }

        
    }




}
