void Squares(int num){
    int i = 1;
    while(num>=i){
        Console.WriteLine(Math.Pow(i,3));
        i++;
    }
}

Squares(5);