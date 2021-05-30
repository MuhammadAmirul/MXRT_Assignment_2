using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Questions : MonoBehaviour
{
    public VirusPreventions virusPreventions;

    // Start is called before the first frame update
    void Start()
    {
        //virusPreventions = new VirusPreventions();
    }

    // Update is called once per frame
    /*void Update()
    {
        
    }*/

    public void SelectQuestions()
    {
        virusPreventions.FirstQuestionSelection();
    }
}
