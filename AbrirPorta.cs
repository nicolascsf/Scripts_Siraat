using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AbrirPorta: MonoBehaviour
{

	public _GC coloque_GC_aqui;

	void OnTriggerStay (Collider col)
	{
		coloque_GC_aqui.AbrirPorta ();
	}

	void OnTriggerExit (Collider col)
	{
		if (col.tag == "Player")
			coloque_GC_aqui.txts.txtInfo2.gameObject.SetActive (false);
	}


}