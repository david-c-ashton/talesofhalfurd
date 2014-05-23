using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {
	public Item mItem = new Item();
	public GameObject fakeItem;

	// Use this for initialization
	void Start () {
		mItem.setItemDurability (100.0f);
		mItem.setItemID (1);
		mItem.setItemName ("Wooden Sword");
		mItem.setItemObject (this.fakeItem);
		mItem.setItemPower (1);

		mItem.debug ();
	}
}
