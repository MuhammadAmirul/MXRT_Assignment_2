using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Virus : MonoBehaviour
{
    public VirusPreventions virusPreventions;

    public SelectVirus selectVirusScript;

    [SerializeField]
    private int health;

    [SerializeField]
    private GameObject enemyHealth;

    [SerializeField]
    private Text enemyHealthText;

    [SerializeField]
    private GameObject[] answerButtons = new GameObject[3];

    [SerializeField]
    private Text[] answerText = new Text[3];

    [SerializeField]
    private GameObject questionWindow;

    List<int> numberOfQuestions = new List<int>();

    private string question;

    // Start is called before the first frame update
    void Start()
    {
        health = Random.Range(1, 3);
        virusPreventions = new VirusPreventions(health);

        virusPreventions.GetGameObjectsAndTextComponents();

        selectVirusScript = FindObjectOfType<SelectVirus>();

        this.gameObject.name = "Virus";

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
        if (selectVirusScript.isSelected == true)
        {
            virusPreventions.ShowQuestionsUI();
            virusPreventions.ShowQuestion();
        }
    }
}
