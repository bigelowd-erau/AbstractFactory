using UnityEngine;

public class KeyboardFactory : MonoBehaviour, IProductFactory
{
    public Laptop laptop; //Portable and has Screen
    public Desktop desktop; //Non-Portable and has Screen
    public Typewriter typewriter; //Portable and No Screen
    public Jukebox jukebox; //Non-Portable and no Screen

    public IProduct Produce(ProductRequirements requirements)
    {
        if (requirements.IsPortable)
        {
            if (requirements.HasScreen)
            {
                //Logs to console what was made, and creates a new object of
                //that type through the Product's Copy method
                Debug.Log("Laptop made");
                return laptop.Copy();
            }
            else
            {
                Debug.Log("Typewriter made");
                return typewriter.Copy();
            }
        }
        else
        {
            if (requirements.HasScreen)
            {
                Debug.Log("Desktop made");
                return desktop.Copy();
            }
            else
            {
                Debug.Log("Jukebox made");
                return jukebox.Copy();
            }
        }
    }
}
