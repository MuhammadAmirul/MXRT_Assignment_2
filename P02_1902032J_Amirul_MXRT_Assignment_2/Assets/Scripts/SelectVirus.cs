using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class SelectVirus : MonoBehaviour
{
    // Declared a Virus script variable to check
    // the virus type.
    public Virus virusScript;

    // Declared an Answers script variable to get the
    // Virus script so that the player will be able
    // to answer the questions.
    public Answers answersScript;
    
    // Declared a UIManager script to check whether
    // the player is currently viewing knowledge.
    public UIManager uiManagerScript;

    // Declared a Camera variable to cast a ray from the
    // AR Camera.
    [SerializeField]
    private Camera arCamera;

    // This boolean is to check whether the player has
    // selected any virus to answer the questions.
    public bool isSelected;

    // Start is called before the first frame update
    void Start()
    {
        // Find the object that has the type component of Answers script.
        answersScript = FindObjectOfType<Answers>();

        // Find the object that has the type component of UIManager script.
        uiManagerScript = FindObjectOfType<UIManager>();

        // Find the object that has the type component of Camera.
        arCamera = FindObjectOfType<Camera>();

        // Set the isSelected boolean to false.
        isSelected = false;
    }

    // Update is called once per frame
    void Update()
    {
        // Call the VirusSelection() method in update to constantly check if the player has
        // tapped on any virus.
        VirusSelection();
    }

    void VirusSelection()
    {
        // If the player did not touch any part of the screen, return it.
        if (Input.touchCount == 0)
            return;

        // Otherwise, if the player did tap the screen, declare a Ray variable which
        // stores and cast a ray from the camera to the touch position and RaycastHit
        // variable that will store the object that was hit by the ray.
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            var ray = arCamera.ScreenPointToRay(Input.GetTouch(0).position);

            RaycastHit hit;

            // If the ray casted has hit any object that has the name "Virus" and isSelected and viewingKnowledge is false,
            // set the virusScript to get the Virus component from the current hit transform of the object and
            // set the virusScript variable in the answersScript so that the player is able to answer the questions.
            if (Physics.Raycast(ray, out hit) && hit.transform.name == "Virus" && !isSelected && uiManagerScript.viewingKnowledge == false)
            {
                virusScript = hit.transform.GetComponent<Virus>();
                answersScript.virusScript = virusScript;

                // If the virusType is 1, call the method GetGameObjectsAndTextComponents()
                // in the virusScript from the virusPreventions class which will set its health
                // and the number of questions the player has to answer.
                if (virusScript.virusType == 1)
                {
                    virusScript.virusPreventions.GetGameObjectsAndTextComponents();
                }
                // If the virusType is 2, call the method GetGameObjectsAndTextComponents()
                // in the virusScript from the virusSymptoms class which will set its health
                // and the number of questions the player has to answer.
                else if (virusScript.virusType == 2)
                {
                    virusScript.virusSymptoms.GetGameObjectsAndTextComponents();
                }

                // Set the isSelected boolean to true to indicate that the player
                // has selected the virus and will not be able to view their knowledge
                // until the virus is dead.
                isSelected = true;
            }
        }
    }
}
