using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card
{
    public string Name;
    public string Description;
    public Event OnCardPlayed;
    private void Update()
    {
        switch(Name)
        {
            case "MoveOne":
                break;
            case "MoveTwo":
                break;
            case "MoveThree":
                break;
        }
    }
}
