using UnityEngine;

public class KeyboardFactory : IProductFactory
{
    public IProduct Produce(ProductRequirements requirements)
    {
        Debug.Log("Keyboard made");
        if (requirements.IsPortable)
        {
            if (requirements.HasScreen)
            {
                IProduct laptop = new Laptop();
                return laptop;
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
