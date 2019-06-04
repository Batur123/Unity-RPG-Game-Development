using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SahneDegistirme : MonoBehaviour {

	public void SahneDegistirme1(string sahneadi)
    {
        SceneManager.LoadScene(sahneadi);
    }
}
