using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ControlJoystick : MonoBehaviour, IDragHandler, IPointerUpHandler, IPointerDownHandler {

	private Image Ibackground;
	private Image Ijoystick;
	private Vector3 inputVector;


	void Start(){
		Ibackground = GetComponent<Image>();
		Ijoystick = transform.GetChild(0).GetComponent<Image>();
	}

	public virtual void OnDrag(PointerEventData eventData){

		Vector2 pos;
		if(RectTransformUtility.ScreenPointToLocalPointInRectangle(Ibackground.rectTransform, eventData.position, eventData.pressEventCamera, out pos)){ // Funciona el joystick dentro del limite del bck

		}
	//	Debug.Log("Probando");
		pos.x = (pos.x / Ibackground.rectTransform.sizeDelta.x);
		pos.y = (pos.y / Ibackground.rectTransform.sizeDelta.y);

		inputVector = new Vector3(pos.x * 2 + 1, 0, pos.y * 2 -1);
		inputVector = (inputVector.magnitude > 1.0f)?inputVector.normalized:inputVector;


		Ijoystick.rectTransform.anchoredPosition = new Vector3(inputVector.x * (Ibackground.rectTransform.sizeDelta.x/3),inputVector.z * (Ibackground.rectTransform.sizeDelta.y/3)); // el "joystick" se mueva dentro de sus limites

	}

	public virtual void OnPointerUp(PointerEventData eventData){

		inputVector = Vector3.zero;
		Ijoystick.rectTransform.anchoredPosition = Vector3.zero;

	}

	public virtual void OnPointerDown(PointerEventData eventData){

		OnDrag(eventData);

	}

	public float Horizontal(){

		if(inputVector.x != 0){
			return inputVector.x;
		}
		else
		{
			return Input.GetAxis("Horizontal");
		}
		

	}

	public float Vertical(){

		if(inputVector.z != 0){
			return inputVector.z;
		}
		else
		{
			return Input.GetAxis("Vertical");
		}
		

	}





}
