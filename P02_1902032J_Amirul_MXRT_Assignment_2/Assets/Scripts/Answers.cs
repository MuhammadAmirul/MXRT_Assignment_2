using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Answers : MonoBehaviour
{
    // Declare a Virus script variable.
    // This variable is to check the virusType, the current questions and
    // whether the player is answering the right question.
    public Virus virusScript;

    // This method will be applied to the button for the first selection.
    public void FirstAnswer()
    {
        if (virusScript.virusType == 1)
        {
            virusScript.virusPreventions.FirstAnswer();

            if (virusScript.virusPreventions.index == 1)
            {
                virusScript.virusPreventions.FirstQuestionSelection();
            }
            else if (virusScript.virusPreventions.index == 2)
            {
                virusScript.virusPreventions.SecondQuestionSelection();
            }
            else if (virusScript.virusPreventions.index == 3)
            {
                virusScript.virusPreventions.ThirdQuestionSelection();
            }
        }
        else
        {
            virusScript.virusSymptoms.FirstAnswer();

            if (virusScript.virusSymptoms.index == 1)
            {
                virusScript.virusSymptoms.FirstQuestionSelection();
            }
            else if (virusScript.virusSymptoms.index == 2)
            {
                virusScript.virusSymptoms.SecondQuestionSelection();
            }
        }
    }

    public void SecondAnswer()
    {
        if (virusScript.virusType == 1)
        {
            virusScript.virusPreventions.SecondAnswer();

            if (virusScript.virusPreventions.index == 1)
            {
                virusScript.virusPreventions.FirstQuestionSelection();
            }
            else if (virusScript.virusPreventions.index == 2)
            {
                virusScript.virusPreventions.SecondQuestionSelection();
            }
            else if (virusScript.virusPreventions.index == 3)
            {
                virusScript.virusPreventions.ThirdQuestionSelection();
            }
        }
        else
        {
            virusScript.virusSymptoms.SecondAnswer();

            if (virusScript.virusSymptoms.index == 1)
            {
                virusScript.virusSymptoms.FirstQuestionSelection();
            }
            else if (virusScript.virusSymptoms.index == 2)
            {
                virusScript.virusSymptoms.SecondQuestionSelection();
            }
        }
    }

    public void ThirdAnswer()
    {
        virusScript.virusPreventions.ThirdAnswer();

        if (virusScript.virusPreventions.index == 1)
        {
            virusScript.virusPreventions.FirstQuestionSelection();
        }
        else if (virusScript.virusPreventions.index == 2)
        {
            virusScript.virusPreventions.SecondQuestionSelection();
        }
        else if (virusScript.virusPreventions.index == 3)
        {
            virusScript.virusPreventions.ThirdQuestionSelection();
        }
    }
}
