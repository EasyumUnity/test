namespace Structs.MagicWithStruct
{
    public class WithStructProperty
    {
        private StructData _struct;
        public int Id { get; set; }

        public StructData Struct
        {
            get { return _struct; }
            set { _struct = value; }
        }

        public WithStructProperty()
        {
            Id = 5;
            Struct = new StructData(100, 200);
        }

        public void InternalIncrement()
        {
            Struct.Increment();
        }

        public void InternalPropertyIncrement()
        {
            _struct.Increment();
        }
    }
}