
public class Kata {
	
	public static void main(String arg[]) {
		Long[] value = new Long[10];
		value = powerOfTwo(3);
		System.out.println(value);
	}
	
	public static Long[] powerOfTwo(int n) {
		Long ret[] = new Long[n+1];
		for (int i = 0; i <= n; i++) ret[i] = 1L << i;
		return ret;
	}

}
