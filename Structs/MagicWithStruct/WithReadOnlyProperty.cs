namespace Structs.MagicWithStruct
{
    public class WithReadOnlyProperty
    {
        public readonly StructData Struct;
        public int Id { get; set; }


        public WithReadOnlyProperty()
        {
            Id = 7;
            Struct = new StructData(1000, 2000);
        }

        public void InternalIncrement()
        {
            Struct.Increment();
        }

        public void InternalPropertyIncrement()
        {
            Struct.Increment();
        }
    }
}