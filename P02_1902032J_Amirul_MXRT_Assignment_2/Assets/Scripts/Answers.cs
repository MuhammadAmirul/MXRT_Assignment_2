using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Answers : MonoBehaviour
{
    public Virus virusScript;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    /*void Update()
    {
        
    }*/

    public void FirstAnswer()
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

    public void SecondAnswer()
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
