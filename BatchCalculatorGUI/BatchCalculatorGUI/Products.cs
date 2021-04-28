using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchCalculatorGUI
{
	class Products
	{
		public String Rosemary(int num)
		{
			int init_flour = 1; //cup
			int sugar = 4; //tbsp
			int yeast = 2; //tbsp
			double water = 1.75; //cup
			int butter = 2; //tbsp
							//Post Initial Bloom Ingredients
			int salt = 2; //tsp
			int main_flour = 4; //cup

			String a = "=========================\n";
			String b = "You will need the following ingredients: \n";
			String c = (init_flour * num) + " Cup Initial Flour\n";
			String d = (sugar * num) + " Tbsp Sugar\n";
			String e = (yeast * num) + " Tbsp Yeast\n";
			String f = (water * num) + " Cup Water\n";
			String g = (butter * num) + " Tbsp Butter\n";
			String h = "\nThen, once the yeast has proofed, add: \n";
			String i = (salt * num) + " Tsp Salt\n";
			String j = (main_flour * num) + " Cup Flour\n";
			String k = "=========================\n";
			String returnString = a + b + c + d + e + f + g + h + i + j + k;

			return returnString;
		}

		public String CheddarItalian(int num)
		{
			int init_flour = 1; //cup
			int sugar = 4; //tbsp
			int yeast = 2; //tbsp
			double water = 1.75; //cup
			int butter = 2; //tbsp
			int seasoning = 1; //tsp
							   //Post Initial Bloom Ingredients
			int salt = 2; //tsp
			int main_flour = 4; //cup

			String a = "=========================\n";
			String b = "You will need the following ingredients: \n";
			String c = (init_flour * num) + " Cup Initial Flour\n";
			String d = (sugar * num) + " Tbsp Sugar\n";
			String e = (yeast * num) + " Tbsp Yeast\n";
			String f = (water * num) + " Cup Water\n";
			String g = (butter * num) + " Tbsp Butter\n";
			String h = (seasoning * num) + " Tsp Italian Seasoning\n";
			String i = "\nThen, once the yeast has proofed, add: \n";
			String j = (salt * num) + " Tsp Salt\n";
			String k = (main_flour * num) + " Cup Flour\n";
			String l = "=========================\n";
			String returnString = a + b + c + d + e + f + g + h + i + j + k + l;

			return returnString;
		}

		public String TomatoBasil(int num)
		{
			int init_flour = 1; //cup
			int sugar = 4; //tbsp
			int yeast = 2; //tbsp
			double water = 1.75; //cup
			int butter = 2; //tbsp
			int seasoning = 1; //tsp
							   //Post Initial Bloom Ingredients
			int salt = 2; //tsp
			int main_flour = 4; //cup

			String a = "=========================\n";
			String b = "You will need the following ingredients: \n";
			String c = (init_flour * num) + " Cup Initial Flour\n";
			String d = (sugar * num) + " Tbsp Sugar\n";
			String e = (yeast * num) + " Tbsp Yeast\n";
			String f = (water * num) + " Cup Water\n";
			String g = (butter * num) + " Tbsp Butter\n";
			String h = (seasoning * num) + " Tsp Italian Seasoning\n";
			String i = "\nThen, once the yeast has proofed, add: \n";
			String j = (salt * num) + " Tsp Salt\n";
			String k = (main_flour * num) + " Cup Flour\n";
			String l = "=========================\n";
			String returnString = a + b + c + d + e + f + g + h + i + j + k + l;

			return returnString;
		}

		public String CranberryWalnut(int num)
		{
			int init_flour = 1; //cup
			double honey = 0.5; //cup
			int yeast = 1; //tbsp
			int cinnamon = 1; //tsp
			double water = 1.75; //cup
			int craisins = 1; //cup
			int walnuts = 1; //cup
			double oliveOil = 0.25; //cup
									//Post Initial Bloom Ingredients
			double salt = 1.5; //tsp
			int main_flour = 5; //cup

			String a = "=========================\n";
			String b = "You will need the following ingredients: \n";
			String c = (init_flour * num) + " Cup Initial Flour\n";
			String d = (water * num) + " Cup Water\n";
			String e = (honey * num) + " Cup Honey\n";
			String f = (yeast * num) + " Tbsp Yeast\n";
			String g = (walnuts * num) + " Cup Walnuts\n";
			String h = (craisins * num) + " Cup Craisins\n";
			String i = (cinnamon * num) + " Tsp Cinnamon\n";
			String j = (oliveOil * num) + " Cup Olive Oil\n";
			String k = "\nThen, once the yeast has proofed, add: \n";
			String l = (salt * num) + " Tsp Salt\n";
			String m = (main_flour * num) + " Cup Flour\n";
			String n = "=========================\n";
			String returnString = a + b + c + d + e + f + g + h + i + j + k + l + m + n;

			return returnString;
		}

		public String MountainHerb(int num)
		{
			int quickOats = 1; //cup
			double boilingWater = 1.5; //cup
			int sugar = 1; //tsp
			int yeast = 2; //tsp
			double honey = 0.5; //cup
			double water = 0.25; //cup
			int dill = 1; //tsp
			double garlicPowder = 0.25; //tsp	
			int salt = 1; //tsp
			double main_flour = 3.5; //cup

			String a = "=========================\n";
			String b = "You will need the following ingredients: \n";
			String c = (quickOats * num) + " Cup Quick Oats\n";
			String d = (boilingWater * num) + " Cup Boiling Water\n";
			String e = "\nMove on to blooming the yeast: \n";
			String f = (sugar * num) + " Tsp Sugar\n";
			String g = (honey * num) + " Cup Honey\n";
			String h = (yeast * num) + " Tsp Yeast\n";
			String i = (water * num) + " Cup Water\n";
			String j = (dill * num) + " Tsp Dill\n";
			String k = (garlicPowder * num) + " Tsp Garlic Powder\n";
			String l = "\nThen, once the yeast has proofed, add: \n";
			String m = (salt * num) + " Tsp Salt\n";
			String n = (main_flour * num) + " Cup Flour\n";
			String o = "=========================\n";
			String returnString = a + b + c + d + e + f + g + h + i + j + k + l + m + n + o;

			return returnString;
		}

		public String Molasses(int num)
		{
			int quickOats = 1; //cup
			double boilingWater = 1.5; //cup
			int sugar = 1; //tsp
			int yeast = 2; //tsp
			double molasses = 0.5; //cup
			double water = 0.25; //cup	
			int salt = 1; //tsp
			double main_flour = 3.5; //cup

			String a = "=========================\n";
			String b = "You will need the following ingredients: \n";
			String c = (quickOats * num) + " Cup Quick Oats\n";
			String d = (boilingWater * num) + " Cup Boiling Water\n";
			String e = "\nMove on to blooming the yeast: \n";
			String f = (sugar * num) + " Tsp Sugar\n";
			String g = (molasses * num) + " Cup Molasses\n";
			String h = (yeast * num) + " Tsp Yeast\n";
			String i = (water * num) + " Cup Water\n";
			String j = "\nThen, once the yeast has proofed, add: \n";
			String k = (salt * num) + " Tsp Salt\n";
			String l = (main_flour * num) + " Cup Flour\n";
			String m = "=========================\n";
			String returnString = a + b + c + d + e + f + g + h + i + j + k + l + m;

			return returnString;
		}
	}
}
