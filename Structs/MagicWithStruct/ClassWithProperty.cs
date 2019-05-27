namespace Structs.MagicWithStruct
{
    public struct StructData
    {
        public int X { get; set; }

        public int Y { get; set; }


        public StructData(int x, int y)
        {
            X = x;
            Y = y;
        }

        // Тут был КотЭ )


        public void Increment()
        {
            X++;
        }
    }
}