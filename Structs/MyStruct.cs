namespace Structs
{
    public struct MyStruct
    {
        public int Id { get; set; }

        public string Name;

        private string _secondName;


        public MyStruct(int id, string name, string secondName)
        {
            Id = id;
            Name = name;
            _secondName = secondName;
        }


        public void SetAllData(int id, string name, string secondName)
        {
            Id = id;
            Name = name;
            _secondName = secondName;
        }
    }
}