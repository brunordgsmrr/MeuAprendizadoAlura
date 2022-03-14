package kata;

public class PowerOfTwo {
	public static Long[] powerOfTwo(int n) {
		Long ret[] = new Long[n+1];
		for (int i = 0; i <= n; i++) ret[i] = 1L << i;
		return ret;
	}
}
