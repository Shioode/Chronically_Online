using System;
using UnityEngine;
using UnityEngine.Events;

[Serializable]
public class DialogueAction
{
    [Tooltip("Texto que aparece en el botón de acción")]
    public string etiqueta;

    [Tooltip("Diálogo al que lleva esta acción (null = fin del diálogo)")]
    public DialogueNodeSO siguienteNodo;

    [Tooltip("Eventos adicionales al ejecutar esta acción (dar ítem, activar quest...)")]
    public UnityEvent onEjecutar;
}
