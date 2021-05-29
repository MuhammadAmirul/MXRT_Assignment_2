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
    private int maxVirusSpawn = 10;

    private float virusSpawnTime = 10f;

    // Start is called before the first frame update
    void Start()
    {
        virusSpawn = 0;
    }

    // Update is called once per frame
    void Update()
    {
        TimelyVirusSpawn(virusSpawn, maxVirusSpawn, virusSpawnTime);
    }

    void TimelyVirusSpawn(int _virusSpawn, int _maxVirusSpawn, float _virusSpawnTime)
    {
        if (_virusSpawn < _maxVirusSpawn)
        {
            _virusSpawnTime -= Time.deltaTime;

            if (_virusSpawnTime <= 0f)
            {
                arPlaneManager.planesChanged += SpawnVirus;
                _virusSpawnTime = 10f;
            }
        }
    }

    void SpawnVirus(ARPlanesChangedEventArgs virusObject)
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
