using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Door : MonoBehaviour, IInteractable
{
    new Animator animation; 

    public void Interact(){
        animation = GetComponent<Animator>();
        if(FindObjectOfType<QuestsStatus>().keycard == true){
            //start animation
            animation.Play("Door_Open");
            StartCoroutine(wait());
            //start coroutine
            //GetComponent<Rigidbody2D>().SetActive(false);
        }
    }

    IEnumerator wait(){
        yield return new WaitForSeconds(1f);
        gameObject.active = false;
    }
    public bool CanInteract(){
        return true;
    }
}
