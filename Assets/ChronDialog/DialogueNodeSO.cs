using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NuevoNodo", menuName = "Dialogo/Nodo")]
public class DialogueNodeSO : ScriptableObject
{
    [Header("Secuencia")]
    [SerializeField]
    private List<DialogueElement> elementos = new();

    public IReadOnlyList<DialogueElement> Elementos => elementos;
}

[Serializable]
public class DialogueElement
{
    [Header("Contenido")]
    public Sprite sprite;

    [TextArea(3, 6)]
    public string texto;

    [Header("Flujo")]
    [Tooltip("Si está activo, el diálogo espera input del jugador antes de continuar")]
    public bool pausar;

    [Header("Acciones")]
    public DialogueAction accionIzquierda;
    public DialogueAction accionDerecha;
}
