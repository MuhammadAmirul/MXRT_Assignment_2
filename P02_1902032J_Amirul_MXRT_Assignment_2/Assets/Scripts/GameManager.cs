using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private ARPlaneManager arPlaneManager;

    [SerializeField]
    private GameObject virusTypeOneGameObject;
    [SerializeField]
    private GameObject virusTypeTwoGameObject;

    public int virusType;

    public int virusSpawn = 0;
    private int maxVirusSpawn = 3;

    [Space]
    public GameObject enemyHealth;
    public Text enemyHealthText;

    public Text questionText;

    public GameObject answerButton;
    public GameObject[] answerButtons = new GameObject[3];
    public Text[] answerText = new Text[3];

    public GameObject questionWindow;

    public int playerHealth;

    public Text playerHealthText;

    // Start is called before the first frame update
    void Start()
    {
        virusSpawn = 0;
        playerHealth = 100;

        playerHealthText.text = playerHealth.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        arPlaneManager.planesChanged += SpawnVirus;
    }
    void SpawnVirus(ARPlanesChangedEventArgs virusObject)
    {
        if (virusSpawn < maxVirusSpawn)
        {
            foreach (var plane in virusObject.added)
            {
                virusType = Random.Range(1, 3);

                Vector3 planePosition = new Vector3(Random.Range(plane.transform.position.x - plane.transform.localScale.x / 2, plane.transform.position.x + plane.transform.localScale.x / 2),
                                                    plane.transform.position.y,
                                                    Random.Range(plane.transform.position.z - plane.transform.localScale.z / 2, plane.transform.position.z + plane.transform.localScale.z / 2));

                if (virusType == 1)
                {
                    Instantiate(virusTypeOneGameObject, planePosition, Quaternion.identity);
                }
                else if (virusType == 2)
                {
                    Instantiate(virusTypeTwoGameObject, planePosition, Quaternion.identity);
                }
                
                virusSpawn++;
            }
        }
    }
}
