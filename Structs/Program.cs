using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Structs.MagicWithStruct;

namespace Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            Example4();

            Console.ReadKey();
        }

        private static void Example4()
        {
            List<StructData> list = new List<StructData>()
            {
                new StructData(74, 89),
            };

            StructData[] arr = new StructData[]
            {
                new StructData(899, 247),
            };

            //list[0].X++;

            Console.WriteLine(arr[0].X);
            arr[0].X++;
            Console.WriteLine(arr[0].X);
        }

        private static void Example3()
        {
            WithReadOnlyProperty classData = new WithReadOnlyProperty();

            Console.WriteLine(classData.Struct.X);
            //classData.Struct.X++;
            classData.Struct.Increment();
            classData.InternalIncrement();
            classData.InternalPropertyIncrement();
            Console.WriteLine(classData.Struct.X);
        }

        private static void Example2()
        {
            WithStructProperty classData = new WithStructProperty();

            Console.WriteLine(classData.Struct.X);
            //classData.Struct.X++; <- Редактирование несохранённой копии, компилятор это видит
            classData.Struct.Increment();// <- Редактирование несохранённой копии, компилятор это не видит
            classData.InternalIncrement();// <- Редактирование несохранённой копии внутри класса, компилятор это не видит
            classData.InternalPropertyIncrement();// <- Редактирование поля напрямую
            Console.WriteLine(classData.Struct.X);
        }

        private static void Example1()
        {
            MyStruct firstStruct = new MyStruct(1, "Петя", "Смирнов");
            MyClass firstClass = new MyClass(1, "Петя", "Смирнов");

            EditData(firstStruct, firstClass);

            Console.WriteLine(firstStruct.Id);
            Console.WriteLine(firstClass.Id);
        }

        public static void EditData(MyStruct firstStruct, MyClass firstClass)
        {
            firstStruct.Id = 4;
            firstClass.Id = 4;
        }
    }
}
