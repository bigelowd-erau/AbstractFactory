using UnityEngine;

public class KeyboardFactory : MonoBehaviour, IProductFactory
{
    public Laptop laptop;
    public Desktop desktop;
    public Typewriter typewriter;
    public Jukebox jukebox;

    public IProduct Produce(ProductRequirements requirements)
    {
        if (requirements.IsPortable)
        {
            if (requirements.HasScreen)
            {
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
