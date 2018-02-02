using UnityEngine;
using System.Collections;

public class ExitApp : MonoBehaviour
{
	public void ExitApple ()
	{
		Debug.Log( "Exit" );
		Application.Quit();
	}
}