using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlador : MonoBehaviour {

    public void ChangeScene(string name)
    {
        print("cambiando a la scena" + name);
    }

    public void Salir() {
        print("salir");
    }
}
