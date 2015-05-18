using UnityEngine;
using System.Collections;

public class AutoHideObject : MonoBehaviour {

	void Start ()
	{
		m_SpriteOut.enabled = false;
	}
	
	void Update ()
	{

	}

	void OnClick ()
	{
		if (a == true)
		{
			m_StartTime = Time.realtimeSinceStartup;
			m_SpriteIn.enabled = false;
			m_SpriteOut.enabled = true;
			a = false;

			if ( a == false)
			{
				StartCoroutine("Wait");
			}
		}
	}

	//------------------------------------------
	public UISprite						m_SpriteIn = null;
	public UISprite						m_SpriteOut = null;
	public float						m_HideTimer = 1f;
	//------------------------------------------
	private bool						a = true;
	private float						m_StartTime = 0f;

	IEnumerator Wait()
	{
		yield return new WaitForSeconds(4);

		float nowTime = Time.realtimeSinceStartup;
		float deltaTime = nowTime - m_StartTime;

		if (m_HideTimer <= deltaTime)
		{
			m_SpriteIn.enabled = true;
			m_SpriteOut.enabled = false;
			a = true;
		}
	}
}
