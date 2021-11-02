//Задать целочисленный массив
//Сколько раз повторяется
//Сколько элементов между двумя повторяющимся первым и последним

//Задать массив
int index = 0;

int [] array = new int[10];
while (index<10)
{
    array[index] = new Random().Next(10,100);
    index++;
}

//Обнулить индекс
index = 0;


//Распечатать массив

while (index<10)
{
    int val=array[index];
    Console.WriteLine(val);
    index++;
}

index=1;
Console.WriteLine("Массив без нарушения возрастания");
// Исключенние элементов нарушения возрастания

int currentElement=array[0];
Console.WriteLine(currentElement);
while (index <10) 
{
    if(array[index]>currentElement)
    {
        Console. WriteLine(array[index]);
        currentElement = array[index];
    } 
    index++;
}

index=1;
Console.WriteLine("Массив без нарушения убывания");
// Исключенние элементов нарушения убывания

int currentElementDown=array[0];
Console.WriteLine(currentElementDown);
while (index <10)
{
    if(array[index]<currentElementDown)
    {
        Console. WriteLine(array[index]);
        currentElementDown = array[index];
    } 
    index++;
}

// 2  больше среднего арифметического элементов A
index=0;
int result;
Console.WriteLine("ср арифм элементов массива");

void SrArifm(int [] Array)
{ 
    int arraySum = 0;
    int arrayCount = array.Length;
    
    while(index<arrayCount)
    {
        arraySum = arraySum + array[index];
        index++;
    }
    result = arraySum/arrayCount;
    Console.WriteLine(result);
}

SrArifm(array);

Console.WriteLine("больше ср арифм элементов A");
index=0;

int currentElementBigSrAr=array[index];
while (index <10)
{
    if(array[index]>result)
    {
        Console. WriteLine(array[index]);
        currentElementBigSrAr = array[index];
    } 
    index++;
}


// Определение четных
Console.WriteLine("Четные");
index=0;

while (index <10)
{
    if(array[index]%2==0)
    {
        Console. WriteLine(array[index]);
        int currentElementEven=array[index];
    } 
    index++;
}