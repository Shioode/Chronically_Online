using TMPro;
using UnityEngine;

public class gameManagerSpam : MonoBehaviour
{
    public static int puntos = 0;

    GameObject puntaje;

    //public static int puntosZorrona = 0;
    //public static int puntosCaballito = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        puntaje = GameObject.Find("puntaje");
        //Debug.Log("puntosGatita");
        //Debug.Log("puntosZorrona");
        //Debug.Log("puntosCaballito");
    }

    // Update is called once per frame
    void Update()
    {
        puntaje.GetComponent<TextMeshProUGUI>().text = puntos.ToString();
    }

    //void Panel()
    //{
    //    if (puntosGatita >= 3)
    //   {
    //      Gatita.SetActive(false);
    //          Zorrona.SetActive(true);
    //    }

    //  if (puntosZorrona >= 3)
    //{
    //  Gatita.SetActive(false);
    //Zorrona.SetActive(false);
    //Caballito.SetActive(true);
    //}

    //if (puntosCaballito >= 3)
    //{
    //    Gatita.SetActive(false);
    //   Zorrona.SetActive(false);
    //    Caballito.SetActive(false);
    //   }
    //}
}
