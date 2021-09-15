using UnityEngine;

public class KeyboardFactory : IProductFactory
{
    public IProduct Produce(ProductRequirements requirements)
    {
        if (requirements.IsPortable)
        {
            if (requirements.HasScreen)
            {
                return new Laptop();
            }
            else
            {
                return new Typewriter();
            }
        }
        else
        {
            if (requirements.HasScreen)
            {
                return new Desktop();
            }
            else
            {
                return new Jukebox();
            }
        }
    }
}
