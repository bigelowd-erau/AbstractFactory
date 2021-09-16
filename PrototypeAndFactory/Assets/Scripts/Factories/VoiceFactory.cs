using UnityEngine;

public class VoiceFactory : MonoBehaviour, IProductFactory
{
    public IProduct Produce(ProductRequirements requirements)
    {
        if (requirements.IsPortable)
        {
            if (requirements.HasScreen)
            {
                return new SmartWatch();
            }
            else
            {
                return new BrokenSmartWatch();
            }
        }
        else
        {
            if (requirements.HasScreen)
            {
                return new AnnoyingTV();
            }
            else
            {
                return new SmartHomeSpeaker();
            }
        }
    }
}
