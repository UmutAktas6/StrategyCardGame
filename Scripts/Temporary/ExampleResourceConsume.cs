using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class ExampleResourceConsume : MonoBehaviour
{
    ResourceDefinition resourceDefinition;
    void Start()
    {
        Cost cost = new Cost(ResourceDefinition.ResourceType.Gold, Random.Range(1, 10));
        Debug.Log("Randomly play button has costed you " + cost.stringValue);

        var unit = new Unit(new Worker());
        Debug.Log("Randomly you gain " + unit.Attack + " attack" + " which is a " + unit.Type);
    }
}
