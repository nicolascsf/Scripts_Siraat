using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class _GC_lvl2 : MonoBehaviour
{

	/*[System.Serializable]
	public class Cameras
	{
		public Camera Main;
		public Camera specCam;
	}*/

	[System.Serializable]
	public class Txts
	{
		//public Text txtInfo;
		//public Text txtInfo2;
		//public Text txtHist;
		public Text txtCerteza;
	}

	[System.Serializable]
	public class Btns
	{
		//public GameObject btnPegar;
		//public GameObject btnSoltar;
		public GameObject btnCertezaSim;
		public GameObject btnCertezaNao;
		public GameObject btnVoltarMenu;
	}

	[System.Serializable]
	public class Player
	{
		public GameObject RPG_Character;
	}

	[System.Serializable]
	public class Textures
	{
		public GameObject loadingImage;
		public GameObject pauseImage;
		//public GameObject chavePanel;
	}

	//public Cameras cameras = new Cameras ();
	public Txts txts = new Txts ();
	public Btns btns = new Btns ();
	public Player player = new Player ();
	public Textures textures = new Textures ();

	private float rotationX;
	private float rotationY;
	public Quaternion armazenarRotation;
	public Vector3 armazenarPosition;
	public float dist;

	/*private void Start ()
	{
		cameras.Main.enabled = true;
		cameras.specCam.enabled = false;
	}*/

	private void Update ()
	{
		//ControleDeCamera ();
		PauseMenu ();
		MostrarCursos ();
	}

	/*private void ControleDeCamera ()
	{
		if (cameras.Main.enabled == true && Time.timeScale != 0)
		{
			Time.timeScale = 1;
			cameras.specCam.enabled = false;
			//Cursor.visible = true;
		}
		if (cameras.specCam.enabled == true)
		{
			Time.timeScale = 0.0001f;
			cameras.Main.enabled = false;
			//Cursor.visible = false;
		}
	}*/

	private void ConsertarMenuPause ()
	{
		if (btns.btnVoltarMenu.activeSelf == false)
		{
			btns.btnVoltarMenu.SetActive (true);
		}
		if (txts.txtCerteza.gameObject.activeSelf)
		{
			txts.txtCerteza.gameObject.SetActive (false);
		}
		if (btns.btnCertezaSim.activeSelf)
		{
			btns.btnCertezaSim.SetActive (false);
		}
		if (btns.btnCertezaNao.activeSelf)
		{
			btns.btnCertezaNao.SetActive (false);
		}
	}

	private void PauseMenu ()
	{
		if (textures.pauseImage.activeSelf == false && Time.timeScale != 0.0001f)
		{
			Time.timeScale = 1;
		} 

		if (textures.pauseImage.activeSelf == true)
		{
			Time.timeScale = 0;
		}

		if (Input.GetKeyDown (KeyCode.Escape))
		{

			if (Cursor.visible == false)
			{
				Cursor.visible = true;
			} else if (Cursor.visible == true)
			{
				Cursor.visible = false;
			}

			if (textures.pauseImage.activeSelf)
			{
				textures.pauseImage.SetActive (false);
			} else if (textures.pauseImage.activeSelf == false)
			{
				textures.pauseImage.SetActive (true);
			}

			ConsertarMenuPause ();

			if (textures.pauseImage.activeSelf)
			{
				Cursor.visible = true;
				Time.timeScale = 0;
			} 

			if (!textures.pauseImage.activeSelf)
			{
				Cursor.visible = false;
				Time.timeScale = 1;
			}
		}
	}

	private void MostrarCursos ()
	{
		if (Time.timeScale == 1)
		{
			Cursor.visible = false;
		} else if (Time.timeScale != 0.0001f)
			Cursor.visible = true;
	}

	public void Quit ()
	{
		Application.Quit ();
	}

	public void Certeza (int op)
	{

		if (op == 0)
		{
			//Cursor.visible = true;
			print ("TEM CERTEZA?");
			btns.btnVoltarMenu.SetActive (false);
			txts.txtCerteza.gameObject.SetActive (true);
			btns.btnCertezaSim.SetActive (true);
			btns.btnCertezaNao.SetActive (true);
		} else if (op == 1)
		{
			Load (0);
		} else if (op == 2)
		{
			btns.btnVoltarMenu.SetActive (true);
			txts.txtCerteza.gameObject.SetActive (false);
			btns.btnCertezaSim.SetActive (false);
			btns.btnCertezaNao.SetActive (false);
		}
	}

	public void Load (int scene)
	{
		textures.loadingImage.SetActive (true);
		SceneManager.LoadScene (scene);
	}

	/*public void InspecionarObjeto (GameObject objeto)
	{
		txts.txtInfo2.text = "Aperta E para inspecionar " + objeto.name;

		if (Input.GetKeyDown (KeyCode.E))
		{
			Cursor.visible = true;
			objeto.transform.position += Vector3.up + Vector3.up;
			cameras.specCam.transform.position = objeto.transform.position + Vector3.up;
			objeto.transform.forward = cameras.specCam.transform.forward;
			cameras.specCam.transform.LookAt (objeto.transform);


			cameras.Main.enabled = false;
			cameras.specCam.enabled = true;

			player.RPG_Character.SetActive (false);

			Time.timeScale = 0.0001f;

			string nome = objeto.name;

			switch (nome)
			{
				case "Chave":
					txts.txtHist.text = "Essa chave abre aquela porta li, malandro, corre";
					btns.btnPegar.SetActive (true);
					break;
				case "Chaveiro":
					txts.txtHist.text = "Esse chaveiro foi usado pelo cara mais legal desse lugar.";
					btns.btnSoltar.SetActive (true);
					break;
			}

			txts.txtInfo.text = "USE O [MOUSE1] PARA MUDAR O ÂNGULO DA CÂMERA";
			txts.txtInfo2.text = nome;
			txts.txtHist.gameObject.SetActive (true);
			txts.txtInfo.gameObject.SetActive (true);
		}

		txts.txtInfo2.gameObject.SetActive (true);
	}*/

	/*public void RotacionarObjeto (GameObject objeto)
	{
		rotationX = Input.GetAxis ("Mouse X") * 1000 * Mathf.Deg2Rad;
		rotationY = Input.GetAxis ("Mouse Y") * 1000 * Mathf.Deg2Rad;
		objeto.transform.RotateAroundLocal (cameras.specCam.transform.up, -Mathf.Deg2Rad * rotationX);
		objeto.transform.RotateAroundLocal (cameras.specCam.transform.right, -Mathf.Deg2Rad * rotationY);
	}*/

	public void ArmazenarRotationEPosition (GameObject objeto)
	{
		armazenarRotation = objeto.transform.rotation;
		armazenarPosition = objeto.transform.position;
	}

	/*public void SoltarObjeto (GameObject objeto)
	{
		if (cameras.specCam.enabled == true && cameras.Main.enabled == false)
		{
			print ("ok");
			cameras.Main.enabled = true;
			cameras.specCam.enabled = false;

			objeto.transform.rotation = armazenarRotation;
			objeto.transform.position = armazenarPosition;

			if (gameObject.name == "Chave")
			{
				objeto.SetActive (false);
				textures.chavePanel.SetActive (true);
			}

			Cursor.visible = false;

			player.RPG_Character.SetActive (true);
			txts.txtInfo.gameObject.SetActive (false);
			txts.txtInfo2.gameObject.SetActive (false);
			txts.txtHist.gameObject.SetActive (false);
			btns.btnSoltar.SetActive (false);
		}
	}*/

	/*public void PegarObjeto (GameObject objeto)
	{
		if (cameras.specCam.enabled == true && cameras.Main.enabled == false)
		{
			print ("ok");
			cameras.Main.enabled = true;
			cameras.specCam.enabled = false;

			objeto.transform.rotation = armazenarRotation;
			objeto.transform.position = armazenarPosition;
			objeto.SetActive (false);
			textures.chavePanel.SetActive (true);

			Cursor.visible = false;

			player.RPG_Character.SetActive (true);
			txts.txtInfo.gameObject.SetActive (false);
			txts.txtInfo2.gameObject.SetActive (false);
			txts.txtHist.gameObject.SetActive (false);
			btns.btnPegar.SetActive (false);
		}
	}

	public void AbrirPorta ()
	{
		if (Input.GetKey (KeyCode.E) && textures.chavePanel.activeSelf == true)
		{
			if (textures.chavePanel.activeSelf)
			{
				LoadAsync (4);
				Time.timeScale = 1;
			}
		}

		if (textures.chavePanel.activeSelf)
		{
			txts.txtInfo2.text = "Aperte E para abrir a porta";
		} else
		{
			txts.txtInfo2.text = "Você precisa da chave para abrir essa porta";
		}
		txts.txtInfo2.gameObject.SetActive (true);
	}*/

}