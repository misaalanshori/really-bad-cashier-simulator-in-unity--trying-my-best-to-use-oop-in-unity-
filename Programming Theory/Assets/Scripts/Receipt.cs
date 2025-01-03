using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Receipt : MonoBehaviour
{
    private List<Product> products = new List<Product>();
    [SerializeField] TextMeshProUGUI receiptText;

    // Start is called before the first frame update
    void Start()
    {
        RenderText();
    }

    // Method to add a product to the list
    public void AddProduct(Product product)
    {
        if (product != null && !products.Contains(product))
        {
            products.Add(product);
            RenderText();
        }
    }

    // Method to remove a product from the list
    public void RemoveProduct(Product product)
    {
        if (product != null && products.Contains(product))
        {
            products.Remove(product);
            RenderText();
        }
    }

    // Method to render text for all products in the list
    public void RenderText()
    {
        string storeName = "";
        if (MainManager.Instance)
        {
            storeName = MainManager.Instance.storeName + " - ";
        }
        int total = 0;
        string text = $"{storeName}Receipt:";
        foreach (var product in products)
        {
            text += "\n";
            text += $"{product.productName} - Rp{product.productPrice}\n";
            text += $"{product.GetDetails()}\n";
            total += product.productPrice;
        }

        text += "\n";
        text += $"Total Items: {products.Count}\n";
        text += $"Total Cost: Rp{total}\n";
        text += "\n";
        receiptText.text = text;
    }
}
