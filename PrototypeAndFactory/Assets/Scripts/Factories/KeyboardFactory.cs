using UnityEngine;

public class KeyboardFactory : MonoBehaviour, IProductFactory
{
    public Laptop laptop;
    public IProduct desktop;
    public IProduct typewriter;
    public IProduct jukebox;

    public IProduct Produce(ProductRequirements requirements)
    {
        Debug.Log("Keyboard made");
        if (requirements.IsPortable)
        {
            if (requirements.HasScreen)
            {
                //INPC laptop = new Beggar();
                //return beggar;
                return laptop.Copy();
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
