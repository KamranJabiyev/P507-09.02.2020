using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericType
{
    class Program
    {
        //public enum WeekDays { Monday,Tuesday,Wednesday,Thursday};
        static void Main(string[] args)
        {
            #region Custom Contains
            //string word = "Mubariz";
            ////Console.WriteLine(word.Contains("iz"));
            //Console.WriteLine(word.MyContains("M"));
            #endregion

            #region Enum
            //Console.WriteLine((int)WeekDays.Thursday);
            //foreach (var item in Enum.GetValues(typeof(WeekDays)))
            //{
            //    Console.WriteLine((int)item);
            //}
            #endregion

            #region struct
            //Area area2 = new Area();
            //Area area;

            //area.X = 10;
            //area.Y = 100;
            ////area.MyProperty = 10;

            //int a;

            //Area area1 = new Area(10);


            ////Test test;
            ////test.X = 5;

            //Console.WriteLine(area.Y);
            #endregion

            #region Generic type
            //MyList list = new MyList();
            //list.AddItem("Mubush");
            //list.AddItem("Abulfat");
            //list.AddItem("Selcan");

            //list.ShowAll();

            //MyListInt listInt = new MyListInt();
            //listInt.AddItem(5);
            //listInt.AddItem(5);
            //listInt.AddItem(5);
            //listInt.ShowAll();

            //MyListPerson persons = new MyListPerson();
            //persons.AddItem(new Person("Javid"));
            //persons.AddItem(new Person("Mubush"));
            //persons.AddItem(new Person("Abulfat"));
            //persons.ShowAll();

            //MyList<int> listInt = new MyList<int>();
            //listInt.AddItem(6);
            //listInt.ShowAll();

            //MyList<string> listString = new MyList<string>();
            //listString.AddItem("Mubush");
            //listString.ShowAll();

            //MyList<Person> listPerson = new MyList<Person>();
            //listPerson.AddItem(new Person("Sadiq"));

            //MyList<Student, object> myList = new MyList<Student, object>();
            #endregion\

            int a;
        }
    }

    interface IEatable
    {
        void Eat();
    }

    interface ISee
    {
        void See();
    }

    class Eagle : IEatable,ISee
    {
        public void Fly()
        {

        }
        public void Eat()
        {
            Console.WriteLine("Eat as Eagle");
        }

        public void See()
        {
            throw new NotImplementedException();
        }
    }

    class Python : IEatable
    {
        public void Eat()
        {
            Console.WriteLine("Eat as Python");
        }
    }

    

    #region Generic type
    //class MyList<T> 
    //    //class MyList<T,U> where T:U
    //{
    //    private T[] names;

    //    public MyList()
    //    {
    //        names = new T[0];
    //    }

    //    public void AddItem(T item)
    //    {
    //        Array.Resize(ref names, names.Length + 1);
    //        names[names.Length - 1] = item;
    //    }

    //    public void ShowAll()
    //    {
    //        foreach (T item in names)
    //        {
    //            Console.WriteLine(item);
    //        }
    //    }
    //}

    //class MyListPerson
    //{
    //    private Person[] names;

    //    public MyListPerson()
    //    {
    //        names = new Person[0];
    //    }

    //    public void AddItem(Person item)
    //    {
    //        Array.Resize(ref names, names.Length + 1);
    //        names[names.Length - 1] = item;
    //    }

    //    public void ShowAll()
    //    {
    //        foreach (Person item in names)
    //        {
    //            Console.WriteLine(item);
    //        }
    //    }
    //}

    //class MyListInt
    //{
    //    private int[] names;

    //    public MyListInt()
    //    {
    //        names = new int[0];
    //    }

    //    public void AddItem(int item)
    //    {
    //        Array.Resize(ref names, names.Length + 1);
    //        names[names.Length - 1] = item;
    //    }

    //    public void ShowAll()
    //    {
    //        foreach (int item in names)
    //        {
    //            Console.WriteLine(item);
    //        }
    //    }
    //}


    //class Student:Person
    //{

    //}


    //class Person
    //{
    //    public string Name { get; set; }
    //    public Person()
    //    {

    //    }

    //    public Person(string name)
    //    {
    //        Name = name;
    //    }

    //    public override string ToString()
    //    {
    //        return Name;
    //    }
    //}
    #endregion

    #region Struct
    //struct Area
    //{
    //    public int X;
    //    public int Y;

    //    static Area()
    //    {
    //        Console.WriteLine("First Area");
    //    }
    //    public Area(int x)
    //    {
    //        X = 50;
    //        Y = 10;
    //    }
    //}

    //class Test
    //{
    //    public int X;
    //}
    #endregion

}
