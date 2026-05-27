using System;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class GachaSystem : MonoBehaviour
{
    //PROBABILIDADES EN PORCENTAJES

    //[SerializeField]
    //private int commonChance = 95;

    [SerializeField]
    private int rareChance = 5;

    //spublic GameObject boton;

    public GameObject Gacha;

    public GameObject Contrato;

    public GameObject ImagenFail;

    public GameObject Contratado;

    public GameObject panelAnimacion;

    //public GameObject Sig;

    Animator controlAnimacion;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        controlAnimacion = panelAnimacion.GetComponent<Animator>();
        //Contrato = GameObject.Find("contrato");
        //ImagenFail = GameObject.Find("todoMal");
        //Debug.Log(Contrato);
        ImagenFail.SetActive(false);
        Contrato.SetActive(false);
        Contratado.SetActive(false);
        panelAnimacion.SetActive(false);
        //Sig.SetActive(false);
    }

    // Update is called once per frame
    void Update() { }

    public void OnMouseClickGacha()
    {
        gameObject.SetActive(false);
        Gacha.SetActive(false);
        PullGacha();
    }

    public void PullGacha()
    {
        controlAnimacion = panelAnimacion.GetComponent<Animator>();
        panelAnimacion.SetActive(true);
        //Gacha.SetActive(false);
        //GENERAR NUMERO DE 0 A 100

        int random = Random.Range(0, 101);

        //PROBABILIDADES

        if (random > rareChance)
        {
            Debug.Log("Random: " + random);
            //Gacha.SetActive(false);
            controlAnimacion.SetBool("ActivaComun", true);
            //ImagenFail.SetActive(true);
            //Debug.Log("nadie te quiere, sigues siendo pobre.");

            //OnRareReward();
        }
        else
        {
            //Gacha.SetActive(false);
            controlAnimacion.SetBool("ActivaRare", true);
            //Contrato.SetActive(true);
            //Debug.Log("¡Conseguiste trabajo!");

            OnComonReward();
        }
    }

    //METODO DE REGALO COMUN

    private void OnComonReward()
    {
        //ImagenFail.SetActive(true);
        //Debug.Log("¡Conseguiste trabajo!");
    }

    //METODO DE REGALO RARO

    private void OnRareReward()
    {
        //Contrato.SetActive(true);
        //Debug.Log("nadie te quiere, sigues siendo pobre.");
    }

    public void GachaSystemactivaFail()
    {
        ImagenFail.SetActive(true);
        //Sig.SetActive(true);
        Debug.Log("nadie te quiere, sigues siendo pobre.");
    }

    public void GachaSystemactivaContrato()
    {
        Contrato.SetActive(true);
        Debug.Log("¡Conseguiste trabajo!");
    }

    public void OnMouseClickContrato()
    {
        gameObject.SetActive(false);
        Contrato.SetActive(false);
        Contratado.SetActive(true);
    }

    public void OnMouseClickFinal()
    {
        SceneManager.LoadScene("InicioScene");
    }

    public void OnMouseClickSeguimos()
    {
        SceneManager.LoadScene("Conv2Scene");
    }
}
