using System.Collections;
using System.Collections.Generic;
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
        factoryFactory = new FactoryFactory();
        requirements = new ProductRequirements();

        requirements.interactionType = (InteractionType)inputType.value;
        requirements.IsPortable = isPortable.isOn;
        requirements.HasScreen = hasScreen.isOn;
        factoryFactory.Produce(requirements);
    }
}
