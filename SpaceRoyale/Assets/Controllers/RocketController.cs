using UnityEngine;

public class RocketController : MonoBehaviour {

    public float Speed;

	// Use this for initialization
	void Start () {
        Speed = 20;
	}
	
	// Update is called once per frame
	void Update () {
<<<<<<< HEAD
        transform.Translate(Vector3.up * Time.deltaTime * Speed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
=======
        transform.Translate(Vector3.right * Time.deltaTime * Speed);
>>>>>>> parent of b52af0b... costam
    }
}
