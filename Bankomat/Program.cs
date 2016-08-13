using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat
{
    class Program
    {
        static void Main()
        {
            //первый человек в очереди в банкомат
            Person Ivan = new Person(1212, 15000);  //Создаем персонажа Иван, с PIN = 1212 и на счету с 15000 грн
            Bankomat PrivatBank = new Bankomat();   //Создаем банкомат Приват Банка

            if (Ivan.enterPass())       //если введен верный пароль, загружаем меню банкомата
                PrivatBank.showMenu(Ivan.personCard);

        }
    }

}