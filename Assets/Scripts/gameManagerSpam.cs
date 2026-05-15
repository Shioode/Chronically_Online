using UnityEngine;

public class gameManagerSpam : MonoBehaviour
{
    public static int puntosGatita = 0;
    public static int puntosZorrona = 0;
    public static int puntosCaballito = 0;

    GameObject Gatita;
    GameObject Zorrona;
    GameObject Caballito;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Gatita = GameObject.Find("Fondo1");
        Zorrona = GameObject.Find("Fondo2");
        Caballito = GameObject.Find("Fondo3");
        Gatita.SetActive(true);
        Zorrona.SetActive(false);
        Caballito.SetActive(false);
        //Debug.Log("puntosGatita");
        //Debug.Log("puntosZorrona");
        // Debug.Log("puntosCaballito");
    }

    // Update is called once per frame
    void Update() { }

    void Panel()
    {
        if (puntosGatita >= 3)
        {
            Gatita.SetActive(false);
            Zorrona.SetActive(true);
        }

        if (puntosZorrona >= 3)
        {
            Gatita.SetActive(false);
            Zorrona.SetActive(false);
            Caballito.SetActive(true);
        }

         if (puntosCaballito >= 3)
        {
            Gatita.SetActive(false);
            Zorrona.SetActive(false);
            Caballito.SetActive(false);
        }
    }
}
