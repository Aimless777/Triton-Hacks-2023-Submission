using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCard : MonoBehaviour, IInteractable
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.active = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Interact(){
        gameObject.active = false;
        FindObjectOfType<QuestsStatus>().keycard = true;
    }

    public bool CanInteract(){
        return true;
    }
}
