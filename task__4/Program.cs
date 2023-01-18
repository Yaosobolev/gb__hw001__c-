Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write($"все четные числа с 1 до {N}: ");
for(int i=1;i<N+1;i++){
    int x;
    if(i%2==0){ 
        x=i;
        Console.Write(x + " ");
    } 
}

