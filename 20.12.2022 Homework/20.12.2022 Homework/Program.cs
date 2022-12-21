//using _20._12._2022_Homework;
//using System;
//using System.ComponentModel;
//using System.Data;

//#region Order

//static Order[] Orders()
//{
//    Order order1 = new Order();

//    order1.Date = new DateTime(2022, 10, 05);
//    order1.Price = 250;

//    Order order2 = new Order();
//    order2.Date = new DateTime(2022, 11, 12);
//    order2.Price = 300;

//    Order order3 = new Order();
//    order3.Date = new DateTime(2022, 12, 13);
//    order3.Price = 100;

//    Order order4 = new Order();
//    order4.Date = new DateTime(2022, 12, 14);
//    order4.Price = 500;

//    Order order5 = new Order();
//    order5.Date = new DateTime(2022, 09, 15);
//    order5.Price = 400;

//    Order[] orders = { order1, order2, order3, order4, order5 };
//    return orders;

//}

//DateTime filtereddate = DateTime.Now.AddDays(1);
//double filteredPrice = 300;

//GetOrders(filtereddate, filteredPrice);

//static void GetOrders(DateTime filtereddate, double filteredPrice)
//{
//    var orders = Orders();

//    foreach (var item in orders)
//    {
//        if (item.Price > filteredPrice && item.Date < filtereddate)
//        {
//            Console.WriteLine(item.Price + ":" + item.Date);
//        }

//    }


//}

//#endregion

//#region Person
////static Person[] Person()
////{
////    Person person1 = new Person();

////    person1.Name = "Azer";
////    person1.Surname = "Babayev";
////    person1.Age = 27;
////    person1.IsMarried = true;

////    Person person2 = new Person();

////    person2.Name = "Nail";
////    person2.Surname = "Mammadov";
////    person2.Age = 32;
////    person2.IsMarried = true;

////    Person person3 = new Person();

////    person3.Name = "Behruz";
////    person3.Surname = "Dadasov";
////    person3.Age = 20;
////    person3.IsMarried = false;


////    Person person4 = new Person();

////    person4.Name = "Vahid";
////    person4.Surname = "Novruzov";
////    person4.Age = 30;
////    person4.IsMarried = false;

////    Person[] persons = { person1, person2, person3, person4 };
////    return persons;

////}

////int Age = 26;

////GetIsMarried(26);

////    static void GetIsMarried(int Age)
////{
////    int count = 0;
////    var persons =  Person();
////    foreach (var item in persons)
////    {
////        if (item.Age > Age && item.IsMarried)
////        {
////            count++;

////        }

////    }
////    Console.WriteLine(count);
////}


//#endregion



//#region Calculator

//static void Calculation()
//{
//   Calculator calculator = new Calculator();

//    Console.WriteLine("Add first number :");

//    Number1: string number1 = Console.ReadLine();
//    int checkedNum1;
//    bool isParseNum1 = int.TryParse(number1, out checkedNum1);



//    if (!isParseNum1)
//    {
//        Console.WriteLine("Please add correct format number  1");
//        goto Number1;
//    }


//    Console.WriteLine(" Add operation :");
//    string operation = Console.ReadLine();

    
//    Console.WriteLine("Add second number :");

//    Number2: string number2 = Console.ReadLine();
//    int  checkedNum2;
//    bool isParseNum2 = int.TryParse(number2, out checkedNum2);   

//    if (!isParseNum2)
//    {
//        Console.WriteLine("Plesae add correct format number 2");
//        goto Number2;   
//    }

//    var result = calculator.Calculation(checkedNum1,checkedNum2,operation);

//    Console.WriteLine(result);

//}

//#endregion