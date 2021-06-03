using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    // Declared selectvirusScript which will later check
    // if the player has selected any virus.
    [Header("Select Virus Script")]
    public SelectVirus selectVirusScript;

    // This boolean will check whether the player is
    // viewing the knowledge. If the boolean is true,
    // then the player will not be able to tap on the
    // virus to answer the questions.
    //
    // This is to prevent from too many UI appearing.
    [Header("Viewing Knowledge Boolean")]
    public bool viewingKnowledge;

    // A region which has the variables for
    // Prevention Related Knowledge.
    #region Prevention Related Knowledge

    // Declared smallPreventionWindow GameObject variable
    // to make it appear and disappear.
    [Header("Mini Virus Prevention Window")]
    [SerializeField]
    private GameObject smallPreventionWindow;

    // Declared preventionIndividualWindow GameObject
    // variable to make it appear and disappear.
    [Header("Prevention Individual Window")]
    [SerializeField]
    private GameObject preventionIndividualWindow;

    // A region relating to the virus prevention knowledge
    // information variables
    #region Prevention Information Variables

    // Declared an Image variable and 2 Text variables.
    // The Image variable will hold either 1 of the 3 sprites
    // when the respective knowledge is pressed and the title
    // and information text will show their respective information.
    [Header("Prevention Information Variables")]
    [SerializeField]
    private Image preventionIcon;
    [SerializeField]
    private Text preventionTitleText;
    [SerializeField]
    private Text preventionInformationText;
    #endregion

    // A region that contains the string variable for each individual prevention knowledge.
    #region Prevention Information

    // Each title and information holds their own information which will be assigned to
    // preventionTitleText and preventionInformationText and show their respective information
    // when the respective knowledge buttons are pressed.
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

    // These 3 booleans are to check when the 1st, 2nd and 3rd questions are answered correctly.
    // When answer correctly, the knowledge will unlock.
    //
    // These 3 booleans will be called in the VirusPreventions.cs class script.
    [Header("Virus Preventions Booleans")]
    public bool firstCorrectPreventionAnswer, secondCorrectPreventionAnswer, thirdCorrectPreventionAnswer;

    // A region that contains the Sprite variables for the prevention knowledge.
    #region Virus Preventions Sprites Variables

    // Each individual Sprite variable holds 3 different sprites
    // that will be assigned to preventionIcon Image variable
    // to show the current selected knowledge image in the mini window
    // of virus preventions.
    [Header("Virus Preventions Sprites")]
    [SerializeField]
    private Sprite faceMask;
    [SerializeField]
    private Sprite socialDistancing;
    [SerializeField]
    private Sprite washingHands;
    #endregion

    // A region that contains the Image variables of the prevention knowledge
    // icon buttons in the mini window of virus preventions.
    #region Prevention Knowledge Icons Images Variables

    // Each of these 3 Image variables holds the button image which will
    // change to their respective icons when the player answers the questions correctly.
    [Header("Prevention Knowledge Icons Images")]
    [SerializeField]
    private Image firstPreventionKnowledgeIcon;
    [SerializeField]
    private Image secondPreventionKnowledgeIcon;
    [SerializeField]
    private Image thirdPreventionKnowledgeIcon;
    #endregion

    // A region that contains the Text variables of the prevention knowledge
    // text buttons in the mini window of virus preventions.
    #region Prevention Knowledge Brief Text Variables

    // Each of these 3 Text variables holds the text buttons which will
    // change to their respective text when the player answers the questions correctly.
    [Header("Prevention Knowledge Brief Text")]
    [SerializeField]
    private Text firstPreventionKnowledgeText;
    [SerializeField]
    private Text secondPreventionKnowledgeText;
    [SerializeField]
    private Text thirdPreventionKnowledgeText;
    #endregion

    // These are the string variables that will change the text buttons in the
    // mini virus preventions window.
    private string faceMaskInfo = "Face Mask \nTap for more Info";
    private string socialDistancingInfo = "Social Distancing \nTap for more Info";
    private string washinghandsInfo = "Washing Hands \n With Soap \nTap for more Info";
    #endregion

    // A region which has the variables for
    // Symptoms Related Knowledge.
    #region Symptoms Related Knowledge

    // Declared smallSymptomsWindow GameObject variable
    // to make it appear and disappear.
    [Header("Mini Virus Symptoms Window")]
    [SerializeField]
    private GameObject smallSymptomsWindow;

    // Declared symptomsIndividualWindow GameObject
    // variable to make it appear and disappear.
    [Header("Symptoms Individual Window")]
    [SerializeField]
    private GameObject symptomsIndividualWindow;

    // A region relating to the virus prevention knowledge
    // information variables
    #region Symptoms Information Variables

    // Declared an Image variable and 2 Text variables.
    // The Image variable will hold either 1 of the 3 sprites
    // when the respective knowledge is pressed and the title
    // and information text will show their respective information.
    [Header("Symptoms Information Variables")]
    [SerializeField]
    private Image symptomsIcon;
    [SerializeField]
    private Text symptomsTitleText;
    [SerializeField]
    private Text symptomsInformationText;
    #endregion

    // A region that contains the string variable for each individual symptoms knowledge.
    #region Symptoms Information

    // Each title and information holds their own information which will be assigned to
    // symptomsTitleText and symptomsInformationText and show their respective information
    // when the respective knowledge buttons are pressed.
    private string commonSymptomsTitle = "Common Symptoms";
    private string commonSymptomsInformation = "Fever, Dry Cough and Fatgue \nare common symptoms of COVID-19. \nThose with common symptoms who " +
                                         "\nare otherwise healthy should \nquarantine themselves at home for \n14 days to monitor their health.";

    private string lessCommonSymptomsTitle = "Less Common Symptoms";
    private string lessCommonSymptomsInformation = "Loss of taste and smell is the \nmost obvious symptoms compared to \nothers such as sore throat, diarrhoea, " +
                                                 "\naches and pains etc. Seek \nmedical attention and always call \nbefore visiting your doctor or \n health facility.";
    #endregion

    // These 2 booleans are to check when the 1st and 2nd questions are answered correctly.
    // When answer correctly, the knowledge will unlock.
    //
    // These 2 booleans will be called in the VirusSymptoms.cs class script.
    [Header("Virus Symptoms Booleans")]
    public bool firstCorrectSymptomsAnswer, secondCorrectSymptomsAnswer;

    // A region that contains the Sprite variables for the symptoms knowledge.
    #region Virus Symptoms Sprite Variable

    // Each individual Sprite variable holds 3 different sprites
    // that will be assigned to symptomsIcon Image variable
    // to show the current selected knowledge image in the mini window
    // of virus symptoms.
    [Header("Virus Symptoms Sprites")]
    [SerializeField]
    private Sprite symptomsSprite;
    #endregion

    // A region that contains the Image variables of the symptoms knowledge
    // icon buttons in the mini window of virus symptoms.
    #region Symptoms Knowledge Icons Image Variables

    // Both the Image variables holds the button image which will
    // change to their respective icons when the player answers the questions correctly.
    [Header("Symptoms Knowledge Icons Image")]
    [SerializeField]
    private Image firstSymptomsKnowledgeIcon;
    [SerializeField]
    private Image secondSymptomsKnowledgeIcon;
    #endregion

    // A region that contains the Text variables of the symptoms knowledge
    // text buttons in the mini window of virus symptoms.
    #region Symptoms Knowledge Brief Text Variables

    // Both the Text variables holds the text buttons which will
    // change to their respective text when the player answers the questions correctly.
    [Header("Symptoms Knowledge Brief Text")]
    [SerializeField]
    private Text firstSymptomsKnowledgeText;
    [SerializeField]
    private Text secondSymptomsKnowledgeText;
    #endregion

    // These are the string variables that will change the text buttons in the
    // mini virus symptoms window.
    private string commonSymptomsInfo = "Common Symptoms \nTap for more Info";
    private string lessCommonSymptomsInfo = "Less Common \nSymptoms \nTap for more Info";
    #endregion

    // Start is called before the first frame update
    void Start()
    {
        // Get the component of SelectVirus script.
        selectVirusScript = FindObjectOfType<SelectVirus>();

        // Set the activeness of the smallPreventionWindow and smallSymptomsWindow
        // GameObject to false.
        smallPreventionWindow.SetActive(false);
        smallSymptomsWindow.SetActive(false);

        // Set the activeness of the preventionIndividualWindow GameObject to false.
        preventionIndividualWindow.SetActive(false);

        // Set the firstCorrectPreventionAnswer, secondCorrectPreventionAnswer and thirdCorrectPreventionAnswer
        // booleans to false.
        firstCorrectPreventionAnswer = secondCorrectPreventionAnswer = thirdCorrectPreventionAnswer = false;

        // Set the firstCorrectSymptomsAnswer and secondCorrectSymptomsAnswer to false.
        firstCorrectSymptomsAnswer = secondCorrectSymptomsAnswer = false;

        // Set the viewingKnowledge boolean to false.
        viewingKnowledge = false;
    }

    #region Virus Preventions Methods

    #region Show Mini Prevention Knowledge
    // This method will be applied to the Virus_Prevention_Button GameObject in the Scene
    // to show the mini prevention window when the button is pressed.
    public void ShowMiniPreventionKnowledge()
    {
        // When the boolean isSelected of selectVirusScript is false,
        // show the smallPreventionWindow, set the viewKnowledge boolean
        // to true and call the method ShowUnlockPreventionKnowledge()
        // to show any prevention knowledge if it is unlocked.
        if (selectVirusScript.isSelected == false)
        {
            smallPreventionWindow.SetActive(true);
            smallSymptomsWindow.SetActive(false);

            viewingKnowledge = true;

            ShowUnlockPreventionKnowledge();
        }
    }
    #endregion

    #region Close Mini Prevention Window
    // This method will be applied to the Close_Button in the parent GameObject
    // Virus_Prevention_Button to close the mini prevention window
    public void CloseMiniPreventionWindow()
    {
        // Set the activeness of smallPreventionWindow GameObject to false
        // and viewingKnowledge to false.
        smallPreventionWindow.SetActive(false);
        viewingKnowledge = false;
    }
    #endregion

    #region Show Unlock Prevention Knowledge
    // This method is being called in ShowMiniPreventionKnowledge() to show the
    // knowledge obtained.
    public void ShowUnlockPreventionKnowledge()
    {
        // If either the firstCorrectPreventionAnswer, secondCorrectPreventionAnswer and thirdCorrectPreventionAnswer
        // boolean is true, change their sprites and text accordingly.
        if (firstCorrectPreventionAnswer == true)
        {
            // Set the firstPreventionKnowledgeIcon to the face mask sprite
            // and firstPreventionKnowledgeText to the face mask info.
            firstPreventionKnowledgeIcon.sprite = faceMask;
            firstPreventionKnowledgeText.text = faceMaskInfo;
        }

        if (secondCorrectPreventionAnswer == true)
        {
            // Set the secondPreventionKnowledgeIcon to the social distancing sprite
            // and secondPreventionKnowledgeText to the social distancing info.
            secondPreventionKnowledgeIcon.sprite = socialDistancing;
            secondPreventionKnowledgeText.text = socialDistancingInfo;
        }

        if (thirdCorrectPreventionAnswer == true)
        {
            // Set the thirdPreventionKnowledgeIcon to the washing hands sprite
            // and thirdPreventionKnowledgeText to the washing hands info.
            thirdPreventionKnowledgeIcon.sprite = washingHands;
            thirdPreventionKnowledgeText.text = washinghandsInfo;
        }
    }
    #endregion

    #region Show Face Mask Knowledge
    // This method will be applied to the Locked_Label_1 GameObject in the Scene
    // to open up a window and show the knowledge regarding Face Mask.
    public void ShowFaceMaskKnowledge()
    {
        // If firstCorrectPreventionAnswer is true, then open up the window and show
        // more detailed information about Face Mask.
        if (firstCorrectPreventionAnswer == true)
        {
            // Set the activeness preventionIndividualWindow to true and
            // smallPreventionWindow to false.
            preventionIndividualWindow.SetActive(true);
            smallPreventionWindow.SetActive(false);

            // Set the sprite of smallPreventionWindow to face mask,
            // preventionTitleText to the title of Face Mask,
            // and preventionInformationText to the full information about
            // Face Mask.
            preventionIcon.sprite = faceMask;
            preventionTitleText.text = faceMaskTitle;
            preventionInformationText.text = faceMaskInformation;
        }
    }
    #endregion

    #region Show Social Distancing Knowledge
    // This method will be applied to the Locked_Label_2 GameObject in the Scene
    // to open up a window and show the knowledge regarding Social Distancing.
    public void ShowSocialDistancingKnowledge()
    {
        // If secondCorrectPreventionAnswer is true, then open up the window and show
        // more detailed information about Social Distancing.
        if (secondCorrectPreventionAnswer == true)
        {
            // Set the activeness preventionIndividualWindow to true and
            // smallPreventionWindow to false.
            preventionIndividualWindow.SetActive(true);
            smallPreventionWindow.SetActive(false);

            // Set the sprite of smallPreventionWindow to social distancing,
            // preventionTitleText to the title of Social Distancing,
            // and preventionInformationText to the full information about
            // Social Distancing.
            preventionIcon.sprite = socialDistancing;
            preventionTitleText.text = socialDistancingTitle;
            preventionInformationText.text = socialDistancingInformation;
        }
    }
    #endregion

    #region Show Washing Hands Knowledge
    // This method will be applied to the Locked_Label_3 GameObject in the Scene
    // to open up a window and show the knowledge regarding Washing Hands.
    public void ShowWashingHandsKnowledge()
    {
        // If thirdCorrectPreventionAnswer is true, then open up the window and show
        // more detailed information about Washing Hands.
        if (thirdCorrectPreventionAnswer == true)
        {
            // Set the activeness preventionIndividualWindow to true and
            // smallPreventionWindow to false.
            preventionIndividualWindow.SetActive(true);
            smallPreventionWindow.SetActive(false);

            // Set the sprite of smallPreventionWindow to washing hands,
            // preventionTitleText to the title of Washing Hands,
            // and preventionInformationText to the full information about
            // Washing Hands.
            preventionIcon.sprite = washingHands;
            preventionTitleText.text = wasingHandsTitle;
            preventionInformationText.text = wasingHandsInformation;
        }
    }
    #endregion

    #region Close Prevention Knowledge Window
    // This method will be applied to the Close_Button in the Preventions_Window 
    // GameObject in the Scene to close the current knowledge the player is viewing.
    public void ClosePreventionKnowledgeWindow()
    {
        // Set the activeness of the preventionIndividualWindow to false
        // and set the viewingKnowledge to false.
        preventionIndividualWindow.SetActive(false);
        viewingKnowledge = false;
    }
    #endregion

    #endregion

    #region Virus Symptoms Method

    #region Show Mini Symptoms Window
    // This method will be applied to the Virus_Symptoms_Button GameObject in the Scene
    // to show the mini symptoms window when the button is pressed.
    public void ShowMiniSymptomsWindow()
    {
        // If the boolean isSelected in selectVirus is false, set the activeness of
        // smallPreventionWindow to false, smallSymptomsWindow to true, set viewingKnowledge
        // to true and call the ShowUnlockSymptomsKnowledge()
        // to show any symptoms knowledge if it is unlocked.
        if (selectVirusScript.isSelected == false)
        {
            smallPreventionWindow.SetActive(false);
            smallSymptomsWindow.SetActive(true);

            viewingKnowledge = true;

            ShowUnlockSymptomsKnowledge();
        }
    }
    #endregion

    #region Close Mini Symptoms Window
    // This method is applied in the Close_Button in Symptoms_Window GameObject which will
    // close the smallSymptomsWindow activeness and viewingKnowledge boolean to false.
    public void CloseMiniSymptomsWindow()
    {
        smallSymptomsWindow.SetActive(false);
        viewingKnowledge = false;
    }
    #endregion

    #region Show Unlock Symptoms Knowledge
    // This method is called in ShowMiniSymptomsWindow() to show any virus smyptoms knowledge
    // if it is unlocked.
    public void ShowUnlockSymptomsKnowledge()
    {
        // If the firstCorrectSymptomsAnswer and secondCorrectSymptomsAnswer is true
        // show the sprites and text accordingly.
        if (firstCorrectSymptomsAnswer == true)
        {
            // Change the firstSymptomsKnowledgeIcon sprite to the symptoms sprite and
            // firstSymptomsKnowledgeText to the common symptoms info.
            firstSymptomsKnowledgeIcon.sprite = symptomsSprite;
            firstSymptomsKnowledgeText.text = commonSymptomsInfo;
        }

        if (secondCorrectSymptomsAnswer == true)
        {
            // Change the secondSymptomsKnowledgeIcon sprite to the symptoms sprite and
            // secondSymptomsKnowledgeText to the less common symptoms info.
            secondSymptomsKnowledgeIcon.sprite = symptomsSprite;
            secondSymptomsKnowledgeText.text = lessCommonSymptomsInfo;
        }
    }
    #endregion

    #region Show Common Symptoms Knowledge
    // This method is applied in the Locked_Label_1 in Symptoms_Window GameObject. When the button
    // is pressed, the player will be able to see information about common symptoms.
    public void ShowCommonSymptomsKnowledge()
    {
        // If firstCorrectSymptomsAnswer is true, then show the information about common symptoms
        // in a new window. 
        if (firstCorrectSymptomsAnswer == true)
        {
            // Set the activeness of symptomsIndividualWindow to true and
            // smallSymptomsWindow to false.
            symptomsIndividualWindow.SetActive(true);
            smallSymptomsWindow.SetActive(false);

            // Set the symptomsIcon sprite to the symptoms sprite,
            // symptomsTitleText to the title of Common Symptoms and
            // symptomsInformationText to the information about Common Symptoms.
            symptomsIcon.sprite = symptomsSprite;
            symptomsTitleText.text = commonSymptomsTitle;
            symptomsInformationText.text = commonSymptomsInformation;
        }
    }
    #endregion

    #region Show Less Common Symptoms Knowledge
    // This method is applied in the Locked_Label_2 in Symptoms_Window GameObject. When the button
    // is pressed, the player will be able to see information about less common symptoms.
    public void ShowLessCommonSymptomsKnowledge()
    {
        // If secondCorrectSymptomsAnswer is true, then show the information about
        // less common symptoms in a new window. 
        if (secondCorrectSymptomsAnswer == true)
        {
            // Set the activeness of symptomsIndividualWindow to true and
            // smallSymptomsWindow to false.
            symptomsIndividualWindow.SetActive(true);
            smallSymptomsWindow.SetActive(false);

            // Set the symptomsIcon sprite to the symptoms sprite,
            // symptomsTitleText to the title of Less Common Symptoms and
            // symptomsInformationText to the information about Less Common Symptoms.
            symptomsIcon.sprite = symptomsSprite;
            symptomsTitleText.text = lessCommonSymptomsTitle;
            symptomsInformationText.text = lessCommonSymptomsInformation;
        }
    }
    #endregion

    #region Close Symptoms Knowledge Window
    // This method is applied in the Close_Button in Virus_Symptoms_Window GameObject
    // which will close the current knowledge the player is viewing.
    public void CloseSymptomsKnowledgeWindow()
    {
        // Set the symptomsIndividualWindow activeness to false and
        // viewingKnowledge boolean to false.
        symptomsIndividualWindow.SetActive(false);
        viewingKnowledge = false;
    }
    #endregion

    #endregion
}
