using UnityEngine;
using System.Collections;

public class Checkpoint : MonoBehaviour
{

	public GameObject Player;
	public GameObject inicio;
	public GameObject check1;
	public GameObject check2;
	public GameObject check3;
	public GameObject check4;
	public GameObject check5;
	public GameObject final;
	private Vector3 CHECKPOINT;

	public GameObject pauseImage;
	public GameObject btnVoltarMenu;
	public GameObject txtCerteza;
	public GameObject btnCertezaSim;
	public GameObject btnCertezaNao;

	public _GC_lvl2 coloque_GC_aqui;

	void Start ()
	{
		Cursor.visible = false;
	}

	// Update is called once per frame
	void Update ()
	{

		if (Input.GetKey (KeyCode.R))
		{
			Player.transform.position = inicio.transform.position;
		}
		if (Input.GetKey (KeyCode.F1))
		{
			Player.transform.position = check1.transform.position;
		}
		if (Input.GetKey (KeyCode.F2))
		{
			Player.transform.position = check2.transform.position;
		}
		if (Input.GetKey (KeyCode.F3))
		{
			Player.transform.position = check3.transform.position;
		}
		if (Input.GetKey (KeyCode.F4))
		{
			Player.transform.position = check4.transform.position;
		}
		if (Input.GetKey (KeyCode.F5))
		{
			Player.transform.position = check5.transform.position;
		}
		if (Input.GetKey (KeyCode.F6))
		{
			Player.transform.position = final.transform.position;
		}
	}

	public void setCheckpoint (Vector3 checkpoint)
	{
		CHECKPOINT = checkpoint;
	}

	public void btnCheckReset (int op)
	{
		if (op == 0)
		{
			Player.transform.position = CHECKPOINT;
			Time.timeScale = 1;
			//Cursor.visible = false;

			closeMenu ();
		}

	}

	void closeMenu ()
	{
		if (pauseImage.activeSelf)
		{
			pauseImage.SetActive (false);
		}
		if (btnVoltarMenu.activeSelf == false)
		{
			btnVoltarMenu.SetActive (true);
		}
		if (txtCerteza.activeSelf)
		{
			txtCerteza.SetActive (false);
		}
		if (btnCertezaSim.activeSelf)
		{
			btnCertezaSim.SetActive (false);
		}
		if (btnCertezaNao.activeSelf)
		{
			btnCertezaNao.SetActive (false);
		}
	}
}