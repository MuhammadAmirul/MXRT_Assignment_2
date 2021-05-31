using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Virus : MonoBehaviour
{
    private GameManager gameManagerScript;

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
        gameManagerScript = FindObjectOfType<GameManager>();

        selectVirusScript = FindObjectOfType<SelectVirus>();

        virusPreventions = new VirusPreventions();

        virusPreventions.GetGameObjectsAndTextComponents();

        this.gameObject.name = "Virus";
    }

    // Update is called once per frame
    void Update()
    {
        if (selectVirusScript.isSelected == true)
        {
            virusPreventions.ShowQuestionsUI();
            virusPreventions.ShowQuestion();
        }

        if (virusPreventions.health <= 0)
        {
            gameManagerScript.virusSpawn--;

            virusPreventions.CloseQuestionsUI();
            selectVirusScript.isSelected = false;

            Destroy(this.gameObject);
        }
    }
}
