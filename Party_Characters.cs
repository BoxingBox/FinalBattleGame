using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TheFinalBattle
{
    internal class Party_Characters
    {
        Enemy_NPCs.Npc_type _Target_Selection;

        public  static int MainCharactersHp = 25;
        private static int Skeleton_1_Hp = 10;
        private static int Skeleton_2_Hp = 10;

        
        



        public Party_Characters(string MainCharactersName)
        {
            int skeleton_1_Death_Check = SkeletonDeathCheck(Skeleton_1_Hp, Skeleton_2_Hp);
            int skeleton_2_Death_Check = SkeletonDeathCheck(Skeleton_1_Hp, Skeleton_2_Hp); 

          
            Action_announcer(MainCharactersName);                                      //Notifies the player when its their turn
            int Action_Selection = Convert.ToInt32(Console.ReadLine());

            Target_Announcer();                                                        //Notifies the player about their potential targets
            int Id_Target_Selection = Convert.ToInt32(Console.ReadLine());
            if (SkeletonDeathCheck(Skeleton_1_Hp, Skeleton_2_Hp) != 3)
            { 
                switch (Id_Target_Selection)
            {
                case 1:
                    var Target_Selection = Enemy_NPCs.Npc_type.SKELETON_1;
                    if (SkeletonDeathCheck(Skeleton_1_Hp, Skeleton_2_Hp) != 1)
                    { 
                        
                        Console.WriteLine(Target_Selection + " is selected!");
                        _Target_Selection = Target_Selection;                         //local to global variable to be used in the next switch
                         Skeleton_1_Hp = Skeleton_1_Hp - 5;                           //deals damage
                         Console.WriteLine("Skeleton 1 hp is now: " + Skeleton_1_Hp);
                         
                         
                    }
                    break;
                case 2:
                        Target_Selection = Enemy_NPCs.Npc_type.SKELETON_2;
                        Console.WriteLine(Target_Selection + " is selected!");
                        _Target_Selection = Target_Selection;                         //local to global variable to be used in the next switch
                        Skeleton_2_Hp = Skeleton_2_Hp - 5;                            //deals damage
                        Console.WriteLine("Skeleton 2 hp is now: " + Skeleton_2_Hp);
                        break;
            }
            }
            else { Console.WriteLine("YOU WIN! ALL ENEMIES ARE DEAD!"); }


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
            if (SkeletonDeathCheck(Skeleton_1_Hp, Skeleton_2_Hp) != 1 && SkeletonDeathCheck(Skeleton_1_Hp, Skeleton_2_Hp) != 3) Console.WriteLine("1:" + Enemy_NPCs.Npc_type.SKELETON_1);
            if (SkeletonDeathCheck(Skeleton_1_Hp, Skeleton_2_Hp) != 2 && SkeletonDeathCheck(Skeleton_1_Hp, Skeleton_2_Hp) != 3) Console.WriteLine("2:" + Enemy_NPCs.Npc_type.SKELETON_2);
            if (SkeletonDeathCheck(Skeleton_1_Hp, Skeleton_2_Hp) == 3) { Console.WriteLine("All skeletons are dead!"); }
            else if(SkeletonDeathCheck(Skeleton_1_Hp, Skeleton_2_Hp) ==1) { Console.WriteLine("Skeleton 1 is dead"); }
            else if (SkeletonDeathCheck(Skeleton_1_Hp, Skeleton_2_Hp) == 2) { Console.WriteLine("Skeleton 2 is dead"); }
        }

        private int SkeletonDeathCheck(int Skeleton_1_Hp, int Skeleton_2_Hp)
        {
            if((Skeleton_1_Hp <= 0)&& (Skeleton_2_Hp <= 0)) { return 3; }
            if (Skeleton_1_Hp <= 0) { return 1; }
            if (Skeleton_2_Hp <= 0) { return 2; }
            else return 0;
        }  // returns 1 if Skeleton 1 is dead and 2 if Skeleton 2 is dead and 3 if both are dead



    }

    
    public enum characters { };
    public enum Characters_Actions { Punch };
}
