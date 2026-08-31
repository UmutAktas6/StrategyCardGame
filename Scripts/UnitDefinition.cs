using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class UnitDefinition
{
    public string name;
    public string description;
    public int health;
    public int attack;
    public int defence;
    public UnitType unitType;
    public enum UnitType
    {
        Worker,
        Swordmen,
        Spearmen,
        Archer,
        Scout,
        Cavalry
    }
}



public class Worker : UnitDefinition
{
    public Worker()
    {
        name = "Worker";
        health = 50;
        attack = 5;
        defence = 2;
        description = "Workers are essential for gathering resources and constructing buildings.";
        unitType = UnitType.Worker;
    }
}
public class Swordmen : UnitDefinition
{
    public Swordmen()
    {
        name = "Swordmen";
        health = 100;
        attack = 15;
        defence = 5;
        description = "Swordmen are melee units that excel in close combat.";
        unitType = UnitType.Swordmen;
    }
}
public class Spearmen : UnitDefinition
{
    public Spearmen()
    {
        name = "Spearmen";
        health = 80;
        attack = 10;
        defence = 8;
        description = "Spearmen are versatile units that can counter cavalry effectively.";
        unitType = UnitType.Spearmen;
    }
}
public class Archer : UnitDefinition
{
    public Archer()
    {
        name = "Archer";
        health = 60;
        attack = 12;
        defence = 3;
        description = "Archers are ranged units that can attack enemies from a distance.";
        unitType = UnitType.Archer;
    }
}
public class Scout : UnitDefinition
{
    public Scout()
    {
        name = "Scout";
        health = 40;
        attack = 8;
        defence = 2;
        description = "Scouts are fast units that can explore the map and gather information.";
        unitType = UnitType.Scout;
    }
}
public class Cavalry : UnitDefinition
{
    public Cavalry()
    {
        name = "Cavalry";
        health = 120;
        attack = 20;
        defence = 10;
        description = "Cavalry are mounted units that excel in mobility and hit-and-run tactics.";
        unitType = UnitType.Cavalry;
    }
}
