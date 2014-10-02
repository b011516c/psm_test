using System;

namespace github_psm_test{
	public class Player{
		private float x;
		private float y;
		private byte health = 50;
		private byte mana = 50;
		public Player (float x, float y, byte health, byte mana){
			SetPosition(this.x, this.y);
			health = this.health;
			mana = this.mana;
		}
		public void SetPosition(float x, float y){
			x = this.x;
			y = this.y;
		}
		public float GetPosition(string xy){
			if(xy == "X" || xy == "x"){
				return x;
			} else if (xy == "Y" || xy == "y"){
				return y;
			}
		}
		public void SetHealth(byte health){
			health = this.health;
		}
		public void SetMana(byte mana){
			mana = this.mana;
		}
	}
}

