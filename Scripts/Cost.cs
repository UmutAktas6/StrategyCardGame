using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cost
{
    public ResourceDefinition.ResourceType resourceType;
    public int amount;
    public string stringValue => $"{amount} {resourceType}";

    public Cost(ResourceDefinition.ResourceType resourceType, int amount)
    {
        this.resourceType = resourceType;
        this.amount = amount;
    }
}
