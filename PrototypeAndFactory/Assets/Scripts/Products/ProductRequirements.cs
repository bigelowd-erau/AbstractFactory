using UnityEngine;

//All configurable options for the requirements for a new product
public class ProductRequirements
{
    public bool IsPortable { get; set; }
    public bool HasScreen { get; set; }
    public InteractionType interactionType { get; set; }
}
