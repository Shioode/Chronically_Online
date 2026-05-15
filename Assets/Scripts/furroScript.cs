using UnityEngine;

public class furroScript : MonoBehaviour
{
    /// <summary>
    /// [SerializeField]
    /// </summary>
    //private float cantidadPuntos;

    //[SerializeField]
    //private Puntaje puntosGatita;

    //public GameObject ObjPuntos;
    public int valor = 1;

    GameObject Gatita;
    GameObject Zorrona;
    GameObject Caballito;

    //Fpublic static int puntosGatita;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Gatita = GameObject.Find("Fondo1");
        Zorrona = GameObject.Find("Fondo2");
        Caballito = GameObject.Find("Fondo3");
    }

    // Update is called once per frame
    void Update()
    {
        //Gatita.SetActive(true);
        //Zorrona.SetActive(false);
        //Caballito.SetActive(false);

        if (gameManagerSpam.puntos < 3)
        {
            Gatita.SetActive(true);
            Zorrona.SetActive(false);
            Caballito.SetActive(false);
        }

        /*if (gameManagerSpam.puntos >= 3)
        {
            Gatita.SetActive(false);
            Zorrona.SetActive(true);
            Caballito.SetActive(false);
        }

        if (gameManagerSpam.puntos >= 3 && gameManagerSpam.puntosZorrona >= 3)
        {
            Gatita.SetActive(false);
            Zorrona.SetActive(false);
            Caballito.SetActive(true);
        }

        //if (Zorrona == false && Caballito == false)
        //{
        //    Gatita.SetActive(true);
        //Caballito.SetActive(false);
        //}

        //if (gameManagerSpam.puntosGatita >= 3)
        //{
        //    Gatita.SetActive(false);
        //}

        //if (Gatita == false && Caballito == false)
        //{
        //   Zorrona.SetActive(true);
        //Caballito.SetActive(false);
        //}

        //if (gameManagerSpam.puntosZorrona >= 3)
        //{
        //    Zorrona.SetActive(false);
        //}

        //if (Gatita == false && Zorrona == false)
        //{
        //    Caballito.SetActive(true);
        //}

        //if (gameManagerSpam.puntosCaballito >= 3)
        //{
        //    Caballito.SetActive(false);
        //}
        */
    }

    public void OnMouseClick1()
    {
        gameObject.SetActive(false);
        gameManagerSpam.puntos += valor;
        Debug.Log("puntos =" + gameManagerSpam.puntos);
        //Puntaje.SumarPuntos(cantidadPuntos);

        if (gameManagerSpam.puntos >= 3)
        {
            Gatita.SetActive(false);
            Zorrona.SetActive(true);
            Caballito.SetActive(false);
        }

        if (gameManagerSpam.puntos >= 6)
        {
            Gatita.SetActive(false);
            Zorrona.SetActive(false);
            Caballito.SetActive(true);
        }

        if (gameManagerSpam.puntos >= 9)
        {
            Gatita.SetActive(false);
            Zorrona.SetActive(false);
            Caballito.SetActive(false);
        }
    }

    //public void OnMouseClick2()
    //{
    //.puntosZorrona += cantidadPuntos;
    //    gameObject.SetActive(false);
    //}

    //public void OnMouseClick3()
    //{
    //    gameObject.SetActive(false);
    //puntosCaballito += cantidadPuntos;

    //    if (gameManagerSpam.puntosCaballito >= 3)
    //    {
    //        Caballito.SetActive(false);
    //}
    //}
}
