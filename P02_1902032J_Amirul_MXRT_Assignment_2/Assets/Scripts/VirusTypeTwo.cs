using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VirusTypeTwo : MonoBehaviour
{
    private GameManager gameManagerScript;

    public SelectVirus selectVirusScript;

    public VirusSymptoms virusSymptoms;

    [SerializeField]
    private int health;

    [SerializeField]
    private GameObject enemyHealth;

    [SerializeField]
    private Text enemyHealthText;

    [SerializeField]
    private GameObject questionWindow;

    // Start is called before the first frame update
    void Start()
    {
        gameManagerScript = FindObjectOfType<GameManager>();

        selectVirusScript = FindObjectOfType<SelectVirus>();

        virusSymptoms = new VirusSymptoms();
        virusSymptoms.GetGameObjectsAndTextComponents();

        this.gameObject.name = "Virus_Type_Two";
    }

    // Update is called once per frame
    void Update()
    {
        if (selectVirusScript.isSelected == true)
        {
            virusSymptoms.ShowQuestionsUI();
            virusSymptoms.ShowQuestion();
        }

        if (virusSymptoms.health <= 0)
        {
            gameManagerScript.virusSpawn--;
            virusSymptoms.CloseQuestionsUI();
            virusSymptoms.NullSettingsOnDeath();

            selectVirusScript.isSelected = false;

            Destroy(this.gameObject);
        }
    }
}
