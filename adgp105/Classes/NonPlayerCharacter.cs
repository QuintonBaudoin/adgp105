using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adgp105
{
   // [Serializable]
   //public class NonPlayerCharacter 
   // {
   //     Hashtable m_Attributes = new Hashtable();


   //     public NonPlayerCharacter(int speed, int maxhealth)
   //     {
           
   //         m_Attributes.Add("Health", maxhealth);
   //         m_Attributes.Add("MaxHealth", maxhealth);

   //         m_Attributes.Add("Speed", speed);

   //         Level = 1;
   //         m_UnitStatus = Status.ACTIVE;

   //     }
   //     public NonPlayerCharacter() { }

   //     int m_Level = 0;
   //     int m_Exp = 0;
   //     int m_ExpNextLVL;

   //     Status m_UnitStatus;

     

   //     public int Exp
   //     {
   //         get
   //         {
   //             return m_Exp;
   //         }

   //         set
   //         {
   //             m_Exp = value;

   //             if (Exp > ExpNextLVL)
   //                 Level++;
   //         }
   //     }
   //     public int ExpNextLVL
   //     {
   //         get
   //         {
   //             return m_ExpNextLVL;
   //         }

   //         set
   //         {
   //             m_ExpNextLVL = value;
   //         }
   //     }
   //     public int ExpWorth
   //     {
   //         get
   //         {
   //             return LevelingSystem.ExpWorth(m_Level);
   //         }


   //     }
   //     public int Level
   //     {
   //         get
   //         {
   //             return m_Level;
   //         }

   //         set
   //         {
   //             m_Level = value;
   //             Exp = 0;
   //             m_ExpNextLVL = LevelingSystem.SetExpToNextLevel(value + 1);
   //         }
   //     }

   //     public int Speed
   //     {
   //         get
   //         {
   //             return (int)m_Attributes["Speed"];
   //         }
   //     }


   //     public Status UnitStatus
   //     {
   //         get
   //         {
   //             return m_UnitStatus;
   //         }
   //     }

    

       

   //     public string Name
   //     {
   //         get
   //         {
   //             throw new NotImplementedException();
   //         }
   //     }

   //     public int ActOn(IUnit target, IAction action)
   //     {
   //         action.Action(this, target);
   //         return 1;
   //     }
   //     public int ActedOn(IUnit source, IAction action)
   //     {
   //         int tmp = (int)m_Attributes[action.Attribute];

   //         tmp += action.Value;

   //         m_Attributes[action.Attribute] = tmp;

   //         return 1;
   //     }
   //     public int End()
   //     {
   //         CombatSystem.instance.NextStep();
   //         return 1;
   //     }
   //     public int Init()
   //     {
   //         throw new NotImplementedException();
   //     }
   //     public int Main()
   //     {
   //         throw new NotImplementedException();
   //     }

   //     public int Start()
   //     {
   //         throw new NotImplementedException();
   //     }

   //     public bool GetAttribute(string attribute, out int value)
   //     {
   //         value = 0;
   //         if (!m_Attributes.ContainsKey(attribute))
   //             return false;

   //         value = (int)m_Attributes[attribute];

   //         return true;
   //     }
   // }
}
