////1.Array'dəki ən kiçik elementi tapıb ekrana yazdırın.
//{
//    int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
//    int minNumber = arr[0];


//    for (int i = 1; i < arr.Length; i++)
//    {
//        if (minNumber > arr[i])
//        {
//            minNumber = arr[i];
//        }
//    }
//    Console.WriteLine(minNumber);
//}





////2.Array'in içərisindəki sözləri tərsinə çevirən bir alqoritm yazın.
//{
//    int index;
//    string[] arr = { "code", "academy", "class", "room" };
//    Console.Write("indexi daxil ele");
//    int n = Convert.ToInt32(Console.ReadLine());

//    for (int i = arr[n].Length - 1; i >= 0; i--)
//    {
//        Console.Write(arr[n][i]);
//    }
//}




//3.Array'in içərisindəki sözlərin sırasını tərsinə çevirən bir alqoritm yazın.


//string name = "";

//string[] arr = { "Mercedes", "BMW", "Audi" };
//name = arr[1];
//Console.WriteLine("Ad daxil edin");
//name = Convert.ToString(Console.ReadLine());

//for (int i = arr.Length - 1; i >= 0; i--)
//{
//    Console.WriteLine(arr);
//}





//4. Verilmiş integer array-in  bütün elementlərini müsbətə çevirib yeni bir array'ə tərsinə yığın və ekrana çap edin.
//Məsələn, {-2,3,4,-5} verilibsə, {5,4,3,2} almalıyıq cavab olaraq.










////5.Verilmiş integer array-in  bütün elementlərini stringə çevirib ekrana çap edin.
////    Məsələn, {-2,3,4,-5} verilibsə, "-2 3 4 -5" çapa verilməlidir. (optional)

{
    int[] array = { -2, 3, 4, -5 };
    string result = string.Join(" ", Array.ConvertAll(array, x => x.ToString()));
    Console.WriteLine(result);

}





