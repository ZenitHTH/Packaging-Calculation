namespace Packaging_Calculation { 
public class OxygenAbsorber
{
	private float lenght, width, height, foodWeight;
	public OxygenAbsorber(float length, float width, float height,float foodWeight)
	{
		this.height = height;
		this.lenght = length;
		this.width = width;
		this.foodWeight = foodWeight;
	}

	public float GetLength()
	{ return lenght; }
	public float GetWidth()
	{ return width; }

	public float GetHeight()
	{ return height; }

	public float GetFoodWeight()
	{ return foodWeight; }

	public float PackageVolume()
	{
		return (lenght * width * height);
	}

	public float OxygenAbsorberVolume()
    {
		return PackageVolume() - (foodWeight * 0.21f);
    }
}
}