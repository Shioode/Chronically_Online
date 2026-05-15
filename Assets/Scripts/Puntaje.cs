using TMPro;
using UnityEngine;

public class Puntaje : MonoBehaviour
{
    private float puntosGatita;

    private TextMeshProUGUI textMesh;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        puntosGatita += Time.deltaTime;
        textMesh.text = puntosGatita.ToString("0");
    }

    public void SumarPuntos(float puntosEntradaGata)
    {
        puntosGatita += puntosEntradaGata;
    }
}
