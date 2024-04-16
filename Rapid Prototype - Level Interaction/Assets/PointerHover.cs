using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PointerHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public SpriteRenderer target;
    // Start is called before the first frame update
    void Start()
    {
        target = GetComponentInChildren<SpriteRenderer>();
        target.enabled = false; 
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        target.enabled = true;         
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        target.enabled = false; 
    }

    public void click(){
        Debug.Log("click click");
    }

    
}
