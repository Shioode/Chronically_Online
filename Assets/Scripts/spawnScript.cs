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

    public timerScript timerElScript;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // anuncio = GameObject.Find("Spam");
        timerElScript = FindFirstObjectByType<timerScript>();
        StartCoroutine(Spawnear());
        // Instantiate(anuncio, posicion, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log("Tiempo restante:" + timerElScript.time_Left);
    }

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
            if (timerElScript.time_Left <= 0)
            {
                yield break;
            }

            yield return new WaitForSeconds(0.5f);
        }
    }
}
