using UnityEngine;

public class VoiceFactory : MonoBehaviour, IProductFactory
{
    public SmartWatch smartWatch; //Portable and Has Screen
    public BrokenSmartWatch brokenSmartWatch; //Portable and No Screen
    public AnnoyingTV annoyingTV; //Non-Portable and Has Screen
    public SmartHomeSpeaker smartHomeSpeaker; //Non-Portable and No Screen
    public IProduct Produce(ProductRequirements requirements)
    {
        if (requirements.IsPortable)
        {
            if (requirements.HasScreen)
            {
                //Logs to console what was made, and creates a new object of
                //that type through the Product's Copy method
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
