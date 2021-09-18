using UnityEngine;

public class TouchFactory : IProductFactory
{
    public IProduct Produce(ProductRequirements requirements)
    {
        if (requirements.IsPortable)
        {
            if (requirements.HasScreen)
            {
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
