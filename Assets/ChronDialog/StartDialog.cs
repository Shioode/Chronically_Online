using UnityEngine;

public class StartDialog : MonoBehaviour
{
    [SerializeField]
    private DialogueNodeSO nodoInicial;

    public void QueComienceElDialogo()
    {
        DialogueManager manager = FindObjectOfType<DialogueManager>();
        if (manager != null)
        {
            gameObject.SetActive(false);
            manager.IniciarDialogo(nodoInicial);
            //gameObject.SetActive(false);
        }
        else
        {
            Debug.LogError("No se encontró un DialogueManager en la escena.");
        }
    }
}
