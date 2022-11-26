Console.Write("Введите число: ");
string input = Console.ReadLine();
bool isNumber = Int32.TryParse(input, out int number);
if (isNumber) {
    int index = 2;
    string result = "";
    if (index > number) {
        Console.Write("От 1 до " + number.ToString() + " нет чётных чисел.");
    }
    else {
        while (index <= number) {
            if (string.IsNullOrEmpty(result)) {
                result = index.ToString();
            } 
            else {
                result = result + ", " + index.ToString();
            }
            index += 2;
        }
    Console.WriteLine("Чётные числа от 1 до " + number.ToString() + ":");
    Console.WriteLine(result);
    }
}
else {
    Console.WriteLine("Вы ошиблись при вводе. Убедитесь, что вводите целое число");
}