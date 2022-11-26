Console.Write("Введите первое целое число: ");
string inputA = Console.ReadLine();
Console.Write("Введите второе целое число: ");
string inputB = Console.ReadLine();

// парсим ввод юзера
bool isNumberA = Int32.TryParse(inputA, out int numberA);
bool isNumberB = Int32.TryParse(inputB, out int numberB);

if (isNumberA && isNumberB) { // убеждаемся, что оба ввода - это целые числа
    Console.Write("Максимальное число: ");
    Console.WriteLine(numberA > numberB ? numberA : numberB);
}
 else {
    Console.Write("Похоже вы ошиблись при вводе. Перезапустите программу и убедитесь, что вы вводите числа.");
 }