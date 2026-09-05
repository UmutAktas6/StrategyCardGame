using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
public class HexMap : MonoBehaviour 
{
    public Dictionary<Vector3Int, Hex> hexMap;
    public Dictionary<(Nation, Hex), NationHexState> nationHexStates;


    void Start()
    {
        hexMap = new Dictionary<Vector3Int, Hex>();
        nationHexStates = new Dictionary<(Nation, Hex), NationHexState>();

        var hex1 = new Hex();
        var hex2 = new Hex();

        var nation1 = new Nation();
        var nation2 = new Nation();

        hexMap.Add(Vector3Int.zero, hex1);
        nationHexStates.Add((nation1, hex1), new NationHexState(hex1, nation1));
        nationHexStates.TryGetValue((nation1, hex1), out NationHexState nationHexState);
        nationHexState.Explore();
    }




    public void AddHex(Hex hex)
    {
        hexMap.Add(hex.coordinate, hex);
    }

    public NationHexState GetOrCreateNationHexState(Nation nation, Hex hex)
    {
        NationHexState nationHexState = new NationHexState(hex, nation);
        return nationHexState;
    }
}
