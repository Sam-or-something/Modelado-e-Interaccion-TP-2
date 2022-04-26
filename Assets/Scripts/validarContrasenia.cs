using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class validarContrasenia : MonoBehaviour {

	string contrseniaCorrecta;
	string contraseniaUsuario;
	public Text ingresoUsuario;
	public GameObject cartelitoMensaje;
	public Text textMensaje;

	void Start () 
	{
		contrseniaCorrecta = "password";
		cartelitoMensaje.SetActive(false);
	}
	
	void Update ()
	{
		
	}
	
	public void validarContra()
	{
		contraseniaUsuario = ingresoUsuario.text;
		if (contraseniaUsuario == contrseniaCorrecta)
		{
			cartelitoMensaje.SetActive(true);
			textMensaje.text = "Bienvenido";
			Debug.Log("Bienvenido");
		}
		else
		{
			cartelitoMensaje.SetActive(true);
			textMensaje.text = "Contraseña incorrecta";
			Debug.Log("Contraseña incorrecta");
		}
	}
}
