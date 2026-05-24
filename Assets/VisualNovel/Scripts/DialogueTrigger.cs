using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    [SerializeField]
    private DialogueData dialogueData;

    [SerializeField]
    private bool startOnInteract = true;

    public void TriggerDialogue()
    {
        if (startOnInteract && DialogueManager.Instance != null)
        {
            DialogueManager.Instance.StartDialogue(dialogueData);
        }
    }

    private void OnMouseDown()
    {
        TriggerDialogue();
    }
}
