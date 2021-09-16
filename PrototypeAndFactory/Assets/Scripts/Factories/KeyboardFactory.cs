using UnityEngine;

public class KeyboardFactory : MonoBehaviour, IProductFactory
{
    public Laptop laptop;
    public Desktop desktop;
    public Typewriter typewriter;
    public Jukebox jukebox;

    public IProduct Produce(ProductRequirements requirements)
    {
        Debug.Log("Keyboard made");
        if (requirements.IsPortable)
        {
            if (requirements.HasScreen)
            {
                return laptop.Copy();
            }
            else
            {
                return typewriter.Copy();
            }
        }
        else
        {
            if (requirements.HasScreen)
            {
                return desktop.Copy();
            }
            else
            {
                return jukebox.Copy();
            }
        }
    }
}
