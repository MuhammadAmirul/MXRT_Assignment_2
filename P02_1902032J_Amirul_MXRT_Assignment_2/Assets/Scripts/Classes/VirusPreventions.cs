using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VirusPreventions
{
    // Declared a GameManager script variable to
    // set its GameObjects and Texts component to this
    // script GameObject and Text variables.
    public GameManager gameManager;

    // Declared a UIManager script variable to get
    // the booleans that checks if the player answered
    // the questions correctly.
    public UIManager uiManagerScript;

    // Integer variable to set a random number for its health.
    public int health;
    // A GameObject to store the UI for virus health.
    public GameObject enemyHealth;
    // A Text variable to store the text of the virus health.
    public Text enemyHealthText;

    // A Text variable to store the virus questions text.
    public Text questionText;
    // A string variable that sets the questions.
    public string question;

    // This answerButton GameObject variable is to store
    // the parent GameObject that holds the 3 answer buttons.
    public GameObject answerButton;
    // A Text array that stores the answer text of the 3 answer buttons.
    public Text[] answerText = new Text[3];

    // A GameObject that holds the questions window.
    public GameObject questionWindow;

    // A list of int that will be used to show the questions depending
    // on the number.
    public List<int> numberOfQuestions = new List<int>();

    // The index is to store the number in the element of the integer list.
    // Depending on the index value, the virus will either show the 1st, 2nd,
    // or 3rd question.
    public int index;
    // A boolean to indicate that the questions have been randomized or not.
    public bool randomizedAnswer;

    public void GetGameObjectsAndTextComponents()
    {
        // Find the GameObject that has the component GameManager script.
        gameManager = GameObject.FindObjectOfType<GameManager>();

        // Find the GameObject that has the component UIManager script.
        uiManagerScript = GameObject.FindObjectOfType<UIManager>();

        // Set the enemyHealth GameObject to this enemyHealth GameObject.
        enemyHealth = gameManager.enemyHealth;

        // Get the Text component of enemyHealthText in GameManager.
        enemyHealthText = gameManager.enemyHealthText.GetComponent<Text>();

        // Get the Text component of questionText in GameManager.
        questionText = gameManager.questionText.GetComponent<Text>();

        // Set the answerButton GameObject to this answerButton GameObject.
        answerButton = gameManager.answerButtons;

        // Get the array of Text component of answerText in GameManager.
        answerText[0] = gameManager.answerText[0].GetComponent<Text>();
        answerText[1] = gameManager.answerText[1].GetComponent<Text>();
        answerText[2] = gameManager.answerText[2].GetComponent<Text>();

        // Set the questionWindow GameObject to this questionWindow GameObject.
        questionWindow = gameManager.questionWindow;
    }

    public void SetHealth()
    {
        // Set the virus health with a random number of 2 or 3.
        health = Random.Range(2, 4);
    }

    // When the virus dies, set the variables in this method to null
    // so when the next virus is selected, it will get the components again.
    public void NullSettingsOnDeath()
    {
        gameManager = null;

        uiManagerScript = null;

        enemyHealthText = null;

        questionText = null;

        answerButton = null;

        answerText[0] = null;
        answerText[1] = null;
        answerText[2] = null;

        questionWindow = null;
    }

    // When the virus is selected, show the UI questions that will
    // set the activeness of enemyHealth, questionWindow, and answerButton to true.
    // Also set the health value to the enemyHealthText.
    public void ShowQuestionsUI()
    {
        enemyHealth.SetActive(true);

        questionWindow.SetActive(true);

        answerButton.SetActive(true);

        enemyHealthText.text = health.ToString();
    }

    // When the virus dies, close the UI questions.
    // Set the activeness of enemyHealth, questionWindow, and
    // answerButton to false.
    public void CloseQuestionsUI()
    {
        enemyHealth.SetActive(false);

        questionWindow.SetActive(false);

        answerButton.SetActive(false);
    }

    // This method will show the question depending on the index value.
    public void ShowQuestion()
    {
        // If the health is greater than 0 and randomizer is false,
        // do a for loop to add the integer value into the list in numberOfQuestions
        // based on the virus health.
        if (health > 0 && !randomizedAnswer)
        {
            for (int i = 1; i <= health; i++)
            {
                numberOfQuestions.Add(i);
            }

            // Then assign a random number to index using the numberOfQuestions list by
            // getting the values in the element.
            index = Random.Range(numberOfQuestions[0], numberOfQuestions.Count);
            // Set the numberOfQuestions to true so that the questions won't randomize.
            randomizedAnswer = true;

            // If index is equals to 1, show the first question.
            if (index == 1)
            {
                FirstQuestion();
            }
            // If index is equals to 2, show the second question.
            else if (index == 2)
            {
                SecondQuestion();
            }
            // If index is equals to 3, show the second question.
            else if (index == 3)
            {
                ThirdQuestion();
            }
        }
    }

    // Declare an integer playerAnswer to store the player's
    // selected answer.
    public int playerAnswer;

    // Integers value to store the first, second, and third
    // answers to playerAnswer.
    public int firstAnswer = 1;
    public int secondAnswer = 2;
    public int thirdAnswer = 3;

    // Set the playerAnswer to the firstAnswer.
    public void FirstAnswer()
    {
        playerAnswer = firstAnswer;
    }

    // Set the playerAnswer to the secondAnswer.
    public void SecondAnswer()
    {
        playerAnswer = secondAnswer;
    }

    // Set the playerAnswer to the thirdAnswer.
    public void ThirdAnswer()
    {
        playerAnswer = thirdAnswer;
    }

    // This method will show the first question if the index value is 1.
    public void FirstQuestion()
    {
        // Set the first question into the question variable.
        question = "What should you wear on \n your face when you are \n outdoors or in public areas?";
        // Set the question variable to the questionText.
        questionText.text = question;

        // Set the array of each element in answerText to a string:
        // Element 0 is Face Mask
        // Element 1 is Helmet
        // Element 2 is Nothing
        answerText[0].text = "Face Mask";
        answerText[1].text = "Helmet";
        answerText[2].text = "Nothing";
    }

    // This method will check whether the player answers correctly.
    public void FirstQuestionSelection()
    {
        // If the playerAnswer is not equals to 1, the playerHealth will deduct by 5
        // and set the playerHealth value to playerHealthText into a string.
        if (playerAnswer != 1)
        {
            gameManager.playerHealth -= 5;
            gameManager.playerHealthText.text = gameManager.playerHealth.ToString();
        }
        // If the playerAnswer is equals to 1, the virus health will deduct by 1
        // and set the virus health value to enemyHealthText into a string and
        // set firstCorrectPreventionAnswer to true to indicate the player answer correctly and
        // remove the current index from numberOfQuestions and set randomizedAnswer to false.
        else if (playerAnswer == 1)
        {
            health--;
            enemyHealthText.text = health.ToString();
            uiManagerScript.firstCorrectPreventionAnswer = true;
            numberOfQuestions.Remove(index);
            randomizedAnswer = false;
        }
    }

    // This method will show the second question if the index value is 2.
    public void SecondQuestion()
    {
        // Set the second question into the question variable.
        question = "How many metre is \n considered social distancing?";
        // Set the question variable to the questionText.
        questionText.text = question;

        // Set the array of each element in answerText to a string:
        // Element 0 is 0.5 metre
        // Element 1 is At least 1 metre
        // Element 2 is 0.7 metre
        answerText[0].text = "0.5 metre";
        answerText[1].text = "At least 1 metre";
        answerText[2].text = "0.7 metre";
    }

    // This method will check whether the player answers correctly.
    public void SecondQuestionSelection()
    {
        // If the playerAnswer is not equals to 2, the playerHealth will deduct by 5
        // and set the playerHealth value to playerHealthText into a string.
        if (playerAnswer != 2)
        {
            gameManager.playerHealth -= 5;
            gameManager.playerHealthText.text = gameManager.playerHealth.ToString();
        }
        // If the playerAnswer is equals to 2, the virus health will deduct by 1
        // and set the virus health value to enemyHealthText into a string and
        // set secondCorrectPreventionAnswer to true to indicate the player answer correctly and
        // remove the current index from numberOfQuestions and set randomizedAnswer to false.
        else if (playerAnswer == 2)
        {
            health--;
            enemyHealthText.text = health.ToString();
            uiManagerScript.secondCorrectPreventionAnswer = true;
            numberOfQuestions.Remove(index);
            randomizedAnswer = false;
        }
    }

    // This method will show the third question if the index value is 3.
    public void ThirdQuestion()
    {
        // Set the third question into the question variable.
        question = "What is another critical \n aspect of COVID-19 prevention measures?";
        // Set the question variable to the questionText.
        questionText.text = question;

        // Set the array of each element in answerText to a string:
        // Element 0 is Handshake
        // Element 1 is Washing Hands
        // Element 2 is Washing Hands with Soap
        answerText[0].text = "Handshake";
        answerText[1].text = "Washing Hands";
        answerText[2].text = "Washing Hands with Soap";
    }

    // This method will check whether the player answers correctly.
    public void ThirdQuestionSelection()
    {
        // If the playerAnswer is not equals to 3, the playerHealth will deduct by 5
        // and set the playerHealth value to playerHealthText into a string.
        if (playerAnswer != 3)
        {
            gameManager.playerHealth -= 5;
            gameManager.playerHealthText.text = gameManager.playerHealth.ToString();
        }
        // If the playerAnswer is equals to 3, the virus health will deduct by 1
        // and set the virus health value to enemyHealthText into a string and
        // set thirdCorrectPreventionAnswer to true to indicate the player answer correctly and
        // remove the current index from numberOfQuestions and set randomizedAnswer to false.
        else if (playerAnswer == 3)
        {
            health--;
            enemyHealthText.text = health.ToString();
            uiManagerScript.thirdCorrectPreventionAnswer = true;
            numberOfQuestions.Remove(index);
            randomizedAnswer = false;
        }
    }
}
