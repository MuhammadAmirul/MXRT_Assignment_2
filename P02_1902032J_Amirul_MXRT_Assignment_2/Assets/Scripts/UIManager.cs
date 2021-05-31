using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [Header("Virus Script")]
    private Virus virusScript;

    [Header("Virus Prevention Window")]
    [SerializeField]
    private GameObject preventionWindow;

    [Header("Virus Preventions Sprites")]
    [SerializeField]
    private Sprite faceMask;
    [SerializeField]
    private Sprite socialDistancing;
    [SerializeField]
    private Sprite washingHands;

    [Header("Knowledge Icons Images")]
    [SerializeField]
    private Image firstKnowledgeIcon;
    [SerializeField]
    private Image secondKnowledgeIcon;
    [SerializeField]
    private Image thirdKnowledgeIcon;

    [Header("Knowledge Brief Text")]
    [SerializeField]
    private Text firstKnowledgeText;
    [SerializeField]
    private Text secondKnowledgeText;
    [SerializeField]
    private Text thirdKnowledgeText;

    private string faceMaskInfo = "Face Mask \n Tap for more Info";
    private string socialDistancingInfo = "Social Distancing \n Tap for more Info";
    private string washinghandsInfo = "Washing Hands \n With Soap \n Tap for more Info";

    private string preventionTitle;

    private string preventionDescription;

    // Start is called before the first frame update
    void Start()
    {
        //virusScript = FindObjectOfType<Virus>();
        preventionWindow.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //UnlockPreventionKnowledge();
    }

    public void UnlockPreventionKnowledge()
    {
        preventionWindow.SetActive(true);

        if (virusScript.virusPreventions.firstCorrectAnswer == true)
        {
            firstKnowledgeIcon.sprite = faceMask;
            firstKnowledgeText.text = faceMaskInfo;
        }

        if (virusScript.virusPreventions.secondCorrectAnswer == true)
        {
            secondKnowledgeIcon.sprite = socialDistancing;
            secondKnowledgeText.text = socialDistancingInfo;
        }

        if (virusScript.virusPreventions.thirdCorrectAnswer == true)
        {
            thirdKnowledgeIcon.sprite = washingHands;
            thirdKnowledgeText.text = washinghandsInfo;
        }
    }
}
