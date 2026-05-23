using UnityEngine;

public class caida : MonoBehaviour
{
    public float velocidad = 200f;
    private lluviadeideasScript gameManager;
    public bool esIncorrecto = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameManager = FindFirstObjectByType<lluviadeideasScript>();
    }

    // Update is called once per frame
    void Update()
    {
        RectTransform rt = GetComponent<RectTransform>();
        rt.anchoredPosition += Vector2.down * velocidad * Time.deltaTime;

        if (rt.anchoredPosition.y < -600f)
        {
            gameManager.PerderCorazon();
            Destroy(gameObject);
        }
    }

    public void AlHacerClick()
    {
        if (esIncorrecto)
        {
            gameManager.PerderCorazon();
        }
        Destroy(gameObject);
    }
}
