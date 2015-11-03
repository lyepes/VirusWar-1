using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {
	
	public int energy = 5;
	public GameObject  target;
	public GameObject balas;
	public GameObject explosion;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("Disparar", 3, 3);
	}
	
	// Update is called once per frame
	void Update () {
		//Vector3 direccion = (target.transform.position - transform.position);
		//transform.rotation = Quaternion.LookRotation (direccion, Vector3.up);
		//transform.position += transform.forward * 3 * Time.deltaTime;
        transform.position = new Vector3(transform.position.x + 3 * Time.deltaTime,transform.position.y,transform.position.z);

	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bala")
        {
            Hitted();
        }
    }
	
	public void Hitted()
	{
		energy--;
		if (energy<=0) {
			Instantiate(explosion, transform.position, transform.rotation);
			Destroy(gameObject);
		}
	}

	public void Disparar()
	{
		//Instantiate crea objetos en el area(mundo)        
		Instantiate (balas, transform.position, Quaternion.identity);
	}
}