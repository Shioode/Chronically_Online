using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class GachaSystem : MonoBehaviour
{
    //PROBABILIDADES EN PORCENTAJES

    [SerializeField]
    private int commonChance = 95;

    [SerializeField]
    private int rareChance = 5;

    public GameObject boton;

    GameObject Gacha;

    public GameObject Contrato;

    public GameObject ImagenFail;

    Animator controlAnimacion;

    Animator anim;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Gacha = GameObject.Find("pantallaGacha");
        //Contrato = GameObject.Find("contrato");
        //ImagenFail = GameObject.Find("todoMal");
        //Debug.Log(Contrato);
        ImagenFail.SetActive(false);
        Contrato.SetActive(false);
        controlAnimacion = GetComponent<Animator>();
        anim = GetComponent<Animator>();
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
        //Gacha.SetActive(false);
        //GENERAR NUMERO DE 0 A 100

        int random = Random.Range(0, 101);

        //PROBABILIDADES

        if (random > rareChance)
        {
            //Gacha.SetActive(false);
            controlAnimacion.SetTrigger("activaComun");
            ImagenFail.SetActive(true);
            Debug.Log("¡Conseguiste trabajo!");
            OnRareReward();
        }
        else
        {
            //Gacha.SetActive(false);
            anim.SetTrigger("activaRare");
            Contrato.SetActive(true);
            Debug.Log("nadie te quiere, sigues siendo pobre.");
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
}
