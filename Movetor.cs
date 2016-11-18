using UnityEngine;
using System.Collections;

public class Movetor : MonoBehaviour {

	public Transform pos1; //Posicao Inicial do objeto
	public Transform pos2; //Posicao Final do objeto
	private bool indo; //Verifica se esta indo ou voltando
	public float velMovimento;
	public float tempoParado;

	void Update () {
		Mover ();
	}

	void Mover()
	{
		if (indo) {
			transform.position = Vector3.Lerp (transform.position, pos1.position, velMovimento * Time.deltaTime);
			if (Vector3.Distance (transform.position, pos1.position) < tempoParado/10)
				indo = false;
		} else {
			transform.position = Vector3.Lerp (transform.position, pos2.position, velMovimento * Time.deltaTime);
			if (Vector3.Distance (transform.position, pos2.position) < tempoParado/10)
				indo = true;
		}
	}

	void OnCollisionStay(Collision player)
	{
		if (indo) {
			player.transform.position = Vector3.Lerp (player.transform.position, pos1.position, velMovimento * Time.deltaTime);
			if (Vector3.Distance (player.transform.position, pos1.position) < tempoParado/10)
				indo = false;
		} else {
			player.transform.position = Vector3.Lerp (player.transform.position, pos2.position, velMovimento * Time.deltaTime);
			if (Vector3.Distance (player.transform.position, pos2.position) < tempoParado/10)
				indo = true;
		}
	}
}
