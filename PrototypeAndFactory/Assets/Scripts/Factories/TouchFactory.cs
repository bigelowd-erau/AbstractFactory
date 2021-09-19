using UnityEngine;

public class TouchFactory : MonoBehaviour, IProductFactory
{
    public CellPhone cellphone; //Portable and Has Screen
    public EarBuds earBuds; //Portable and No Screen
    public SmartFridge smartFridge; //Non-Portable and Has Screen
    public FingerprintScanner fingerprintScanner; //Non-Portable and No Screen

    public IProduct Produce(ProductRequirements requirements)
    {
        if (requirements.IsPortable)
        {
            if (requirements.HasScreen)
            {
                //Logs to console what was made, and creates a new object of
                //that type through the Product's Copy method
                Debug.Log("Cell Phone made");
                return cellphone.Copy();
            }
            else
            {
                Debug.Log("Ear Buds made");
                return earBuds.Copy();
            }
        }
        else
        {
            if (requirements.HasScreen)
            {
                Debug.Log("Smart Fridge made");
                return smartFridge.Copy();
            }
            else
            {
                Debug.Log("Fingerprint Scanner Door made");
                return fingerprintScanner.Copy();
            }
        }
    }
}
