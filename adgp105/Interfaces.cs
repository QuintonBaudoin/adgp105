using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adgp105
{

    public interface IUnit
    {

        Dictionary<string, int> Attributes
        {
            get; set;
        }

        /// <summary>
        /// If true unit will be able to make an "Action" when its turn comes;
        /// </summary>
        bool canAct
        {
            get;
        }

        /// <summary>
        /// Needs to be set to Attribute that is acting Speed.
        /// 
        /// Speed will be used to determin order of turns for of the combat.
        /// 
        /// Highest speed goes first;
        /// </summary>
        int Speed { get; }

        

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

        int ActedOn(IUnit source, IAction action, string attribute, int value);

        int Init();
        int Start();
        int Main();
        int End();
    }

    public interface IAction
    {
        int Action(IUnit target);
    }

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
