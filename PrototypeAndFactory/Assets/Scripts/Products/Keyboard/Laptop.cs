using UnityEngine;

public class Laptop : MonoBehaviour, IProduct
{
    public Laptop()
    {
        Instantiate(Resources.Load("Prefabs/Laptop"));
    }
}
