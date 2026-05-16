using TMPro;
using UnityEngine;

public class gameManagerFurros : MonoBehaviour
{
    public static int puntos = 0;

    GameObject puntaje;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        puntaje = GameObject.Find("puntaje");
    }

    // Update is called once per frame
    void Update()
    {
        puntaje.GetComponent<TextMeshProUGUI>().text = puntos.ToString();
    }
}
