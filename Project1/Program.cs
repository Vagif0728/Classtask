

//----------------------------------------------------task 1--------------------------------------


//double num = int.Parse(Console.ReadLine());

//if (num > 0)
//{
//    Console.WriteLine("Eded musbetdir");
//}
//else if (num == 0)
//{
//    Console.WriteLine("hec biri deyil");
//}
//else
//{
//    Console.WriteLine("Eded menfidir");
//}



// ----------------------------------- Task 2---------------------------------------------------------


//int num = int.Parse(Console.ReadLine());

//if (num== 0)
//{
//    Console.WriteLine("ne tek deyil ne cut");
//}
//else if (num % 2 == 0)
//{
//    Console.WriteLine("EDED CUTDUR");
//}
//else
//{
//    Console.WriteLine("tek ededir");
//}

//----------------------------------------------------Task 3----------------------------------------------


//int C = int.Parse(Console.ReadLine());


//double F =C* (1.8) + 32;

//Console.WriteLine(F);

//----------------------------------------------------Task 4----------------------------------------------

//int num = int.Parse(Console.ReadLine());
//int num2 = int.Parse(Console.ReadLine());
//int num3 = int.Parse(Console.ReadLine());


//if (num == num2 && num2 == num3)
//{
//    Console.WriteLine("bearberdir");
//}
//else if(num>num2 && num2 > num3)
//{
//    Console.WriteLine(num);
//}
//else if(num<num3 && num3 > num2)
//{
//    Console.WriteLine(num3);
//}
//else
//{
//    Console.WriteLine(num2);
//}


//----------------------------------------------------Task 5----------------------------------------------


//double num1 = double.Parse(Console.ReadLine());
//double num2 = double.Parse(Console.ReadLine());
//double number =0;
//char o = char.Parse(Console.ReadLine());


//switch (o)
//{
//    case '+':
//        Console.WriteLine(number = num1 + num2);
//        break;
//    case '-':
//        Console.WriteLine(number=num1 - num2);
//        break;
//    case '*':
//        Console.WriteLine(number = num1 * num2);
//        break;
//    case '/':
//        Console.WriteLine(number = num1 /num2);
//        break;
//    default:
//        Console.WriteLine("opreator sehvdir");
//        break;
//}

//----------------------------------------------------Task 6----------------------------------------------

//double num1 = double.Parse(Console.ReadLine());


//if (num1 < 0 || num1 > 100)
//{
//    Console.WriteLine("Wrong Input");
//}
//else if (num1 >= 90 && num1 <= 100)
//{
//    Console.WriteLine("A");
//}
//else if (num1 < 90 && num1 >= 80)
//{
//    Console.WriteLine("B");
//}
//else if (num1 < 80 && num1 >= 70)
//{
//    Console.WriteLine("C");
//}
//else if (num1 < 70 && num1 >= 60)
//{
//    Console.WriteLine("D");
//}


int num = int.Parse(Console.ReadLine());
int num2 = 0;
int num3 = 0;
int num4 = 0;
num2= num % 10;
num3 = (num % 100)/10;
num4= (num /100)* 100;
Console.WriteLine("Yuzluk"+ num2);
Console.WriteLine("Onluq :"+ num3);