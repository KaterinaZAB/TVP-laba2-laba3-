using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lines : MonoBehaviour
{
	private LineRenderer line;
	private Vector3 mousePos;	
	private Vector3 startPos;    // позици€ начала линии
	private Vector3 endPos;     // позици€ конца линии
	public Transform emptyPos;
	private bool empty = true;
	public Material lineMaterial;
	public float width = 0.1f;

	void Update()
	{
		//если игра не выключена
		if (Time.timeScale > 0)
		{
			//вычисление положени€ курсора на экране
			mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			if (empty == true)
			{
				//вычисление положени€ пустого объекта на экране
				emptyPos.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			}
			//при нажатии мыши создаетс€ нова€ лини€ 
			if (Input.GetMouseButtonDown(0))
			{
				empty = false;
				if (line == null)
				{
					createLine();

					mousePos.z = 0;
					line.SetPosition(0, mousePos);
					startPos = mousePos;
				}
			}
			else if (Input.GetMouseButtonUp(0))
			{
				empty = true;
				if (line)
				{
					mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
					mousePos.z = 0;
					line.SetPosition(1, mousePos);
					endPos = mousePos;
					line = null;
				}
			}
			else if (Input.GetMouseButton(0))
			{
				if (line)
				{
					mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);//получение позиции мышки
					mousePos.z = 0;
					line.SetPosition(1, mousePos);
					if (Vector2.Distance(emptyPos.position, Camera.main.ScreenToWorldPoint(Input.mousePosition)) > 0.01)
					{
						line.material = lineMaterial;
					}
				}
			}

		}
	}
	//метод создани€ линии
	private void createLine()
	{
		line = new GameObject("Line").AddComponent<LineRenderer>();

		line.positionCount = 2;
		line.startWidth = 5f; 
		line.endWidth = 5f; 
		line.startColor = Color.black;
		line.endColor = Color.black;
	}
}
