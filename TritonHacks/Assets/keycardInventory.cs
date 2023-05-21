using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keycardInventory : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(FindObjectOfType<QuestsStatus>().keycard == true){
            enabled = true;
        }else{
            enabled = false;
        }
    }
}
