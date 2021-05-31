using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class SelectVirus : MonoBehaviour
{
    public GameManager gameManager;

    public Answers answersScript;

    /*[SerializeField]
    private GameObject selectedObject;*/

    [SerializeField]
    private Camera arCamera;

    public bool isSelected;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();

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
                if (gameManager.virusType == 1)
                {
                    answersScript.virusTypeOneScript = FindObjectOfType<VirusTypeOne>();
                }
                else if (gameManager.virusType == 2)
                {
                    answersScript.virusTypeTwoScript = FindObjectOfType<VirusTypeTwo>();
                }
                
                isSelected = true;
            }
        }
    }
}
