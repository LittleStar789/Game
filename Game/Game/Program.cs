using System;
using System.Text;
  namespace Game
  { 
     class Program
     {
        static void Main(string[] args)
        {
            Console.Title = "DragonFightForPrincess";
            Story stories = new Story();
            stories.BeginGame();
            Fights fights = new Fights();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                      Введите имя персонажа");
            string name = Convert.ToString(Console.ReadLine());
            Console.Clear();
            Player player = new Player(name, 1, 140, 1000);
            Monsters monster = new Monsters("Разбойник", 1, 100, 1120);
    
            stories.Chapter1();
            fights.FightTheRobber(player.Health, monster.Health, player.Damage, monster.Damage);
            player.Level = 2;
            player.Damage += 100;
            player.Health += 200;
            Console.WriteLine($"Теперь ваш уровень равен: {player.Level}, ваше здоровье равно: {player.Health}, ваш урон равен: {player.Damage}.");
            Console.ReadLine();
            Console.WriteLine("Фух, было не просто");
            Console.ReadLine();
            Console.Clear();
    
            stories.Chapter2();
            fights.Vibor();
            Console.Clear();
    
            stories.Chapter3();
            Player player4 = new Player(name, 3, 440, 1800);
            Monsters monster4 = new Monsters("Дракон", 4, 250, 2640);
            fights.FinalFight(player4.Health, monster4.Health, player4.Damage, monster4.Damage);
            player4.Level = 5;
            player4.Damage += 250;
            player4.Health += 650;
            Console.WriteLine($"Теперь ваш уровень равен: {player4.Level}, ваше здоровье равно: {player4.Health}, ваш урон равен: {player4.Damage}.");
            Console.ReadLine();
            Console.WriteLine("Победа!!!");
            Console.ReadLine();
        }
     }
  }