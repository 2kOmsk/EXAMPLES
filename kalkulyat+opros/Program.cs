﻿// Калькулятор 1

// Console.WriteLine("Введите через Enter первое число, оператор (+, -, *, /) и второе число:");
// double input1 = Convert.ToDouble(Console.ReadLine());
// string input2 = Console.ReadLine();
// double input3 = Convert.ToDouble(Console.ReadLine());

// double output = 0;

// if (input2 == "*") output = input1 * input3;
// if (input2 == "/") output = input1 / input3;
// if (input2 == "-") output = input1 - input3;
// if (input2 == "+") output = input1 + input3;

// Console.WriteLine($"{input1} {input2} {input3} = {output}");

// // Калькулятор 2

// // Ввести число, знак, второе число
// // Сохраняем число
// // если точка вместо знака, то стираем предыдущий ответ
// // с предыдущим ответом выполняем действия
// // символ q - выход из программы

// Console.WriteLine("Введите число");
// double result = Convert.ToInt32(Console.ReadLine());
// char sign=' ';

// while (true)
// {
//     Console.WriteLine("Введите знак");
//     sign = Console.ReadKey().KeyChar;
//     if (sign=='q' )
//     break;

//     Console.WriteLine();

//     Console.WriteLine("Введите число");
//     int B = Convert.ToInt32(Console.ReadLine());

//     switch (sign)
//     {
//         case '+':
//             result = result + B;
//             break;
//         case '-':
//             result = result - B;
//             break;
//         case '*':
//             result = result * B;
//             break;
//         case '/':
//             result = result / B;
//             break;
//         case '.':
            
//             result = 0;
//             break;

//         default:
//             Console.WriteLine("Error! Wrong sign!");
//             break;
//     }
//     Console.WriteLine($"Result is {result}");
// }

Console.Clear();
Console.WriteLine("Добро пожаловать в передачу 'Кто хочет стать миллионером!'");
Console.WriteLine();
 
string[] questions = {
"Какие из перечисленных ниже программ являются антивирусными?",
"Какого типа графики не существует?",
"Когда появился термин «информационные технологии» в современном значении?",
"В каком году компанией IBM был выпущен первый в истории жесткий диск?",
"Какая поисковая система была самой популярной в 2011 году?",
"Страна лидер по количеству суперкомпьютеров?",
"Какого Интернет-браузера не существует?",
"Какая страна является родиной Интернета?",
"Какие из клавиш клавиатуры относятся к группе функциональных?",
"Какую скорость передачи данных может обеспечить широкополосная связь по ЛЭП?"
};
 
string[,] answers = {
{"MS Word", "Dr.Web", "Chrome", "PDFreader", "Dr.Web"},
{"Растровая", "Векторная", "Облачная", "Трехмерная", "Облачная"},
{"В 1893 году", "В 1990 году", "В 1958 году", "В 1902 году", "В 1958 году"},
{"В 1956 году", "В 1958 году", "В 1955 году", "В 1957 году", "В 1956 году"},
{"Yahoo!", "Google", "Bing", "Yandex", "Google"},
{"Китай", "США", "Япония", "Россия", "Китай"},
{"MS PowerPoint", "Opera", "Google Chrome", "Internet Explorer", "MS PowerPoint"},
{"Китай", "Россия", "Великобритания", "США", "США"},
{"F1-F12", "CTRL, ALT, Shift", "Windows","Tab",  "F1-F12"},
{"200 МБит/с", "1 МБит/с", "100 МБит/с", "10 МБит/с", "100 МБит/с"}
};
 
int trueCounter = 0;
bool fiftyOnFifty = true;
for (int i = 0; i < questions.Length; i++)
{
    Console.WriteLine($"Вопрос {i + 1}:");
    Console.WriteLine(questions[i]);
 
    for (int j = 0; j < 4; j++)
    {
        Console.WriteLine($"{j + 1}) {answers[i, j]}");
    }
 
    if (fiftyOnFifty)
    {
        Console.WriteLine($"Введите номер ответа или '0' для 50 на 50: ");
    }
    else
    {
        Console.WriteLine($"Введите номер ответа: ");
    }
 
    int answer = Convert.ToInt32(Console.ReadLine());
 
    if (answer == 0 && fiftyOnFifty)
    {
        int firstAnswer = 0;
        int secondAnswer = 0;
        while (answers[i, firstAnswer] == answers[i, 4] || answers[i, secondAnswer] != answers[i, 4])
        {
            firstAnswer = new Random().Next(0, 4);
            secondAnswer = new Random().Next(0, 4);
        }
 
        Console.WriteLine($"{firstAnswer + 1}) {answers[i, firstAnswer]}");
        Console.WriteLine($"{secondAnswer + 1}) {answers[i, secondAnswer]}");
 
        fiftyOnFifty = false;
 
        Console.WriteLine($"Введите номер ответа: ");
        answer = Convert.ToInt32(Console.ReadLine());
    }
    else if (answer == 0 && !fiftyOnFifty)
    {
        Console.WriteLine("Вы уже использовали подсказку!");
        Console.WriteLine();
        i--;
        continue;
    }
 
 
    if (answers[i, answer - 1] == answers[i, 4] && answer > 0 && answer < 5)
    {
        trueCounter++;
        Console.WriteLine("И это правильный ответ!");
    }
    else
    {
        Console.WriteLine("Вы ответили неверно!");
    }
    Console.WriteLine();
}
 
Console.WriteLine($"Игра окончена! Ваш результат: {trueCounter} из 10!");
