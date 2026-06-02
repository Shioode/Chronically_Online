using UnityEngine;


public class lluviadeideasScript : MonoBehaviour
{
   public GameObject primera_pantalla;
   public GameObject segunda_pantalla;


   public GameObject[] incorrectos;
   public GameObject[] correctos;
   public float velocidadCaida = 200f;
   public float tiempoEntreSpawn = 1f;


   public GameObject[] corazones;


   public GameObject tercera_pantalla;


   private float timer;
   private bool juegoActivo = false;


   public void IrASiguiente()
   {
       primera_pantalla.SetActive(false);
       segunda_pantalla.SetActive(true);
       juegoActivo = true;
   }
   // Start is called once before the first execution of Update after the MonoBehaviour is created
   void Start()
   {
      
   }


   // Update is called once per frame
   void Update()
   {
       if (!juegoActivo) return;


       timer += Time.deltaTime;
       if (timer >= tiempoEntreSpawn)
       {
           timer = 0f;
           SpawnObjeto();
       }
   }


   void SpawnObjeto()
   {
       bool correcto = Random.Range(0, 2) == 0;
       GameObject[] lista = correcto ? correctos : incorrectos;
       GameObject prefab = lista[Random.Range(0, lista.Length)];


       float x = Random.Range(-860f, 860f);
       Vector2 pos = new Vector2(x, 600f);


       GameObject obj = Instantiate(prefab, pos, Quaternion.identity);
       obj.transform.SetParent(segunda_pantalla.transform, false);
       obj.GetComponent<RectTransform>().anchoredPosition = pos;
   }


   public void PerderCorazon()
   {
       for (int i = corazones.Length -1; i >= 0; i--)
       {
           if (corazones[i].activeSelf)
           {
               corazones[i].SetActive(false);
               break;
           }
       }


       if (corazones[0].activeSelf == false &&
           corazones[1].activeSelf == false&&
           corazones[2].activeSelf == false)
       {
           segunda_pantalla.SetActive(false);
           tercera_pantalla.SetActive(true);
           juegoActivo = false;
       }
   }


   public void StartAgain()
   {
       corazones[0].SetActive(true);
       corazones[1].SetActive(true);
       corazones[2].SetActive(true);
       tercera_pantalla.SetActive(false);
       segunda_pantalla.SetActive(true);
       juegoActivo = true;


       foreach (Transform hijo in segunda_pantalla.transform)
       {
           if (hijo.GetComponent<caida>() != null)
           {
               Destroy(hijo.gameObject);
           }
       }
   }
}


