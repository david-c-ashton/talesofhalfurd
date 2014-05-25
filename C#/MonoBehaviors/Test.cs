using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {
	public Spell spell1 = new Spell();
	public Spell spell2 = new Spell();

	// Use this for initialization
	void Start () {
		this.spell1.setSpellPower (7);
		this.spell1.setSpellMana (2);
		this.spell1.setSpellDuration (0);
		this.spell1.setSpellName ("Fire Bolt");
		this.spell1.setSpellDomain (mDOMAIN.FIRE);
		this.spell1.setSpellType (aTYPE.SINGLE);

		this.spell2.setSpellPower (3);
		this.spell2.setSpellMana (1);
		this.spell2.setSpellDuration (2.4f);
		this.spell2.setSpellName ("Light Cure");
		this.spell2.setSpellDomain (mDOMAIN.BODY);
		this.spell2.setSpellType (aTYPE.SUPPORT);

		this.spell1.debug ();
		this.spell2.debug ();
	}
}
