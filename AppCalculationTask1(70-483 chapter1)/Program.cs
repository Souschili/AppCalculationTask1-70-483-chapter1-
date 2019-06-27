using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCalculationTask1_70_483_chapter1_
{
    class Program
    {
        static void Main(string[] args)
        {


           

            //Состояние приложения для основного цикла( вкл или выкл)
            bool isActive = true;


            //жизненый цикл программы
            do
            {
                //Очистка экрана
                Console.Clear();

                //вывод меню
                Console.WriteLine("1 - Addition ");
                Console.WriteLine("2 - Subtraction");
                Console.WriteLine("3 - Multipliation");
                Console.WriteLine("4 - Division");

                //ловим выбор меню
                int chooce;
                //проверяем число или нет
                if(!Int32.TryParse(Console.ReadLine(),out chooce))
                {
                    Console.WriteLine("Неверный ввод !! ");
                    continue;
                }

                //переменые для выражения,при каждой итерации пересоздаются
                //тип дабл выбран для удобства при делении, 5\2=2.5 в случае с интом мы получим 2
                double val1;
                double val2;
                double rezult;

                //запрос чисел и проверка число ли это
                Console.Write("Input value1 :");
                if(!Double.TryParse(Console.ReadLine(), out  val1))
                {
                    Console.WriteLine("Некоректное значение val1 !!!!");
                    continue;
                }
                //Console.WriteLine(val1);

                Console.Write("Input value1 :");
                if(!Double.TryParse(Console.ReadLine(), out val2))
                {
                    Console.WriteLine("Некоректное значение val1 !!!!");
                }
                //Console.WriteLine(val1);
                // через свитч выбираем выражение
                switch (chooce)
                {
                    
                    case 1:
                        rezult = val1 + val2;
                        Console.WriteLine("{0} + {1} = {2}",val1,val2,rezult);
                        break;
                    case 2:
                        rezult = val1 - val2;
                        Console.WriteLine("{0} - {1} = {2}", val1, val2, rezult);
                        break;

                    case 3:
                        rezult = val1*val2;
                        Console.WriteLine("{0} * {1} = {2}", val1, val2, rezult);
                        break;

                    case 4:
                        if((int)val2 != 0)
                        {
                            rezult = val1/val2;
                            Console.WriteLine("{0} / {1} = {2}", val1, val2, rezult);
                        }
                        else
                        {
                            Console.WriteLine("В этой вселенной на ноль делить нельзя!");
                        }
                        break;
                    default:
                        break;
                }


                //запрос продолжить или нет 
                while(true)
                {
                    
                    Console.Write("\nПродолжаем Y / N :");
                    //считываем символ
                    char ch = Console.ReadKey().KeyChar;

                    if( ch=='N'  || ch=='n')
                    {
                        isActive = false;
                        Console.WriteLine("\nспасибо что воспользовались нашей программой !!! ");
                        Console.WriteLine("Нажмите любую клавищу для завершения....");
                        Console.ReadLine();
                        break;
                    } else if(ch=='Y' || ch=='y')
                    {
                        Console.WriteLine("\nЭкран будет очищке...сохраните вычисления)");
                        Console.ReadLine();
                        break;
                    }
                    
                   
                }




            } while (isActive);
        }
    }
}
