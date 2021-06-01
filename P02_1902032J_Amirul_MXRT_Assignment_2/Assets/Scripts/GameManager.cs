using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [Header("AR Plane Manager")]
    [SerializeField]
    private ARPlaneManager arPlaneManager;

    [Header("Virus GameObject")]
    [SerializeField]
    private GameObject virusGameObject;

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

    [Header("Quit UI")]
    [SerializeField]
    private GameObject quitSelection;

    [Header("Lose Screen GameObject")]
    [SerializeField]
    private GameObject loseScreen;

    public int virusSpawn = 0;
    private int maxVirusSpawn = 3;

    [Header("Virus Health Variables")]
    [Space]
    public GameObject enemyHealth;
    public Text enemyHealthText;

    public Text questionText;

    public GameObject answerButtons;
    public Text[] answerText = new Text[3];

    public GameObject questionWindow;

    public int playerHealth;

    public Text playerHealthText;

    // Start is called before the first frame update
    void Start()
    {
        virusSpawn = 0;
        playerHealth = 100;

        virusPreventionButton.SetActive(true);
        virusSymptomsButton.SetActive(true);
        playerHealthImage.SetActive(true);
        quitButton.SetActive(true);
        knowledgePanel.SetActive(true);
        questionsPanel.SetActive(true);
        individualKnowledgePanel.SetActive(true);

        quitSelection.SetActive(false);

        loseScreen.SetActive(false);

        playerHealthText.text = playerHealth.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        arPlaneManager.planesChanged += SpawnVirus;

        PlayerDeath();
    }

    void SpawnVirus(ARPlanesChangedEventArgs virusObject)
    {
        if (virusSpawn < maxVirusSpawn)
        {
            foreach (var plane in virusObject.added)
            {
                Vector3 planePosition = new Vector3(Random.Range(plane.transform.position.x - plane.transform.localScale.x / 2, plane.transform.position.x + plane.transform.localScale.x / 2),
                                                    plane.transform.position.y,
                                                    Random.Range(plane.transform.position.z - plane.transform.localScale.z / 2, plane.transform.position.z + plane.transform.localScale.z / 2));

                Instantiate(virusGameObject, planePosition, Quaternion.identity);
                virusSpawn++;
            }
        }
    }

    void PlayerDeath()
    {
        if (playerHealth <= 0)
        {
            virusPreventionButton.SetActive(false);
            virusSymptomsButton.SetActive(false);
            playerHealthImage.SetActive(false);
            quitButton.SetActive(false);
            knowledgePanel.SetActive(false);
            questionsPanel.SetActive(false);
            individualKnowledgePanel.SetActive(false);

            loseScreen.SetActive(true);
        }
    }

    public void Retry()
    {
        SceneManager.LoadScene("Gameplay_Scene");
    }

    public void ShowQuitSelection()
    {
        quitSelection.SetActive(true);

        Button preventionButton = virusPreventionButton.GetComponent<Button>();
        Button symptomsButton = virusSymptomsButton.GetComponent<Button>();

        preventionButton.interactable = false;
        symptomsButton.interactable = false;
    }

    public void CloseQuitSelection()
    {
        quitSelection.SetActive(false);

        Button preventionButton = virusPreventionButton.GetComponent<Button>();
        Button symptomsButton = virusSymptomsButton.GetComponent<Button>();

        preventionButton.interactable = true;
        symptomsButton.interactable = true;
    }
}
