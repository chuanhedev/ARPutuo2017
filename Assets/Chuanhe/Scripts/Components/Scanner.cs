using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scanner : MonoBehaviour {

	[HideInInspector]
	public bool scanning = false;
	public RectTransform scanline;
	public float scanlineMaxY = 430;
	public float scanlineMinY = -280;
	public float scanlineSpeed = -300;
	// Update is called once per frame


	void Update(){
		if (!scanning)
			return;
		scanline.localPosition = scanline.localPosition.SetY (scanline.localPosition.y + scanlineSpeed * Time.deltaTime);
		if (scanline.localPosition.y < scanlineMinY)
			scanline.localPosition = scanline.localPosition.SetY (scanlineMaxY);
	}
}
