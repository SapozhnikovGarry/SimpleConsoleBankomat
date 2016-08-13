using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat
{
    /// <summary>
    /// Класс банкомат
    /// </summary>
    class Bankomat
    {
        /// <summary>
        /// Показ главного меню
        /// </summary>
        /// <param name="c">Карточка пользователя</param>
        public void showMenu(Card c)
        {
            do
            {
                Console.Clear();

                Console.WriteLine("1. Cache");
                Console.WriteLine("2. Show balance");
                Console.WriteLine("3. Change PIN");
                Console.WriteLine("0. Exit");

                Console.Write("Your choice: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        c.giveCashe();      //запрос денег по карточке
                        if (goToMenu(c))
                            break;
                        else
                            return;
                    case "2":
                        c.showBalance();    //показать баланс по карточке
                        break;
                    case "3":
                        c.changePinCode();  //сменить PIN код
                        break;
                    case "0":
                        thanksForVisit();   //благодарим за визит в Банк
                        return;

                }

            } while (true);
        }


        /// <summary>
        /// Запрос выхода в главное Меню
        /// </summary>
        /// <param name="c">карточка пользователя</param>
        /// <returns>успешность выхода в меню</returns>
        private bool goToMenu(Card c)
        {
            Console.WriteLine("Do you want to go to the menu?");
            Console.WriteLine("0 - no, 1 - yep");

            string yourChoice = Console.ReadLine();

            switch (yourChoice)
            {
                default:
                case "0":
                    thanksForVisit();
                    return false;

                case "1":
                    if (c.enterPinCode())
                        return true;
                    else
                    {
                        Console.ReadKey();
                        return false;
                    }
            }
        }

        /// <summary>
        /// Благодарность за визит в Банк
        /// </summary>
        private void thanksForVisit()
        {
            Console.WriteLine("Thanks for visit");
            Console.ReadKey();
            Console.Clear();
        }

    }
}
