using System.Collections;
using System.Threading;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class timerScript : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI timer_Text;

    [SerializeField]
    public float time_Left;

    public GameObject boton;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        boton.SetActive(false);
        StartCoroutine(timer_Count());
    }

    void Update() { }

    // Update is called once per frame
    IEnumerator timer_Count()
    {
        time_Left--;

        UpdateTime();

        if (time_Left <= 0)
        {
            Debug.Log("Tiempo fuera!");
            boton.SetActive(true);

            time_Left = 0;
            StopAllCoroutines();
        }

        yield return new WaitForSeconds(1);
        StartCoroutine(timer_Count());
    }

    private void UpdateTime()
    {
        int min = Mathf.FloorToInt(time_Left / 60);
        int sec = Mathf.FloorToInt(time_Left % 60);

        //Debug.Log((time_Left / 60).ToString("00") + " " + (time_Left % 60).ToString("00"));
        this.timer_Text.text = min.ToString("00") + ":" + sec.ToString("00");

        // this.timer_Text.text = "10";
    }

    public void OnMouseClickVa()
    {
        SceneManager.LoadScene("ConIntermedia");
    }
}
