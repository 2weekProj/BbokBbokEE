using UnityEngine;
using System.Collections;

public class AutoHideObject : MonoBehaviour {

	void Start ()
	{
		m_ButtonOut.enabled = false;
		m_ButtonSound = gameObject.GetComponent<AudioSource>();
	}
	
	void Update ()
	{

	}

	void OnClick ()
	{
		int RandPoint = Random.Range(0,8);

		switch(RandPoint)
		{
			case 0:
			Debug.Log("0");
			m_ButtonSound.clip = RandSound01;
			m_ButtonSound.Play();
			break;
			
			case 1:
			Debug.Log("1");
			m_ButtonSound.clip = RandSound02;
			m_ButtonSound.Play();
			break;
			
			case 2:
			Debug.Log("2");
			m_ButtonSound.clip = RandSound03;
			m_ButtonSound.Play();
			break;
			
			case 3:
			Debug.Log("3");
			m_ButtonSound.clip = RandSound04;
			m_ButtonSound.Play();
			break;
			
			case 4:
			Debug.Log("4");
			m_ButtonSound.clip = RandSound05;
			m_ButtonSound.Play();
			break;
			
			case 5:
			Debug.Log("5");
			m_ButtonSound.clip = RandSound06;
			m_ButtonSound.Play();
			break;
			
			case 6:
			Debug.Log("6");
			m_ButtonSound.clip = RandSound07;
			m_ButtonSound.Play();
			break;

			case 7:
			Debug.Log("7");
			m_ButtonSound.clip = RandSound08;
			m_ButtonSound.Play();
			break;
		
			case 8:
			Debug.Log("8");
			m_ButtonSound.clip = RandSound09;
			m_ButtonSound.Play();
			break;
		}

		if (m_ButtonCheck == true)
		{
			m_StartTime = Time.realtimeSinceStartup;
			m_ButtonIn.enabled = false;
			m_ButtonOut.enabled = true;
			m_ButtonCheck = false;

			if (m_ButtonCheck == false)
			{
				StartCoroutine("Wait");
			}
		}
	}

	IEnumerator Wait()
	{
		yield return new WaitForSeconds(m_ButtonWaitTime);

		float nowTime = Time.realtimeSinceStartup;
		float deltaTime = nowTime - m_StartTime;

		if (m_HideTimer <= deltaTime)
		{
			m_ButtonIn.enabled = true;
			m_ButtonOut.enabled = false;
			m_ButtonCheck = true;
		}
	}

	AudioSource m_ButtonSound;
	
	//------------------------------------------
	public UISprite						m_ButtonIn = null;
	public UISprite						m_ButtonOut = null;
	public int							m_ButtonWaitTime = 1; // 값이 1 이하면 안됨.
	public AudioClip					RandSound01 = null;
	public AudioClip					RandSound02 = null;
	public AudioClip					RandSound03 = null;
	public AudioClip					RandSound04 = null;
	public AudioClip					RandSound05 = null;
	public AudioClip					RandSound06 = null;
	public AudioClip					RandSound07 = null;
	public AudioClip					RandSound08 = null;
	public AudioClip					RandSound09 = null;
	
	//------------------------------------------
	private float						m_HideTimer = 0.5f;
	private bool						m_ButtonCheck = true;
	private float						m_StartTime = 0f;
}
