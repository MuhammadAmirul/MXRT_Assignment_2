using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Virus : MonoBehaviour
{
    public VirusPreventions virusPreventions;

    private int health;
    List<int> numberOfQuestions = new List<int>();

    private string question;

    // Start is called before the first frame update
    void Start()
    {
        health = Random.Range(1, 3);
        virusPreventions = new VirusPreventions(health);

        virusPreventions.GetGameObjectsAndTextComponents();

        //numberOfQuestions = health;

        //QuestionsSetUp();
    }

    /*void QuestionsSetUp()
    {
        for (int i = 0; i < health; i++)
        {
            numberOfQuestions.Add(i);
        }
    }*/

    // Update is called once per frame
    void Update()
    {
        
    }
}
