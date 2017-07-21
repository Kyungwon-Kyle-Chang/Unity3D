using UnityEngine;
using System.Collections;

public class Manager : MonoBehaviour {

    public GameObject dd;

	void Start () {
        IUpper test = new Draw();
        test.Draw();
	}

}
