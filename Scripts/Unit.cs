using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    public UnitDefinition.UnitType unitType;
    public string name;
    public string description;
    public int health;
    public int attack;
    public int defence;
    public string stringValue => $"{defence} {attack} {health} {description} {name} {unitType}";

    public Unit(UnitDefinition.UnitType unitType, string name, string description, int health, int attack, int defence)
    {
        this.unitType = unitType;
        this.name = name;
        this.description = description;
        this.health = health;
        this.attack = attack;
        this.defence = defence;
    }
}
