// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int getNum(){
    Console.Write("Введите число: ");
    return Convert.ToInt32(Console.ReadLine());
}

int numN = getNum();

string buildLine(int num, int pow){
    string res = "";
    for (int i = 1; i <= num; i++)
    {   
        res += Math.Pow(i, pow) + "\n";
    }
    return res;
}
Console.WriteLine(buildLine(numN, 3));