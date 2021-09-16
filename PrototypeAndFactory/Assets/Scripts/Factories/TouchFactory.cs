using UnityEngine;

public class TouchFactory : MonoBehaviour, IProductFactory
{
    public CellPhone cellphone;
    public EarBuds earBuds;
    public SmartFridge smartFridge;
    public FingerprintScanner fingerprintScanner;

    public IProduct Produce(ProductRequirements requirements)
    {
        if (requirements.IsPortable)
        {
            if (requirements.HasScreen)
            {
                return cellphone.Copy();
            }
            else
            {
                return earBuds.Copy();
            }
        }
        else
        {
            if (requirements.HasScreen)
            {
                return smartFridge.Copy();
            }
            else
            {
                return fingerprintScanner.Copy();
            }
        }
    }
}
