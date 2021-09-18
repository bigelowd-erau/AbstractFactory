using UnityEngine;

public class Product : MonoBehaviour, IProduct
{
    public IProduct Copy()
    {
        return Instantiate(this);
    }
}
