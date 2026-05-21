using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class GameManagerForm : MonoBehaviour
{
   public GameObject primeraPantalla;
   public GameObject segundaPantalla;
   public GameObject terceraPantalla;
   public int casillasCambiadas = 0;
   public int letrasCambiadas = 0;


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
   public Button boton_letra1;
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


   //opciones tercera pantalla
   public Button boton1;
   public Button boton2;
   public Button boton3;
   public Button boton4;


   public Sprite boton_normal;
   public Sprite boton_seleccionado;


   private Button botonActual = null;


   //para pasar a la cuarta pantalla
   public GameObject boton_siguiente3;
   public GameObject cuarta_pantalla;


   //caurta pantalla
   public GameObject Button1;
   public GameObject Button2;
   public GameObject Button3;
   public GameObject Button4;


   public Button casilla_correcta1;
   public Button casilla_correcta2;
   public Button casilla_correcta3;
   public Button casilla_correcta4;


   void Start()
   {
       primeraPantalla.SetActive(true);
       segundaPantalla.SetActive(false);
       terceraPantalla.SetActive(false);
       cuarta_pantalla.SetActive(false);
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
       boton_siguiente3.SetActive(false);
       rellenar_texto.text = "";
       rellenar_texto.ActivateInputField();
       boton_letra1.onClick.AddListener(CambiarLetra1);
       boton1.onClick.AddListener(SeleccionarBoton1);
       boton2.onClick.AddListener(SeleccionarBoton2);
       boton3.onClick.AddListener(SeleccionarBoton3);
       boton4.onClick.AddListener(SeleccionarBoton4);
       boton1.interactable = false;
       boton2.interactable = false;
       boton3.interactable = false;
       boton4.interactable = false;
   }


   //cambiar letras
   public void CambiarLetra1()
   {
       letra_p.sprite = letra_T;
       letrasCambiadas++;
       ComprobarLetras();
   }
   public void CambiarLetra2()
   {
       letra_i.sprite = letra_I;
       letrasCambiadas++;
       ComprobarLetras();
   }
   public void CambiarLetra3()
   {
       letra_j.sprite = letra_P;
       letrasCambiadas++;
       ComprobarLetras();
   }
   public void CambiarLetra4()
   {
       letra_o.sprite = letra_O;
       letrasCambiadas++;
       ComprobarLetras();
   }
   public void CambiarLetra5()
   {
       letra_e.sprite = letra_D;
       letrasCambiadas++;
       ComprobarLetras();
   }
   public void CambiarLetra6()
   {
       letra_t.sprite = letra_E;
       letrasCambiadas++;
       ComprobarLetras();
   }
   public void CambiarLetra7()
   {
       letra_b.sprite = letra_D2;
       letrasCambiadas++;
       ComprobarLetras();
   }
   public void CambiarLetra8()
   {
       letra_o2.sprite = letra_I2;
       letrasCambiadas++;
       ComprobarLetras();
   }
   public void CambiarLetra9()
   {
       letra_d.sprite = letra_B;
       letrasCambiadas++;
       ComprobarLetras();
   }
   public void CambiarLetra10()
   {
       letra_u.sprite = letra_U;
       letrasCambiadas++;
       ComprobarLetras();
   }
   public void CambiarLetra11()
   {
       letra_d2.sprite = letra_J;
       letrasCambiadas++;
       ComprobarLetras();
   }
   public void CambiarLetra12()
   {
       letra_i2.sprite = letra_O2;
       letrasCambiadas++;
       ComprobarLetras();
   }


   public void ComprobarLetras()
   {
       if (letrasCambiadas >= 12)
       {
           Debug.Log("Letras cambiadas: " + letrasCambiadas);
           if (letrasCambiadas >=12)
           {
               Debug.Log("Desbloqueando botones");
               boton1.interactable = true;
               boton2.interactable = true;
               boton3.interactable = true;
               boton4.interactable = true;
           }
       }
   }
   public void SeleccionarBoton(Button boton)
   {
       if (botonActual != null)
       {
           botonActual.GetComponent<Image>().sprite = boton_normal;
       }
       botonActual = boton;
       botonActual.GetComponent<Image>().sprite = boton_seleccionado;
       boton_siguiente3.SetActive(true);
   }
   public void SeleccionarBoton1()
   {
       SeleccionarBoton(boton1);
   }
   public void SeleccionarBoton2()
   {
       SeleccionarBoton(boton2);
   }
   public void SeleccionarBoton3()
   {
       SeleccionarBoton(boton3);
   }
   public void SeleccionarBoton4()
   {
       SeleccionarBoton(boton4);
   }
  
   //cuarta pantalla
   public void IrACuartaPantalla()
   {
       terceraPantalla.SetActive(false);
       cuarta_pantalla.SetActive(true);
       casilla_correcta1.gameObject.SetActive(false);
       casilla_correcta2.gameObject.SetActive(false);
       casilla_correcta3.gameObject.SetActive(false);
       casilla_correcta4.gameObject.SetActive(false);
   }


   //casillas cuarta pantalla
   public void ClickDisperso1()
   {
       Button1.SetActive(false);
       casilla_correcta1.gameObject.SetActive(true);
   }
   public void ClickDisperso2()
   {
       Button2.SetActive(false);
       casilla_correcta2.gameObject.SetActive(true);
   }
   public void ClickDisperso3()
   {
       Button3.SetActive(false);
       casilla_correcta3.gameObject.SetActive(true);
   }
   public void ClickDisperso4()
   {
       Button4.SetActive(false);
       casilla_correcta4.gameObject.SetActive(true);
   }
   public void seleccionar_correcto1()
   {
       Debug.Log("SeleccionarCorrecto1 llamada");
       SeleccionarBoton(casilla_correcta1);
   }
   public void seleccionar_correcto2()
   {
       SeleccionarBoton(casilla_correcta2);
   }
   public void seleccionar_correcto3()
   {
       SeleccionarBoton(casilla_correcta3);
   }
   public void seleccionar_correcto4()
   {
       SeleccionarBoton(casilla_correcta4);
   }
}
