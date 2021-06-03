using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Virus : MonoBehaviour
{
    // Declared a GameManager script to deduct the
    // virus quantity once its dead.
    private GameManager gameManagerScript;

    // Declared a SelectVirus script to check
    // if the player has selected the virus.
    public SelectVirus selectVirusScript;

    // An integer value which gives a random number
    // of either 1 or 2.
    public int virusType;

    // Declare a class variable of VirusPreventions and VirusSymptoms
    // to create a new instance.
    public VirusPreventions virusPreventions;
    public VirusSymptoms virusSymptoms;

    // Start is called before the first frame update
    void Start()
    {
        // Find the object that has the component of GameManager script.
        gameManagerScript = FindObjectOfType<GameManager>();

        // Find the object that has the component of SelectVirus script.
        selectVirusScript = FindObjectOfType<SelectVirus>();

        // Give a random number of 1 or 2.
        virusType = Random.Range(1, 3);

        // If the virusType is 1, create an instance of VirusPreventions
        // and call its method to set the virus health.
        if (virusType == 1)
        {
            virusPreventions = new VirusPreventions();
            virusPreventions.SetHealth();
        }
        // If the virusType is 2, create an instance of VirusSymptoms
        // and call its method to set the virus health.
        else if (virusType == 2)
        {
            virusSymptoms = new VirusSymptoms();
            virusSymptoms.SetHealth();
        }

        // Set the name of this GameObject to Virus when it spawns.
        this.gameObject.name = "Virus";
    }

    // Update is called once per frame
    void Update()
    {
        // When the isSelected boolean is true, check if
        // the virusType is 1 or 2.
        if (selectVirusScript.isSelected == true)
        {
            // If the virusType is 1, call the virusPreventions.ShowQuestionsUI()
            // and virusPreventions.ShowQuestion() method to show the questions
            // and answer selections.
            if (virusType == 1)
            {
                virusPreventions.ShowQuestionsUI();
                virusPreventions.ShowQuestion();
            }
            // If the virusType is 2, call the virusSymptoms.ShowQuestionsUI()
            // and virusSymptoms.ShowQuestion() method to show the questions
            // and answer selections.
            else if (virusType == 2)
            {
                virusSymptoms.ShowQuestionsUI();
                virusSymptoms.ShowQuestion();
            }

            // This method is to destroy the virus once its health reaches 0.
            DestroyVirusTypes();
        }
    }

    void DestroyVirusTypes()
    {
        // If the virusType is 1, check if the
        // virusPreventions health is less than or
        // equals to 0.
        if (virusType == 1)
        {
            // If the virusPreventions.health is less than or equals 0,
            // deduct gameManagerScript.virusSpawn by 1, close the questions UI,
            // set some settings to null in virusPreventions.NullSettingsOnDeath()
            // method, set the isSelected bool to false and destroy this GameObject.
            if (virusPreventions.health <= 0)
            {
                gameManagerScript.virusSpawn--;

                virusPreventions.CloseQuestionsUI();
                virusPreventions.NullSettingsOnDeath();

                selectVirusScript.isSelected = false;

                Destroy(this.gameObject);
            }

        }
        // If the virusType is 2, check if the
        // virusSymptoms health is less than or
        // equals to 0.
        else if (virusType == 2)
        {
            // If the virusSymptoms.health is less than or equals 0,
            // deduct gameManagerScript.virusSpawn by 1, close the questions UI,
            // set some settings to null in virusSymptoms.NullSettingsOnDeath()
            // method, set the isSelected bool to false and destroy this GameObject.
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
