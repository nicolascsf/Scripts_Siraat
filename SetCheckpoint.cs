using UnityEngine;
using System.Collections;

public class SetCheckpoint : MonoBehaviour
{

	Vector3 CHECKPOINT;

	public Checkpoint coloque_GC_aqui;

	bool ini = false;
	bool ck1 = false;
	bool ck2 = false;
	bool ck3 = false;
	bool ck4 = false;
	bool ck5 = false;
	bool fin = false;

	void OnCollisionEnter (Collision col)
	{

		print (col.collider.name);

		if (col.collider.name == "Chao")
		{
			gameObject.transform.position = CHECKPOINT;
		}

		if (col.collider.name == "Inicio")
		{
			if (!ini)
			{
				print ("CHECKSET = Inicio");
				CHECKPOINT = coloque_GC_aqui.inicio.transform.position;
				coloque_GC_aqui.setCheckpoint (CHECKPOINT);
				ini = true;
			}
		}

		if (col.collider.name == "Mesa_C1")
		{
			if (!ck1)
			{
				print ("CHECKSET = MESA_C1");
				CHECKPOINT = coloque_GC_aqui.check1.transform.position;
				coloque_GC_aqui.setCheckpoint (CHECKPOINT);
				ck1 = true;
			}
		}

		if (col.collider.name == "Mesa_C2")
		{
			if (!ck2)
			{
				print ("CHECKSET = MESA_C2");
				CHECKPOINT = coloque_GC_aqui.check2.transform.position;
				coloque_GC_aqui.setCheckpoint (CHECKPOINT);
				ck2 = true;
			}
		}

		if (col.collider.name == "Mesa_C3")
		{
			if (!ck3)
			{
				print ("CHECKSET = MESA_C3");
				CHECKPOINT = coloque_GC_aqui.check3.transform.position;
				coloque_GC_aqui.setCheckpoint (CHECKPOINT);
				ck3 = true;
			}
		}

		if (col.collider.name == "Mesa_C4")
		{
			if (!ck4)
			{
				print ("CHECKSET = MESA_C4");
				CHECKPOINT = coloque_GC_aqui.check4.transform.position;
				coloque_GC_aqui.setCheckpoint (CHECKPOINT);
				ck4 = true;
			}
		}

		if (col.collider.name == "Mesa_C5")
		{
			if (!ck5)
			{
				print ("CHECKSET = MESA_C5");
				CHECKPOINT = coloque_GC_aqui.check5.transform.position;
				coloque_GC_aqui.setCheckpoint (CHECKPOINT);
				ck5 = true;
			}
		}

		if (col.collider.name == "Final")
		{
			if (!fin)
			{
				print ("CHECKSET = Final");
				CHECKPOINT = coloque_GC_aqui.final.transform.position;
				coloque_GC_aqui.setCheckpoint (CHECKPOINT);
				fin = true;
			}
		}
	}
}