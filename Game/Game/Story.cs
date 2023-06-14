using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Story
    {
        public void BeginGame()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                     Добро пожаловать в DragonFightForPrincess");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                             Готов(а) начать игру?");
            Console.WriteLine("");
            Console.WriteLine("                              Введите Да или Нет");
            string choice = Convert.ToString(Console.ReadLine());
            if (choice == "Да" || choice == "да" || choice == "ДА")
            {
                Console.WriteLine("                             Начнём же приключение!");
                Console.ReadLine();
                Console.Clear();
            }
            else if (choice == "нет" || choice == "НЕТ" || choice == "Нет")
            {
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("                       Очень жаль, надеюсь встретимся ещё!");
                Console.ReadLine();
                Environment.Exit(0);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("              К сожалению, такой ответ не принимается. Может, придумаешь что-нибудь другое?");
                Console.ReadLine();
                Environment.Exit(0);
            }
        }
        public void Chapter1()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
            Console.WriteLine("                               Начало истории");
            Console.ReadLine();
            Console.WriteLine("....................................");
            Console.ReadLine();
            Console.WriteLine("Совсем недавно королевство в котором я живу потерпело большое горе.");
            Console.ReadLine();
            Console.WriteLine("На него напал огромный, ужасающий дракон.");
            Console.ReadLine();
            Console.WriteLine("Он желал забрать принцессу в свой замок.");
            Console.ReadLine();
            Console.WriteLine("В противном же случае разрушить поселение, забрать все золото и скот.");
            Console.ReadLine();
            Console.WriteLine("В тот злаполучный день король принял сложнейшее решение в его жизни...");
            Console.ReadLine();
            Console.WriteLine("Отдал свою единственную дочь в лапы дракона чтобы защитить свой народ.");
            Console.ReadLine();
            Console.WriteLine("Королева не смогла смириться с решением супруга и вскоре подписала указ, который содержал следующее:");
            Console.ReadLine();
            Console.WriteLine("Спасший принцессу получит денежное вознагражение, а так же благословение от королевы.");
            Console.ReadLine();
            Console.WriteLine("Добровольцев было множество в их числе был и я.");
            Console.ReadLine();
            Console.WriteLine("Ничем не приметный крестьянин.");
            Console.ReadLine();
            Console.WriteLine("Но тем не менее со спортивным телосложением, далеко не страхолюдинка и к тому же владеющий мечом.");
            Console.ReadLine();
            Console.WriteLine("Большинство из тех кто отправился на поиски принцессы так и не вернулись.");
            Console.ReadLine();
            Console.WriteLine("Поэтому я решил не затягивать с походом и отправляться прямо сейчас.");
            Console.ReadLine();
            Console.WriteLine("Ведь где-то там сидит напуганая и совсем одинокая принцесса.");
            Console.ReadLine();
            Console.WriteLine("Времени на сборы ушло совсем немного. Собрал необходимое и отправился в путь.");
            Console.ReadLine();
            Console.WriteLine("Пошел я в направлении своих предшествеников, но вскоре был вынужден приостановить свой поход.");
            Console.ReadLine();
            Console.WriteLine("Внезапно, из леса послышался треск.");
            Console.ReadLine();
            Console.WriteLine("- Кто здесь?!");
            Console.ReadLine();
            Console.WriteLine("Ответом послужил повторный хруст");
            Console.ReadLine();
            Console.WriteLine("- Эй, выходи кто бы ты ни был!");
            Console.ReadLine();
            Console.WriteLine("Из-за деревьев показался мужчина средних лет.");
            Console.ReadLine();
            Console.WriteLine("Мне так и не объяснили намерений нападения. Завязалась драка. Пологаю это разбойник.");
            Console.ReadLine();
        }

        public void Chapter2()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
            Console.WriteLine("                             Предстоящий выбор");
            Console.ReadLine();
            Console.WriteLine("Преодолев первое испытание поход был продолжен ведь основная цель так и не была достигнута.");
            Console.ReadLine();
            Console.WriteLine("В каком направление необходимо было следовать пока было совершенно непонятно.");
            Console.ReadLine();
            Console.WriteLine("Постепенно начинало темнеть.");
            Console.ReadLine();
            Console.WriteLine("В момент я понял что в ночи можно нарваться на более опасных противников.");
            Console.ReadLine();
            Console.WriteLine("Поэтому решил переночевать в лесу у костра.");
            Console.ReadLine();
            Console.WriteLine("*На утро*");
            Console.ReadLine();
            Console.WriteLine("На мое удивление ночь прошла совсем спокойно и мирно.");
            Console.ReadLine();
            Console.WriteLine("Лишь изредка было слышно ночных птиц.");
            Console.ReadLine();
            Console.WriteLine("Запасы еще оставались, но из было не так много");
            Console.ReadLine();
            Console.WriteLine("Спустя некоторое время предо мной предстала развилка.");
            Console.ReadLine();
            Console.WriteLine("Стоял выбор: пройти через горную дорогу или отправиться по смешанным полям.");
            Console.ReadLine();
        }

        public void MountainRoad()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
            Console.WriteLine("                             Горная дорога");
            Console.ReadLine();
            Console.WriteLine("Это был тяжелый и опасный путь, но я знал, что это единственный способ попасть в замок дракона.");
            Console.ReadLine();
            Console.WriteLine("Шел медленно, стараясь избегать скользких участков горной тропы и не выпуская меч из рук.");
            Console.ReadLine();
            Console.WriteLine("Так как понимал, что вокруг могут скрываться опасные хищники.");
            Console.ReadLine();
            Console.WriteLine("Я прошел много миль и был уже близок к цели, когда наступила ночь.");
            Console.ReadLine();
            Console.WriteLine("Силы стремительно покидали меня и поэтому я стал искать место, где можно укрыться и отдохнуть.");
            Console.ReadLine();
            Console.WriteLine("В итоге нашел уютную пещеру.");
            Console.ReadLine();
            Console.WriteLine("Хотя темнота была плотной, я нашел что-то вроде топлива и разжег огонь.");
            Console.ReadLine();
            Console.WriteLine("Нужно было придумать как утолить голод. Недолго думая я выловил пару летучих мышей и поджарил их.");
            Console.ReadLine();
            Console.WriteLine("Я сидел у костра, думая об опасностях и о том, что меня ожидает на следующий день.");
            Console.ReadLine();
            Console.WriteLine("*Через некоторое время*");
            Console.ReadLine();
            Console.WriteLine("Наконец, я заснул, но не на долго.");
            Console.ReadLine();
            Console.WriteLine("Потому что услышал странные звуки, вызванные, вероятно, убийцей из соседней пещеры.");
            Console.ReadLine();
            Console.WriteLine("Я понимал, что в любой момент могу быть атакован, поэтому так и не смог заснуть.");
            Console.ReadLine();
            Console.WriteLine("После некоторых напрасных попыток заснуть я все-таки решил продолжить свой путь.");
            Console.ReadLine();
            Console.WriteLine("Чтобы не тратьть попусту время.");
            Console.ReadLine();
            Console.WriteLine("Из пещеры выходил неспешно и крайне осторожно, чтобы не столкнуться с ночным убийцей.");
            Console.ReadLine();
            Console.WriteLine("Все было тихо поэтому я слегка расслабился.");
            Console.ReadLine();
            Console.WriteLine("Вскоре на моем пути выскочила рысь, я сразу понял что это именно тот кого я опасался встретить.");
            Console.ReadLine();
            Console.WriteLine("Пасть рыси была окровавлена.");
            Console.ReadLine();
            Console.WriteLine("Выхватив меч, я стал защищаться от атаки зверя.");
            Console.ReadLine();
            Console.WriteLine("Но рысь была сильнее и быстрее меня, и я едва успел увернуться от ее первого прыжка.");
            Console.ReadLine();
            Console.WriteLine("Мы боролись в разных положениях, я пытался нанести роковой удар, но зверь оказался ловким и умелым бойцом.");
            Console.ReadLine();
        }

        public void FieldRoad()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
            Console.WriteLine("                             Полевая дорога");
            Console.ReadLine();
            Console.WriteLine("Я отправился по прямой на запад, через сельскую местность.");
            Console.ReadLine();
            Console.WriteLine("Шел неспешно, надеясь найти следы моих предшественников, но все было тщетно.");
            Console.ReadLine();
            Console.WriteLine("В округе не было ни единой души.");
            Console.ReadLine();
            Console.WriteLine("Многие покидали свои дома, чтобы не встретиться с драконом.");
            Console.ReadLine();
            Console.WriteLine("Близился вечер. Силы были на исходе и ужасно сильно хотелось есть.");
            Console.ReadLine();
            Console.WriteLine("Я разбил небольшой лагерь и разжег костер, чтобы согреться и приготовить еду.");
            Console.ReadLine();
            Console.WriteLine("Неподолеку разливалась небольшая речушка.");
            Console.ReadLine();
            Console.WriteLine("Незатейливым способом я заточил несовсем длинную палку и пошел ловить рыбу.");
            Console.ReadLine();
            Console.WriteLine("Улов вышел очень даже хороший.");
            Console.ReadLine();
            Console.WriteLine("После приготовления и заточения вкуснейшего ужина я отправился спать.");
            Console.ReadLine();
            Console.WriteLine("*На утро*");
            Console.ReadLine();
            Console.WriteLine("Проснулся с первыми лучами солнца, которые предательски слепили глаза.");
            Console.ReadLine();
            Console.WriteLine("Позавтракать мне не дали..");
            Console.ReadLine();
            Console.WriteLine("Откудо-то со стороны послышался страшный рев.");
            Console.ReadLine();
            Console.WriteLine("Как только я подскочил в поле зрения появился страшный огр.");
            Console.ReadLine();
            Console.WriteLine("Он смотрел на меня с недоверием и вниманием.");
            Console.ReadLine();
            Console.WriteLine("Это нечто было в два раза больше меня, и я понимал, что битва будет трудной.");
            Console.ReadLine();
            Console.WriteLine("Так же было очевидным и то, что он может разорвать меня на части.");
            Console.ReadLine();
            Console.WriteLine("Однако я не мог остановиться - принцесса нуждалась в моей помощи.");
            Console.ReadLine();
            Console.WriteLine("Я достал свой меч и начал выполнять комбинации, изо всех сил пытаясь увернуться от огромных ударов.");
            Console.ReadLine();
        }

        public void Chapter3()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
            Console.WriteLine("                             Финальная схватка");
            Console.ReadLine();
            Console.WriteLine("Наконец, я добрался до последнего перевала.");
            Console.ReadLine();
            Console.WriteLine("За ним раскинулся устрашающий замок выполненый в готическом стиле");
            Console.ReadLine();
            Console.WriteLine("На вершине, которого распологался спящий дракон.");
            Console.ReadLine();
            Console.WriteLine("Мной было принято решение тихо проникнуть в замок.");
            Console.ReadLine();
            Console.WriteLine("Кто знает может и резни избежать получится.");
            Console.ReadLine();
            Console.WriteLine("*Спустя время в замке*");
            Console.ReadLine();
            Console.WriteLine("Временное пространство расплылось для меня.");
            Console.ReadLine();
            Console.WriteLine("Понятия не имею сколько времени было убито пока я блуждал по замку в поисках принцессы..");
            Console.ReadLine();
            Console.WriteLine("В конце-концов я все же отыскал место ее заточения.");
            Console.ReadLine();
            Console.WriteLine("Оказавшись в комнате непроизвольно я столкнулся со взором принцессы.");
            Console.ReadLine();
            Console.WriteLine("В ее глазах таились надежда и отчаянье, переменяя друг друга");
            Console.ReadLine();
            Console.WriteLine("Безмолвно осободив принцессу от цепей, которые ее удерживали в комнате, мы отправились прочь.");
            Console.ReadLine();
            Console.WriteLine("К счастью я запоминал дорогу, которой шел.");
            Console.ReadLine();
            Console.WriteLine("Оставалось преодалеть лишь пару коридоров.");
            Console.ReadLine();
            Console.WriteLine("Как вдруг откудо-то сверху раздался рев и я понял, дракон уже почуял мое присутствие.");
            Console.ReadLine();
            Console.WriteLine("Я осознавал что дракон вероятнее будет поджидать нас у входа в замок.");
            Console.ReadLine();
            Console.WriteLine("Поэтому оставив принцессу подле выхода я смело шагнул за дверь.");
            Console.ReadLine();
            Console.WriteLine("На встречу самому устрашающему противнику на моем пути.");
            Console.ReadLine();
            Console.WriteLine("Лишь сейчас я осознал всю опасность своей миссии.");
            Console.ReadLine();
            Console.WriteLine("Я знал, что это будет самый трудный бой в моей жизни.");
            Console.ReadLine();
            Console.WriteLine("Отбросив пессимистичные мысли я  встал на защиту и начал битву с драконом.");
            Console.ReadLine();
            Console.WriteLine("Отбивая огненные струи его дыхания и атаки огромного тела.");
            Console.ReadLine();
        }
    }
}
