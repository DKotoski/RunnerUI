using UnityEngine;
using System.Collections;

public class ChangeScene : MonoBehaviour {

    public GameObject loading;
	public void ChangeToLevel(string level)
    {
        loading.SetActive(true);
        Application.LoadLevel(level);
        loading.SetActive(false);
    }
}
