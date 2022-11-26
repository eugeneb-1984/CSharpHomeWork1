Console.Write("Введите число: ");
string input = Console.ReadLine();

bool isNumber = Int32.TryParse(input, out int number);

if (isNumber) {
    Console.WriteLine (number % 2 == 0 ? "Это чётное число" : "Это нечётное число");
    }
else {
    Console.WriteLine ("Похоже вы ошиблись при вводе. Убедитесь, что вводите число");
}
