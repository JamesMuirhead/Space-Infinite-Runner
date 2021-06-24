using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonSound : MonoBehaviour, IPointerEnterHandler
{
    public AudioSource clip;
    public void OnPointerEnter(PointerEventData eventData)
    {
        clip.Play();
    }
}
