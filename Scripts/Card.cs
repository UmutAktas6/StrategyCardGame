using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class Card : MonoBehaviour, IPointerClickHandler
{
    public string Name;
    public string Description;
    public UnityEvent OnCardPlayed;

    public void OnPointerClick(PointerEventData eventData)
    {
        switch (gameObject.name)
        {
            case "MoveOne":
                Debug.Log("MoveOne card played!");
                break;
            case "MoveTwo":
                Debug.Log("MoveTwo card played!");
                break;
            case "MoveThree":
                Debug.Log("MoveThree card played!");
                break;
        }
    }
}
