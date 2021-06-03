using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Declare an ARPlaneManager to allow the virus
    // to spawn on the plane.
    [Header("AR Plane Manager")]
    [SerializeField]
    private ARPlaneManager arPlaneManager;

    // Declare a GameObject virusGameObject to spawn the virus.
    [Header("Virus GameObject")]
    [SerializeField]
    private GameObject virusGameObject;

    // Declare a GameObject variables which will store the
    // UI GameObjects.
    [Header("Game UI")]
    [SerializeField]
    private GameObject virusPreventionButton;
    [SerializeField]
    private GameObject virusSymptomsButton;
    [SerializeField]
    private GameObject playerHealthImage;
    [SerializeField]
    private GameObject quitButton;
    [SerializeField]
    private GameObject knowledgePanel;
    [SerializeField]
    private GameObject questionsPanel;
    [SerializeField]
    private GameObject individualKnowledgePanel;

    // Declare a GameObject variable that will store the
    // quitSelection.
    [Header("Quit UI")]
    [SerializeField]
    private GameObject quitSelection;

    // Declare a GameObject loseScreen to show the lose screen
    // once the player loses the game.
    [Header("Lose Screen GameObject")]
    [SerializeField]
    private GameObject loseScreen;

    // The integer virusSpawn is to increment the value when
    // the virus spawns.
    public int virusSpawn = 0;
    // The maxVirusSpawn is to limit the number of virus to spawn.
    private int maxVirusSpawn = 3;

    // The declared variables from here are being used in VirusSymptoms and
    // VirusPreventions class.
    
    // Declare a GameObject enemyHealth and Text enemyHealthText variables.
    [Header("Virus Health Variables")]
    [Space]
    public GameObject enemyHealth;
    public Text enemyHealthText;

    // Declare a Text questionText variable.
    public Text questionText;

    // Declare an answerButtons GameObject and array of answerText Text
    // variables.
    public GameObject answerButtons;
    public Text[] answerText = new Text[3];

    // Declare a GameObject questionWindow.
    public GameObject questionWindow;

    // Declare a integer playerHealth to deduct health in the virus class
    // and to check if the player dies.
    public int playerHealth;

    // Declare a Text playerHealthText to set the playerHealth value into
    // this variable as a string.
    public Text playerHealthText;

    // Start is called before the first frame update
    void Start()
    {
        // Set the virusSpawn to 0 and playerHealth to 100.
        virusSpawn = 0;
        playerHealth = 100;

        // Set these GameObject variables to true and false accordingly.
        virusPreventionButton.SetActive(true);
        virusSymptomsButton.SetActive(true);
        enemyHealth.SetActive(false);
        playerHealthImage.SetActive(true);
        quitButton.SetActive(true);
        knowledgePanel.SetActive(true);
        questionsPanel.SetActive(true);
        individualKnowledgePanel.SetActive(true);

        quitSelection.SetActive(false);

        loseScreen.SetActive(false);

        // Set the playerHealth value into playerHealthText as a string.
        playerHealthText.text = playerHealth.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        // Spawn the virus.
        arPlaneManager.planesChanged += SpawnVirus;

        // Check if the player dies.
        PlayerDeath();
    }

    void SpawnVirus(ARPlanesChangedEventArgs virusObject)
    {
        // If the virudSpawn is less than maxVirusSpawn, do a foreach loop which uses the plane
        // in ARPlaneManager to that spawns periodically and declare a Vector3 planePosition which
        // allows the virus to spawn randomly around the plane size.
        if (virusSpawn < maxVirusSpawn)
        {
            foreach (var plane in virusObject.added)
            {
                Vector3 planePosition = new Vector3(Random.Range(plane.transform.position.x - plane.transform.localScale.x / 2, plane.transform.position.x + plane.transform.localScale.x / 2),
                                                    plane.transform.position.y,
                                                    Random.Range(plane.transform.position.z - plane.transform.localScale.z / 2, plane.transform.position.z + plane.transform.localScale.z / 2));

                // Instantiate the virusGameObject on the planePosition and a rotation of 0, 0, 0.
                Instantiate(virusGameObject, planePosition, Quaternion.identity);
                // Increment the virusSpawn by 1.
                virusSpawn++;
            }
        }
    }

    void PlayerDeath()
    {
        // If playerHealth is less than or equals to 0, set these GameObjects activeness to false
        // except for the loseScreen to true to show the lose screen.
        if (playerHealth <= 0)
        {
            virusPreventionButton.SetActive(false);
            virusSymptomsButton.SetActive(false);
            enemyHealth.SetActive(false);
            playerHealthImage.SetActive(false);
            quitButton.SetActive(false);
            knowledgePanel.SetActive(false);
            questionsPanel.SetActive(false);
            individualKnowledgePanel.SetActive(false);

            loseScreen.SetActive(true);
        }
    }

    // Load the scene of the Gameplay when the player wants to retry.
    public void Retry()
    {
        SceneManager.LoadScene("Gameplay_Scene");
    }

    // Load the Main_Menu scene when the player wants to go to the Main Menu.
    public void MainMenu()
    {
        SceneManager.LoadScene("Main_Menu");
    }

    // This method is applied to the Quit_Button.
    public void ShowQuitSelection()
    {
        // Show the window to show the player the options to quit.
        quitSelection.SetActive(true);

        // Get the buttons from virusPreventionButton and virusSymptomsButton.
        Button preventionButton = virusPreventionButton.GetComponent<Button>();
        Button symptomsButton = virusSymptomsButton.GetComponent<Button>();

        // Disable the buttons so player cannot interact with it.
        preventionButton.interactable = false;
        symptomsButton.interactable = false;
    }

    // This method is applied to the No_Button.
    public void CloseQuitSelection()
    {
        // Close the quitSelection window.
        quitSelection.SetActive(false);

        // Get the buttons from virusPreventionButton and virusSymptomsButton.
        Button preventionButton = virusPreventionButton.GetComponent<Button>();
        Button symptomsButton = virusSymptomsButton.GetComponent<Button>();

        // Enable the buttons so player can interact with it.
        preventionButton.interactable = true;
        symptomsButton.interactable = true;
    }
}
