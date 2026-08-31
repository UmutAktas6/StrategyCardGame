using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit
{
    public UnitDefinition unitDefinition;
    public string Name => unitDefinition.name;
    public string Description => unitDefinition.description;
    public int Attack => unitDefinition.attack;
    public int Defence => unitDefinition.defence;
    public int Health;

    public Type Type => unitDefinition.GetType();
    public Unit(UnitDefinition unitDefinition)
    {
        this.unitDefinition = unitDefinition;
        this.Health = unitDefinition.health;    
    }
}
