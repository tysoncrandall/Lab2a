using System;

class MainClass {
  public static void Main (string[] args) {

    //ask for the name of the item
    Console.WriteLine ("Enter the name of the item");
    var item_name = Console.ReadLine();

    //ask for the quantity of the item
    Console.WriteLine ("Enter the quantity");
    var quantity = Console.ReadLine();

    //ask for the unit price of the item
    Console.WriteLine ("Enter the unit price");
    var unit_price = Console.ReadLine();
    
    int quantity_num = Convert.ToInt32(quantity);
    double unit_price_num = Convert.ToDouble(unit_price);
    Console.WriteLine("Total price of " + item_name + " = $" +(quantity_num * unit_price_num));


  }
}