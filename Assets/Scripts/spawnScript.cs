using UnityEngine;

public class spawnScript : MonoBehaviour
{
    GameObject anuncio;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        anuncio = GameObject.Find("Spam00");
        Vector3 position = new Vector3(Random.Range(1.0f, 10.0f), Random.Range(1.0f, 10.0f), 0);
        Instantiate(anuncio, position, Quaternion.identity);
        Debug.Log("he aparecido");
        Debug.Log("he escalado?");
    }

    // Update is called once per frame
    void Update() { }

    void SpawnAnuncio() { }
}
