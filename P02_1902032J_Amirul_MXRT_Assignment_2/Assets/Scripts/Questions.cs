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

    public void SelectQuestions()
    {
        virusScript.virusPreventions.FirstQuestionSelection();
    }
}
