def fibonacci_sum_squares(n):
    if n <= 1:
        return n

    previous, current, sum = 0, 1, 1

    for _ in range(n - 1):
        previous, current = current, (previous + current) % 10
        sum = (sum + (current * current)) % 10

    return sum


if __name__ == '__main__':
    n = int(input())
    print(fibonacci_sum_squares(n))
