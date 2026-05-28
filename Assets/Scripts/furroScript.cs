using UnityEngine;

public class furroScript : MonoBehaviour
{
    public int valor = 1;

    GameObject Gatita;
    GameObject Zorrona;
    GameObject Caballito;

    GameObject botonFinalin;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        botonFinalin = GameObject.Find("PanelBoton");
        Gatita = GameObject.Find("Fondo1");
        Zorrona = GameObject.Find("Fondo2");
        Caballito = GameObject.Find("Fondo3");
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManagerFurros.puntos < 3)
        {
            botonFinalin.SetActive(false);
            Gatita.SetActive(true);
            Zorrona.SetActive(false);
            Caballito.SetActive(false);
        }
    }

    public void OnMouseClick1()
    {
        gameObject.SetActive(false);
        gameManagerFurros.puntos += valor;
        Debug.Log("puntos =" + gameManagerFurros.puntos);
        //Puntaje.SumarPuntos(cantidadPuntos);

        if (gameManagerFurros.puntos >= 3)
        {
            Gatita.SetActive(false);
            Zorrona.SetActive(true);
            Caballito.SetActive(false);
        }

        if (gameManagerFurros.puntos >= 6)
        {
            Gatita.SetActive(false);
            Zorrona.SetActive(false);
            Caballito.SetActive(true);
        }

        if (gameManagerFurros.puntos >= 9)
        {
            botonFinalin.SetActive(true);
            Gatita.SetActive(false);
            Zorrona.SetActive(false);
            Caballito.SetActive(true);
        }
    }
}
