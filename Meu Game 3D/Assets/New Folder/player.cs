
using Unity.VisualScripting;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{
    public int velocidade = 10;
    Rigidbody rb;
    public int forcapulo = 8;

    public bool noChao ;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("START");
        TryGetComponent(out rb);
    }
    
    private void OnCollisionEnter(Collision collision)
    
    {
        if (!noChao && collision.gameObject.tag == "noChao")
        {
            noChao = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("UPDATE");
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        UnityEngine.Vector3 direcao = new Vector3(h, 0, v);
        rb.AddForce(direcao * (velocidade * Time.deltaTime), ForceMode.Impulse);
        if (Input.GetKeyDown(KeyCode.Space) && noChao)
        {
            rb.AddForce(Vector3.up * forcapulo, ForceMode.Impulse);
            noChao = false;
        }

        if (transform.position.y <= -15)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    }
}
