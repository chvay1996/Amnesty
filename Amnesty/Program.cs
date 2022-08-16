using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amnesty
{
    class Program
    {
        static void Main ( string [] args )
        {
            Work work = new Work ();
            work.Works ();
        }
    }

    class Work
    {
        private List<Criminal> _criminals = new List<Criminal> ();

        public Work ()
        {
            _criminals.Add ( new Criminal ( "Абрам Роман Петрович", "Антиправительственное" ) );
            _criminals.Add ( new Criminal ( "Грозный Иван Иванович", "Убийство" ) );
            _criminals.Add ( new Criminal ( "Вова Викторович Колбасин", "Насилие" ) );
            _criminals.Add ( new Criminal ( "Сергей Алексеевич Федоров", "Антиправительственное" ) );
            _criminals.Add ( new Criminal ( "Султан Никитович Носков", "Грабеж" ) );
            _criminals.Add ( new Criminal ( "Кирилл Николаевич Юдин", "Распростронение и употребление" ) );
            _criminals.Add ( new Criminal ( "Алексей Викторович Папонин", "Антиправительственное" ) );
            _criminals.Add ( new Criminal ( "Алах Аламович Алахич", "Взлом" ) );
            _criminals.Add ( new Criminal ( "Александр Тимурович Гарбов", "Антиправительственное" ) );
            _criminals.Add ( new Criminal ( "Пётр Александрович Головач", "Фольшивоманетчик" ) );
            _criminals.Add ( new Criminal ( "Хабиб Хабибович Хабибов", "Антиправительственное" ) );
            _criminals.Add ( new Criminal ( "Вова Викторович Колбасин", "Убийство" ) );
            _criminals.Add ( new Criminal ( "Вадим Петрович Хлебкин", "Антиправительственное" ) );
        }

        public void Works ()
        {
            bool isWork = true;
            string input;

            while ( isWork == true )
            {
                Console.WriteLine ( "В нашей великой стране Арстоцка произошла амнистия!" +
                    "\nВсех людей заключенных за преступление \"Антиправительственное\" следует исключить из списка заключенных." +
                    "\nВыбирете пункт действия!"+
                    "\n1 - Исключить из списка" +
                    "\n2 - Посмотреть список всех заключеных." +
                    "\n3 - Exit");
                input = Console.ReadLine ();

                switch ( input )
                {
                    case "1":
                        Remove ();
                        break;
                    case "2":
                        ShowInfo ();
                        break;
                    case "3":
                        isWork = false;
                        break;
                    default:
                        Console.WriteLine ("Кмх... Кажется что-то пошло не так!");
                        break;
                }
                Console.ReadLine ();
                Console.Clear ();
            }
        }

        private void Remove ()
        {
            Console.WriteLine ( "Все люди заключенне за преступление \"Антиправительственное\" освобождаются." );
            Console.WriteLine ( "\nОсталисть\n" );

            _criminals.RemoveAll ( Criminal => Criminal.Punishment == "Антиправительственное" );

            ShowInfo ();
        }

        private void ShowInfo ()
        {
            foreach ( var criminals in _criminals )
            {
                criminals.ShowDetails ();
            }
        }
    }

    class Criminal
    {
        public Criminal(string fio , string punishment )
        {
            Punishment = punishment;
            FIO = fio;
        }

        public string Punishment { get; private set; }
        public string FIO { get; private set; }

        public void ShowDetails ()
        {
            Console.WriteLine ( $"\n{FIO} седит за {Punishment}" );
        }
    }
}
/*Задача:
В нашей великой стране Арстоцка произошла амнистия!
Всех людей заключенных за преступление "Антиправительственное" следует исключить из списка заключенных.
Есть список заключенных, каждый заключенный состоит из полей: ФИО, преступление.
Вывести список до амнистии и после.*/