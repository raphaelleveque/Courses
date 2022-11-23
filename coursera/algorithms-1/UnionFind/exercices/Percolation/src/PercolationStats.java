import edu.princeton.cs.algs4.StdOut;
import edu.princeton.cs.algs4.StdRandom;
import edu.princeton.cs.algs4.StdStats;

public class PercolationStats {

    private final double[] fractions;
    private final int trials;

    public PercolationStats(int n, int trials) {
        if (n <= 0 || trials <= 0) throw new IllegalArgumentException("Given N <= 0 || T <= 0");
        this.trials = trials;
        fractions = new double[trials];

        for (int experimentNumber = 0; experimentNumber < trials; experimentNumber++) {
            Percolation pr = new Percolation(n);
            int openSites = 0;

            while (!pr.percolates()) {
                int i = StdRandom.uniformInt(1, n+1);
                int j = StdRandom.uniformInt(1, n+1);

                if (!pr.isOpen(i, j)) {
                    pr.open(i, j);
                    openSites++;
                }
            }
            double fraction = (double) openSites / (n * n);
            fractions[experimentNumber] = fraction;
        }
    }

    public double mean() {
        return StdStats.mean(fractions);
    }

    public double stddev() {
        return StdStats.stddev(fractions);
    }

    public double confidenceLo() {
        return mean() - ((1.95 * stddev()) / Math.sqrt(trials));
    }

    public double confidenceHi() {
        return mean() + ((1.95 * stddev()) / Math.sqrt(trials));
    }

    public static void main(String[] args) {
        int n = Integer.parseInt(args[0]);
        int trials = Integer.parseInt(args[1]);
        PercolationStats ps = new PercolationStats(n, trials);

        String confidence = ps.confidenceLo() + ", " + ps.confidenceHi();
        StdOut.println("mean = " + ps.mean());
        StdOut.println("stddev = " + ps.stddev());
        StdOut.println("95% confidence interval = " + confidence);
    }
}
