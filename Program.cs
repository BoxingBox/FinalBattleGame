using TheFinalBattle;

string MainCharacterName = PlayerNamerMethod();
PlayGameByIncreasingRound(Enemy_NPCs.Npc_type.SKELETON_1);


void PlayGameByIncreasingRound(Enemy_NPCs.Npc_type TypeOfMonster)
{
    int Turn_Counter = 1;

    while (Turn_Counter <= 10)
    {
        if (Turn_Counter % 2 == 1)
        { 
            Enemy_NPCs enemy_Npcs = new Enemy_NPCs(Enemy_NPCs.Npc_type.SKELETON_1);
            Turn_Counter++;
        }
        else 
        {
            Party_Characters party_Characters = new Party_Characters(MainCharacterName);
            Turn_Counter++;
        }

        Console.WriteLine();
        Thread.Sleep(500);
    }

    
}
string PlayerNamerMethod()
{
    Console.WriteLine("Plese enter your characters name");
    string MainCharacterName = Console.ReadLine();
    if(MainCharacterName == null)
    {
        while (MainCharacterName == null)
        {
            Console.WriteLine("Please enter a valid character name");
            MainCharacterName = Console.ReadLine();
        }
    }
    return MainCharacterName;
}