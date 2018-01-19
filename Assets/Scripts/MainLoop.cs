using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainLoop : MonoBehaviour
{

    public GameObject[] stones = new GameObject[3];
    // Fuerza de torsion que vamos a aplicar en cada eje
    public float torque = 5.0f;
    // Valores de fuerza que van a tener las piedras cuando las lancemos, y sera un valor aleatorio entre 20 y 40
    public float minAntiGravity = 20.0f, maxAntiGravity = 40.0f;
    // Valores de fuerza lateral cuando las lancemos 
    public float minLateralForce = -15.0f, maxLateralForce = 15.0f;
    // Tiempo que vamos a tener que esperar entre el lanzamiento de una piedra y la siguiente
    public float minTimeBetweenStones = 1f, maxTimeBetweenStones = 3f;
    // Posición X del lanzamiento de la piedra
    public float minX = -30.0f, maxX = 30.0f;
    // Posición Z del lanzamiento de la piedra
    public float minZ = -5.0f, maxZ = 5.0f;
    //Permitir que se lancen piedras
    private bool enableStones = true;
    private Rigidbody rigibody;

    public int amountStones = 20;


    void Start()
    {
        StartCoroutine(ThrowStones());
    }

    private IEnumerator ThrowStones()
    {
        yield return new WaitForSeconds(3.0f);

        while (enableStones)
        {
            GameObject stone = Instantiate(stones[Random.Range(0, stones.Length)]);
            stone.transform.position = new Vector3(Random.Range(minX, maxX), -30.0f, Random.Range(minZ, maxZ));
            stone.transform.rotation = Random.rotation;
            rigibody = stone.GetComponent<Rigidbody>();
            rigibody.AddTorque(Vector3.up * torque, ForceMode.Impulse);
            rigibody.AddTorque(Vector3.right * torque, ForceMode.Impulse);
            rigibody.AddTorque(Vector3.forward * torque, ForceMode.Impulse);

            rigibody.AddForce(Vector3.up * Random.Range(minAntiGravity, maxAntiGravity), ForceMode.Impulse);
            rigibody.AddForce(Vector3.right * Random.Range(minLateralForce, maxLateralForce), ForceMode.Impulse);

            GameManager.stonesThrown++;

            if(GameManager.stonesThrown == amountStones)
            {
                enableStones = false;
                yield return new WaitForSeconds(6.0f);
            }
            else
            {
                yield return new WaitForSeconds(Random.Range(minTimeBetweenStones, maxTimeBetweenStones));
            }
        }
        SceneManager.LoadScene("Final");



    }

    // Update is called once per frame
    void Update()
    {

    }
}
