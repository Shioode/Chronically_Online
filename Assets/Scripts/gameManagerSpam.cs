using TMPro;
using UnityEngine;

public class gameManagerSpam : MonoBehaviour
{
    public static int puntosSpam = 0;

    GameObject puntuacion;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        puntuacion = GameObject.Find("Puntuacion");
    }

    // Update is called once per frame
    void Update()
    {
        puntuacion.GetComponent<TextMeshProUGUI>().text = puntosSpam.ToString();
    }
}
