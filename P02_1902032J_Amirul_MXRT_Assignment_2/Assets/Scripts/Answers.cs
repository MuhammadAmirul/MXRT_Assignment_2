using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Answers : MonoBehaviour
{
<<<<<<< HEAD
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
=======
    public Virus virusScript;

    public void FirstAnswer()
    {
        virusScript.virusPreventions.FirstAnswer();
>>>>>>> parent of 72981ad (Made several changes to scripts)

        if (virusScript.virusPreventions.index == 1)
        {
            virusScript.virusPreventions.FirstQuestionSelection();
        }
<<<<<<< HEAD
        else if (selectVirusScript.virusName == "Virus_Type_Two")
=======
        else if (virusScript.virusPreventions.index == 2)
>>>>>>> parent of 72981ad (Made several changes to scripts)
        {
            virusScript.virusPreventions.SecondQuestionSelection();
        }
        else if (virusScript.virusPreventions.index == 3)
        {
            virusScript.virusPreventions.ThirdQuestionSelection();
        }
    }

    public void SecondAnswer()
    {
<<<<<<< HEAD
        if (selectVirusScript.virusName == "Virus_Type_One")
        {
            virusTypeOneScript.virusPreventions.SecondAnswer();
=======
        virusScript.virusPreventions.SecondAnswer();
>>>>>>> parent of 72981ad (Made several changes to scripts)

        if (virusScript.virusPreventions.index == 1)
        {
            virusScript.virusPreventions.FirstQuestionSelection();
        }
<<<<<<< HEAD
        else if (selectVirusScript.virusName == "Virus_Type_Two")
=======
        else if (virusScript.virusPreventions.index == 2)
>>>>>>> parent of 72981ad (Made several changes to scripts)
        {
            virusScript.virusPreventions.SecondQuestionSelection();
        }
        else if (virusScript.virusPreventions.index == 3)
        {
            virusScript.virusPreventions.ThirdQuestionSelection();
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
