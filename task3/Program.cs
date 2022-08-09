// 3. Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.WriteLine("введите число 1 до 7:");
int num = Convert.ToInt32(Console.ReadLine());
string day = "";
if (num >= 1 && num <=7)
    {
        switch (num)
        {
        case 1:
            day = "понедельник";
            break;
        case 2:
            day = "вторник";
            break;
        case 3:
            day = "среда";
            break;
        case 4:
            day = "четверг";
            break;
        case 5:
            day = "пятница";
            break;
        case 6:
            day = "суббота";
            break;
        case 7:
            day = "воскресенье";
            break;
        }
        Console.WriteLine("день недели: " + day);

    }    


