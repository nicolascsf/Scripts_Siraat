using UnityEngine;
using System.Collections;

public class InspecionarObjeto : MonoBehaviour
{

	public _GC coloque_GC_aqui;

	void Start ()
	{
		//Cursor.visible = true;
	}

	void OnMouseDrag ()
	{
		coloque_GC_aqui.RotacionarObjeto (gameObject);
	}

	void OnTriggerStay (Collider other)
	{
		if (other.tag == "Player")
		{
			coloque_GC_aqui.InspecionarObjeto (gameObject);
		}
	}

	void OnTriggerExit (Collider other)
	{
		if (other.tag == "Player")
			coloque_GC_aqui.txts.txtInfo2.gameObject.SetActive (false);
	}
}
