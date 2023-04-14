using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinScreen : MonoBehaviour
{
    [SerializeField] GameObject winCanvas;
    [SerializeField] GameObject menuCanvas;
    [SerializeField] GameObject gameCanvas;
    [SerializeField] OptionsManager optionsManager;
    [SerializeField] GameObject winText;
    [SerializeField] GameObject loseText;

    public void GoToMainMenu(){
        menuCanvas.SetActive(true);
        winCanvas.SetActive(false);
        gameCanvas.SetActive(false);
    }

    public void TryAgain(){
        gameCanvas.SetActive(true);
        winCanvas.SetActive(false);
        optionsManager.Restart();
    }
    public void Win()
    {
        winText.SetActive(true); loseText.SetActive(false);
    }
    public void Lose()
    {
        winText.SetActive(false); loseText.SetActive(true);
    }

}
