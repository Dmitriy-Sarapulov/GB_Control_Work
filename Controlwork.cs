//Control Work
Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

string [] array = new string[size];


Console.WriteLine("Введите элементы массива: ");
int size2=0;

for(int i = 0; i < array.Length; i++)
{
    string element=Convert.ToString(Console.ReadLine());
    if (element.Length<=3) {        
        size2++;
    }
    array[i] = element;
}
string [] array2 = new string[size2]; 
Console.Write("Итоговый массив: ");
int count=0;
for(int i = 0; i < array.Length; i++)
{
    if (array[i].Length<=3) {
        array2[count]=array[i];
        count++;
        Console.Write(array[i] +" ");
    }   
}