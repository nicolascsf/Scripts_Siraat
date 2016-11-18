using UnityEngine;
using System.Collections;

public class SoltarObjeto : MonoBehaviour
{

	public _GC coloque_GC_aqui;


	public void Soltar ()
	{
		if (coloque_GC_aqui.cameras.specCam.enabled == true && coloque_GC_aqui.cameras.Main.enabled == false)
		{
			coloque_GC_aqui.cameras.Main.enabled = true;
			coloque_GC_aqui.cameras.specCam.enabled = false;

			transform.rotation = coloque_GC_aqui.armazenarRotation;
			transform.position = coloque_GC_aqui.armazenarPosition;

			Cursor.visible = false;

			coloque_GC_aqui.player.RPG_Character.SetActive (true);
			coloque_GC_aqui.txts.txtInfo.gameObject.SetActive (false);
			coloque_GC_aqui.txts.txtInfo2.gameObject.SetActive (false);
			coloque_GC_aqui.txts.txtHist.gameObject.SetActive (false);
			coloque_GC_aqui.btns.btnSoltar.SetActive (false);
		}
	}
}
