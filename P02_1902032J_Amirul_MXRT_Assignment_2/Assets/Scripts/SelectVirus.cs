using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class SelectVirus : MonoBehaviour
{
    public Questions questionsScript;

    [SerializeField]
    private GameObject selectedObject;

    [SerializeField]
    private Transform virusPlaceholder;

    [SerializeField]
    private Camera arCamera;

    public bool isSelected;

    // Start is called before the first frame update
    void Start()
    {
        questionsScript = FindObjectOfType<Questions>();

        arCamera = FindObjectOfType<Camera>();
        isSelected = false;
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

            if (Physics.Raycast(ray, out hit) && hit.transform.name == "Virus" && !isSelected)
            {
                selectedObject = hit.transform.gameObject;
                questionsScript.virusScript = FindObjectOfType<Virus>();
                isSelected = true;

                selectedObject.transform.position = virusPlaceholder.position;
            }
        }
    }
}
