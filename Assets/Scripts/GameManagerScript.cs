using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManagerForm : MonoBehaviour
{
    public GameObject primeraPantalla;
    public GameObject segundaPantalla;
    public GameObject terceraPantalla;
    private int casillasCambiadas = 0;

    //casillas
    public Image primera_casilla;
    public Image segunda_casilla;
    public Image tercera_casilla;
    public Image cuarta_casilla;


    public Sprite primera_casilla_correcta;
    public Sprite segunda_Casilla_correcta;
    public Sprite tercera_casilla_correcta;
    public Sprite cuarta_casilla_correcta;

    //texto y botón segunda pantalla
    public TMP_InputField rellenar_texto;
    public GameObject boton_siguiente2;

    //letras tercera pantalla
    public Image letra_p;
    public Image letra_i;
    public Image letra_j;
    public Image letra_o;
    public Image letra_e;
    public Image letra_t;
    public Image letra_b;
    public Image letra_o2;
    public Image letra_d;
    public Image letra_u;
    public Image letra_d2;
    public Image letra_i2;

    public Sprite letra_T;
    public Sprite letra_I;
    public Sprite letra_P;
    public Sprite letra_O;
    public Sprite letra_D;
    public Sprite letra_E;
    public Sprite letra_D2;
    public Sprite letra_I2;
    public Sprite letra_B;
    public Sprite letra_U;
    public Sprite letra_J;
    public Sprite letra_O2;

    void Start()
    {
        primeraPantalla.SetActive(true);
        segundaPantalla.SetActive(false);
        terceraPantalla.SetActive(false);

        boton_siguiente2.SetActive(false);
    }

    //casillas
    public void CambiarPrimera()
    {
        primera_casilla.sprite = primera_casilla_correcta;
        casillasCambiadas++;
        ComprobarCasillas();
    }

    public void CambiarSegunda()
    {
        segunda_casilla.sprite = segunda_Casilla_correcta;
        casillasCambiadas++;
        ComprobarCasillas();
    }

    public void CambiarTercera ()
    {
        tercera_casilla.sprite = tercera_casilla_correcta;
        casillasCambiadas++;
        ComprobarCasillas();
    }

    public void CambiarCuarta()
    {
        cuarta_casilla.sprite = cuarta_casilla_correcta;
        casillasCambiadas++;
        ComprobarCasillas();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // pasar a segunda pantalla
    public void IrASegundaPantalla()
    {
        primeraPantalla.SetActive(false);
        segundaPantalla.SetActive(true);
        rellenar_texto.text = "";
        boton_siguiente2.SetActive(false);
        rellenar_texto.interactable = false;
        rellenar_texto.onEndEdit.AddListener((string texto) => ConfirmarTexto(texto));
        rellenar_texto.ActivateInputField();
    }

    //activar botón al escribir
    public void ComprobarTexto()
    {
        //supongo
    }

    public void ConfirmarTexto(string texto)
    {
        if (!string.IsNullOrEmpty(texto))
        {
            boton_siguiente2.SetActive(true);
        }
    }

    public void ComprobarCasillas()
    {
        if (casillasCambiadas >=4)
        {
            rellenar_texto.interactable = true;
        }
    }

    //pasar a tercera pantalla
    public void IrATerceraPantalla()
    {
        segundaPantalla.SetActive(false);
        terceraPantalla.SetActive(true);
        rellenar_texto.text = "";
        rellenar_texto.ActivateInputField();
    }

    //cambiar letras
    public void CambiarLetra1()
    {
        letra_p.sprite = letra_T;
    }
    public void CambiarLetra2()
    {
        letra_i.sprite = letra_I;
    }
    public void CambiarLetra3()
    {
        letra_j.sprite = letra_P;
    }
    public void CambiarLetra4()
    {
        letra_o.sprite = letra_O;
    }
    public void CambiarLetra5()
    {
        letra_e.sprite = letra_D;
    }
    public void CambiarLetra6()
    {
        letra_t.sprite = letra_E;
    }
    public void CambiarLetra7()
    {
        letra_b.sprite = letra_D2;
    }
    public void CambiarLetra8()
    {
        letra_o2.sprite = letra_I2;
    }
    public void CambiarLetra9()
    {
        letra_d.sprite = letra_B;
    }
    public void CambiarLetra10()
    {
        letra_u.sprite = letra_U;
    }
    public void CambiarLetra11()
    {
        letra_d2.sprite = letra_J;
    }
    public void CambiarLetra12()
    {
        letra_i2.sprite = letra_O2;
    }
}
