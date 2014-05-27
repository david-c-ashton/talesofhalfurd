using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {
	public Player mPlayer = new Player();

	// Use this for initialization
	void Start () {
		CSV.items = CSV.loadItems ();
		this.mPlayer.setNewCharacter ("Holfurd");
		Debug.Log (this.mPlayer.player.inventory.weapon.itemName);
	}
}
