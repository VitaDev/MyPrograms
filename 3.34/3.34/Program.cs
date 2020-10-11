using System;

namespace _3._34
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Дано шахматное поле 8 на 8");
            int FirstCoord1;
            int SecondCoord1;
            int FirstCoord2;
            int SecondCoord2;
            do
            {
                Console.WriteLine("Вводите верные координаты");
                Console.WriteLine("Введите первые координаты поля:");
                FirstCoord1 = Convert.ToInt32(Console.ReadLine());
                SecondCoord1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите вторые координаты поля:");
                FirstCoord2 = Convert.ToInt32(Console.ReadLine());
                SecondCoord2 = Convert.ToInt32(Console.ReadLine());
            } while ((FirstCoord1 > 8 || FirstCoord1 <= 0) || (SecondCoord1 > 8 || SecondCoord1 <= 0) || (FirstCoord2 > 8 || FirstCoord2 <= 0) || (SecondCoord2 > 8 || SecondCoord2 <= 0) || ((FirstCoord1==FirstCoord2)&&(SecondCoord1==SecondCoord2)));
            int dif1 = FirstCoord2 - FirstCoord1;
            int dif2 = SecondCoord2 - SecondCoord1;
            int sum1 = FirstCoord2 + FirstCoord1;
            int sum2 = SecondCoord2 + SecondCoord1;
            void Ladya()
            {
                if (FirstCoord1 == FirstCoord2 || SecondCoord1 == SecondCoord2)
                {
                    Console.WriteLine("Ладья с координатами " + FirstCoord1 + ";" + SecondCoord1 + " угрожает полю с координатами " + FirstCoord2 + ";" + SecondCoord2);
                }
                else
                    Console.WriteLine("Ладья с координатами " + FirstCoord1 + ";" + SecondCoord1 + " не угрожает полю с координатами " + FirstCoord2 + ";" + SecondCoord2);
            }
            void Slon()
            {
                if (Math.Abs(dif1) == Math.Abs(dif2) || Math.Abs(sum1) == Math.Abs(sum2))
                {
                    Console.WriteLine("Слон с координатами " + FirstCoord1 + ";" + SecondCoord1 + " угрожает полю с координатами " + FirstCoord2 + ";" + SecondCoord2);
                }
                else
                    Console.WriteLine("Слон с координатами " + FirstCoord1 + ";" + SecondCoord1 + " не угрожает полю с координатами " + FirstCoord2 + ";" + SecondCoord2);
            }
            void Ferz()
            {
                if (FirstCoord1 == FirstCoord2 || SecondCoord1 == SecondCoord2)
                {
                    Console.WriteLine("Король с координатами " + FirstCoord1 + ";" + SecondCoord1 + " угрожает полю с координатами " + FirstCoord2 + ";" + SecondCoord2);
                }
                else if (Math.Abs(dif1) == Math.Abs(dif2) || Math.Abs(sum1) == Math.Abs(sum2))
                {
                    Console.WriteLine("Король с координатами " + FirstCoord1 + ";" + SecondCoord1 + " угрожает полю с координатами " + FirstCoord2 + ";" + SecondCoord2);
                }
                else
                    Console.WriteLine("Король с координатами " + FirstCoord1 + ";" + SecondCoord1 + " не угрожает полю с координатами " + FirstCoord2 + ";" + SecondCoord2);
            }
            void King()
            {
                if (FirstCoord1 == FirstCoord2 && Math.Abs(dif2) == 1 || SecondCoord1 == SecondCoord2 && Math.Abs(dif1) == 1)
                {
                    Console.WriteLine("Король с координатами " + FirstCoord1 + ";" + SecondCoord1 + " угрожает полю с координатами " + FirstCoord2 + ";" + SecondCoord2);
                }
                else if (Math.Abs(dif1) == 1 && Math.Abs(dif2) == 1)
                {
                    Console.WriteLine("Король с координатами " + FirstCoord1 + ";" + SecondCoord1 + " угрожает полю с координатами " + FirstCoord2 + ";" + SecondCoord2);
                }
                else
                    Console.WriteLine("Король с координатами " + FirstCoord1 + ";" + SecondCoord1 + " не угрожает полю с координатами " + FirstCoord2 + ";" + SecondCoord2);
            }
            void Pawn()
            {
                Console.WriteLine("1 - Обычный ход (Белая пешка)\n2 - Атака (Белая пешка)\n3 - Обычный ход(Чёрная пешка)\n4 - Атака(Чёрная пешка)");
                int PawnCase = Convert.ToInt32(Console.ReadLine());
                switch (PawnCase)
                {
                    case 1:
                        if ((Math.Abs(dif2) == 1 && dif2 > 0) && (dif1 == 1)||(dif1 == - 1))
                        {
                        Console.WriteLine("Белая пешка с координатами " + FirstCoord1 + ";" + SecondCoord1 + " может пойти по диагонали в поле с координатами " + FirstCoord2 + ";" + SecondCoord2);
                        }
                        else if ((FirstCoord1==FirstCoord2 && dif2 == 1) || (FirstCoord1 == FirstCoord2 && dif2 == 2))
                        {
                            Console.WriteLine("Белая пешка с координатами " + FirstCoord1 + ";" + SecondCoord1 + " может пойти по вертикали в поле с координатами " + FirstCoord2 + ";" + SecondCoord2);
                        }
                        else
                            Console.WriteLine("Белая пешка с координатами " + FirstCoord1 + ";" + SecondCoord1 + " не может пойти в поле с координатами " + FirstCoord2 + ";" + SecondCoord2);
                        break;
                    case 2:
                        if ((Math.Abs(dif2) == 1 && dif2 > 0) && (dif1 == 1) || (dif1 == -1))
                        {
                            Console.WriteLine("Белая пешка с координатами " + FirstCoord1 + ";" + SecondCoord1 + " может атаковать по диагонали в поле с координатами " + FirstCoord2 + ";" + SecondCoord2);
                        }
                        else
                            Console.WriteLine("Белая пешка с координатами " + FirstCoord1 + ";" + SecondCoord1 + " не может атаковать по диагонали в поле с координатами " + FirstCoord2 + ";" + SecondCoord2);
                        break;
                    case 3:
                        if ((Math.Abs(dif2) == 1 && dif2 < 0) && ((dif1 == 1) || (dif1 == -1)))
                        {
                            Console.WriteLine("Чёрная пешка с координатами " + FirstCoord1 + ";" + SecondCoord1 + " может пойти по диагонали в поле с координатами " + FirstCoord2 + ";" + SecondCoord2);
                        }
                        else if ((FirstCoord1 == FirstCoord2 && dif2 == -1) || (FirstCoord1 == FirstCoord2 && dif2 == -2))
                        {
                            Console.WriteLine("Чёрная пешка с координатами " + FirstCoord1 + ";" + SecondCoord1 + " может пойти по вертикали в поле с координатами " + FirstCoord2 + ";" + SecondCoord2);
                        }
                        else
                            Console.WriteLine("Чёрная пешка с координатами " + FirstCoord1 + ";" + SecondCoord1 + " не может пойти в поле с координатами " + FirstCoord2 + ";" + SecondCoord2);
                        break;
                    case 4:
                        if ((Math.Abs(dif2) == 1 && dif2 < 0) && ((dif1 == 1) || (dif1 == -1)))
                        {
                            Console.WriteLine("Чёрна пешка с координатами " + FirstCoord1 + ";" + SecondCoord1 + " может атаковать по диагонали в поле с координатами " + FirstCoord2 + ";" + SecondCoord2);
                        }
                        else
                            Console.WriteLine("Чёрная пешка с координатами " + FirstCoord1 + ";" + SecondCoord1 + " не может атаковать по диагонали в поле с координатами " + FirstCoord2 + ";" + SecondCoord2);
                        break;
                }
            }
            Console.WriteLine("Выберите фигуру:\n1 - Ладья\n2 - Слон\n3 - Ферзь\n4 - Король\n5 - Пешка");
            int SwitchNumber = Convert.ToInt32(Console.ReadLine());
            switch (SwitchNumber)
            {
                case 1:
                    Ladya();
                    break;
                case 2:
                    Slon();
                    break;
                case 3:
                    Ferz();
                    break;
                case 4:
                    King();
                    break;
                case 5:
                    Pawn();
                    break;
            }
        }
    }
}
