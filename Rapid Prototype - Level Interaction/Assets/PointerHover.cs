using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PointerHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public SpriteRenderer target;
    public GameObject npcObj;
    // Start is called before the first frame update
    void Start()
    {
        target = GetComponentInChildren<SpriteRenderer>();
        target.enabled = false; 
        Debug.Log(npcObj);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        target.enabled = true;         
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        target.enabled = false; 
    }

    public GameObject NpcObj
    {
        get { return npcObj; }
        set { npcObj = value;}
    }

    public void selectClick(){
        npcObj = GameObject.Find("Enemy"); 
        Debug.Log(npcObj);

        // set arrow forever for this game object
    }

    
}
