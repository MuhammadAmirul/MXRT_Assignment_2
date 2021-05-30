using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VirusPreventions
{
    public int health;
    public GameObject enemyHealth;
    public Text enemyHealthText;

    public string question;
    public GameObject[] answerButtons = new GameObject[3];
    public Text[] answerText = new Text[3];

    public GameObject questionWindow;

    public VirusPreventions(int _health)
    {
        health = _health;
    }

    public void GetGameObjectsAndTextComponents()
    {
        answerButtons[0] = GameObject.Find("Answer_Button_1");
        answerButtons[1] = GameObject.Find("Answer_Button_2");
        answerButtons[2] = GameObject.Find("Answer_Button_3");

        answerText[0] = answerButtons[0].GetComponentInChildren<Text>();
        answerText[1] = answerButtons[1].GetComponentInChildren<Text>();
        answerText[2] = answerButtons[2].GetComponentInChildren<Text>();

        enemyHealth = GameObject.Find("Enemy_Health");
        enemyHealth.SetActive(false);

        questionWindow = GameObject.Find("Questions_Window");
        questionWindow.SetActive(false);

        enemyHealthText = enemyHealth.GetComponentInChildren<Text>();
        enemyHealthText.text = health.ToString();
    }

    public void FirstQuestion()
    {
        question = "What should you wear on your face when you are outdoors or in public areas?";

        answerButtons[0].SetActive(true);
        answerButtons[1].SetActive(true);
        answerButtons[2].SetActive(true);

        answerText[0].text = "Face Mask";
        answerText[1].text = "Helmet";
        answerText[2].text = "Nothing";
    }

    public void SecondQuestion()
    {
        question = "How many metre is considered social distancing?";

        answerButtons[0].SetActive(true);
        answerButtons[1].SetActive(true);
        answerButtons[2].SetActive(true);

        answerText[0].text = "0.5 metre";
        answerText[1].text = "At least 1 metre";
        answerText[2].text = "0.7 metre";
    }

    public void ThirdQuestion()
    {
        question = "What is another critical aspect of COVID-19 prevention measures?";

        answerButtons[0].SetActive(true);
        answerButtons[1].SetActive(true);
        answerButtons[2].SetActive(true);

        answerText[0].text = "Handshake";
        answerText[1].text = "Washing Hands";
        answerText[2].text = "Washing Hands with Soap";
    }
}
