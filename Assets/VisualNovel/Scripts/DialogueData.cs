using UnityEngine;

[CreateAssetMenu(fileName = "NewDialogue", menuName = "VisualNovel/Dialogue Data")]
public class DialogueData : ScriptableObject
{
    public DialogueLine[] lines;
    public DialogueChoice[] choices;
}
