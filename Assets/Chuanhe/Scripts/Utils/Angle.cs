using UnityEngine;
using System.Collections;
using System;

public class Angle {
    
	//convert angle from -180 to 180
	public static float ToStardard (float a){
		float temp = Utils.ModPositive(a, 360);
		return temp > 180 ? temp - 360 : temp;
	}

	//convert angle from 0 to 360
	public static float ToStardard2 (float a){
		return Utils.ModPositive(a, 360);
	}
}