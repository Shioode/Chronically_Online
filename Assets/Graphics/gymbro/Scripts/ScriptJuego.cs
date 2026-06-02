using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScriptJuego : MonoBehaviour
{
    private int PreguntaNum;
    public int AciertosNum;
    public int BotonNum;

    public GameObject Objetos1;
    public GameObject Objetos2;
    public GameObject Objetos3;

    public GameObject Button1;
    public GameObject Button2;
    public GameObject Button3;
    public static TextMeshProUGUI TextoDialogo;

    public GameObject Botoncin;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PreguntaNum = 1;
        AciertosNum = 0;
        TextoDialogo = GameObject.Find("Texto_Dialogo").GetComponent<TextMeshProUGUI>();
        //Objetos1 = GameObject.Find("Objetos1");
        //Objetos2 = GameObject.Find("Objetos2");
        //Objetos3 = GameObject.Find("Objetos3");
        Objetos2.SetActive(false);
        Objetos3.SetActive(false);
        Botoncin.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("PreguntaNum" + PreguntaNum);

        Button1.SetActive(true);
        Button2.SetActive(true);
        Button3.SetActive(true);

        //código de preguntas
        if (PreguntaNum == 1)
        {
            if (BotonNum == 1)
            {
                BotonNum = 0;
                TextoDialogo.text = "Que aburrido tío...";
                Objetos1.SetActive(false);
                Objetos2.SetActive(true);
                Debug.Log("BotonNum" + BotonNum);
                PreguntaNum = PreguntaNum + 1;
            }
            else if (BotonNum == 2)
            {
                AciertosNum = AciertosNum + 1;
                BotonNum = 0;
                TextoDialogo.text = "Buena idea! Así estará a mi nivel";
                Objetos1.SetActive(false);
                Objetos2.SetActive(true);
                Debug.Log("BotonNum" + BotonNum);
                PreguntaNum = PreguntaNum + 1;
            }
            else if (BotonNum == 3)
            {
                BotonNum = 0;
                TextoDialogo.text = "Que aburrido tío...";
                Objetos1.SetActive(false);
                Objetos2.SetActive(true);
                Debug.Log("BotonNum" + BotonNum);
                PreguntaNum = PreguntaNum + 1;
            }
        }
        else if (PreguntaNum == 2)
        {
            if (BotonNum == 1)
            {
                AciertosNum = AciertosNum + 1;
                PreguntaNum = PreguntaNum + 1;
                BotonNum = 0;
                TextoDialogo.text = "Sí, le hace falta";
                Objetos2.SetActive(false);
                Objetos3.SetActive(true);
            }
            else if (BotonNum == 2)
            {
                PreguntaNum = PreguntaNum + 1;
                BotonNum = 0;
                TextoDialogo.text = "Vaya cursilada";
                Objetos2.SetActive(false);
                Objetos3.SetActive(true);
            }
            else if (BotonNum == 3)
            {
                PreguntaNum = PreguntaNum + 1;
                BotonNum = 0;
                TextoDialogo.text = "Vaya cursilada";
                Objetos2.SetActive(false);
                Objetos3.SetActive(true);
            }
        }
        else if (PreguntaNum == 3)
        {
            if (BotonNum == 1)
            {
                PreguntaNum = PreguntaNum + 1;
                BotonNum = 0;
                TextoDialogo.text = "EWW";
                Objetos3.SetActive(false);
            }
            else if (BotonNum == 2)
            {
                PreguntaNum = PreguntaNum + 1;
                BotonNum = 0;
                TextoDialogo.text = "EWW";
                Objetos3.SetActive(false);
            }
            else if (BotonNum == 3)
            {
                AciertosNum = AciertosNum + 1;
                PreguntaNum = PreguntaNum + 1;
                BotonNum = 0;
                TextoDialogo.text = "Jajajaja seguro que le encanta!";
                Objetos3.SetActive(false);
            }
        }
        else if (PreguntaNum == 4)
        {
            Button1.SetActive(false);
            Button2.SetActive(false);
            Button3.SetActive(false);

            if (AciertosNum == 3)
            {
                TextoDialogo.text = "Fua tío... Son perfectos. Cuando quieras te invito a algo.";
            }
            else if (AciertosNum < 3)
            {
                TextoDialogo.text = "Vaya mariconadas... gracias supongo.";
            }
        }

        if (AciertosNum == 3)
        {
            Botoncin.SetActive(true);
        }
    }

    void BotonPresionado(int _BotonNum)
    {
        BotonNum = _BotonNum;
        Debug.Log("Boton" + _BotonNum);
        Debug.Log("BotonNum" + BotonNum);
    }

    public void OnMouseClickSiguienteEscena()
    {
        SceneManager.LoadScene("creditosScene");
    }
}
