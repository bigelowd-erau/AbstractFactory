using UnityEngine;

public class FactoryFactory : IProductFactory
{
    public IProduct Produce(ProductRequirements requirements)
    {
        switch(requirements.interactionType)
        {
            case InteractionType.Keyboard:
                return new KeyboardFactory().Produce(requirements);
            case InteractionType.Touch:
                return new TouchFactory().Produce(requirements);
            case InteractionType.Voice:
                return new VoiceFactory().Produce(requirements);
        }
        return null;
    }
}
