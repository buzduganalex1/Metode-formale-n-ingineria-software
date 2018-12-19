namespace MainProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            var integerArray = new IntegerArray();

            integerArray.addElem(1);
            integerArray.addElem(2);
            integerArray.delElem(2);

            integerArray.DisplayArray();
        }
    }
}
