
using TMPro;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bola : MonoBehaviour
{
    // Start is called before the first frame update

    private int velocidade = 13;
    

    void Start()
    {
       
        float x = Random.Range(0, 2) == 0 ? -1 : 1;

        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        GetComponent<Rigidbody>().velocity = new Vector2(x * velocidade, y * velocidade);
    
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.CompareTag("Finish"))
        {
            Start();
            transform.position = new Vector3(0, 18, 0);
        }
    }
}
