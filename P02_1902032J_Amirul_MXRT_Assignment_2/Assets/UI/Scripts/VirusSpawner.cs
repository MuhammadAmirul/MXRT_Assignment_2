using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class VirusSpawner : MonoBehaviour
{
    [SerializeField]
    private ARPlaneManager arPlaneManager;

    [SerializeField]
    private GameObject virusGameObject;

    private int virusSpawn = 0;
    private int maxVirusSpawn = 5;

    // Start is called before the first frame update
    void Start()
    {
        virusSpawn = 0;
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(TimelyVirusSpawn());
    }

    IEnumerator TimelyVirusSpawn()
    {
        yield return new WaitForSeconds(2f);

        arPlaneManager.planesChanged += SpawnVirus;
    }

    void SpawnVirus(ARPlanesChangedEventArgs virusObject)
    {
        if (virusSpawn < maxVirusSpawn)
        {
            foreach (var plane in virusObject.added)
            {
                Instantiate(virusGameObject, plane.center, Quaternion.identity);
                virusSpawn++;
            }
        }
    }
}
