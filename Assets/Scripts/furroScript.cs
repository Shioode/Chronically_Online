using UnityEngine;

public class furroScript : MonoBehaviour
{
    public int valor = 1;
    public GameObject = puntosObj;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() { }

    // Update is called once per frame
    void Update() {

        if()
     }

    public void OnMouseClick1()
    {
        gameObject.SetActive(false);
        gameManagerSpam.puntosGatita += valor;
    }

    public void OnMouseClick2()
    {
        gameObject.SetActive(false);
        gameManagerSpam.puntosZorrona += valor;
    }

    public void OnMouseClick3()
    {
        gameObject.SetActive(false);
        gameManagerSpam.puntosCaballito += valor;
    }
}
