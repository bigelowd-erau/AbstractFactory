using UnityEngine;

public class FactoryFactory :MonoBehaviour, IProductFactory
{
    //public acessors to the concrete factories
    public KeyboardFactory keyboardFactory;
    public TouchFactory touchFactory;
    public VoiceFactory voiceFactory;

    //Choose what foactory is needed to produce the product
    public IProduct Produce(ProductRequirements requirements)
    {
        //the factory decider is the input type
        switch(requirements.interactionType)
        {
            //for each case create anew IProduct that is made by calling produce
            //on the appropriate factory and passing requirements
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
