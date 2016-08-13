using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat
{
    //класс банковская карточка
    class Card
    {
        int pinCode;    //pin код карточки
        int balance;    //баланс на счету
        int cnt;        //количество оставшихся попыток входа

        private bool enterFlag; //успешность входа

        public bool EnterFlag
        {
            get { return enterFlag; }
        }

        public int Cnt
        {
            get { return cnt; }
        }

        public Card()           //конструктор
        {
            pinCode = 1234;     //устанавливаем пароль 1234
            balance = 10000;    //баланс 10000
            cnt = 3;            //количество попыток 3

        }

        public Card(int pinCode, int balance)   //конструктор с параметрами
        {
            this.pinCode = pinCode;
            this.balance = balance;
            cnt = 3;

        }
        /// <summary>
        /// подучить деньги
        /// </summary>
        public void giveCashe()
        {
            try
            {
                Console.Write("How much money you want to receive?: ");
                int sum = int.Parse(Console.ReadLine());
                
                //выдаем деньги в том случае , если снимают не больше, чем сумма на счету
                balance = (balance >= sum)       
                    ? (balance - sum)
                    : balance;

                Console.WriteLine("Your balanse is {0}", balance);

            }
            catch
            {
                Console.WriteLine("Error cashe sum!");
            }
            
        }

        /// <summary>
        /// показать баланс по карте
        /// </summary>
        public void showBalance()
        {
            Console.Clear();
            
            Console.WriteLine("Your balance is {0}", balance);
            Console.ReadKey();
        }


        /// <summary>
        /// сменить PIN код
        /// </summary>
        public void changePinCode()
        {
            try
            {
                Console.Write("Enter new pin code: ");
                pinCode = int.Parse(Console.ReadLine());

                Console.Write("Pin succesfully changed");
            }
            catch
            {
                Console.WriteLine("error pin code");
            }

            finally
            {
                Console.ReadKey();
            }
        }

        /// <summary>
        /// ввод PIN код
        /// </summary>
        /// <returns>успешность ввода кода</returns>
        public bool enterPinCode()
        {
            try
            {
                Console.Write("Enter your pin code: ");
                if (pinCode == int.Parse(Console.ReadLine()))
                {
                    enterFlag = true;
                    return true;
                }
                else
                {
                    this.cnt--;
                    enterFlag = false;
                    Console.WriteLine("Wrong PIN! , you have {0} attempt(s) more!", cnt);
                    return false;
                }

            }
            catch
            {
                enterFlag = false;
                return false;
                
            }

        }

    }
}
