using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat
{
    /// <summary>
    /// Класс Пользователь
    /// </summary>
    class Person
    {
        public Card personCard;         //карточка пользователя

        //Конструктор, в котором создаем пользователю карточку со стандартными параметрами
        //PIN = 1234, balance = 10000, количество успешных ввода PIN = 3
        public Person()                 
        {
            personCard = new Card();
        }

        //Конструктор, в котором создаем пользователю карточку с определенными параметрами
        public Person(int pin, int cashe)
        {
            personCard = new Card(pin, cashe);
        }

        /// <summary>
        /// Ввод пароля
        /// </summary>
        /// <returns>Успешность входа</returns>
        public bool enterPass()
        {

            while (!personCard.enterPinCode())
                if (personCard.Cnt == 0) break;

            return personCard.EnterFlag;

        }
    }
}
