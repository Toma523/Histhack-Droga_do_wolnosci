using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using TMPro;


public class LogicScript : MonoBehaviour
{
    [SerializeField] int stars;
    [SerializeField] string[] names = new string[4];
    [SerializeField] TextMeshProUGUI starCount;
    
    void Start()
    {
        SetStars(0);
        ChangeNames("Ekonomia", "Wola Walki", "Wojsko", "Poparcie");
    }

    public void AddStars(int n)
    {
        stars += n;
        starCount.text = stars.ToString();
    }

    public void SetStars(int n)
    {
        stars = n;
        starCount.text = stars.ToString();
    }
    public int ReturnStars() { return stars; }
    //zmienienie po kolei wartosci statystyk 1,2,3,4

    //zmienianie nazwy po kolei 1,2,3,4
    public void ChangeNames(string name1,string name2,string name3, string name4)
    {
        names[0] = name1;
        names[1] = name2;
        names[2] = name3;
        names[3] = name4;

    }
   
}
