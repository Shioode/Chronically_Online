using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditosScript : MonoBehaviour
{
    public GameObject inicio;
    public GameObject fin;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() { }

    // Update is called once per frame
    void Update() { }

    public void OnMouseClickInicio()
    {
        SceneManager.LoadScene("InicioScene");
    }

        public void OnMouseClickSalir()
    {
        Application.Quit();

    }
}

