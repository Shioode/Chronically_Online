using UnityEngine;

public class furroScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() { }

    // Update is called once per frame
    void Update() { }

    public void OnMouseClick1()
    {
        gameObject.SetActive(false);
        gameManagerSpam.puntosGatita = +1;
    }

     public void OnMouseClick2()
    {
        gameObject.SetActive(false);
        gameManagerSpam.puntosZorrona = +1;
    }

     public void OnMouseClick3()
    {
        gameObject.SetActive(false);
        gameManagerSpam.puntosCaballito = +1;
    }
}
