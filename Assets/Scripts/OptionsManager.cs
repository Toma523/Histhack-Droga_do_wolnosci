using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class OptionsManager : MonoBehaviour
{
    [SerializeField] GameObject parameter1;
    [SerializeField] GameObject parameter2;
    [SerializeField] GameObject parameter3;
    [SerializeField] GameObject parameter4;
    [SerializeField] Image postac;
    [SerializeField] Image pilsudzki;
    [SerializeField] Image sikorski;
    [SerializeField] TextMeshProUGUI commentText;
    [SerializeField] TextMeshProUGUI infoText;
    [SerializeField] TextMeshProUGUI option1Text;
    [SerializeField] TextMeshProUGUI option2Text;
    [SerializeField] TextMeshProUGUI option3Text;
    [SerializeField] GameObject winCanvas;
    [SerializeField] GameObject menuCanvas;
    [SerializeField] GameObject gameCanvas;
    [SerializeField] TextMeshProUGUI button1;
    [SerializeField] TextMeshProUGUI button2;
    [SerializeField] TextMeshProUGUI button3;
    [SerializeField] Acts[] actsArray;
    [SerializeField] string[] parameterTypes;
    [SerializeField] Sprite[] parameterSprites;
    [SerializeField] Acts activeAct;
    [SerializeField] TextMeshProUGUI summary;
    [SerializeField] TextMeshProUGUI actCounter;
    [SerializeField] TextMeshProUGUI chapterCounter;

    [SerializeField] TextMeshProUGUI winstars;
    [SerializeField] TextMeshProUGUI winaverage;
    [SerializeField] TextMeshProUGUI year;

    [SerializeField] GameObject end;

    Parameters parameters;
    LogicScript logicScript;
    public int[] amount = new int[4];
    int actsAmount;
    public int actNumber = 0;

    void Start() {
        winCanvas.SetActive(false);
        menuCanvas.SetActive(true);
        gameCanvas.SetActive(false);
    }

    void SetParameterTypes(){
        for (int i = 0; i < 11; i++){
            if(activeAct.par1Type == parameterTypes[i]){
                Debug.Log(parameterSprites[i]);
                parameter1.GetComponent<Parameters>().ChangeImage(parameterSprites[i]);
            }
            if(activeAct.par2Type == parameterTypes[i]){
                Debug.Log(parameterSprites[i]);
                parameter2.GetComponent<Parameters>().ChangeImage(parameterSprites[i]);
            }
            if(activeAct.par3Type == parameterTypes[i]){
                Debug.Log(parameterSprites[i]);
                parameter3.GetComponent<Parameters>().ChangeImage(parameterSprites[i]);
            }
            if(activeAct.par4Type == parameterTypes[i]){
                Debug.Log(parameterSprites[i]);
                parameter4.GetComponent<Parameters>().ChangeImage(parameterSprites[i]);
            }
        }
    }

    public void Option1(){
        commentText.text = activeAct.btnComment1;
    }

    public void Option2(){
        commentText.text = activeAct.btnComment2;
    }

    public void Option3(){
        commentText.text = activeAct.btnComment3;
    }

    public void ShowEventDetails(){
        infoText.text = activeAct.info;
        commentText.text = "Hmmmmmmmm";
    }

    public void TookOption1(){
        infoText.text = activeAct.info;
        commentText.text = activeAct.btnComment1;
        ChangeAmount(activeAct.btn1Par1, activeAct.btn1Par2, activeAct.btn1Par3, activeAct.btn1Par4);
        if(activeAct.starPosition == 1){
            Debug.Log("1");
            logicScript.AddStars(1);
        }
        ChangeAct();
        ChangeChapter();
        Option1();
        ChangeParameters();
        year.text = "Rok: " + activeAct.year;
    }

    public void TookOption2(){
        infoText.text = activeAct.info;
        commentText.text = activeAct.btnComment2;
        ChangeAmount(activeAct.btn2Par1, activeAct.btn2Par2, activeAct.btn2Par3, activeAct.btn2Par4);
        if(activeAct.starPosition == 2){
            Debug.Log("2");
            logicScript.AddStars(1);
        }
        ChangeAct();
        ChangeChapter();
        Option2();
        ChangeParameters();
        year.text = "Rok: " + activeAct.year;
    }

    public void TookOption3(){
        infoText.text = activeAct.info;
        commentText.text = activeAct.btnComment3;
        ChangeAmount(activeAct.btn3Par1, activeAct.btn3Par2, activeAct.btn3Par3, activeAct.btn3Par4);
        if(activeAct.starPosition == 3){
            Debug.Log("3");
            logicScript.AddStars(1);
        }
        ChangeAct();
        ChangeChapter();
        Option3();
        ChangeParameters();
        year.text = "Rok: " + activeAct.year;
    }

    public void ChangeParameters()
    {
        SetParameterTypes();
        parameter1.GetComponent<Parameters>().ChangeParameter((float)amount[0]/100);
        parameter2.GetComponent<Parameters>().ChangeParameter((float)amount[1]/100);
        parameter3.GetComponent<Parameters>().ChangeParameter((float)amount[2]/100);
        parameter4.GetComponent<Parameters>().ChangeParameter((float)amount[3]/100);
        Debug.Log("ilosc: " + amount[0] + ' ' + amount[1] + ' ' + amount[2] + ' ' + amount[3]);
        
    } 
    
    void ChangeAct()
    {
        if (actNumber >= (actsAmount - 1))
        {
            ShowWinScreen();
            return;
        }else
        {
            actNumber++;
            activeAct = actsArray[actNumber];
            actCounter.text = (actNumber + 1).ToString();
            chapterCounter.text = 1.ToString();
        }
        ShowButtons();
    }

    void ChangeChapter()
    {
        chapterCounter.text = activeAct.chapter.ToString();
    }

    void ShowWinScreen(){
        gameCanvas.SetActive(false);
        winCanvas.SetActive(true);
        winstars.text = logicScript.ReturnStars().ToString();
        winaverage.text = ((amount[0] + amount[1] + amount[2] + amount[3]) / 4).ToString()+'%';
        //end.Win();
    }

    void ShowGameOverScreen(){
        gameCanvas.SetActive(false);
        winCanvas.SetActive(true);
        winstars.text = logicScript.ReturnStars().ToString();
        winaverage.text = ((amount[0] + amount[1] + amount[2] + amount[3]) / 4).ToString() + '%';
        //end.Lose();
    }
    
    public void GoToMainMenu(){
        menuCanvas.SetActive(true);
        gameCanvas.SetActive(false);
    }

    public void SetAmount(int n1,int n2, int n3, int n4)
    {
        amount[0] = n1;
        amount[1] = n2;
        amount[2] = n3;
        amount[3] = n4;
    }

    //ustawienie po kolei wartosci statystyk 1,2,3,4
    public void ChangeAmount(int n1, int n2,int n3,int n4)
    {
        amount[0] += n1;
        if (amount[0] > 100) amount[0] = 100;
        if (amount[0] <= 0) ShowGameOverScreen();

        amount[1] += n2;
        if (amount[1] > 100) amount[1] = 100;
        if (amount[1] <= 0) ShowGameOverScreen();

        amount[2] += n3;
        if (amount[2] > 100) amount[2] = 100;
        if (amount[2] <= 0) ShowGameOverScreen();

        amount[3] += n4;
        if (amount[3] > 100) amount[3] = 100;
        if (amount[3] <= 0) ShowGameOverScreen();
    }

    public void Restart()
    {
        postac = pilsudzki;
        logicScript = FindObjectOfType<LogicScript>();
        parameters = FindObjectOfType<Parameters>();
        activeAct = actsArray[0];
        actsAmount = actsArray.Length;
        actNumber = 0;
        actCounter.text = (actNumber + 1).ToString();
        chapterCounter.text = 1.ToString();
        SetParameterTypes();
        SetAmount(50, 50, 50, 50);
        ChangeParameters();
        ShowEventDetails();
        ShowButtons();
        ChangeChapter();
        if(activeAct == actsArray[3]){
            postac = sikorski;
        }
        year.text = "Rok: " + activeAct.year;
        logicScript.SetStars(0);
        //ChangeParameters();
        winCanvas.SetActive(false);
        menuCanvas.SetActive(false);
        gameCanvas.SetActive(true);
    }
    public void ShowButtons()
    {
        button1.text = activeAct.btnInfo1;
        button2.text = activeAct.btnInfo2;
        button3.text = activeAct.btnInfo3;
    }
}
