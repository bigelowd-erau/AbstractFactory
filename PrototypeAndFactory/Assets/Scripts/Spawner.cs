using UnityEngine;
using UnityEngine.UI;

public class Spawner : MonoBehaviour
{
    public Dropdown inputType;
    public Toggle isPortable;
    public Toggle hasScreen;
    public FactoryFactory factoryFactory;

    private ProductRequirements requirements;

    public void Spawn()
    {
        requirements = new ProductRequirements();
        //get interaction type through UI dropdown
        requirements.interactionType = (InteractionType)inputType.value;
        //get if portable through UI Checkbox
        requirements.IsPortable = isPortable.isOn;
        //get if has a screen through UI Checkbox
        requirements.HasScreen = hasScreen.isOn;
        //call the abstract factory passing the 3 requirements
        factoryFactory.Produce(requirements);
    }
}
