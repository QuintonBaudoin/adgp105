using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adgp105
{
    public enum Status {ACTIVE, INACTIVE, DEAD };
    /// <summary>
    /// Use this interface for a class to become a unit that will be able to be used in the CombatSystem
    /// </summary>
    public interface IUnit
    {
        
        Status UnitStatus { get;}

        bool GetAttribute(string attribute, out int value);

        /// <summary>
        /// Needs to be set to Attribute that is acting Speed.
        /// 
        /// Speed will be used to determin order of turns for of the combat.
        /// 
        /// Highest speed goes first;
        /// </summary>
        int Speed { get; }
        
        string Name { get; }
        /// <summary>
        /// CurrentLevel
        /// </summary>
        int Level { get; set; }
        /// <summary>
        /// Current Experiance
        /// </summary>
        int Exp { get; set; }
        /// <summary>
        /// Experiance needed to level up
        /// </summary>
        int ExpNextLVL { get; set; }
        /// <summary>
        /// Experiance this unit is worth based on its own experiance.
        /// </summary>
        int ExpWorth { get;}


        int ActedOn(IUnit source, IAction action);

        int ActOn(IUnit target, IAction action);

        /// <summary>
        /// When it is this unit's turn this will be the first function called;
        /// </summary>
        /// <returns></returns>
        int Init();
        int Start();
        int Main();
        /// <summary>
        /// When unit's end step is finished pleas remember to call NextStep();
        /// </summary>
        /// <returns></returns>
        int End();
    }

    /// <summary>
    /// Use this interface to create an action. Actions can bet what ever you defined it as.
    /// </summary>
    public interface IAction
    {
        int Cost {get; }
        string Attribute
        {
            get;
        }
        int Value
        {
            get;
        }
        int Action(IUnit source, IUnit target);
    }

    public interface IAttribute
    {
        string Name { get; }
        int Value { get; }
        int MaxValue { get; }      
    }


    /// <summary>
    /// Use this interface to establish the rules and Post-Termination for the CombatSystem
    /// </summary>
    public interface ICombat
    {
        /// <summary>
        /// If true combat continues, if false combat will begin to end;
        /// </summary>
        /// <returns></returns>
        bool CombatCase();
        /// <summary>
        /// Runs once combat has hit termination state;
        /// </summary>
        /// <returns></returns>
        void CombatFinished();

    }

}
