using System.Buffers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Hex 
{
    public Vector3Int coordinate;
    public Nation ownedNation;
    public Unit currentUnit;
    public Building constructedBuilding;
    //public Terrain terrainType; veya baþka þekilde veri tutan bir field gelebilir
}
