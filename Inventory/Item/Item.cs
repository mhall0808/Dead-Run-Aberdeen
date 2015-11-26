using UnityEngine;
using System.Collections;

public class Item : MonoBehaviour {
	private string itemName;
	private string itemDescription;

	private int itemHP;
	private int itemDef;
	private int itemAttack;

	// Use this for initialization
	void Start () {
		itemName = "Default";
		itemDescription = "Default Description";

		itemHP = 0;
		itemDef = 0;
		itemAttack = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
