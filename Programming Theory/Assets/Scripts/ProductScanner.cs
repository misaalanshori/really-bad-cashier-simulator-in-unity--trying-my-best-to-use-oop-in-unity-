using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProductScanner : MonoBehaviour
{
    [SerializeField] Receipt receipt;

    private void OnTriggerEnter(Collider other)
    {
        Product product = other.GetComponent<Product>();
        if (product != null)
        {
            receipt.AddProduct(product);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Product product = other.GetComponent<Product>();
        if (product != null)
        {
            receipt.RemoveProduct(product);
        }
    }
}
