def fibonacci_huge(n, m):
    pisano = pisano_period(m)

    n = n % pisano
    if n <= 1:
        return n
    
    prev, cur = 0, 1

    for i in range(n - 1):
        prev, cur = cur, (prev + cur) % m

    return cur

def pisano_period(m):
    prev, cur = 0, 1
    for i in range(m*m):
        prev, cur = cur, (prev + cur) % m

        if prev == 0 and cur == 1:
            return i + 1



if __name__ == '__main__':
    n, m = map(int, input().split())
    print(fibonacci_huge(n, m))
