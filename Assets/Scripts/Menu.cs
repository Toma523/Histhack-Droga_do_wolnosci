using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    [SerializeField] GameObject menuCanvas;
    [SerializeField] GameObject gameCanvas;
    [SerializeField] OptionsManager optionsManager;

    public void Quit(){
        Debug.Log("Quit!");
        Application.Quit();
    }

    public void StartGame(){
        Debug.Log("Start!");
        gameCanvas.SetActive(true);
        menuCanvas.SetActive(false);
        optionsManager.Restart();
    }
}
