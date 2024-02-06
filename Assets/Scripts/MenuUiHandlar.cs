using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuUiHandlar : MonoBehaviour
{


    //for start button 
    public void startNew()
    {
        SceneManager.LoadScene(1);
    }


    //to exit the game or back from one scene to another
    public void exit()
    {
        if (UnityEditor.EditorApplication.isPlaying)
        {
            EditorApplication.ExitPlaymode();
        }
        else
        {
            Application.Quit();
        }
        
    }

   


}
