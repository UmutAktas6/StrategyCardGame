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
    public enum Type
    {
        Building,
        Attack,
        Army,
        Support,
        Resource
    }
    public void OnPointerClick(PointerEventData eventData)
    {

    }
}
