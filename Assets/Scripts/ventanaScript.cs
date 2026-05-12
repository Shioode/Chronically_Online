using Unity.VisualScripting;
using UnityEngine;

public class ventanaScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() { }

    // Update is called once per frame
    void Update() { }

    public void OnMouseClick()
    {
        gameObject.SetActive(false);

        // gameObject.GetComponent<Animator>().SetBool("obtenerCoin", true);
    }
}
