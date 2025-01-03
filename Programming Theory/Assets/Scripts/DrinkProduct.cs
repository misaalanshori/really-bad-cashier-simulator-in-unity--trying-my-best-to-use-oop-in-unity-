using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrinkProduct : Product // INHERITANCE
{
    // Array of generic drink names
    private string[] drinkNames = { "Water", "Soda", "Juice", "Tea", "Coffee", "Smoothie", "Milkshake", "Lemonade", "Iced Tea", "Hot Chocolate", "Energy Drink", "Milk", "Sparkling Water", "Mocktail", "Sports Drink" };
    private int minPrice = 2500;
    private int maxPrice = 5000;
    private int ml;
    private int minMl = 10;
    private int maxMl = 500;
    

    new void Start()
    {
        base.Start();
        productName = drinkNames[Random.Range(0, drinkNames.Length)];
        productPrice = Random.Range(minPrice, maxPrice + 1);
        ml = Random.Range(minMl, maxMl + 1);
    }

    public override string GetDetails()
    {
        return $"A drink that contains {ml}ml of {productName}";
    }
}
