using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using Random = UnityEngine.Random;

public class GachaSystem : MonoBehaviour
{
    //PROBABILIDADES EN PORCENTAJES

    [SerializeField]
    private int commonChance = 95;

    [SerializeField]
    private int rareChance = 5;

    //[SerializeField]
    // private VideoPlayer videoComun;

    //[SerializeField]
    //private VideoPlayer videoRaro;

    //public GameObject videoUIcomun;

    //public GameObject videoUIraro;

    GameObject Gacha;
    GameObject Contrato;

    GameObject pantallaFinalContrato;

    //GameObject comun;

    //GameObject raro;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Gacha = GameObject.Find("pantallaGacha");
        Contrato = GameObject.Find("contratoImagen");
        pantallaFinalContrato = GameObject.Find("finalContrato");
        //videoUIcomun = GameObject.Find("videoGachaComun");
        //videoUIraro = GameObject.Find("videoGachaRaro");
        Contrato.SetActive(false);
        pantallaFinalContrato.SetActive(false);
        //videoUIcomun.SetActive(false);
        //videoUIraro.SetActive(false);
    }

    // Update is called once per frame
    void Update() { }

    public void OnMouseClickGacha()
    {
        PullGacha();
        gameObject.SetActive(false);
    }

    public void PullGacha()
    {
        Gacha.SetActive(false);
        //GENERAR NUMERO DE 0 A 100

        int random = Random.Range(0, 101);

        //PROBABILIDADES

        if (random < rareChance)
        {
            Gacha.SetActive(false);
            //videoUIraro.SetActive(true);
            //videoUIraro.loopPointReached += OnVideoEnd;
            //PlayVideo(videoRaro);
            Debug.Log("¡Conseguiste trabajo!");
            OnRareReward();
        }
        else
        {
            Gacha.SetActive(false);
            //videoUIcomun.SetActive(true);
            Debug.Log("nadie te quiere, sigues siendo pobre.");
            //PlayVideo(videoComun);
            OnComonReward();
        }
    }

    //INTENTO DE PONER VIDEOS Y CERRARLOS

    /*void OnVideoEnd()
    {
        videoUIcomun.SetActive(false);
    }

    //PONER VIDEOS

    private void PlayVideo(VideoPlayer videoPlayer)
    {
        if (videoPlayer != null && !videoPlayer.isPlaying)
        {
            videoPlayer.Play();
        }
    }
    */

    //METODO DE REGALO COMUN

    private void OnComonReward() { }

    //METODO DE REGALO RARO

    private void OnRareReward()
    {
        Contrato.SetActive(true);
    }
}
