namespace CalcProjectV2.Manager {
	public interface NumberSystem {
		public double Result
		{ get; set; }
		public double B
		{ get; set; }
		public int K
		{ get; set; }
		double Summ();
		double Subtraction();
		double Segmentation();
		double Multiplication();
		double Pow();
		double Mod();
		double Div();
		double MinOfArray(double[] dat,int count);
	}
}