using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    [Header("Referencias UI")]
    [SerializeField]
    private Image imagenPersonaje;

    [SerializeField]
    private TMP_Text textoDialogo;

    [SerializeField]
    private Button botonIzquierda;

    [SerializeField]
    private Button botonDerecha;

    [SerializeField]
    private TMP_Text etiquetaIzquierda;

    [SerializeField]
    private TMP_Text etiquetaDerecha;

    [SerializeField]
    private GameObject panelDialogo;

    [SerializeField]
    private float tiempoEntreElementos = 2f;

    [SerializeField]
    private float tiempoEntreCaracteres = 0.03f;

    private DialogueNodeSO dialogoActual;
    private int indiceActual = -1;
    private Coroutine avanceAutomatico;
    private Coroutine escrituraCoroutine;

    public void Start()
    {
        panelDialogo.SetActive(false);
        MostrarBotones(false);
    }

    public void IniciarDialogo(DialogueNodeSO dialogoInicial)
    {
        if (dialogoInicial == null || dialogoInicial.Elementos.Count == 0)
        {
            Debug.LogWarning("Se intentó iniciar un diálogo vacío.");
            TerminarDialogo();
            return;
        }

        dialogoActual = dialogoInicial;
        panelDialogo.SetActive(true);
        MostrarElemento(0);
    }

    private void MostrarElemento(int indice)
    {
        if (dialogoActual == null || indice < 0 || indice >= dialogoActual.Elementos.Count)
        {
            TerminarDialogo();
            return;
        }

        DetenerAvanceAutomatico();
        DetenerEscritura();

        indiceActual = indice;
        DialogueElement elemento = dialogoActual.Elementos[indice];

        textoDialogo.text = string.Empty;
        imagenPersonaje.sprite = elemento.sprite;
        imagenPersonaje.gameObject.SetActive(elemento.sprite != null);

        MostrarBotones(false);
        escrituraCoroutine = StartCoroutine(EscribirElemento(elemento, indice + 1));
    }

    private void MostrarBotones(bool mostrar)
    {
        botonIzquierda.gameObject.SetActive(mostrar);
        botonDerecha.gameObject.SetActive(mostrar);
    }

    private void DetenerAvanceAutomatico()
    {
        if (avanceAutomatico != null)
        {
            StopCoroutine(avanceAutomatico);
            avanceAutomatico = null;
        }
    }

    private void DetenerEscritura()
    {
        if (escrituraCoroutine != null)
        {
            StopCoroutine(escrituraCoroutine);
            escrituraCoroutine = null;
        }
    }

    private System.Collections.IEnumerator EscribirElemento(
        DialogueElement elemento,
        int siguienteIndice
    )
    {
        string contenido = elemento.texto ?? string.Empty;

        foreach (char caracter in contenido)
        {
            textoDialogo.text += caracter;

            if (tiempoEntreCaracteres > 0f)
            {
                yield return new WaitForSeconds(tiempoEntreCaracteres);
            }
            else
            {
                yield return null;
            }
        }

        escrituraCoroutine = null;

        if (elemento.pausar)
        {
            ConfigurarBoton(botonIzquierda, etiquetaIzquierda, elemento.accionIzquierda);
            ConfigurarBoton(botonDerecha, etiquetaDerecha, elemento.accionDerecha);
            yield break;
        }

        avanceAutomatico = StartCoroutine(AvanzarAutomatico(siguienteIndice));
    }

    private void ConfigurarBoton(Button boton, TMP_Text etiqueta, DialogueAction accion)
    {
        bool tieneAccion = accion != null && !string.IsNullOrEmpty(accion.etiqueta);
        boton.gameObject.SetActive(tieneAccion);

        if (!tieneAccion)
        {
            boton.onClick.RemoveAllListeners();
            return;
        }

        etiqueta.text = accion.etiqueta;
        boton.onClick.RemoveAllListeners();
        boton.onClick.AddListener(() => EjecutarAccion(accion));
    }

    private void EjecutarAccion(DialogueAction accion)
    {
        if (accion == null)
        {
            TerminarDialogo();
            return;
        }

        accion.onEjecutar?.Invoke(); // Dispara los UnityEvents asignados
        MostrarSiguienteDialogo(accion.siguienteNodo);
    }

    private void IrAIndice(int siguienteIndice)
    {
        if (siguienteIndice < 0)
        {
            TerminarDialogo();
            return;
        }

        MostrarElemento(siguienteIndice);
    }

    private void MostrarSiguienteDialogo(DialogueNodeSO siguienteDialogo)
    {
        if (siguienteDialogo == null)
        {
            TerminarDialogo();
            return;
        }

        dialogoActual = siguienteDialogo;
        MostrarElemento(0);
    }

    private System.Collections.IEnumerator AvanzarAutomatico(int siguienteIndice)
    {
        yield return new WaitForSeconds(tiempoEntreElementos);

        if (dialogoActual != null && indiceActual >= 0)
        {
            IrAIndice(siguienteIndice);
        }

        avanceAutomatico = null;
    }

    private void TerminarDialogo()
    {
        DetenerAvanceAutomatico();
        DetenerEscritura();
        MostrarBotones(false);
        panelDialogo.SetActive(false);
        dialogoActual = null;
        indiceActual = -1;
    }
}
