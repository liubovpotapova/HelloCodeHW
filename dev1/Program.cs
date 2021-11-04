//Задать массив
Console.WriteLine("Зададим отрезок");
int index = 0;
int [] array = new int[10];
int minValue;
int maxValue;
void CreateArrray(int [] Array)
{
    Console.WriteLine("Введите начало отрезка");
    minValue = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите конец отрезка");
    maxValue = Convert.ToInt32(Console.ReadLine());
    while (index<10)
    {

    array[index] = new Random().Next((minValue-1), (maxValue+1));
    index++;
    }
}
CreateArrray(array);

//Обнулить индекс
index = 0;

//Распечатать массив
Console.WriteLine("Массив готов");
while (index<10)
{
    int val=array[index];
    Console.WriteLine(val);
    index++;
}

Console.WriteLine("Массив без нарушения убывания");
// Исключенние элементов нарушения убывания
int currentElementDown=array[0];
Console.WriteLine(currentElementDown);
index=1;
while (index <10)
{
    if(array[index]<currentElementDown)
    {
        Console. WriteLine(array[index]);
        currentElementDown = array[index];
    } 
    index++;
}

Console.WriteLine("Больше 8");
// Больше 8
index=0;
while (index <10)

{
    if(array[index]>8)
    {
        Console. WriteLine(array[index]);
    } 
    index++;
}
Console.WriteLine("Знакочередование");
// Чтобы не нарушался порядок знакочередования
// Не получилось решить=((((((((((( Временное решение оставлю
index=0;
int indexSr=index+1;
int currentEl=array[index];
Console.WriteLine(currentEl);

while (indexSr < array.Length)
{
    if((currentEl>0 & array[indexSr]<0) | (currentEl<0 & array[indexSr]>0))
    {
        currentEl=array[indexSr];
        Console. WriteLine(array[indexSr]);
        index++;
    }
    else
    {
        indexSr++;
    }
}