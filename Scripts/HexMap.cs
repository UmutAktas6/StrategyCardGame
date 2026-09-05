using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
public class HexMap  
{
    public Dictionary<Vector3Int, Hex> hexes = new Dictionary<Vector3Int, Hex>();
    public Dictionary<(Nation, Hex), NationHexState> nationHexStates = new Dictionary<(Nation, Hex), NationHexState>();

    Hex hex1 = new Hex();
    Hex hex2 = new Hex();

    Nation nation1 = new Nation();
    Nation nation2 = new Nation();

    HexMap hexMap = new HexMap();

    void Start()
    {
        hexMap.AddHex(hex1);
        nationHexStates.Add((nation1, hex1) ,new NationHexState(hex1, nation1));


        var nationHexState = GetOrCreateNationHexState(nation1, hex1);
        nationHexState.Explore();
        
        HexMap hexagon = new HexMap();
        hexagon.AddHex(hex1);   

    }


    public void AddHex(Hex hex)
    {
        hexes.Add(hex.coordinate, hex);
    }

    public NationHexState GetOrCreateNationHexState(Nation nation, Hex hex)
    {
        NationHexState nationHexState = new NationHexState(hex, nation);
        return nationHexState;
    }
}
