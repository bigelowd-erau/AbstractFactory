using UnityEngine;

public interface IProductFactory
{
    IProduct Produce(ProductRequirements requirements);
}
