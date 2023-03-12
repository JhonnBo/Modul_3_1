﻿namespace _2._Class_Modificators_Fields
{

    internal class Classes
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();
            obj.var = 100; //Ошибка
            obj.myArr = new int[10]; //Ошибка
            MyClass.varD = 5.0; //Ошибка
            obj.myArr[0] = 11; //Ошибки нет
            obj.varInt = 12; //Ошибка
            MyClass.varInt = 12; //Ошибки нет
        }
    }

    class MyClass
    {
        public readonly int var = 10;
        public readonly int[] myArr = { 1, 2, 3 };
        public const double varD = 100.0;
        public static int varInt = 0;
    }
}

//Поле — это переменная, которая хранит значение 
//любого стандартного типа или ссылку на ссылочный тип.
//При объявлении полей могут указываться следующие 
//ключевые слова:

//■ static — используется для объявления статического 
//поля, которое принадлежит классу, а не конкретному 
//объекту, то есть является общим для всех экземпляров класса.

//■ const — используется для объявления постоянного 
//поля, то есть значение данного поля не может быть 
//изменено. Поле с модификатором const должно быть 
//обязательно проинициализировано при объявлении 
//поля класса. Константные поля являются неявно статическими,
//поэтому обращение к  ним необходимо 
//осуществлять только через имя типа.

//■ readonly — означает, что поле будет использоваться 
//только для чтения, присвоение значений таким полям 
//разрешается только в конструкторе либо сразу при 
//объявлении.