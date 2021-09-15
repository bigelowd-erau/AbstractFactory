using UnityEngine;

public class Product : MonoBehaviour, IProduct
{
    public IProduct Copy()
    {
        Debug.Log("Created");
        return Instantiate(this);
    }
}
