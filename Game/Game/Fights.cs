using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Game
{
    internal class Fights
    {
        private string name;

        public void FightTheRobber(double playerhealth, double monsterhealth, double playerdamage, double monsterdamage)

        {
            Console.WriteLine("");
            Console.WriteLine("                  Бой с разбойником начинается");
            Console.WriteLine("");
            double ph = playerhealth;
            double mh = monsterhealth;
            double pd = playerdamage;
            double md = monsterdamage;
            while (ph > 0 && mh > 0)
            {
                ph = ph - md;
                Console.WriteLine($"Разбойник наносит удар - {md} урона");
                Console.WriteLine("");
                Console.WriteLine($"Ваш уровень здоровья - {ph}");
                Console.WriteLine("");
                mh = mh - pd;
                Console.WriteLine($"Вы наносите удар - {pd}");
                Console.WriteLine("");
                Console.WriteLine($"Уровень здоровья разбойника - {mh} урона");
                Console.ReadLine();

            }
            if (mh <= 20)
            {

                Console.WriteLine("");
                Console.WriteLine("Я не хотел смерти этого мужчины, но моя жизнь мне дороже.");
                Console.ReadLine();
            }
            else if (ph <= 20)
            {

                Console.Clear();
                Death();
            }
        }

        public void Vibor()
        {
            Fights fights = new Fights();
            Story stories = new Story();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("");
            Console.WriteLine("                             Какой дорогой пойдем?");
            Console.WriteLine("");
            Console.WriteLine("                             Через горы или поле?");
            Console.WriteLine("");
            Console.WriteLine("                            Введите Горы или Поле");
            string choice = Convert.ToString(Console.ReadLine());
            switch (choice)
            {
                case "Горы":
                    Console.WriteLine("                         Отправимся дальше через горы!");
                    Console.ReadLine();
                    Console.Clear();
                    stories.MountainRoad();
                    Player player = new Player(name, 2, 240, 1200);
                    Monsters monster = new Monsters("Рысь", 1, 120, 1920);
                    fights.FightInMountain(player.Health, monster.Health, player.Damage, monster.Damage);
                    player.Level = 3;
                    player.Damage += 200;
                    player.Health += 600;
                    Console.WriteLine($"Теперь ваш уровень равен: {player.Level}, ваше здоровье равно: {player.Health}, ваш урон равен: {player.Damage}.");
                    Console.ReadLine();
                    Console.WriteLine("Чудом уцелел.");
                    Console.ReadLine();
                    break;
                case "горы":
                    Console.WriteLine("                         Отправимся дальше через горы!");
                    Console.ReadLine();
                    Console.Clear();
                    stories.MountainRoad();
                    Player player_1 = new Player(name, 2, 240, 1200);
                    Monsters monster_1 = new Monsters("Рысь", 1, 120, 1920);
                    fights.FightInMountain(player_1.Health, monster_1.Health, player_1.Damage, monster_1.Damage);
                    player_1.Level = 3;
                    player_1.Damage += 200;
                    player_1.Health += 600;
                    Console.WriteLine($"Теперь ваш уровень равен: {player_1.Level}, ваше здоровье равно: {player_1.Health}, ваш урон равен: {player_1.Damage}.");
                    Console.ReadLine();
                    Console.WriteLine("Чудом уцелел.");
                    Console.ReadLine();
                    break;
                case "ГОРЫ":
                    Console.WriteLine("                         Отправимся дальше через горы!");
                    Console.ReadLine();
                    Console.Clear();
                    stories.MountainRoad();
                    Player player_2 = new Player(name, 2, 240, 1200);
                    Monsters monster_2 = new Monsters("Рысь", 1, 120, 1920);
                    fights.FightInMountain(player_2.Health, monster_2.Health, player_2.Damage, monster_2.Damage);
                    player_2.Level = 3;
                    player_2.Damage += 200;
                    player_2.Health += 600;
                    Console.WriteLine($"Теперь ваш уровень равен: {player_2.Level}, ваше здоровье равно: {player_2.Health}, ваш урон равен: {player_2.Damage}.");
                    Console.ReadLine();
                    Console.WriteLine("Чудом уцелел.");
                    Console.ReadLine();
                    break;
                case "поле":
                    Console.WriteLine("                         Отправимся дальше через поле!");
                    Console.ReadLine();
                    Console.Clear();
                    stories.FieldRoad();
                    Player player1 = new Player(name, 2, 240, 1200);
                    Monsters monster1 = new Monsters("Огр", 1, 120, 1920);
                    fights.FightInField(player1.Health, monster1.Health, player1.Damage, monster1.Damage);
                    player1.Level = 3;
                    player1.Damage += 200;
                    player1.Health += 600;
                    Console.WriteLine($"Теперь ваш уровень равен: {player1.Level}, ваше здоровье равно: {player1.Health}, ваш урон равен: {player1.Damage}.");
                    Console.ReadLine();
                    Console.WriteLine("Чудом уцелел.");
                    Console.ReadLine();
                    break;
                case "ПОЛЕ":
                    Console.WriteLine("                         Отправимся дальше через поле!");
                    Console.ReadLine();
                    Console.Clear();
                    stories.FieldRoad();
                    Player player2 = new Player(name, 2, 240, 1200);
                    Monsters monster2 = new Monsters("Огр", 1, 120, 1920);
                    fights.FightInField(player2.Health, monster2.Health, player2.Damage, monster2.Damage);
                    player2.Level = 3;
                    player2.Damage += 200;
                    player2.Health += 600;
                    Console.WriteLine($"Теперь ваш уровень равен: {player2.Level}, ваше здоровье равно: {player2.Health}, ваш урон равен: {player2.Damage}.");
                    Console.ReadLine();
                    Console.WriteLine("Чудом уцелел.");
                    Console.ReadLine();
                    break;
                case "Поле":
                    Console.WriteLine("                         Отправимся дальше через поле!");
                    Console.ReadLine();
                    Console.Clear();
                    stories.FieldRoad();
                    Player player3 = new Player(name, 2, 240, 1200);
                    Monsters monster3 = new Monsters("Огр", 1, 120, 1920);
                    fights.FightInField(player3.Health, monster3.Health, player3.Damage, monster3.Damage);
                    player3.Level = 3;
                    player3.Damage += 200;
                    player3.Health += 600;
                    Console.WriteLine($"Теперь ваш уровень равен: {player3.Level}, ваше здоровье равно: {player3.Health}, ваш урон равен: {player3.Damage}.");
                    Console.ReadLine();
                    Console.WriteLine("Чудом уцелел.");
                    Console.ReadLine();
                    break;
                default: 
                    Console.WriteLine("Странный ты конечно. Варианты выбора были же совершенно другие.");
                    break;
                    
            }
        }

        public void FightInMountain(double playerhealth, double monsterhealth, double playerdamage, double monsterdamage)
        {
            Console.WriteLine("");
            Console.WriteLine("                  Бой с Рысью начинается");
            Console.WriteLine("");
            double ph = playerhealth;
            double mh = monsterhealth;
            double pd = playerdamage;
            double md = monsterdamage;
            while (ph > 0 && mh > 0)
            {
                ph = ph - md;
                Console.WriteLine($"Рысь наносит удар - {md} урона");
                Console.WriteLine("");
                Console.WriteLine($"Ваш уровень здоровья - {ph}");
                Console.WriteLine("");
                mh = mh - pd;
                Console.WriteLine($"Вы наносите удар - {pd}");
                Console.WriteLine("");
                Console.WriteLine($"Уровень здоровья рыси - {mh} урона");
                Console.ReadLine();

            }
            if (mh <= 20)
            {

                Console.WriteLine("");
                Console.WriteLine("Мне удалось пронзить тело рыси мечом, и мы оба свалились на землю жестоко раненные.");
                Console.ReadLine();
                Console.WriteLine("Осмотрев тело радости во мне было не много, ведь путь к замку дракона был еще долгим и опасным.");
                Console.ReadLine();
            }
            else if (ph <= 20)
            {

                Console.Clear();
                Death();
            }
        }

        public void FightInField(double playerhealth, double monsterhealth, double playerdamage, double monsterdamage)
        {
            Console.WriteLine("");
            Console.WriteLine("                  Бой с Огром начинается");
            Console.WriteLine("");
            double ph = playerhealth;
            double mh = monsterhealth;
            double pd = playerdamage;
            double md = monsterdamage;
            while (ph > 0 && mh > 0)
            {
                ph = ph - md;
                Console.WriteLine($"Огр наносит удар - {md} урона");
                Console.WriteLine("");
                Console.WriteLine($"Ваш уровень здоровья - {ph}");
                Console.WriteLine("");
                mh = mh - pd;
                Console.WriteLine($"Вы наносите удар - {pd}");
                Console.WriteLine("");
                Console.WriteLine($"Уровень здоровья огра - {mh} урона");
                Console.ReadLine();

            }
            if (mh <= 20)
            {

                Console.WriteLine("");
                Console.WriteLine("Наконец, я смог нанести ему смертельный удар и вырвать сердце из груди.");
                Console.ReadLine();
                Console.WriteLine("Я продолжал свой путь, но уже осторожнее.");
                Console.ReadLine();
            }
            else if (ph <= 20)
            {

                Console.Clear();
                Death();
            }
        }

        public void FinalFight(double playerhealth, double monsterhealth, double playerdamage, double monsterdamage)
        {
            Console.WriteLine("");
            Console.WriteLine("                  Бой с Драконом начинается");
            Console.WriteLine("");
            double ph = playerhealth;
            double mh = monsterhealth;
            double pd = playerdamage;
            double md = monsterdamage;
            while (ph > 0 && mh > 0)
            {
                ph = ph - md;
                Console.WriteLine($"Дракон наносит удар - {md} урона");
                Console.WriteLine("");
                Console.WriteLine($"Ваш уровень здоровья - {ph}");
                Console.WriteLine("");
                mh = mh - pd;
                Console.WriteLine($"Вы наносите удар - {pd}");
                Console.WriteLine("");
                Console.WriteLine($"Уровень здоровья дракона - {mh} урона");
                Console.ReadLine();

            }
            if (mh <= 20)
            {

                Console.WriteLine("");
                Console.WriteLine("Наконец, я призвал всю свою силу и нанес смертельный удар в голову дракона.");
                Console.ReadLine();
                Console.WriteLine("Принцесса спасена. ");
                Console.ReadLine();
            }
            else if (ph <= 20)
            {

                Console.Clear();
                Death();
            }
        }
        public void Death()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                           Вы мертвы");
            Console.ReadLine();
            Environment.Exit(0);
        }
    }
}
