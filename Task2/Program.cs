Console.Write("Введите первое целое число: ");
string inputA = Console.ReadLine();
Console.Write("Введите второе целое число: ");
string inputB = Console.ReadLine();
Console.Write("Введите второе целое число: ");
string inputC = Console.ReadLine();

// парсим ввод юзера
bool isNumberA = Int32.TryParse(inputA, out int numberA);
bool isNumberB = Int32.TryParse(inputB, out int numberB);
bool isNumberC = Int32.TryParse(inputC, out int numberC);

if (isNumberA && isNumberB && isNumberC) { // убеждаемся, что оба ввода - это целые числа
    int maxNumber = numberA;
    if (numberB > maxNumber) maxNumber = numberB;
    if (numberC > maxNumber) maxNumber = numberC;

    Console.Write("Максимальное число: ");
    Console.WriteLine(maxNumber);
}
 else {
    Console.Write("Похоже вы ошиблись при вводе. Перезапустите программу и убедитесь, что вы вводите числа.");
 }