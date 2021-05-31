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
    public Text[] answerText = new Text[3];

    public GameObject questionWindow;

    public List<int> numberOfQuestions = new List<int>();

    public int index;
    public bool randomizedAnswer;

    public bool firstCorrectAnswer, secondCorrectAnswer, thirdCorrectAnswer;

    public void GetGameObjectsAndTextComponents()
    {
        gameManager = GameObject.FindObjectOfType<GameManager>();

        enemyHealth = gameManager.enemyHealth;
        enemyHealth.SetActive(false);

        health = Random.Range(1, 4);

        enemyHealthText = gameManager.enemyHealthText.GetComponent<Text>();

        questionText = gameManager.questionText.GetComponent<Text>();

        answerButton = gameManager.answerButton;
        answerButton.SetActive(false);

        answerText[0] = gameManager.answerText[0].GetComponent<Text>();
        answerText[1] = gameManager.answerText[1].GetComponent<Text>();
        answerText[2] = gameManager.answerText[2].GetComponent<Text>();

        questionWindow = gameManager.questionWindow;
        questionWindow.SetActive(false);

        randomizedAnswer = false;

        firstCorrectAnswer = secondCorrectAnswer = thirdCorrectAnswer = false;
    }

    public void ShowQuestionsUI()
    {
        enemyHealth.SetActive(true);

        questionWindow.SetActive(true);

        answerButton.SetActive(true);

        enemyHealthText.text = health.ToString();
    }

    public void CloseQuestionsUI()
    {
        enemyHealth.SetActive(false);

        questionWindow.SetActive(false);

        answerButton.SetActive(false);
    }

    public void ShowQuestion()
    {
        if (health > 0 && !randomizedAnswer)
        {
            for (int i = 1; i <= health; i++)
            {
                numberOfQuestions.Add(i);
            }

            index = Random.Range(numberOfQuestions[0], numberOfQuestions.Count);
            randomizedAnswer = true;
        }

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

    public void FirstAnswer()
    {
        playerAnswer = firstAnswer;
    }

    public void SecondAnswer()
    {
        playerAnswer = secondAnswer;
    }

    public void ThirdAnswer()
    {
        playerAnswer = thirdAnswer;
    }

    public int playerAnswer;

    public int firstAnswer = 1;
    public int secondAnswer = 2;
    public int thirdAnswer = 3;

    public void FirstQuestion()
    {
        question = "What should you wear on \n your face when you are \n outdoors or in public areas?";
        questionText.text = question;

        answerText[0].text = "Face Mask";
        answerText[1].text = "Helmet";
        answerText[2].text = "Nothing";
    }

    public void FirstQuestionSelection()
    {
        if (playerAnswer != 1)
        {
            gameManager.playerHealth -= 5;
            gameManager.playerHealthText.text = gameManager.playerHealth.ToString();
        }
        else if (playerAnswer == 1)
        {
            health--;
            enemyHealthText.text = health.ToString();
            randomizedAnswer = false;
            firstCorrectAnswer = true;
            numberOfQuestions.Remove(index);
        }
    }

    public void SecondQuestion()
    {
        question = "How many metre is \n considered social distancing?";
        questionText.text = question;

        answerText[0].text = "0.5 metre";
        answerText[1].text = "At least 1 metre";
        answerText[2].text = "0.7 metre";
    }

    public void SecondQuestionSelection()
    {
        if (playerAnswer != 2)
        {
            gameManager.playerHealth -= 5;
            gameManager.playerHealthText.text = gameManager.playerHealth.ToString();
        }
        else if (playerAnswer == 2)
        {
            health--;
            enemyHealthText.text = health.ToString();
            randomizedAnswer = false;
            secondCorrectAnswer = true;
            numberOfQuestions.Remove(index);
        }
    }

    public void ThirdQuestion()
    {
        question = "What is another critical \n aspect of COVID-19 prevention measures?";
        questionText.text = question;

        answerText[0].text = "Handshake";
        answerText[1].text = "Washing Hands";
        answerText[2].text = "Washing Hands with Soap";
    }

    public void ThirdQuestionSelection()
    {
        if (playerAnswer != 3)
        {
            gameManager.playerHealth -= 5;
            gameManager.playerHealthText.text = gameManager.playerHealth.ToString();
        }
        else if (playerAnswer == 3)
        {
            health--;
            enemyHealthText.text = health.ToString();
            randomizedAnswer = false;
            thirdCorrectAnswer = true;
            numberOfQuestions.Remove(index);
        }
    }
}
