using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Parameters : MonoBehaviour
{
    Image image;

    void Awake() {
        image = GetComponent<Image>();
    }

    public void ChangeParameter(float parameterLevel){
        image.fillAmount = parameterLevel;
    }

    public void ChangeImage(Sprite parameterImage){
        //Debug.Log(sprite);
        image.sprite = parameterImage;
    }
}
