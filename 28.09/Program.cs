//int[] num = { 1, 2, 3, 4, 5 };
//int sum = 0;
//for (int i = 0; i < num.Length; i++)
//{
//    num = [i];
//}




//Console.WriteLine();

//Task 2

//string[] words = { "bir", "salam", "universitet", "olar" };
//for (int i=0 ; i< words.Length; i++)
//   {
//    if (words[i].Length > 4)
//    {
//        Console.WriteLine(words[i]);


//    }
//}
//Task3

//int[] arr = new int[] { 1, 2, 4, 7, 5, 3};

//int temp;

//// traverse 0 to array length
//for (int i = 0; i < arr.Length - 1; i++)

//    // traverse i+1 to array length
//    for (int j = i + 1; j < arr.Length; j++)

//        // compare array element with
//        // all next element
//        if (arr[i] < arr[j])
//        {

//            temp = arr[i];
//            arr[i] = arr[j];
//            arr[j] = temp;
//        }

//// print all element of array
//foreach (int value in arr)
//{
//    Console.Write(value + " ");
//}