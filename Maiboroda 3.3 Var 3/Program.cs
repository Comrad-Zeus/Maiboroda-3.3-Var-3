// Майборода А.А. - Вар: 3

var nValue = int.Parse(Console.ReadLine());
var xValue = double.Parse(Console.ReadLine());

double sum = 0;
for (var iteration = 0; iteration < nValue; iteration++)
{
    var numberDegree = 1 + 2 * iteration;

    double factorial = 1;
    for (var number = 1; number <= numberDegree; number++) factorial *= number;

    var temperance = Math.Pow(xValue, numberDegree) / factorial;

    sum += iteration % 2 == 0 ? temperance : -temperance;
}

Console.WriteLine(sum);