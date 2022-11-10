var n = int.Parse(Console.ReadLine());
var x = double.Parse(Console.ReadLine());

double result = 0;
for (var i = 0; i < n; i++) {
    var factorial = 1;
    for (var j = 1; j < i; j++) factorial += j;
    
    result += Math.Cos(x * i) / factorial;
}
Console.WriteLine(result);