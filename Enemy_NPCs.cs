using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFinalBattle
{
    internal class Enemy_NPCs
    {
        private static int _Enemy_NPC_Hp = 10;

        public Enemy_NPCs(Npc_type npc_type)
        {
            switch (npc_type)
            {
                case Npc_type.SKELETON_1: Console.WriteLine("It's " + npc_type + "'s turn");
                                        Console.WriteLine(npc_type + " used " + Npc_type_actions.BoneCrunch);                    
                                        break;
            }

            
            
        }

        private void announcer(Npc_type npc_type)
        {
            Console.WriteLine("Its " + npc_type + "turn");
        }
        public enum Npc_type { SKELETON_1, SKELETON_2 }
        public enum Npc_type_actions { BoneCrunch };
    }
}
