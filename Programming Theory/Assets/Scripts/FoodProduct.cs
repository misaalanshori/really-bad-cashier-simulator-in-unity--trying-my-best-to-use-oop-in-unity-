using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodProduct : Product
{
    // Array of generic food names
    private string[] foodNames = { "Bread", "Crackers", "Cheese", "Biscuits", "Wafers", "Cereal", "Chips", "Cookies", "Pretzels", "Bagels", "Croissants", "Pancakes", "Muffins", "Brownies", "Cupcakes" };
    private int minPrice = 2500;
    private int maxPrice = 5000;
    private int gram;
    private int minGram = 10;
    private int maxGram = 500;

    new void Start()
    {
        base.Start();
        productName = foodNames[Random.Range(0, foodNames.Length)];
        productPrice = Random.Range(minPrice, maxPrice + 1);
        gram = Random.Range(minGram, maxGram + 1);
    }

    public override string GetDetails()
    {
        return $"A food product that contains {gram}gr of {productName}";
    }
}
