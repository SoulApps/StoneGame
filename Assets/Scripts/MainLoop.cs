using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainLoop : MonoBehaviour {
    // Array de GameObject donde sus componentes cero, uno y dos
    // van a ser los tres prefab Stone que hemos creado
    public GameObject[] stones = new GameObject[3];
    // Fuerza de torsión que vamos a aplicar a cada uno de los ejes para que
    // la piedra tenga rotación inicial al crearse
    public float torque = 5.0f;
    // Valores que vamos a tener ccomo fuerza cuando lancemos las piedras, 
    // que será un valor aleatorio entre 20 y 40
    public float minAntiGravity = 5.0f, maxAntiGravity = 40.0f;
    // Fuerza lateral con las que lanzarán las piedras, en rango entre 5 y 15
    public float minLateralForce = 15.0f, maxLateralForce = 15.0f;
    // Tiempo que vamos a tener que esperar entre el lanzamiento de una piedra
    // y la siguiente
    public float minTimeBetweenStones = 1f, maxTimeBetweenStones = 3f;
    // Posición X del lanzamiento de la piedra
    public float minX = -30.0f, maxX = 30.0f;
    // Posición Z del lanzamiento de la piedra
    public float minZ = -5.0f, maxZ = 5.0f;

    // changes
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
