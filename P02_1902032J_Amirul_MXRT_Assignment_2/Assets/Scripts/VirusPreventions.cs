using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VirusPreventions
{
    public GameManager gameManager;

    public int health;
    public GameObject enemyHealth;
    public Text enemyHealthText;

    public Text questionText;
    public string question;

    public GameObject answerButton;
    public GameObject[] answerButtons = new GameObject[3];
    public Text[] answerText = new Text[3];

    public GameObject questionWindow;

    List<int> numberOfQuestions = new List<int>();

    public bool correctAnswer;

    public VirusPreventions(int _health)
    {
        health = _health;
    }

    public void GetGameObjectsAndTextComponents()
    {
        gameManager = GameObject.FindObjectOfType<GameManager>();

        enemyHealth = gameManager.enemyHealth;
        enemyHealth.SetActive(false);

        enemyHealthText = gameManager.enemyHealthText.GetComponent<Text>();
        enemyHealthText.text = health.ToString();

        questionText = gameManager.questionText.GetComponent<Text>();

        answerButton = gameManager.answerButton;
        answerButton.SetActive(false);

        answerButtons[0] = gameManager.answerButtons[0];
        answerButtons[1] = gameManager.answerButtons[1];
        answerButtons[2] = gameManager.answerButtons[2];

        answerText[0] = gameManager.answerText[0].GetComponent<Text>();
        answerText[1] = gameManager.answerText[1].GetComponent<Text>();
        answerText[2] = gameManager.answerText[2].GetComponent<Text>();

        questionWindow = gameManager.questionWindow;
        questionWindow.SetActive(false);
    }

    public void ShowQuestionsUI()
    {
        enemyHealth.SetActive(true);

        questionWindow.SetActive(true);

        answerButton.SetActive(true);
    }

    public void ShowQuestion()
    {
        for (int i = 1; i <= health; i++)
        {
            numberOfQuestions.Add(i);
        }

        int index = numberOfQuestions.IndexOf(health);

        if (index == 1)
        {
            FirstQuestion();
        }
        else if (index == 2)
        {
            SecondQuestion();
        }
        else if (index == 3)
        {
            ThirdQuestion();
        }
    }

    public void FirstQuestion()
    {
        question = "What should you wear on \n your face when you are \n outdoors or in public areas?";
        questionText.text = question;

        /*answerButtons[0].SetActive(true);
        answerButtons[1].SetActive(true);
        answerButtons[2].SetActive(true);*/

        answerText[0].text = "Face Mask";
        answerText[1].text = "Helmet";
        answerText[2].text = "Nothing";
    }

    public void SecondQuestion()
    {
        question = "How many metre is considered social distancing?";
        questionText.text = question;

        /*answerButtons[0].SetActive(true);
        answerButtons[1].SetActive(true);
        answerButtons[2].SetActive(true);*/

        answerText[0].text = "0.5 metre";
        answerText[1].text = "At least 1 metre";
        answerText[2].text = "0.7 metre";
    }

    public void ThirdQuestion()
    {
        question = "What is another critical aspect of COVID-19 prevention measures?";
        questionText.text = question;

        /*answerButtons[0].SetActive(true);
        answerButtons[1].SetActive(true);
        answerButtons[2].SetActive(true);*/

        answerText[0].text = "Handshake";
        answerText[1].text = "Washing Hands";
        answerText[2].text = "Washing Hands with Soap";
    }
}
