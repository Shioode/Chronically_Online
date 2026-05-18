using UnityEngine;

public class DestroyScript : MonoBehaviour
{
    //public GameObject Contrato;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() { }

    // Update is called once per frame
    void Update() { }

    public void Destruirbjeto()
    {
        Destroy(gameObject);
        //Contrato.SetActive(true);
        //Debug.Log("¡Conseguiste trabajo!");
    }

    /*public void DestruirYSeguir()
    {
        Destroy(gameObject);

    }
    */
}
