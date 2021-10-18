using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Задан класс Building, который описывает здание. Класс содержит следующие элементы:
//адрес здания;
//длина здания;
//ширина здания;
//высота здания.
//В классе Building нужно реализовать следующие методы:
//конструктор с 4 параметрами;
//свойства get/set для доступа к полям класса;
//метод Print(), который выводит информацию о здании.
//Разработать класс MultiBuilding, который наследует возможности класса Building и добавляет поле этажность. В классе MultiBuilding реализовать следующие элементы:
//конструктор с 5 параметрами – реализует вызов конструктора базового класса;
//свойство get/set доступа к внутреннему полю класса;
//метод Print(), который обращается к методу Print() базового класса Building для вывода информации о всех полях класса.
//Класс MultiBuilding сделать таким, что не может быть унаследован.

namespace Lab_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Building building = new Building("Юбилейная д.5", 100, 200, 300);
            Console.WriteLine(building.Print());
            Console.ReadKey();


        }
    }
    class Building
    {
        public string Address { get; set; }
        public int A { get; set; }
        public int B { get; set; }
        public int H { get; set; }
        public Building(string Address, int A, int B, int H)
        {
            this.Address = Address;
            this.A = A;
            this.B = B;
            this.H = H;
        }
        public string Print()
        {
            return string.Format("Адрес: {0} Длинна: {1} Ширина: {2} Высота: {3}", Address, A, B, H);
        }
    }
}


