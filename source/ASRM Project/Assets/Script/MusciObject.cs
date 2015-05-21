using UnityEngine;
using System.Collections;

public class MusciObject : MonoBehaviour {

	// Use this for initialization
	void Start ()
	{

	}
	
	// Update is called once per frame
	void Update () 
	{

	}

	void OnClick ()
	{
		Vector2 touchPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		Ray2D ray = new Ray2D(touchPosition, Vector2.zero);
		RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction);
		Debug.Log(hit.collider.tag);
		
		if(hit.collider.tag == "Music_01_01")
		{
			Debug.Log("2222");
			audio.clip = SoundA;
			audio.Stop();
         	audio.Play();
		}
		if(hit.collider.tag == "Music_01_02")
		{
			Debug.Log("3333");
			audio.clip = SoundA;
         	audio.Stop();
         	audio.Play();
		}
		if(hit.collider.tag == "Music_01_03")
		{
			Debug.Log("4444");
		}
	}
	public AudioClip SoundA;
}
