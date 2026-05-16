using System.Collections;
using UnityEngine;

public class spawnScript : MonoBehaviour
{
    // GameObject anuncio;

    public GameObject[] anuncios;

    public float minX = -16.0f;
    public float maxX = 16.0f;
    public float minY = -8.0f;
    public float maxY = 8.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // anuncio = GameObject.Find("Spam");
        StartCoroutine(Spawnear());
        // Instantiate(anuncio, posicion, Quaternion.identity);
    }

    // Update is called once per frame
    void Update() { }

    public IEnumerator Spawnear()
    {
        while (true)
        {
            int randomIndex = Random.Range(0, anuncios.Length);
            Vector3 posicion = new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY), 0);

            GameObject gameObject = Instantiate(
                anuncios[randomIndex],
                posicion,
                Quaternion.identity
            );

            yield return new WaitForSeconds(0.5f);
        }
    }
}
