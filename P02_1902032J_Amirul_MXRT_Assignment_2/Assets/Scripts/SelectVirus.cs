using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class SelectVirus : MonoBehaviour
{
    public Virus virusScript;

    public Answers answersScript;

    /*[SerializeField]
    private GameObject selectedObject;*/

    [SerializeField]
    private Camera arCamera;

    public bool isSelected;

    public string virusName;

    // Start is called before the first frame update
    void Start()
    {
        answersScript = FindObjectOfType<Answers>();

        arCamera = FindObjectOfType<Camera>();
        isSelected = false;
    }

    // Update is called once per frame
    void Update()
    {
        VirusSelection();
    }

    void VirusSelection()
    {
        if (Input.touchCount == 0)
            return;

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            var ray = arCamera.ScreenPointToRay(Input.GetTouch(0).position);

            RaycastHit hit;

            if (Physics.Raycast(ray, out hit) && hit.transform.name == "Virus" && !isSelected)
            {
                virusScript = FindObjectOfType<Virus>();
                answersScript.virusScript = FindObjectOfType<Virus>();

                if (virusScript.virusType == 1)
                {
                    answersScript.virusScript.virusPreventions.GetGameObjectsAndTextComponents();
                }
                else
                {
                    answersScript.virusScript.virusSymptoms.GetGameObjectsAndTextComponents();
                }

                isSelected = true;
            }
        }
    }

    /*void PCVirusSelection()
    {
        Vector3 distance = virus.position - transform.position;
        //var mainRay = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit;
        Debug.DrawRay(transform.position, virus.position, Color.green);

        if (Physics.Raycast(transform.position, distance, out hit) && hit.transform.name == "Virus" && !isSelected && Input.GetMouseButtonDown(0))
        {
            virusScript = FindObjectOfType<Virus>();
            answersScript.virusScript = FindObjectOfType<Virus>();

            if (virusScript.virusType == 1)
            {
                answersScript.virusScript.virusPreventions.GetGameObjectsAndTextComponents();
            }
            else
            {
                answersScript.virusScript.virusSymptoms.GetGameObjectsAndTextComponents();
            }

            isSelected = true;
        }
    }*/
}
