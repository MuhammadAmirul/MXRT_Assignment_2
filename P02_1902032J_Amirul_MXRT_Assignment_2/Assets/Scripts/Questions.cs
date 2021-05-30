using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Questions : MonoBehaviour
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
        if (virusScript.virusPreventions.index == 1)
        {
            virusScript.virusPreventions.FirstAnswer();
            virusScript.virusPreventions.FirstQuestionSelection();
        }
    }

    public void SecondAnswer()
    {
        if (virusScript.virusPreventions.index == 1)
        {
            virusScript.virusPreventions.SecondAnswer();
            virusScript.virusPreventions.FirstQuestionSelection();
        }
    }

    public void ThirdAnswer()
    {
        if (virusScript.virusPreventions.index == 1)
        {
            virusScript.virusPreventions.ThirdAnswer();
            virusScript.virusPreventions.FirstQuestionSelection();
        }
    }
}
