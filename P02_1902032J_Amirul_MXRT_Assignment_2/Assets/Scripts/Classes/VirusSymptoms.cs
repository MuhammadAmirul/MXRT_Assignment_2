using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VirusSymptoms
{
    public GameManager gameManager;

    public UIManager UIManagerScript;

    public int health;
    public GameObject enemyHealth;
    public Text enemyHealthText;

    public Text questionText;
    public string question;

    public GameObject answerButton;
    public GameObject[] answerButtons = new GameObject[3];
    public Text[] answerText = new Text[3];

    public GameObject questionWindow;

    public List<int> numberOfQuestions = new List<int>();

    public int index;
    public bool randomizedAnswer = false;

    public void GetGameObjectsAndTextComponents()
    {
        gameManager = GameObject.FindObjectOfType<GameManager>();

        UIManagerScript = GameObject.FindObjectOfType<UIManager>();

        enemyHealth = gameManager.enemyHealth;
        //enemyHealth.SetActive(false);

        //health = Random.Range(1, 3);

        enemyHealthText = gameManager.enemyHealthText.GetComponent<Text>();

        questionText = gameManager.questionText.GetComponent<Text>();

        answerButton = gameManager.answerButton;
        //answerButton.SetActive(false);

        answerText[0] = gameManager.answerText[0].GetComponent<Text>();
        answerText[1] = gameManager.answerText[1].GetComponent<Text>();
        answerText[2] = gameManager.answerText[2].GetComponent<Text>();

        questionWindow = gameManager.questionWindow;
        //questionWindow.SetActive(false);

        //randomizedAnswer = false;

        UIManagerScript.firstCorrectSymptomsAnswer = UIManagerScript.secondCorrectSymptomsAnswer = false;
    }

    public void SetHealth()
    {
        health = Random.Range(1, 3);
    }

    public void NullSettingsOnDeath()
    {
        gameManager = null;

        UIManagerScript = null;

        enemyHealthText = null;

        questionText = null;

        answerButton = null;

        answerText[0] = null;
        answerText[1] = null;
        answerText[2] = null;

        questionWindow = null;
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
        if (!randomizedAnswer)
        {
            for (int i = 1; i <= health; i++)
            {
                numberOfQuestions.Add(i);
            }

            index = Random.Range(numberOfQuestions[0], numberOfQuestions.Count);
            randomizedAnswer = true;

            if (index == 1)
            {
                FirstQuestion();
            }
            else if (index == 2)
            {
                SecondQuestion();
            }
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
        question = "What are the most \ncommon symptoms of \nCOVID-19?";
        questionText.text = question;

        answerText[0].text = "Fever, Dry Cough \n and Fatigue";
        answerText[1].text = "Dry Cough and \nFatigue";
        answerText[2].text = "Fever";
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
            UIManagerScript.firstCorrectSymptomsAnswer = true;
            numberOfQuestions.Remove(index);
            randomizedAnswer = false;
        }
    }

    public void SecondQuestion()
    {
        question = "Which is the most \nobvious symptoms for \nless common symptoms?";
        questionText.text = question;

        answerText[0].text = "Headache";
        answerText[1].text = "Loss of taste \nand smell";
        answerText[2].text = "Sore throat";
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
            UIManagerScript.secondCorrectSymptomsAnswer = true;
            numberOfQuestions.Remove(index);
            randomizedAnswer = false;
        }
    }
}
