using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFinalBattle
{
    internal class Party_Characters
    {
        Enemy_NPCs.Npc_type _Target_Selection;

        public  int MainCharactersHp = 25;
        private static int Skeleton_1_Hp = 10;
        private static int Skeleton_2_Hp = 10;
        public Party_Characters(string MainCharactersName)
        {
            Action_announcer(MainCharactersName);                                      //Notifies the player when its their turn
            int Action_Selection = Convert.ToInt32(Console.ReadLine());

            Target_Announcer();                                                        //Notifies the player about their potential targets
            int Id_Target_Selection = Convert.ToInt32(Console.ReadLine());

            switch (Id_Target_Selection)
            {
                case 1: var Target_Selection = Enemy_NPCs.Npc_type.SKELETON_1;
                        Console.WriteLine(Target_Selection + " is selected!");
                        _Target_Selection = Target_Selection;                         //local to global variable to be used in the next switch
                         Skeleton_1_Hp = Skeleton_1_Hp - 5;                           //deals damage
                         Console.WriteLine("Skeleton 1 hp is now: " + Skeleton_1_Hp);
                         break;
                case 2:
                        Target_Selection = Enemy_NPCs.Npc_type.SKELETON_2;
                        Console.WriteLine(Target_Selection + " is selected!");
                        _Target_Selection = Target_Selection;                         //local to global variable to be used in the next switch
                        Skeleton_2_Hp = Skeleton_2_Hp - 5;                            //deals damage
                        Console.WriteLine("Skeleton 2 hp is now: " + Skeleton_1_Hp);
                        break;
            }

            switch (Action_Selection)
            {
                case 1: Console.WriteLine(MainCharactersName + " used " + Characters_Actions.Punch + " on " + _Target_Selection); break;
            }

            
        }

        private void Action_announcer(string mainCharactersName)
        {
            Console.WriteLine("Its " + mainCharactersName + " party's turn");
            Console.WriteLine("What do you want to do? ");
            Console.WriteLine("1: Punch ");
        }

        private void Target_Announcer()
        {
            Console.WriteLine("Please select a target");
            Console.WriteLine("1:" + Enemy_NPCs.Npc_type.SKELETON_1);
            Console.WriteLine("2:" + Enemy_NPCs.Npc_type.SKELETON_2);
        }




    }

    
    public enum characters { };
    public enum Characters_Actions { Punch };
}
