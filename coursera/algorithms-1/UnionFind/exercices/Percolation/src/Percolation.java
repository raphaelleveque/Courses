import edu.princeton.cs.algs4.In;
import edu.princeton.cs.algs4.WeightedQuickUnionUF;

public class Percolation {
    // open: 0 = blocked; 1 = open; 2 = full;
    private boolean[][] open;
    private int gridSize;
    private int bottom;
    private int top = 0;
    private WeightedQuickUnionUF uf;
    private int openSites;

    // creates n-by-n grid, with all sites initially blocked
    public Percolation(int n) {
        if (n <= 0)
            throw new IllegalArgumentException();
        open = new boolean[n][n];
        gridSize = n;
        // there will be an upper node and a bottom node
        bottom = n * n + 1;
        uf = new WeightedQuickUnionUF(n * n + 2);
        openSites = 0;
    }

    private int getIndex(int row, int col) {
        return (row - 1) * gridSize + (col);
    }

    private void checkException(int row, int col) {
        if (row <= 0 || row > gridSize || col <= 0 || col > gridSize) throw new IllegalArgumentException();
    }
    // opens the site (row, col) if it is not open already
    public void open(int row, int col) {
        checkException(row, col);
        openSites++;
        // row - 1 and col - 1 because we have an upper node, so the index [0][0] it's actually [1][1]
        open[row - 1][col - 1] = true;

        // Because the top is a superior node, outside the grid, if this is the first row, I have to Union this row
        // with the superior node
        if (row == 1) {
            uf.union(getIndex(row, col), top);
        }
        // Because there is a bottom node outside the grid, if this is the last row, I have to Union this row with the
        // last one
        if (row == gridSize) {
            uf.union(getIndex(row, col), bottom);
        }
        if (row > 1 && isOpen(row - 1, col)) {
            uf.union(getIndex(row, col), getIndex(row - 1, col));
        }
        if (row < gridSize && isOpen(row + 1, col)) {
            uf.union(getIndex(row, col), getIndex(row + 1, col));
        }
        if (col > 1 && isOpen(row, col - 1)) {
            uf.union(getIndex(row, col), getIndex(row, col - 1));
        }
        if (col < gridSize && isOpen(row, col + 1)) {
            uf.union(getIndex(row, col), getIndex(row, col + 1));
        }
    }

    // is the site (row, col) open?
    public boolean isOpen(int row, int col) {
        checkException(row, col);
        return open[row - 1][col - 1];
    }

    // is the site (row, col) full?
    public boolean isFull(int row, int col) {
        // It's full only if the top is connected to the node
        checkException(row, col);
        return uf.find(top) == uf.find(getIndex(row, col));
    }

    // returns the number of open sites
    public int numberOfOpenSites() {
        return openSites;
    }

    // does the system percolate?
    public boolean percolates() {
        return uf.find(top) == uf.find(bottom);
    }

    private static void simulateFromFile(String filename) {
        In in = new In(filename);
        int n = in.readInt();
        Percolation percolation = new Percolation(n);


        while (!in.isEmpty()) {
            int row = in.readInt();
            int col = in.readInt();
            percolation.open(row, col);
        }
        System.out.println(percolation.percolates());
        // That returns true, and it doesn't throw any exception
    }

    public static void main(String[] args) {
        String filename = args[0];
        simulateFromFile(filename);
    }
}