Console.WriteLine("Currency formatting - {0:C} {1:C4}", 88.8,-888.8);
Console.WriteLine("Integer formatting - {0:D5}", 88);
Console.WriteLine("Exponential formatting - {0:E}", 888.8);
Console.WriteLine("Fixed-point formatting - {0:F3}",888.8888);
Console.WriteLine("{0:0000.00}",10.5);
Console.WriteLine("{0:####.##}",10.5); 		
Console.WriteLine("{0:####.##}",10.567);
Console.WriteLine("General formatting - {0:G}", 888.8888);
Console.WriteLine("Number formatting - {0:N}", 8888888.8);
Console.WriteLine("Hexadecimal formatting - {0:X4}", 88);
Console.WriteLine("{0:gg yyyy년 M월 d일 dddd tt h시 m분 s초 zzz}", DateTime.Now);

Currency formatting - $88.80 ($888.8000)
Integer formatting - 00088
Exponential formatting - 8.888000E+002
Fixed-point formatting - 888.889
0010.50
10.5
10.57
General formatting - 888.8888
Number formatting - 8,888,888.80
Hexadecimal formatting – 0058
서기 2008년 1월 22일 화요일 오후 11시 2분 1초 +09:00
참조)형식지정http://msdn2.microsoft.com/ko-kr/library/fbxft59x(VS.80).aspx
