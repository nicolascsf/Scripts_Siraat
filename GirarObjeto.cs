using UnityEngine;
using System.Collections;

public class GirarObjeto : MonoBehaviour
{

	public int x, y, z;

	void Update ()
	{
		transform.Rotate (new Vector3 (1 * x, 1 * y, 1 * z) * Time.deltaTime);	
	}

	void OnCollisionStay (Collision other)
	{
		other.transform.Rotate (new Vector3 (1 * x, 1 * y, 1 * z) * Time.deltaTime);
	}
}
