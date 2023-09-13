using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GM : MonoBehaviour
{
    public GameObject panel;     
   
    public void GameOver()
    {
        Time.timeScale = 0;                  
        panel.SetActive(true);               
    }
    public void Restart()
    {
        SceneManager.LoadScene(1);        

        Time.timeScale = 1;                        
    }
}