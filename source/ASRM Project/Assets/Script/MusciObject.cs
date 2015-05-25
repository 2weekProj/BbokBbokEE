using UnityEngine;
using System.Collections;

public class MusciObject : MonoBehaviour {

	// Use this for initialization
	void Start ()
	{
		_aa = gameObject.GetComponent<AudioSource>();
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
		
		if(hit.collider.tag != null)
		{
			//_aa.Stop();

			switch(hit.collider.tag)
			{
				case "Music_01_01":	
				_aa.Stop();
				_aa.clip = Sample1;
				_aa.Play();
				break;

				case "Music_01_02":
				_aa.Stop();
				_aa.clip = Sample2;
				_aa.Play();
				break;
			}
		}
	}
	public AudioClip Sample1;
	public AudioClip Sample2;
	
	AudioSource _aa;
}
	
/*
	void OnClick ()
	{
		Vector2 touchPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		Ray2D ray = new Ray2D(touchPosition, Vector2.zero);
		RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction);
		Debug.Log(hit.collider.tag);

		if(hit.collider.tag != null)
		{
			
			switch(hit.collider.tag)
			{
				case "Music_01_01":
				audio.clip = SoundA;
				audio.Play();
				break;

			 	case "Music_01_02":
				audio.clip = SoundB;
				audio.Play();
				break;
			}
		}
	}
	public AudioClip SoundA;
	public AudioClip SoundB;
}
*/



/*
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
	//AudioClip SoundB = null;
}
*/
