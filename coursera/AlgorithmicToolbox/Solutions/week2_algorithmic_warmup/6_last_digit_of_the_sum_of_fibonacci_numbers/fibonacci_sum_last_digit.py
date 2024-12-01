def fibonacci_sum_fast(n):
    if n <= 1:
        return n

    previous, current, _sum = 0, 1, 1

    for _ in range(n - 1):
        previous, current = current, (previous + current) % 10
        _sum = (_sum + current) % 10

    return _sum


def fibonacci_sum(n):
    m = 10
    pisano = pisano_period(m)

    n = n % pisano
    if n <= 1:
        return n
    
    prev, cur = 0, 1
    sum = 1

    for i in range(n - 1):
        prev, cur = cur, (prev + cur) % m
        sum = (sum + cur) % m

    return sum

def pisano_period(m):
    prev, cur = 0, 1
    for i in range(m*m):
        prev, cur = cur, (prev + cur) % m

        if prev == 0 and cur == 1:
            return i + 1


if __name__ == '__main__':
    n = int(input())
    print(fibonacci_sum(n))
