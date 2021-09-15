using UnityEngine;

public class TouchFactory : IProductFactory
{
    public IProduct Produce(ProductRequirements requirements)
    {
        if (requirements.IsPortable)
        {
            if (requirements.HasScreen)
            {
                return new CellPhone();
            }
            else
            {
                return new EarBuds();
            }
        }
        else
        {
            if (requirements.HasScreen)
            {
                return new SmartFridge();
            }
            else
            {
                return new FingerprintScanner();
            }
        }
    }
}
