using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Product : MonoBehaviour
{
    public string productName { get; protected set; }
    public int productPrice { get; protected set; }

    // Start is called before the first frame update
    protected void Start()
    {
        RandomizeColor();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1)) // 1 is the right mouse button
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject == this.gameObject)
                {
                    RandomizeColor();
                }
            }
        }
    }

    private void RandomizeColor()
    {
        // Get the Renderer component of the GameObject
        Renderer renderer = GetComponent<Renderer>();

        if (renderer != null)
        {
            // Create a unique instance of the material
            renderer.material = new Material(renderer.material);

            // Change the Albedo color of the material
            renderer.material.color = ColorUtility.GenerateBrightColor();
        }
    }

    public abstract string GetDetails();
}
