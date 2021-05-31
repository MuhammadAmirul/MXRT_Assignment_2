using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Answers : MonoBehaviour
{
    public SelectVirus selectVirusScript;

    public VirusTypeOne virusTypeOneScript;
    public VirusTypeTwo virusTypeTwoScript;

    private void Start()
    {
        selectVirusScript = FindObjectOfType<SelectVirus>();
    }

    public void FirstAnswer()
    {
        if (selectVirusScript.virusName == "Virus_Type_One")
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
        else if (selectVirusScript.virusName == "Virus_Type_Two")
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
        if (selectVirusScript.virusName == "Virus_Type_One")
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
        else if (selectVirusScript.virusName == "Virus_Type_Two")
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
