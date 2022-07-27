namespace Packaging_Calculation
{
	public class SilicaGel
	{
		private float lenght, width, height;
		public SilicaGel(float length, float width, float height)
		{
			this.height = height;
			this.lenght = length;
			this.width = width;
		}

		public float GetLength()
		{ return lenght; }
		public float GetWidth()
		{ return width; }

		public float GetHeight()
		{ return height; }

		public float PackageVolume()
		{
			return (lenght * width * height);
		}

		public float SlilcaGelVolume()
		{ return (PackageVolume() / 1000) * 2; }

	}
}
