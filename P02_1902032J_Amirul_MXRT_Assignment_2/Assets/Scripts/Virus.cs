using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Virus : MonoBehaviour
{
    private GameManager gameManagerScript;

    public SelectVirus selectVirusScript;

    public int virusType;

    public VirusPreventions virusPreventions;
    public VirusSymptoms virusSymptoms;

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

        virusType = Random.Range(1, 3);

        if (virusType == 1)
        {
            virusPreventions = new VirusPreventions();
            virusPreventions.SetHealth();
        }
        else if (virusType == 2)
        {
            virusSymptoms = new VirusSymptoms();
            virusSymptoms.SetHealth();
        }

        this.gameObject.name = "Virus";
    }

    // Update is called once per frame
    void Update()
    {
        if (selectVirusScript.isSelected == true)
        {
            if (virusType == 1)
            {
                virusPreventions.ShowQuestionsUI();
                virusPreventions.ShowQuestion();
            }
            else if (virusType == 2)
            {
                virusSymptoms.ShowQuestionsUI();
                virusSymptoms.ShowQuestion();
            }

            DestroyVirusTypes();
        }
    }

    void DestroyVirusTypes()
    {
        if (virusType == 1)
        {
            if (virusPreventions.health <= 0)
            {
                gameManagerScript.virusSpawn--;

                virusPreventions.CloseQuestionsUI();
                virusPreventions.NullSettingsOnDeath();

                selectVirusScript.isSelected = false;

                Destroy(this.gameObject);
            }
            
        }
        else if (virusType == 2)
        {
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
}
