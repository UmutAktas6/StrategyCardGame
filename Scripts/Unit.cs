using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    public UnitDefinition.ArmyType armyType;
    public string name;
    public string description;
    public int health;
    public int attack;
    public int defence;
    public string stringValue => $"{defence} {attack} {health} {description} {name} {armyType}";

    public Unit(UnitDefinition.ArmyType armyType, string name, string description, int health, int attack, int defence)
    {
        this.armyType = armyType;
        this.name = name;
        this.description = description;
        this.health = health;
        this.attack = attack;
        this.defence = defence;
    }
}
