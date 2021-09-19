using UnityEngine;

public class Product : MonoBehaviour, IProduct
{
    public IProduct Copy()
    {
        //Returns a copy of the opbject this is called from.
        return Instantiate(this);
    }
}
