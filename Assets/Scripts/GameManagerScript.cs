using UnityEngine;
using UnityEngine.UI;

public class GameManagerForm : MonoBehaviour
{
    public GameObject primeraPantalla;
    public GameObject segundaPantalla;

    //casillas
    public Image primera_casilla;
    public Image segunda_casilla;
    public Image tercera_casilla;
    public Image cuarta_casilla;


    public Sprite primera_casilla_correcta;
    public Sprite segunda_Casilla_correcta;
    public Sprite tercera_casilla_correcta;
    public Sprite cuarta_casilla_correcta;

    public void CambiarPrimera()
    {
        primera_casilla.sprite = primera_casilla_correcta;
    }

    public void CambiarSegunda()
    {
        segunda_casilla.sprite = segunda_Casilla_correcta;
    }

    public void CambiarTercera ()
    {
        tercera_casilla.sprite = tercera_casilla_correcta;
    }

    public void CambiarCuarta()
    {
        cuarta_casilla.sprite = cuarta_casilla_correcta;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //principio del minijuego
        primeraPantalla.SetActive(true);
        segundaPantalla.SetActive(false);
    }

    // Update is called once per frame
    public void IrASegundaPantalla()
    {
        primeraPantalla.SetActive(false);
        segundaPantalla.SetActive(true);
    }
}
