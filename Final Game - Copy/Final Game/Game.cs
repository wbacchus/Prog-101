using System;
using System.Collections.Generic;
using System.Text;

using static System.Console;


namespace Final_Game
{
    public class Game
    {

        public string Input;
        public string Gift;
        public int HP;

        public Game(string input, string gift, int hp)
        {
            Input = input;
            Gift = gift;
            HP = hp;
        }


        public static int Generate()
        {
            Random random = new Random();
            int number = random.Next(0, 10);
            return number;
        }



        public static void Play()
        {
            Clear();
            // instantiate game
            Game game = new Game("", "", 10);

            //Create Character
            WriteLine("Type the name of your new character and press Enter to see them created!");
            Player player = new Player(Generate(), Generate(), Generate(), ReadLine(), false, false, 10);
            Clear();
            WriteLine($"Character Created! \nName: {player.Name} \nHP: {player.HP} \nInt: {player.Intelligence} \nPower: {player.Power} \nSpeed: {player.Speed} ");

            WriteLine("");

            // Choose Environment
            Environment environment = new Environment("");
            WriteLine($"What Environment would you like to start in? a Forest or an Island? \n type the name and press enter!");
            environment.Name = ReadLine();
            Clear();

            WriteLine($"You have chosen to start in {environment.Name}!");

            //Start on one of the paths
            if (environment.Name == "Forest")
            {
                player.Power--;
                player.Speed++;
                player.Intelligence++;
            }
            if (environment.Name == "Island")
            {
                player.Power--;
                player.Speed--;
                player.Intelligence = player.Intelligence + 2;
            }

            // Description of Environment
            WriteLine($"You find yourself in a {environment.Name}");
                WriteLine($"Will you: \n a: Walk along path \n b: sit and meditate");

                // First Decision
                game.Input = ReadLine();
                Clear();

                if (game.Input == "a")
                {
                    WriteLine($"{player.Name} is walking along the path and stumbles across a SWORD!");
                    player.Sword = true;
                    player.Power++;

                }

                else if (game.Input == "b")
                {
                    WriteLine($"{player.Name} meditates for a bit and notices a strange feeling inside.");
                player.Magic = true;
                    player.Intelligence++;

                }
                ReadLine();
                Clear();
                // Second Decision
                WriteLine($"Suddenly a large monster appears!\n Will you: \n a: fight it \n b: run away");
                game.Input = ReadLine();
                Clear();
                if (game.Input == "a")
                {
                    if (player.Sword == true)
                    {
                        WriteLine($"{player.Name} Grabs their sword and gets ready to fight!");


                    }

                    else if (player.Magic == true)
                    {

                        WriteLine($"{player.Name} feels an inner force take over them!");

                    }


                }

                else if (game.Input == "b")
                {
                    WriteLine($"{player.Name} tries to run away from the horrid monster!");
                    ReadKey();
                    Clear();
                    if (player.Sword == true)
                    {
                        WriteLine($"{player.Name} notices the weight of the sword and drops it in order to keep running");
                        player.Sword = false;
                        ReadKey();
                        Clear();
                    }

                    else if (player.Magic == true)
                    {
                        WriteLine($"{player.Name} feels their inner strength dwindling");

                        ReadKey();
                        Clear();
                    }

                    WriteLine($"{player.Name} cannot escape and turns to face the monster!");
                }
                // Monster Fight
                WriteLine($"The monster engages.");
                ReadKey();
                Clear();

                if (player.Sword | player.Magic == true)
                {
                    if (player.Sword == true)
                    {
                        WriteLine($"{player.Name} STABS the monster with the sword!");
                    }

                    else if (player.Magic == true)
                    {
                        WriteLine($"{player.Name} uses an unknown force to DESTROY the monster!");
                    }

                    ReadKey();
                    Clear();

                    WriteLine("Congratulations! You beat the monster!");
                    WriteLine($"Would you like to \n a: Keep exploring \n b: Rest");
                    game.Input = ReadLine();
                    if (game.Input == "a")
                    {
                        player.Speed = player.Speed + 2;
                        // write something
                        WriteLine("");
                    }
                    if (game.Input == "b")
                    {
                        player.Intelligence++;
                        player.Power++;
                        // write something
                        WriteLine("");
                    }
                WriteLine($"{player.Name} sees a strange creature in the distance...");
                ReadKey();
                Clear();
                WriteLine($"{player.Name} feels a strong urge to approach the creature and cannot seem to stop themselves from walking forward...");
                ReadKey();
                Clear();
                WriteLine("As you get closer, you take in it's strange appearance as the creature seems to notice your presence...");
                ReadKey();
                Clear();
                WriteLine("The creature's form is constantly changing and morphing so it's hard to discern what it looks like. \n but as you look closer you realize something interesting.");
                ReadKey();
                Clear();
                WriteLine("This creature has three disctint elements to it's form which all seem to be morphing independently from one another.");
                ReadKey();
                Clear();
                WriteLine("before you can look any longer, you hear a voice with no discernable source speak to you.");
                ReadKey();
                WriteLine("You have made many decisions in the past...");
                ReadKey();
                WriteLine("These decisions have affected you in ways you cannot yet comprehend...");
                ReadKey();
                WriteLine("The choices before you are no different...");
                ReadKey();
                WriteLine("You are now going to be tested...");
                ReadKey();
                WriteLine("As you gaze at the three elements before you, pay attention to the characteristics of the forms that emerge...");
                ReadKey();
                WriteLine("As a manifestation of these elements I present to you two gifts: A Blue Gem and a Red Glove");
                WriteLine("Which one will you choose?");

                WriteLine("a: the Blue Gem \n b: the Red Glove");
                game.Gift = ReadLine();

                if (game.Gift == "a")
                {
                    player.Intelligence++;
                    game.Gift = "Blue Gem";
                }
                if (game.Gift == "b")
                {
                    player.Power++;
                    game.Gift = "Red Glove";
                }

                WriteLine("The Strange Creature vanishes as a glowing light appears and washes over your vision.");
                ReadKey();
                Clear();
                WriteLine("You wake up at the place you began your journey");
                WriteLine($"Will you: \n a: Walk along path \n b: sit and meditate");
                ReadLine();
                WriteLine("Before you can do anything you see the monster you previously fought barreling towards you");
                WriteLine("There is no oppurtunity to run. You must fight");
                WriteLine("You hear a familiar voice in your head speak to you");
                ReadLine();

                do
                {
                    WriteLine($"monster hp: {game.HP}");
                    WriteLine($"{player.Name} hp: {player.HP}");

                    if (player.Power > 8)
                    {

                        WriteLine("The monster goes in for an attack");
                        WriteLine("Will you \n a: Punch \n b: Kick \n Defend");
                        game.Input = ReadLine();
                        

                        if (game.Input == "a")
                        {
                            WriteLine("You cock back a punch and release it. A sharp pain shoots down your entire body starting from your fist. You can notice the monster visibly hurt by this");
                            game.HP--;
                            game.HP--;
                            player.HP--;
                            player.HP--;

                        }
                        if (game.Input == "b")
                        {
                            WriteLine("You give the monster a powerful kick. This startles the monster.");
                            game.HP--;
                            player.HP++;

                        }
                        if (game.Input == "c")
                        {
                            WriteLine("You brace yourself for the monsters incoming attack. The monster's powerful strike causes immense pain");
                            player.HP--;
                            player.HP--;
                            player.HP--;

                        }
                    }
                    else if (player.Intelligence > 8)
                    {
                        WriteLine("You must cast this spell, Recite the following incantation exactly.");
                        WriteLine($"{game.Gift}. You have become a part of me. Now I need your help. Lend me your strength so that I can defeat this unholy monster!");
                        game.Input = ReadLine();
                        if (game.Input == $"{game.Gift}. You have become a part of me. Now I need your help. Lend me your strength so that I can defeat this unholy monster!")
                        {
                            WriteLine("Spell Cast");
                            game.HP = 0;
                            
                        }
                        else if (game.Input != $"{game.Gift}. You have become a part of me. Now I need your help. Lend me your strength so that I can defeat this unholy monster!")
                        {
                            player.HP = player.HP - 4;
                            WriteLine("Spell Not Cast");
                        }
                    }
                    else
                    {
                        //  WriteLine("Adding Stats");
                        player.Intelligence++;
                        player.Power++;
                    }
                } while (game.HP > 0 && player.HP > 0);
                // event depending on stats HOW DO I MAKE THESE PARALLEL?
                if (player.HP > 0)
                {
                    WriteLine("Congratulations! After a long hard battle, You have beaten the monster!");
                    ReadLine();
                    Clear();
                    WriteLine("The ominous voice speaks to you again:");
                    ReadLine();
                    Clear();
                    WriteLine("You have learned a lot on this journey...");
                    ReadLine();
                    Clear();
                    WriteLine("The choices you have made has led to your victory...");
                    ReadLine();
                    Clear();
                    WriteLine("You have defeated the monster for the second time...");
                    ReadLine();
                    Clear();
                    WriteLine("but this is not the last time you will face it...");
                    ReadLine();
                    Clear();
                    WriteLine("This is an ongoing battle...");
                    ReadLine();
                    Clear();
                    MazeGame maze = new MazeGame();
                    maze.Start();


                }
               else if (player.HP <= 0)
                {
                    WriteLine("You have been defeated.");
                }



                else if (player.Sword | player.Magic == false)
                {
                    if (player.Sword == false)
                    {
                        WriteLine($"{player.Name} cannot fight off the monster without the SWORD");
                    }

                    else if (player.Magic == false)
                    {
                        WriteLine($"{player.Name} has no way of fighting this monster");
                    }

                    ReadKey();
                    Clear();

                    WriteLine("You have been defeated.");
                }

            }
               
           
        }
      public static void Maze()
        {
            
        }
        public static void EndScreen()
        {
            WriteLine("END OF GAME");
        }
        public static void MainMenu()
        {
            string prompt = "Welcome \n (use arrow keys to cycle through options and press enter to select an option)";
            string[] options = { "Play", "Exit" };
            Menu mainMenu = new Menu(prompt, options);
            mainMenu.DisplayOptions();
            int selectedIndex = mainMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    Game.Play();
                    break;
                case 2: Game.ExitGame();
                    break;
                default:
                    break;
            }
        }
        private static void ExitGame()
        {
            // Environment.Exit(0);
        }
        
    }
        
}

