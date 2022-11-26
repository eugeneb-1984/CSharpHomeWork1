Console.Write("Введите первое целое число: ");
string inputA = Console.ReadLine();
Console.Write("Введите второе целое число: ");
string inputB = Console.ReadLine();
bool isNumberA = Int32.TryParse(inputA, out int numberA);
bool isNumberB = Int32.TryParse(inputB, out int numberB);

if (isNumberA && isNumberB) {
    Console.Write("Максимальное число: ");
    Console.WriteLine(numberA > numberB ? numberA : numberB);
}
 else {
    Console.Write("Похоже вы ввели не число. Перезапустите программу и убедитесь, что вы вводите числа.");
 }