using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;

public class GameManager : MonoBehaviour
{
    [Header("AR Plane Manager")]
    [SerializeField]
    private ARPlaneManager arPlaneManager;

    [Header("Virus GameObject")]
    [SerializeField]
    private GameObject virusGameObject;

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

        playerHealthText.text = playerHealth.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        arPlaneManager.planesChanged += SpawnVirus;
        //Testing();
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

    /*void Testing()
    {
        if (virusSpawn < maxVirusSpawn)
        {
            for (int i = 0; i < maxVirusSpawn; i++)
            {
                Vector3 planePosition = new Vector3(Random.Range(placeHolder.position.x - placeHolder.localScale.x / 2, placeHolder.position.x + placeHolder.localScale.x / 2),
                                                    placeHolder.position.y,
                                                    Random.Range(placeHolder.position.z - placeHolder.localScale.z / 2, placeHolder.position.z + placeHolder.localScale.z / 2));

                Instantiate(virusGameObject, planePosition, Quaternion.identity);
                virusSpawn++;
            }
        }
    }*/
}
