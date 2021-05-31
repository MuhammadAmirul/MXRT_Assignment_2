using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Answers : MonoBehaviour
{
    public GameManager gameManager;

    public VirusTypeOne virusTypeOneScript;
    public VirusTypeTwo virusTypeTwoScript;

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    public void FirstAnswer()
    {
        if (gameManager.virusType == 1)
        {
            virusTypeOneScript.virusPreventions.FirstAnswer();

            if (virusTypeOneScript.virusPreventions.index == 1)
            {
                virusTypeOneScript.virusPreventions.FirstQuestionSelection();
            }
            else if (virusTypeOneScript.virusPreventions.index == 2)
            {
                virusTypeOneScript.virusPreventions.SecondQuestionSelection();
            }
            else if (virusTypeOneScript.virusPreventions.index == 3)
            {
                virusTypeOneScript.virusPreventions.ThirdQuestionSelection();
            }
        }
        else if (gameManager.virusType == 2)
        {
            virusTypeTwoScript.virusSymptoms.FirstAnswer();

            if (virusTypeTwoScript.virusSymptoms.index == 1)
            {
                virusTypeTwoScript.virusSymptoms.FirstQuestionSelection();
            }
            else if (virusTypeTwoScript.virusSymptoms.index == 2)
            {
                virusTypeTwoScript.virusSymptoms.SecondQuestionSelection();
            }
        }
    }

    public void SecondAnswer()
    {
        if (gameManager.virusType == 1)
        {
            virusTypeOneScript.virusPreventions.SecondAnswer();

            if (virusTypeOneScript.virusPreventions.index == 1)
            {
                virusTypeOneScript.virusPreventions.FirstQuestionSelection();
            }
            else if (virusTypeOneScript.virusPreventions.index == 2)
            {
                virusTypeOneScript.virusPreventions.SecondQuestionSelection();
            }
            else if (virusTypeOneScript.virusPreventions.index == 3)
            {
                virusTypeOneScript.virusPreventions.ThirdQuestionSelection();
            }
        }
        else if (gameManager.virusType == 2)
        {
            virusTypeTwoScript.virusSymptoms.SecondAnswer();

            if (virusTypeTwoScript.virusSymptoms.index == 1)
            {
                virusTypeTwoScript.virusSymptoms.FirstQuestionSelection();
            }
            else if (virusTypeTwoScript.virusSymptoms.index == 2)
            {
                virusTypeTwoScript.virusSymptoms.SecondQuestionSelection();
            }
        }
    }

    public void ThirdAnswer()
    {
        virusTypeOneScript.virusPreventions.ThirdAnswer();

        if (virusTypeOneScript.virusPreventions.index == 1)
        {
            virusTypeOneScript.virusPreventions.FirstQuestionSelection();
        }
        else if (virusTypeOneScript.virusPreventions.index == 2)
        {
            virusTypeOneScript.virusPreventions.SecondQuestionSelection();
        }
        else if (virusTypeOneScript.virusPreventions.index == 3)
        {
            virusTypeOneScript.virusPreventions.ThirdQuestionSelection();
        }
    }
}
