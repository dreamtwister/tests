using tests.samples;


//var first = new First();
//int[] a = { 1, 2, 3, 2, 5, 9, 1, 22, 12, 30 };
//Console.WriteLine("Упорядоченный массив: {0}", string.Join(", ", first.Sort(a)));

//var second = new Second(15);
//second.PingPong();

//double[] data = { 2.5, 0, 4.22, 1.234, -77.0 };
//var third = new Third();
//Console.WriteLine("Стандартное отклонение: {0}", third.CalculateStandardDeviation(data));

var fourth = new Fourth();
Console.WriteLine("Количество вхождений B__AC: {0}", fourth.CountBAC(new System.Text.StringBuilder("B__ACFFB_BACACB__ACB__AC")));