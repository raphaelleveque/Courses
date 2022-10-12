import edu.princeton.cs.algs4.StdIn;
import edu.princeton.cs.algs4.StdOut;
import edu.princeton.cs.algs4.StdRandom;
public class RandomWord {
    public static void main(String[] args) {

        String champ = args[0];
        for (int i = 0; i < args.length; i++) {
            if (StdRandom.bernoulli((1.0/(i + 1)))) {
                champ = args[i];
            }
        }

        StdOut.println(champ);
    }
}


