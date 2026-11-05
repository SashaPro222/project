// Банковский счет
int balance = 1200000;
int goodpass = 9999;
bool unlock = false;
int go = -3;
string[] history = { "Нет данных", "Нет данных", "Нет данных" };
void auth()
{
    System.Console.WriteLine("Добро пожаловать в СаньКофф Банк!");


    int count = 1;
    while (count <= 3)
    {
        System.Console.WriteLine("Введите свой 4-х значный код доступа:");
        int password = int.Parse(Console.ReadLine()!);
        if (password == goodpass)
        {
            System.Console.WriteLine("Добро пожаловать в личный кабинет!");
            unlock = true;
            break;

        }
        else
        {
            System.Console.WriteLine($"Пароль не верный! Использовано попыток {count}/3");
            count++;
        }
    }
    if (count == 4)
    {
        System.Console.WriteLine("Доступ заблокирован! Вы превысили лимит ввода пароля! Позвоните Александру!");
    }
}
void menu()
{
    System.Console.WriteLine("Функции:");
    System.Console.WriteLine("1 - Показать баланс");
    System.Console.WriteLine("2 - Снять деньги");
    System.Console.WriteLine("3 - Пополнить баланс");
    System.Console.WriteLine("4 - Перевести деньги");
    System.Console.WriteLine("5 - История");
    System.Console.WriteLine("0 - Выход из кабинета");

}
if (unlock == false)
{
    auth();
}
while (unlock == true)
{
    menu();
    go = int.Parse(Console.ReadLine()!);
    if (go == 0)
    {
        unlock = false;
        auth();
    }
    else if (go == 1)
    {
        System.Console.WriteLine($"Ваш баланс = {balance}");
        bool back = false;
        while (back == false)
        {
            System.Console.WriteLine("Чтобы вернуться в меню введите 1");
            int mainback = int.Parse(Console.ReadLine()!);
            if (mainback == 1)
            {
                back = true;
            }
        }
    }
    else if (go == 2)
    {
        bool back = false;
        while (back == false)
        {
            System.Console.WriteLine("Введить сколько денег хотите снять:");
            int snatie = int.Parse(Console.ReadLine()!);

            System.Console.WriteLine("Ттрррр....");
            System.Console.WriteLine("Ттрррр....");
            System.Console.WriteLine("Ттрррр....");
            if (snatie > balance)
            {
                System.Console.WriteLine("Недостаточно средств!");
                menu();
            }
            else
            {
                System.Console.WriteLine("Еще немного... готовим купюры...");
                System.Console.WriteLine("Ттрррр....");
                balance = balance - snatie;
                istoia();
                history[2] = $"Снятие на сумму {snatie}";
                System.Console.WriteLine("Успешно! Деньги выданы!");
            }
            System.Console.WriteLine("Чтобы вернуться в меню введите 1");
            int mainback = int.Parse(Console.ReadLine()!);
            if (mainback == 1)
            {
                back = true;
            }
        }

    }
    else if (go == 3)
    {
        bool back = false;
        while (back == false)
        {
            System.Console.WriteLine("Введить на какую сумму пополнение:");
            int popolnenie = int.Parse(Console.ReadLine()!);
            System.Console.WriteLine("Ттрррр....");
            System.Console.WriteLine("Еще немного... отправляю данные в банк...");
            System.Console.WriteLine("Ттрррр....");
            System.Console.WriteLine("Соединение с защищенным каналом....");
            System.Console.WriteLine("Ттрррр....");
            balance = balance + popolnenie;
            istoia();
            history[2] = $"Пополнение на сумму {popolnenie}";
            System.Console.WriteLine("Успешно! Деньги зачислены!");
            System.Console.WriteLine("Спасибо, что выбираете СаньКофф - ведь он такой 1");
            System.Console.WriteLine("Чтобы вернуться в меню введите 1");
            int mainback = int.Parse(Console.ReadLine()!);
            if (mainback == 1)
            {
                back = true;
            }
        }

    }
    else if (go == 4)
    {
        bool back = false;
        while (back == false)
        {
            System.Console.WriteLine("Введить номер телефона для перевода в формате 79999999999:");
            string telefon = Console.ReadLine()!;
            if (telefon.Length == 11 && telefon[0] == '7' || telefon[0] == '8')
            {
                System.Console.WriteLine("Введить сумму перевода:");
                int sum = int.Parse(Console.ReadLine()!);
                System.Console.WriteLine("Обработка....");
                System.Console.WriteLine("Еще немного... отправляю данные в банк...");
                System.Console.WriteLine("Ожидаю ответ от банка получателя....");
                System.Console.WriteLine("Соединение с защищенным каналом....");
                System.Console.WriteLine("Ттрррр....");
                if (sum >= 10000)
                {
                    System.Console.WriteLine("Внимание! Слишком большая сумма, банк проверит платеж! Переводя деньги под влиянием мошенников - банк вернуть не сможет их");
                    for (int i = 0; i < 1999999999; i++) { }
                    System.Console.WriteLine("Не нашли в платеже ничего подозрительного, простите за доставленные неудобства, ваша безопасность - наш приоритет!");
                    balance = balance - sum;
                    istoia();
                    history[2] = $"{sum} переведена на номер {telefon}!";
                    System.Console.WriteLine($"{sum} переведена на номер {telefon}");
                }
                else
                {
                    balance = balance - sum;
                    istoia();
                    history[2] = $"{sum} переведена на номер {telefon}!";
                    System.Console.WriteLine($"{sum} переведена на номер {telefon}");
                    System.Console.WriteLine("Банков много, а СаньКофф - один");
                }
            }
            else
            {
                System.Console.WriteLine("Номер телефона не верный! Проверьте телефон еще раз");
            }
            System.Console.WriteLine("Чтобы вернуться в меню введите 1");
            int mainback = int.Parse(Console.ReadLine()!);
            if (mainback == 1)
            {
                back = true;
            }
        }

    }
    else if (go == 5)
    {
        bool back = false;
        while (back == false)
        {
            System.Console.WriteLine("История операций(Последние три):");
            foreach (string a in history)
            {
                System.Console.WriteLine(a);
            }
            System.Console.WriteLine("Чтобы вернуться в меню введите 1");
            int mainback = int.Parse(Console.ReadLine()!);
            if (mainback == 1)
            {
                back = true;
            }
        }
    }
    void istoia()
    {
        for (int i = 0; i < 1; i++)
        {
            history[0] = history[1];
        }
        for (int i = 0; i < 1; i++)
        {
            history[1] = history[2];
        }
    }
}
