public class Multiply {
    public int Multiply_int(int a, int b) {
        return a * b;
    }

    public int Multiply_intByRepeatedAddition(int a, int b) {
	    int runningTotal = a;
		Add adder = new Add();

		for (int i = 1; i < b; i++)
		{
			runningTotal += adder.Add_int(runningTotal, a);
		}

        return runningTotal;
    }
}