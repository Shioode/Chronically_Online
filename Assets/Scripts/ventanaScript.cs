using UnityEngine;
using UnityEngine.InputSystem;

public class ventanaScript : MonoBehaviour
{
    void Start() { }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePos = Mouse.current.position.ReadValue();

        //Debug.Log(mousePos);

        Ray ray = Camera.main.ScreenPointToRay(mousePos);
        RaycastHit hit;

        //print("hello 1");
        if (Physics.Raycast(ray, out hit) && Mouse.current.leftButton.wasPressedThisFrame)
        {
            Debug.Log(hit.transform.position);
        }
    }

    public void OnMouseClick()
    {
        gameObject.SetActive(false);
    }
}
