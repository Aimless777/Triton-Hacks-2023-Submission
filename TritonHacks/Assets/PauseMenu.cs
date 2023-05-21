using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool paused = false;
    public GameObject menu;
     
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            if(paused == true){
                resume();
            }else{
                pause();
            }
        }
    }

    void resume(){
        menu.active = false;
        Time.timeScale = 1f;
        paused = false;
    }

    void pause(){
        menu.active = true;
        Time.timeScale = 0f;
        paused = true;
    }
}
