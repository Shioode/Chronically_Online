using UnityEngine;
using UnityEngine.InputSystem;


public class AudioManagerObj : MonoBehaviour

{
    public static AudioManagerObj Instance;
    public AudioClip objetos1;
    public AudioClip clipBotones;
    public AudioClip bandaSonora;
    public AudioSource audioSource;
    public AudioClip clickClip;
    void Awake()
    {
    if (Instance != null && Instance != this.gameObject)
    {
    Destroy(this.gameObject);
    return;
    }
    else
        {
            Instance = this;
        DontDestroyOnLoad(this.gameObject);
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GetComponent<AudioSource>().clip = bandaSonora;
        GetComponent<AudioSource>().Play();
      }

    // Update is called once per frame
    void Update()
    { 
    if (InputSystem.actions["Click"].WasPressedThisFrame())
    {
    audioSource.PlayOneShot(clickClip);
    }
    }
    public void SonarBoton()
    {
        SonarClipUnaVez(clipBotones);
    }
    public void SonarClipUnaVez (AudioClip clip)
    {
        GetComponent<AudioSource>().PlayOneShot(clip);
    }
}
