using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class SelectVirus : MonoBehaviour
{
<<<<<<< HEAD
    public SelectVirus gameManager;

=======
>>>>>>> parent of 72981ad (Made several changes to scripts)
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
<<<<<<< HEAD
        gameManager = FindObjectOfType<SelectVirus>();

=======
>>>>>>> parent of 72981ad (Made several changes to scripts)
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

            if (Physics.Raycast(ray, out hit) && !isSelected)
            {
<<<<<<< HEAD
                virusName = hit.transform.name;

                if (virusName == "Virus_Type_One")
                {
                    answersScript.virusTypeOneScript = FindObjectOfType<VirusTypeOne>();
                    answersScript.virusTypeOneScript.virusPreventions.GetGameObjectsAndTextComponents();
                }
                else if (virusName == "Virus_Type_Two")
                {
                    answersScript.virusTypeTwoScript = FindObjectOfType<VirusTypeTwo>();
                    answersScript.virusTypeTwoScript.virusSymptoms.GetGameObjectsAndTextComponents();
                }
                
=======
                answersScript.virusScript = FindObjectOfType<Virus>();
>>>>>>> parent of 72981ad (Made several changes to scripts)
                isSelected = true;
            }
        }
    }
}
