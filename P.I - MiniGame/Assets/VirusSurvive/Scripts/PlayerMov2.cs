using Unity.VisualScripting;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class PlayerMov2 : MonoBehaviour
{
    Rigidbody rig;
    public float speed;
    public int pontoHealth = 0;
    public TMP_Text textP1;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = new Vector3(Input.GetAxisRaw("Horizontal4"), Input.GetAxisRaw("Vertical"),0 );
        GetComponent<Rigidbody>().velocity = position * speed;
    }

    private void OnTriggerEnter(Collider other)
    {


        if (other.CompareTag("AidKit"))
        {
            pontoHealth++;
            textP1.SetText(pontoHealth.ToString());
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Respawn"))
        {
            SceneManager.LoadScene("Perdedor 4");
        }
    }

}
