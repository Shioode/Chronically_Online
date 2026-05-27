using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public static DialogueManager Instance;

    [Header("UI")]
    public GameObject dialoguePanel;
    public TMP_Text speakerText;
    public TMP_Text dialogueText;

    public GameObject botonFinal;

    public Image portraitImage;

    [Header("Choices UI")]
    [SerializeField]
    private GameObject choicesPanel;

    [SerializeField]
    private Button[] choiceButtons;

    [SerializeField]
    private TMP_Text[] choiceTexts;

    [Header("Typewriter")]
    [SerializeField]
    private float typeSpeed = 0.03f;

    private DialogueData currentDialogue;
    private DialogueLine[] currentLines;
    private int currentIndex;
    private Coroutine typeRoutine;
    private bool isTyping;
    private bool isOpen;

    public DialogueData Dialogos;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        //dialoguePanel.SetActive(false);
        choicesPanel.SetActive(false);
    }

    void Start()
    {
        //botonFinal.SetActive(false);

        StartDialogue(Dialogos);
    }

    private void Update()
    {
        if (!isOpen)
            return;

        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            if (isTyping)
            {
                SkipTyping();
            }
            else
            {
                NextLine();
            }
        }
    }

    public void StartDialogue(DialogueData dialogueData)
    {
        if (dialogueData == null || dialogueData.lines == null || dialogueData.lines.Length == 0)
            return;

        currentDialogue = dialogueData;
        currentLines = dialogueData.lines;
        currentIndex = 0;
        isOpen = true;
        dialoguePanel.SetActive(true);
        choicesPanel.SetActive(false);
        botonFinal.SetActive(false);

        ShowLine(currentLines[currentIndex]);
    }

    private void ShowLine(DialogueLine line)
    {
        speakerText.text = line.speakerName;

        if (portraitImage != null)
        {
            portraitImage.sprite = line.portrait;
            portraitImage.enabled = line.portrait != null;
        }

        if (typeRoutine != null)
            StopCoroutine(typeRoutine);

        typeRoutine = StartCoroutine(TypeLine(line.text));
    }

    private IEnumerator TypeLine(string line)
    {
        isTyping = true;
        dialogueText.text = "";
        dialogueText.maxVisibleCharacters = 0;
        dialogueText.text = line;

        dialogueText.ForceMeshUpdate();
        int totalCharacters = dialogueText.textInfo.characterCount;

        for (int i = 0; i <= totalCharacters; i++)
        {
            dialogueText.maxVisibleCharacters = i;
            yield return new WaitForSeconds(typeSpeed);
        }

        isTyping = false;
    }

    private void SkipTyping()
    {
        if (typeRoutine != null)
            StopCoroutine(typeRoutine);

        dialogueText.maxVisibleCharacters = dialogueText.textInfo.characterCount;
        isTyping = false;
    }

    private void NextLine()
    {
        currentIndex++;

        if (currentIndex >= currentLines.Length)
        {
            ShowChoices();
            return;
        }

        ShowLine(currentLines[currentIndex]);
    }

    private void ShowChoices()
    {
        if (currentDialogue.choices == null || currentDialogue.choices.Length == 0)
        {
            EndDialogue();
            return;
        }

        dialoguePanel.SetActive(false);
        choicesPanel.SetActive(true);

        for (int i = 0; i < choiceButtons.Length; i++)
        {
            if (i < currentDialogue.choices.Length)
            {
                choiceButtons[i].gameObject.SetActive(true);
                choiceTexts[i].text = currentDialogue.choices[i].choiceText;

                int choiceIndex = i;
                choiceButtons[i].onClick.RemoveAllListeners();
                choiceButtons[i].onClick.AddListener(() => ChooseOption(choiceIndex));
            }
            else
            {
                choiceButtons[i].gameObject.SetActive(false);
            }
        }
    }

    private void ChooseOption(int index)
    {
        DialogueData next = currentDialogue.choices[index].nextDialogue;

        choicesPanel.SetActive(false);

        if (next != null)
        {
            StartDialogue(next);
        }
        else
        {
            EndDialogue();
        }
    }

    private void EndDialogue()
    {
        botonFinal.SetActive(true);
        isOpen = false;
        dialoguePanel.SetActive(false);
        choicesPanel.SetActive(false);
        currentDialogue = null;
        currentLines = null;
        currentIndex = 0;
    }

    public void OnMouseClickCambioGacha()
    {
        SceneManager.LoadScene("GachaScene");
    }

    // public void OnMouseClickCambioDiaSiguiente()
    // {
    //     SceneManager.LoadScene("GachaScene");
    // }

    public void OnMouseClickConvTres()
    {
        SceneManager.LoadScene("SpamScene");
    }

    public void OnMouseClickFurrificacion()
    {
        SceneManager.LoadScene("furro");
    }

    public void OnMouseClickGymbro()
    {
        SceneManager.LoadScene("BroLlamada");
    }

    public void OnMouseClickGotica()
    {
        SceneManager.LoadScene("lluvia de ideas");
    }
}
