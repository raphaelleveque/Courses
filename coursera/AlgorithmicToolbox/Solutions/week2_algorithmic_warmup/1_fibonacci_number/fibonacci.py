def fibonacci_number(n):
    if n <= 1: return n

    a, b = 0, 1
    for _ in range(1, n):
        num = a + b
        a = b
        b = num
    return b



if __name__ == '__main__':
    input_n = int(input())
    print(fibonacci_number(input_n))
