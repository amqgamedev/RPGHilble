using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ShootButt : MonoBehaviour, IDragHandler, IPointerUpHandler, IPointerDownHandler {

	private Image IShoot;
	private Vector3 inputVector;


	void Start () {
		IShoot = GetComponent<Image>();
	}

	public virtual void OnDrag(PointerEventData eventData){

		

		Vector2 pos;
		if(RectTransformUtility.ScreenPointToLocalPointInRectangle(IShoot.rectTransform,eventData.position, eventData.pressEventCamera, out pos)){
			Debug.Log("Funciona");

			
		}


	}

	public virtual void OnPointerUp(PointerEventData eventData){

		inputVector = Vector3.zero;
		IShoot.rectTransform.anchoredPosition = Vector3.zero;

	}

	public virtual void OnPointerDown(PointerEventData eventData){

		OnDrag(eventData);

	}
	
	
}
