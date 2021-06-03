using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Answers : MonoBehaviour
{
    // Declare a Virus script variable.
    // This variable is to check the virusType, the current questions and
    // whether the player is answering the right question.
    public Virus virusScript;

    // The integer variable index in virusScript.virusPreventions and virusScript.virusSymptoms
    // is to check which question the player is answering.
    // Index 1 is the First Question
    // Index 2 is the Second Question
    // Index 3 is the Third Question

    // This method will be applied to Answer_Button_ 1 in the Answers_Button GameObject.
    public void FirstAnswer()
    {
        // If the virusType is 1, call the method virusScript.virusPreventions.FirstAnswer()
        // which holds an integer value of 1, meaning the player has selected the first answer.
        if (virusScript.virusType == 1)
        {
            virusScript.virusPreventions.FirstAnswer();

            // If the index value is 1, call the method virusScript.virusPreventions.FirstQuestionSelection()
            // which will check the player answer. If the player selects the wrong answer,
            // player will lose 5 health. If the player select the correct answer, the virus will proceed
            // with the next question.
            if (virusScript.virusPreventions.index == 1)
            {
                virusScript.virusPreventions.FirstQuestionSelection();
            }
            // If the index value is 2, call the method virusScript.virusPreventions.SecondQuestionSelection()
            // which will check the player answer. Similarly, if player selects the wrong answer,
            // player will lose 5 health. If the player select the correct answer, the virus will proceed
            // with the next question.
            else if (virusScript.virusPreventions.index == 2)
            {
                virusScript.virusPreventions.SecondQuestionSelection();
            }
            // If the index value is 3, call the method virusScript.virusPreventions.ThirdQuestionSelection()
            // which will check the player answer. Similarly, if player selects the wrong answer,
            // player will lose 5 health. If the player select the correct answer, the virus will proceed
            // with the next question.
            else if (virusScript.virusPreventions.index == 3)
            {
                virusScript.virusPreventions.ThirdQuestionSelection();
            }
        }
        // If the virusType is 2, call the method virusScript.virusSymptoms.FirstAnswer()
        // which holds an integer value of 1, meaning the player has selected the first answer.
        else if (virusScript.virusType == 2)
        {
            virusScript.virusSymptoms.FirstAnswer();

            // If the index value is 1, call the method virusScript.virusSymptoms.FirstQuestionSelection()
            // which will check the player answer. If the player selects the wrong answer,
            // player will lose 5 health. If the player select the correct answer, the virus will proceed
            // with the next question.
            if (virusScript.virusSymptoms.index == 1)
            {
                virusScript.virusSymptoms.FirstQuestionSelection();
            }
            // If the index value is 2, call the method virusScript.virusSymptoms.SecondQuestionSelection()
            // which will check the player answer. Similarly, if player selects the wrong answer,
            // player will lose 5 health. If the player select the correct answer, the virus will proceed
            // with the next question.
            else if (virusScript.virusSymptoms.index == 2)
            {
                virusScript.virusSymptoms.SecondQuestionSelection();
            }
        }
    }

    // This method will be applied to Answer_Button_ 2 in the Answers_Button GameObject.
    public void SecondAnswer()
    {
        // If the virusType is 1, call the method virusScript.virusPreventions.SecondAnswer()
        // which holds an integer value of 2, meaning the player has selected the second answer.
        if (virusScript.virusType == 1)
        {
            virusScript.virusPreventions.SecondAnswer();

            // If the index value is 1, call the method virusScript.virusPreventions.FirstQuestionSelection()
            // which will check the player answer. If the player selects the wrong answer,
            // player will lose 5 health. If the player select the correct answer, the virus will proceed
            // with the next question.
            if (virusScript.virusPreventions.index == 1)
            {
                virusScript.virusPreventions.FirstQuestionSelection();
            }
            // If the index value is 2, call the method virusScript.virusPreventions.SecondQuestionSelection()
            // which will check the player answer. Similarly, if player selects the wrong answer,
            // player will lose 5 health. If the player select the correct answer, the virus will proceed
            // with the next question.
            else if (virusScript.virusPreventions.index == 2)
            {
                virusScript.virusPreventions.SecondQuestionSelection();
            }
            // If the index value is 3, call the method virusScript.virusPreventions.ThirdQuestionSelection()
            // which will check the player answer. Similarly, if player selects the wrong answer,
            // player will lose 5 health. If the player select the correct answer, the virus will proceed
            // with the next question.
            else if (virusScript.virusPreventions.index == 3)
            {
                virusScript.virusPreventions.ThirdQuestionSelection();
            }
        }
        // If the virusType is 2, call the method virusScript.virusSymptoms.SecondAnswer()
        // which holds an integer value of 2, meaning the player has selected the second answer.
        else if (virusScript.virusType == 2)
        {
            virusScript.virusSymptoms.SecondAnswer();

            // If the index value is 1, call the method virusScript.virusSymptoms.FirstQuestionSelection()
            // which will check the player answer. If the player selects the wrong answer,
            // player will lose 5 health. If the player select the correct answer, the virus will proceed
            // with the next question.
            if (virusScript.virusSymptoms.index == 1)
            {
                virusScript.virusSymptoms.FirstQuestionSelection();
            }
            // If the index value is 2, call the method virusScript.virusSymptoms.SecondQuestionSelection()
            // which will check the player answer. Similarly, if player selects the wrong answer,
            // player will lose 5 health. If the player select the correct answer, the virus will proceed
            // with the next question.
            else if (virusScript.virusSymptoms.index == 2)
            {
                virusScript.virusSymptoms.SecondQuestionSelection();
            }
        }
    }

    // This method will be applied to Answer_Button_ 3 in the Answers_Button GameObject.
    public void ThirdAnswer()
    {
        // If the virusType is 1, call the method virusScript.virusPreventions.ThirdAnswer()
        // which holds an integer value of 3, meaning the player has selected the third answer.
        if (virusScript.virusType == 1)
        {
            virusScript.virusPreventions.ThirdAnswer();

            // If the index value is 1, call the method virusScript.virusPreventions.FirstQuestionSelection()
            // which will check the player answer. If the player selects the wrong answer,
            // player will lose 5 health. If the player select the correct answer, the virus will proceed
            // with the next question.
            if (virusScript.virusPreventions.index == 1)
            {
                virusScript.virusPreventions.FirstQuestionSelection();
            }
            // If the index value is 2, call the method virusScript.virusPreventions.SecondQuestionSelection()
            // which will check the player answer. Similarly, if player selects the wrong answer,
            // player will lose 5 health. If the player select the correct answer, the virus will proceed
            // with the next question.
            else if (virusScript.virusPreventions.index == 2)
            {
                virusScript.virusPreventions.SecondQuestionSelection();
            }
            // If the index value is 3, call the method virusScript.virusPreventions.ThirdQuestionSelection()
            // which will check the player answer. Similarly, if player selects the wrong answer,
            // player will lose 5 health. If the player select the correct answer, the virus will proceed
            // with the next question.
            else if (virusScript.virusPreventions.index == 3)
            {
                virusScript.virusPreventions.ThirdQuestionSelection();
            }
        }
        // If the virusType is 2, call the method virusScript.virusSymptoms.ThirdAnswer()
        // which holds an integer value of 3, meaning the player has selected the third answer.
        else if (virusScript.virusType == 2)
        {
            virusScript.virusSymptoms.ThirdAnswer();

            // If the index value is 1, call the method virusScript.virusSymptoms.FirstQuestionSelection()
            // which will check the player answer. If the player selects the wrong answer,
            // player will lose 5 health. If the player select the correct answer, the virus will proceed
            // with the next question.
            if (virusScript.virusSymptoms.index == 1)
            {
                virusScript.virusSymptoms.FirstQuestionSelection();
            }
            // If the index value is 2, call the method virusScript.virusSymptoms.SecondQuestionSelection()
            // which will check the player answer. Similarly, if player selects the wrong answer,
            // player will lose 5 health. If the player select the correct answer, the virus will proceed
            // with the next question.
            else if (virusScript.virusSymptoms.index == 2)
            {
                virusScript.virusSymptoms.SecondQuestionSelection();
            }
        }
    }
}
