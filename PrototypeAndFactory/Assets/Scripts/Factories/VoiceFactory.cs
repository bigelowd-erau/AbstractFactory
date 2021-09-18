using UnityEngine;

public class VoiceFactory : IProductFactory
{
    public SmartWatch smartWatch;
    public BrokenSmartWatch brokenSmartWatch;
    public AnnoyingTV annoyingTV;
    public SmartHomeSpeaker smartHomeSpeaker;
    public IProduct Produce(ProductRequirements requirements)
    {
        if (requirements.IsPortable)
        {
            if (requirements.HasScreen)
            {
                Debug.Log("Smart Watch made");
                return smartWatch.Copy();
            }
            else
            {
                Debug.Log("Broken Smart Watch made");
                return brokenSmartWatch.Copy();
            }
        }
        else
        {
            if (requirements.HasScreen)
            {
                Debug.Log("Voice Control Only TV (Annoying TV) made");
                return annoyingTV.Copy();
            }
            else
            {
                Debug.Log("Smart Home Speaker made");
                return smartHomeSpeaker.Copy();
            }
        }
    }
}
