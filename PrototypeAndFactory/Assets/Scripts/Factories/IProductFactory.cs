using UnityEngine;

public interface IProductFactory
{
    //Produce is the factory method for creating a new product
    IProduct Produce(ProductRequirements requirements);
}
