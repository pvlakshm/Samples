public class Divide {
    public int Divide_int(int a, int b) {
        return a / b;
    }

    public int Divide_intByRepeatedSubtraction(int a, int b) {
		int runningTotal = a;
		Subtract s = new Subtract();
		int quotient = 0;

		while (runningTotal > 0)
		{
			runningTotal = s.Subtract_int(runningTotal, b);
			quotient++;
		}

        return quotient;
    }

}