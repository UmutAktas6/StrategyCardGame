using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Army : MonoBehaviour
{
    public ArmyDefinition.ArmyType armyType
    public string name;
    public string description;
    public int health;
    public int attack;
    public int defence;
    public string stringValue => $"{defence} {attack} {health} {description} {name} {armyType}";

    public armyCard(ArmyDefinition.ArmyType armyType, string name, string description, int health, int attack, int defence)
    {
        this.armyType = armyType;
        this.name = name;
        this.description = description;
        this.health = health;
        this.attack = attack;
        this.defence = defence;
    }
}
