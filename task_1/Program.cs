void Check(int num){
    int i = num/1000;
    int j = num%100;
    if((num/10000 == num%10) && (i%10 == j/10)){
        Console.WriteLine("Да");
    }else{
        Console.WriteLine("Нет");
    }
}

Check(14212);
Check(23432);
Check(12821);