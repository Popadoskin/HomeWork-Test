string[] CreateArray(string[] initialArray, int lengthOfWord)
{
    int length = new int();
    for (int i = 0; i < initialArray.Length; i++)
    {
       if(initialArray[i].Length <= lengthOfWord)
       {
           length ++;
       } 
    }
}











string[] array = { "1234", "ask", "sun", "hello", "world", "sea", "12" };
string[] newArray = CreateArray();
PrintArray(newArray);