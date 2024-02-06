using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.UIElements;


public class MainManager1 : MonoBehaviour
{
    public static MainManager1 instance;
    [SerializeField] TMP_InputField inputField;
    [SerializeField] TMP_Text textField;
    [SerializeField] Text highScore;
    public void Start()
    {
     
    }

    public void Awake()
    {
        output();
        HighScore();                
    }

    public void userName()
    {
        PlayerPrefs.SetString("key", inputField.text);
        PlayerPrefs.SetInt("score", 0);
        highScore.text = "High Score:" + PlayerPrefs.GetInt("score");
    }

    public void  output()
    {
        textField.text = PlayerPrefs.GetString("key");        
    }
    public void HighScore()
    {
        
        
        highScore.text = "High Score:" + PlayerPrefs.GetInt("score");
        
    }

}
