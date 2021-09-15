using UnityEngine;

public class FactoryFactory :MonoBehaviour, IProductFactory
{
    public KeyboardFactory keyboardFactory;
    public TouchFactory touchFactory;
    public VoiceFactory voiceFactory;


    public IProduct Produce(ProductRequirements requirements)
    {
        switch(requirements.interactionType)
        {
            case InteractionType.Keyboard:
                IProduct keyboardProduct = keyboardFactory.Produce(requirements);
                return keyboardProduct;
            case InteractionType.Touch:
                IProduct touchProduct = touchFactory.Produce(requirements);
                return touchProduct;
            case InteractionType.Voice:
                IProduct voiceProduct = voiceFactory.Produce(requirements);
                return voiceProduct;
        }
        return null;
    }
}
