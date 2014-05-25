using UnityEngine;
using System.Collections;

public struct mPlayer
{
	public string name;
	public int id;
	public Equipment inventory;
	public mSEX gender;
	public pStat stats;
	public mTYPE race;
	public mCLASS pClass;
	[HideInInspector]
	public GameObject obj;
}

public class Player
{
	public mPlayer player;

	public void setNewCharacter(string n)
	{
		this.player.name = n;
		this.player.id = 0;
		Equipment items = new Equipment ();
		/*
		 * @TODO: Set default items
		 */
		this.player.inventory = items;
		this.player.gender = mSEX.MALE;

		pStat s = new pStat ();

		s.agility = 10;
		s.charisma = 10;
		s.constitution = 12;
		s.intelligence = 10;
		s.speed = 10;
		s.strength = 12;
		s.wisdom = 10;

		this.player.stats = s;

		mCLASS c = new mCLASS ();
		c.Class = WARRIOR.WARRIOR;
		this.player.pClass = c;
	}
}