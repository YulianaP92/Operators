using System;


namespace B3_P9_9.CreaditCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            LoanСalculator();
            Console.ReadKey();
        }

        static void LoanСalculator()
        {
            Console.Write("Enter loan amount: ");
            var credit = Double.Parse(Console.ReadLine()); //Сумма кредита
            Console.Write("Enter loan percent: ");
            var percent = Double.Parse(Console.ReadLine()); //Процент кредита
            var monthPercent = Math.Round((percent / 12 / 100), 4); //Eжемесячная процентная ставка
            var payment = Math.Round((credit / 12), 2); //Ежемесячный платеж

            var monthPercent_1 = credit * monthPercent; //Eжемесячная процентная ставка для первого месяца выплаты
            var payment_1 = payment + monthPercent_1; //Первый платеж
            var sumPercent = monthPercent_1; //Сумма процентов
            var sumPayment = payment; //Сумма основного долга
            var month = 1; //Номер месяца выплаты
            Console.WriteLine("{0} month: {1:#.##} rub", month, payment_1);

            for (int i = 0; i < 11; i++)
            {
                var x = credit -= payment; //Кредит-Ежемесячный платеж
                monthPercent_1 = (x) * monthPercent;
                var payment_2 = payment + monthPercent_1;//Последующие платежи
                Console.WriteLine("{0} month: {1:#.##} rub", ++month, payment_2);
                sumPercent += monthPercent_1;
                sumPayment += payment;
            }
            var sum = Math.Round((sumPercent + sumPayment), 2); //Общая сумма выплат за год
            Console.WriteLine("Total payout: {0} rub", sum);
        }
    }
}
