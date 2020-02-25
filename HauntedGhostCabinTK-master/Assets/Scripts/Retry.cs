using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Retry : MonoBehaviour
{

    public GameObject pauseScreen;

    public GameObject pauseOptionScreen;

    private bool optionsPause;

    public void ChangeScene(int sceneNumber)
    {
        SceneManager.LoadScene(sceneNumber);
    }

    public void retry()
    {
        ChangeScene(1); //SampleScene

       
         if (Time.timeScale == 0) // Unpauses
        {
            Time.timeScale = 1;
           // Cursor.lockState = CursorLockMode.Locked;
            pauseScreen.SetActive(false);
            //hidePaused();
        }
    }

    public void mainMenu()
    {
        

        
         if (Time.timeScale == 0) // Unpauses
        {
            Time.timeScale = 1;
            //Cursor.lockState = CursorLockMode.Locked;
            pauseScreen.SetActive(false);
            //hidePaused();
        }
        ChangeScene(0);
    }

    public void optionsScene()
    {
       
        ChangeScene(3);//Options Scene
    }

    public void optionInPause()
    {

        if (optionsPause == true)
        {

            pauseOptionScreen.SetActive(false);
            pauseScreen.SetActive(true);
            optionsPause = false;
        }
        else
        {

            pauseScreen.SetActive(false);
            pauseOptionScreen.SetActive(true);
            optionsPause = true;
        }

       
    }


    public void back()
    {
        ChangeScene(1);

        if (Time.timeScale == 0) // Unpauses
        {
            Time.timeScale = 1;
            // Cursor.lockState = CursorLockMode.Locked;
            pauseScreen.SetActive(false);
            //hidePaused();
        }
    }
}
