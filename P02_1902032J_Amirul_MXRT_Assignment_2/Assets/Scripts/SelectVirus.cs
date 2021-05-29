using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class SelectVirus : MonoBehaviour
{
    [SerializeField]
    private GameObject selectedObject;

    [SerializeField]
    private Camera arCamera;

    // Start is called before the first frame update
    void Start()
    {
        arCamera = FindObjectOfType<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        DestroyVirus();
    }

    void DestroyVirus()
    {
        if (Input.touchCount == 0)
            return;

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            var ray = arCamera.ScreenPointToRay(Input.GetTouch(0).position);

            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                selectedObject = hit.transform.gameObject;
                Destroy(selectedObject);
            }
        }
    }
}
