using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [Header("Select Virus Script")]
    public SelectVirus selectVirusScript;

    #region Prevention Related Knowledge
    [Header("Virus Prevention Window")]
    [SerializeField]
    private GameObject smallPreventionWindow;

    [Header("Prevention Individual Window")]
    [SerializeField]
    private GameObject preventionIndividualWindow;

    #region Prevention Information Variables
    [Header("Prevention Information Variables")]
    [SerializeField]
    private Image preventionIcon;
    [SerializeField]
    private Text preventionTitleText;
    [SerializeField]
    private Text preventionInformationText;
    #endregion

    #region Prevention Information
    private string faceMaskTitle = "Face Mask";
    private string faceMaskInformation = "Face Mask are essential to \nwear when going to public \n areas. It helps protect, " +
                                         "\n prevent transmissions and \n save lives from COVID-19.";

    private string socialDistancingTitle = "Social Distancing";
    private string socialDistancingInformation = "Social Distancing helps limit \nthe spread of COVID-19 by \nkeeping a distance of at " +
                                                 "\nleast 1 metre from each \nother in crowded places.";

    private string wasingHandsTitle = "Washing Hands With Soap";
    private string wasingHandsInformation = "Regularly washing hands with \n soap keeps us healthy and \n can reduce the spread of COVID-19. " +
                                            "\nAvoid touching your face or food \nas you may have touched a \ncontaminated surface.";
    #endregion

    [Header("Virus Preventions Booleans")]
    public bool firstCorrectPreventionAnswer, secondCorrectPreventionAnswer, thirdCorrectPreventionAnswer;

    #region Virus Preventions Sprites Variables
    [Header("Virus Preventions Sprites")]
    [SerializeField]
    private Sprite faceMask;
    [SerializeField]
    private Sprite socialDistancing;
    [SerializeField]
    private Sprite washingHands;
    #endregion

    #region Prevention Knowledge Icons Images Variables
    [Header("Prevention Knowledge Icons Images")]
    [SerializeField]
    private Image firstPreventionKnowledgeIcon;
    [SerializeField]
    private Image secondPreventionKnowledgeIcon;
    [SerializeField]
    private Image thirdPreventionKnowledgeIcon;
    #endregion

    #region Prevention Knowledge Brief Text Variables
    [Header("Prevention Knowledge Brief Text")]
    [SerializeField]
    private Text firstPreventionKnowledgeText;
    [SerializeField]
    private Text secondPreventionKnowledgeText;
    [SerializeField]
    private Text thirdPreventionKnowledgeText;
    #endregion

    private string faceMaskInfo = "Face Mask \nTap for more Info";
    private string socialDistancingInfo = "Social Distancing \nTap for more Info";
    private string washinghandsInfo = "Washing Hands \n With Soap \nTap for more Info";
    #endregion

    #region Symptoms Related Knowledge
    [Header("Virus Symptoms Window")]
    [SerializeField]
    private GameObject smallSymptomsWindow;

    [Header("Symptoms Individual Window")]
    [SerializeField]
    private GameObject symptomsIndividualWindow;

    #region Symptoms Information Variables
    [Header("Symptoms Information Variables")]
    [SerializeField]
    private Image symptomsIcon;
    [SerializeField]
    private Text symptomsTitleText;
    [SerializeField]
    private Text symptomsInformationText;
    #endregion

    #region Prevention Information
    private string commonSymptomsTitle = "Common Symptoms";
    private string commonSymptomsInformation = "Fever, Dry Cough and Fatgue \nare common symptoms of COVID-19. \nThose with common symptoms who " +
                                         "\nare otherwise healthy should \nquarantine themselves at home for \n14 days to monitor their health.";

    private string lessCommonSymptomsTitle = "Less Common Symptoms";
    private string lessCommonSymptomsInformation = "Loss of taste and smell is the \nmost obvious symptoms compared to \nothers such as sore throat, diarrhoea, " +
                                                 "\naches and pains etc. Seek \nmedical attention and always call \nbefore visiting your doctor or \n health facility.";
    #endregion

    [Header("Viewing Knowledge Boolean")]
    public bool viewingKnowledge;

    [Header("Virus Symptoms Booleans")]
    public bool firstCorrectSymptomsAnswer, secondCorrectSymptomsAnswer;

    #region Virus Symptoms Sprite Variable
    [Header("Virus Symptoms Sprites")]
    [SerializeField]
    private Sprite symptomsSprite;
    #endregion

    #region Symptoms Knowledge Icons Image Variables
    [Header("Symptoms Knowledge Icons Image")]
    [SerializeField]
    private Image firstSymptomsKnowledgeIcon;
    [SerializeField]
    private Image secondSymptomsKnowledgeIcon;
    #endregion

    #region Symptoms Knowledge Brief Text Variables
    [Header("Symptoms Knowledge Brief Text")]
    [SerializeField]
    private Text firstSymptomsKnowledgeText;
    [SerializeField]
    private Text secondSymptomsKnowledgeText;
    #endregion

    private string commonSymptomsInfo = "Common Symptoms \nTap for more Info";
    private string lessCommonSymptomsInfo = "Less Common \nSymptoms \nTap for more Info";
    #endregion

    // Start is called before the first frame update
    void Start()
    {
        selectVirusScript = FindObjectOfType<SelectVirus>();

        smallPreventionWindow.SetActive(false);
        smallSymptomsWindow.SetActive(false);

        preventionIndividualWindow.SetActive(false);

        firstCorrectPreventionAnswer = secondCorrectPreventionAnswer = thirdCorrectPreventionAnswer = false;
        firstCorrectSymptomsAnswer = secondCorrectSymptomsAnswer = false;

        viewingKnowledge = false;
    }

    public void ShowMiniPreventionKnowledge()
    {
        if (selectVirusScript.isSelected == false)
        {
            smallPreventionWindow.SetActive(true);
            smallSymptomsWindow.SetActive(false);

            viewingKnowledge = true;

            ShowUnlockPreventionKnowledge();
        }
    }

    public void CloseMiniPreventionWindow()
    {
        smallPreventionWindow.SetActive(false);
        viewingKnowledge = false;
    }

    public void ShowMiniSymptomsWindow()
    {
        if (selectVirusScript.isSelected == false)
        {
            smallPreventionWindow.SetActive(false);
            smallSymptomsWindow.SetActive(true);

            viewingKnowledge = true;

            ShowUnlockSymptomsKnowledge();
        }
    }

    public void CloseMiniSymptomsWindow()
    {
        smallSymptomsWindow.SetActive(false);
        viewingKnowledge = false;
    }

    public void ShowUnlockPreventionKnowledge()
    {
        if (firstCorrectPreventionAnswer == true)
        {
            firstPreventionKnowledgeIcon.sprite = faceMask;
            firstPreventionKnowledgeText.text = faceMaskInfo;
        }

        if (secondCorrectPreventionAnswer == true)
        {
            secondPreventionKnowledgeIcon.sprite = socialDistancing;
            secondPreventionKnowledgeText.text = socialDistancingInfo;
        }

        if (thirdCorrectPreventionAnswer == true)
        {
            thirdPreventionKnowledgeIcon.sprite = washingHands;
            thirdPreventionKnowledgeText.text = washinghandsInfo;
        }
    }

    public void ShowUnlockSymptomsKnowledge()
    {
        if (firstCorrectSymptomsAnswer == true)
        {
            firstSymptomsKnowledgeIcon.sprite = symptomsSprite;
            firstSymptomsKnowledgeText.text = commonSymptomsInfo;
        }

        if (secondCorrectSymptomsAnswer == true)
        {
            secondSymptomsKnowledgeIcon.sprite = symptomsSprite;
            secondSymptomsKnowledgeText.text = lessCommonSymptomsInfo;
        }
    }

    public void ShowFaceMaskKnowledge()
    {
        if (firstCorrectPreventionAnswer == true)
        {
            preventionIndividualWindow.SetActive(true);
            smallPreventionWindow.SetActive(false);

            preventionIcon.sprite = faceMask;
            preventionTitleText.text = faceMaskTitle;
            preventionInformationText.text = faceMaskInformation;
        }
    }

    public void ShowSocialDistancingKnowledge()
    {
        if (secondCorrectPreventionAnswer == true)
        {
            preventionIndividualWindow.SetActive(true);
            smallPreventionWindow.SetActive(false);

            preventionIcon.sprite = socialDistancing;
            preventionTitleText.text = socialDistancingTitle;
            preventionInformationText.text = socialDistancingInformation;
        }
    }

    public void ShowWashingHandsKnowledge()
    {
        if (thirdCorrectPreventionAnswer == true)
        {
            preventionIndividualWindow.SetActive(true);
            smallPreventionWindow.SetActive(false);

            preventionIcon.sprite = washingHands;
            preventionTitleText.text = wasingHandsTitle;
            preventionInformationText.text = wasingHandsInformation;
        }
    }

    public void ShowCommonSymptomsKnowledge()
    {
        if (firstCorrectSymptomsAnswer == true)
        {
            symptomsIndividualWindow.SetActive(true);
            smallSymptomsWindow.SetActive(false);

            symptomsIcon.sprite = symptomsSprite;
            symptomsTitleText.text = commonSymptomsTitle;
            symptomsInformationText.text = commonSymptomsInformation;
        }
    }

    public void ShowLessCommonSymptomsKnowledge()
    {
        if (secondCorrectSymptomsAnswer == true)
        {
            symptomsIndividualWindow.SetActive(true);
            smallSymptomsWindow.SetActive(false);

            symptomsIcon.sprite = symptomsSprite;
            symptomsTitleText.text = lessCommonSymptomsTitle;
            symptomsInformationText.text = lessCommonSymptomsInformation;
        }
    }

    public void ClosePreventionKnowledgeWindow()
    {
        preventionIndividualWindow.SetActive(false);
        viewingKnowledge = false;
    }

    public void CloseSymptomsKnowledgeWindow()
    {
        symptomsIndividualWindow.SetActive(false);
        viewingKnowledge = false;
    }
}
