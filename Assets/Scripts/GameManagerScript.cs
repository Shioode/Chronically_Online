using UnityEngine;

public class GameManagerForm : MonoBehaviour
{
    public GameObject primeraPantalla;
    public GameObject segundaPantalla;
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
