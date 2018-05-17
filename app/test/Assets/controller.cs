using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour {

    public void cambiarVentana(string name) {
        
        Application.LoadLevel("aReality");
    }

    public void salir() {
        Application.Quit();
    }
}
