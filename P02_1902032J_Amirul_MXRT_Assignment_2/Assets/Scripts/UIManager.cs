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
    private GameObject smallPreventionWindow;

    [Header("Prevention Individual Window")]
    [SerializeField]
    private GameObject preventionIndividualWindow;

    #region Prevention Information Variables
    [Header("Prevention Information Variables")]
    [SerializeField]
    private Image icon;
    [SerializeField]
    private Text titleText;
    [SerializeField]
    private Text informationText;
    #endregion

    private string faceMaskTitle = "Face Mask";
    private string faceMaskInformation = "Face Mask are essential to \nwear when going to public \n areas. It helps protect, " +
                                         "\n prevent transmissions and \n save lives from COVID-19.";

    private string socialDistancingTitle = "Social Distancing";
    private string socialDistancingInformation = "Social Distancing helps limit \nthe spread of COVID-19 by \nkeeping a distance of at " +
                                                 "\nleast 1 metre from each \nother in crowded places.";

    private string wasingHandsTitle = "Washing Hands With Soap";
    private string wasingHandsInformation = "Regularly washing hands \nwith soap keeps us healthy \nand can reduce the spread " +
                                            "\nof COVID-19. Avoid touching \nyour face or food as you \nmay have touched a \ncontaminated surface.";

    [Header("Virus Preventions Booleans")]
    public bool firstCorrectPreventionAnswer, secondCorrectPreventionAnswer, thirdCorrectPreventionAnswer;

    [Header("Virus Symptoms Booleans")]
    public bool firstCorrectSymptomsAnswer, secondCorrectSymptomsAnswer;

    #region Virus Prevetions Sprites Variables
    [Header("Virus Preventions Sprites")]
    [SerializeField]
    private Sprite faceMask;
    [SerializeField]
    private Sprite socialDistancing;
    [SerializeField]
    private Sprite washingHands;
    #endregion

    #region Knowledge Icons Images Variables
    [Header("Knowledge Icons Images")]
    [SerializeField]
    private Image firstKnowledgeIcon;
    [SerializeField]
    private Image secondKnowledgeIcon;
    [SerializeField]
    private Image thirdKnowledgeIcon;
    #endregion

    #region Knowledge Brief Text Variables
    [Header("Knowledge Brief Text")]
    [SerializeField]
    private Text firstKnowledgeText;
    [SerializeField]
    private Text secondKnowledgeText;
    [SerializeField]
    private Text thirdKnowledgeText;
    #endregion

    private string faceMaskInfo = "Face Mask \n Tap for more Info";
    private string socialDistancingInfo = "Social Distancing \n Tap for more Info";
    private string washinghandsInfo = "Washing Hands \n With Soap \n Tap for more Info";

    private string preventionTitle;

    private string preventionDescription;

    // Start is called before the first frame update
    void Start()
    {
        //virusScript = FindObjectOfType<Virus>();
        smallPreventionWindow.SetActive(false);

        preventionIndividualWindow.SetActive(false);

        firstCorrectPreventionAnswer = secondCorrectPreventionAnswer = thirdCorrectPreventionAnswer = false;
    }

    // Update is called once per frame
    /*void Update()
    {

    }*/

    public void ShowPreventionKnowledge()
    {
        smallPreventionWindow.SetActive(true);

        ShowUnlockPreventionKnowledge();
    }

    public void ClosePreventionWindow()
    {
        smallPreventionWindow.SetActive(false);
    }

    public void ShowUnlockPreventionKnowledge()
    {
        if (firstCorrectPreventionAnswer == true)
        {
            firstKnowledgeIcon.sprite = faceMask;
            firstKnowledgeText.text = faceMaskInfo;
        }

        if (secondCorrectPreventionAnswer == true)
        {
            secondKnowledgeIcon.sprite = socialDistancing;
            secondKnowledgeText.text = socialDistancingInfo;
        }

        if (thirdCorrectPreventionAnswer == true)
        {
            thirdKnowledgeIcon.sprite = washingHands;
            thirdKnowledgeText.text = washinghandsInfo;
        }
    }

    public void ShowFaceMaskKnowledge()
    {
        preventionIndividualWindow.SetActive(true);

        icon.sprite = faceMask;
        titleText.text = faceMaskTitle;
        informationText.text = faceMaskInformation;
    }

    public void ShowSocialDistancingKnowledge()
    {
        preventionIndividualWindow.SetActive(true);

        icon.sprite = socialDistancing;
        titleText.text = socialDistancingTitle;
        informationText.text = socialDistancingInformation;
    }

    public void ShowWashingHandsKnowledge()
    {
        preventionIndividualWindow.SetActive(true);

        icon.sprite = washingHands;
        titleText.text = wasingHandsTitle;
        informationText.text = wasingHandsInformation;
    }
}
